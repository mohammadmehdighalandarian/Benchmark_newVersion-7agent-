using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Running;
using EvaluatedCodeGeneration;
using test.Model;

public class TaskRecord
{
    public string task_id { get; set; }
    public string prompt { get; set; }
    public string test { get; set; }
    public string language { get; set; }
    public string description { get; set; }
    public string entry_point { get; set; }
    public string canonical_solution { get; set; }
    public string natural_language { get; set; }
}

public partial class Program
{
    // =====================================================================
    //  Re-run driver.
    //
    //  Every phase now has a name that can be invoked, so the pipeline can
    //  be re-run without editing and recompiling this file. Running no
    //  command keeps the previous behaviour exactly: benchmarks only.
    //
    //  `assemble` rewrites the 80 shipped solver, test and benchmark files
    //  in place, so it requires an explicit --overwrite flag. That is not
    //  bureaucracy: the shipped corpus is what every published number was
    //  measured on, and regenerating it silently would leave the results
    //  file describing code that no longer exists.
    // =====================================================================
    public static void Main(string[] args)
    {
        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "evaluation_results.xlsx");
        string command = args.Length > 0 ? args[0].Trim().ToLowerInvariant() : "";

        switch (command)
        {
            case "prompts":
                RunPhase1(Arg(args, 1, EvaluatedCodeGeneration.DatasetPreparation.DefaultWorkbookPath),
                          Arg(args, 2, Path.Combine(ProjectRoot(), "Phase1_Prompts")));
                break;

            case "verify-prompts":
                Console.WriteLine("\n--- Verifying prompt templates against the stored corpus ---");
                EvaluatedCodeGeneration.DatasetPreparation.VerifyAgainstWorkbook(
                    Arg(args, 1, EvaluatedCodeGeneration.DatasetPreparation.DefaultWorkbookPath));
                break;

            case "audit-assertions":
                Console.WriteLine("\n--- Comparing source assertions with instrumented assertions ---");
                EvaluatedCodeGeneration.DatasetPreparation.AuditAssertionCounts(
                    Arg(args, 1, EvaluatedCodeGeneration.DatasetPreparation.DefaultWorkbookPath),
                    Arg(args, 2, Path.Combine(ProjectRoot(), "Solution", "Tests")));
                break;

            case "generate-template":
                EvaluatedCodeGeneration.GenerationConfig.WriteTemplate(
                    Arg(args, 1, Path.Combine(ProjectRoot(), "generation.config.json")));
                break;

            case "generate":
                RunPhase2Generation(
                    Arg(args, 1, EvaluatedCodeGeneration.DatasetPreparation.DefaultWorkbookPath),
                    Arg(args, 2, Path.Combine(ProjectRoot(), "generation.config.json")),
                    Arg(args, 3, Path.Combine(ProjectRoot(), "Phase2_Generation")));
                break;

            case "assemble":
                RunAssemble(
                    Arg(args, 1, EvaluatedCodeGeneration.DatasetPreparation.DefaultWorkbookPath),
                    args.Any(a => a.Equals("--overwrite", StringComparison.OrdinalIgnoreCase)));
                break;

            case "correctness":
                RunCorrectnessAndStatic(outputPath);
                break;

            case "benchmark":
            case "":
                Console.WriteLine("\n--- Starting Benchmarks (incremental, resumable) ---");
                RunBenchmarksIncremental(outputPath);
                if (command == "") PrintUsage();
                break;

            case "export-tsv":
                Console.WriteLine("\n--- Exporting results to TSV ---");
                EvaluatedCodeGeneration.TsvExport.FromWorkbook(
                    Arg(args, 1, outputPath),
                    Arg(args, 2, Path.ChangeExtension(Arg(args, 1, outputPath), ".txt")));
                break;

            case "all":
                RunCorrectnessAndStatic(outputPath);
                Console.WriteLine("\n--- Starting Benchmarks (incremental, resumable) ---");
                RunBenchmarksIncremental(outputPath);
                Console.WriteLine("\n--- Exporting results to TSV ---");
                EvaluatedCodeGeneration.TsvExport.FromWorkbook(
                    outputPath, Path.ChangeExtension(outputPath, ".txt"));
                break;

            default:
                Console.WriteLine($"Unknown command: {command}");
                PrintUsage();
                break;
        }
    }

    static void PrintUsage()
    {
        Console.WriteLine();
        Console.WriteLine("Usage: test <command> [args]");
        Console.WriteLine("  prompts [workbook] [outDir]     Phase 1: build and persist every task's prompts");
        Console.WriteLine("  verify-prompts [workbook]       Check the templates reproduce the stored prompts");
        Console.WriteLine("  audit-assertions [wb] [dir]     Report assertions lost to the instrumentation regex");
        Console.WriteLine("  generate-template [path]        Write a generation config to fill in with pinned model ids");
        Console.WriteLine("  generate [wb] [cfg] [outDir]    Phase 2: query each model, persist raw responses");
        Console.WriteLine("  assemble [wb] --overwrite       Rebuild the .cs corpus (REWRITES the shipped files)");
        Console.WriteLine("  correctness                     Phases 1+2: reflection tests, static analysis, SonarAnalyzer");
        Console.WriteLine("  benchmark                       Phase 3: BenchmarkDotNet (resumable) - the default");
        Console.WriteLine("  export-tsv [xlsx] [tsv]         Phase 4: write the TSV directly from the workbook");
        Console.WriteLine("  all                             correctness, then benchmark, then export-tsv");
    }

    static string Arg(string[] args, int index, string fallback) =>
        args.Length > index && !string.IsNullOrWhiteSpace(args[index]) ? args[index] : fallback;

    static void RunPhase1(string workbookPath, string outDir)
    {
        Console.WriteLine("\n--- Phase 1: dataset preparation ---");
        Console.WriteLine($"  Workbook: {workbookPath}");
        var tasks = EvaluatedCodeGeneration.DatasetPreparation.LoadTasks(workbookPath);
        EvaluatedCodeGeneration.DatasetPreparation.WritePrompts(tasks, outDir);
        EvaluatedCodeGeneration.DatasetPreparation.VerifyAgainstWorkbook(workbookPath);
    }

    static void RunPhase2Generation(string workbookPath, string configPath, string outDir)
    {
        Console.WriteLine("\n--- Phase 2: generation ---");
        var tasks = EvaluatedCodeGeneration.DatasetPreparation.LoadTasks(workbookPath);
        var cfg   = EvaluatedCodeGeneration.GenerationConfig.Load(configPath);
        Console.WriteLine($"  {tasks.Count} task(s) x {cfg.Models.Count} model(s), temperature {cfg.Temperature}");
        EvaluatedCodeGeneration.GenerationPhase.RunAsync(tasks, cfg, outDir).GetAwaiter().GetResult();
    }

    // Rebuilds the .cs corpus from the workbook using SolutionWriter, the
    // generator that produced the shipped files. Test-generation failures
    // are recorded and leave no test file behind, so a task whose
    // assertions could not be recovered cannot score as passing.
    static void RunAssemble(string workbookPath, bool overwrite)
    {
        if (!overwrite)
        {
            Console.WriteLine("Refusing to run: 'assemble' rewrites the 80 shipped solver, test and");
            Console.WriteLine("benchmark files, which is what every published number was measured on.");
            Console.WriteLine("Re-run with --overwrite if that is what you intend.");
            return;
        }

        Console.WriteLine("\n--- Assembling the .cs corpus from the workbook ---");
        var solutions = SolutionExport.ReadSolutions(workbookPath);
        var writer = new SolutionWriter();

        foreach (var solution in solutions)
            writer.CreateFiles(solution);

        Console.WriteLine($"\n  {solutions.Count} task(s) assembled.");
        if (writer.Failures.Count == 0)
        {
            Console.WriteLine("  No test-generation failures.");
            return;
        }

        string path = Path.Combine(ProjectRoot(), "test_generation_failures.tsv");
        using (var w = new StreamWriter(path, append: false))
        {
            w.WriteLine("task_id\treason");
            foreach (var failure in writer.Failures)
                w.WriteLine($"{failure.TaskId}\t{failure.Message.Replace('\t', ' ')}");
        }
        Console.WriteLine($"  {writer.Failures.Count} task(s) FAILED test generation and have no test file.");
        Console.WriteLine($"  Recorded in {path}");
    }

    static void RunCorrectnessAndStatic(string outputPath)
    {
        Console.WriteLine("\n--- Starting Logic Tests ---");
        var testResults = RunAndScoreTests();

        Console.WriteLine("\n--- Running Static Analysis & Saving Results Per Task ---");
        Console.WriteLine($"  NOTE: this recreates {Path.GetFileName(outputPath)} from scratch.");
        string? solversDir = FindSolversDirectory();

        EvaluateAndSaveIncremental(testResults, solversDir, outputPath);

        int failing = testResults.Values.Count(v => v.failed > 0);
        if (failing > 0)
            Console.WriteLine($"\n  {failing} of {testResults.Count} (task, model) pair(s) have failing assertions.");
    }

    // Walks up from the executable directory to the folder holding the .csproj.
    static string ProjectRoot()
    {
        var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        while (dir != null && dir.GetFiles("*.csproj").Length == 0)
            dir = dir.Parent;
        return dir?.FullName ?? AppDomain.CurrentDomain.BaseDirectory;
    }

    // Returns per-(taskId, model) pass/fail counts.
    // TestUtils.Reset() is already called inside each generated Run_* method,
    // so GetScore() after Invoke() reflects only that single task/model run.
    static Dictionary<(string taskId, string model), (int passed, int failed)> RunAndScoreTests()
    {
        var results = new Dictionary<(string, string), (int, int)>();
        var assembly = Assembly.GetExecutingAssembly();
        var testClasses = assembly.GetTypes()
            .Where(t => t.Name == "TestRunner" && t.Namespace != null && t.Namespace.StartsWith("Tests."))
            .OrderBy(t => t.Namespace)
            .ToList();

        if (testClasses.Count == 0)
        {
            Console.WriteLine("No test classes found.");
            return results;
        }

        foreach (var testClass in testClasses)
        {
            string taskId = testClass.Namespace!.Substring("Tests.".Length);
            object instance = Activator.CreateInstance(testClass)!;
            var methods = testClass.GetMethods()
                .Where(m => m.Name.StartsWith("Run_"))
                .OrderBy(m => m.Name)
                .ToList();

            foreach (var method in methods)
            {
                string model = method.Name.Replace("Run_", "");
                try
                {
                    method.Invoke(instance, null);
                    var score = Tests.Shared.TestUtils.GetScore();
                    results[(taskId, model)] = (score.Passed, score.Failed);
                    Console.WriteLine($"  [{taskId}] {model}: {score.Passed} passed, {score.Failed} failed");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  [ERROR] {taskId}/{model}: {ex.InnerException?.Message ?? ex.Message}");
                    results[(taskId, model)] = (0, 1);
                }
            }
        }

        return results;
    }

    // Traverses up from the executable directory to find the .csproj root,
    // then returns the Solution/Solvers subdirectory path.
    static string? FindSolversDirectory()
    {
        var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        while (dir != null && dir.GetFiles("*.csproj").Length == 0)
            dir = dir.Parent;

        if (dir == null) return null;
        string path = Path.Combine(dir.FullName, "Solution", "Solvers");
        return Directory.Exists(path) ? path : null;
    }

    // -------------------------------------------------------------------
    //  Extracts the code inside `namespace Benchmarks.<taskId>.<model> { }`,
    //  PREFIXED WITH THE FILE-LEVEL USING DIRECTIVES.
    //
    //  Those usings sit above the namespace blocks and apply to every model
    //  in the file, so a snippet taken without them is not the compilation
    //  unit the real build sees. Dropping them made solutions that relied on
    //  the file's usings (rather than emitting their own) fail the isolated
    //  compile with CS0246 for types as ordinary as List<> and HashSet<>,
    //  and shifted overload resolution where System.Linq was involved.
    //
    //  This is the same failure as the restricted reference set, one level
    //  down: the isolated compile has to reproduce the real compilation
    //  unit, not approximate it.
    //
    //  A duplicated using (a model that emitted its own as well) is CS0105,
    //  a warning, so prefixing unconditionally is safe.
    // -------------------------------------------------------------------
    static string ExtractModelCode(string filePath, string taskId, string model)
    {
        if (!File.Exists(filePath)) return "";
        string content = File.ReadAllText(filePath);
        string marker = $"namespace Benchmarks.{taskId}.{model}";
        int start = content.IndexOf(marker, StringComparison.Ordinal);
        if (start < 0) return "";
        int braceStart = content.IndexOf('{', start);
        if (braceStart < 0) return "";
        int depth = 1, i = braceStart + 1;
        while (i < content.Length && depth > 0)
        {
            if (content[i] == '{') depth++;
            else if (content[i] == '}') depth--;
            i++;
        }

        string body = content.Substring(braceStart + 1, i - braceStart - 2).Trim();
        return FileLevelUsings(content) + body;
    }

    // The using directives preceding the first namespace declaration.
    static string FileLevelUsings(string content)
    {
        int firstNamespace = content.IndexOf("namespace ", StringComparison.Ordinal);
        string header = firstNamespace < 0 ? content : content.Substring(0, firstNamespace);

        var usings = Regex.Matches(header, @"^\s*using\s+[^;{}]+;", RegexOptions.Multiline)
            .Select(m => m.Value.Trim())
            .ToList();

        return usings.Count == 0 ? "" : string.Join(Environment.NewLine, usings) + Environment.NewLine;
    }

    // Finds the first public method name in the extracted code snippet.
    static string DetectMethodName(string code)
    {
        var m = Regex.Match(code, @"public\s+(?:static\s+)?[\w<>\[\],\s]+\s+(\w+)\s*\(");
        return m.Success ? m.Groups[1].Value : "";
    }

    static void EvaluateAndSaveIncremental(
        Dictionary<(string taskId, string model), (int passed, int failed)> testResults,
        string? solversDir,
        string outputPath)
    {
        var evaluator  = new CodeEvaluator();
        var sonarAnalyzer = new EvaluatedCodeGeneration.SonarAnalyzerEvaluator();
        var cfg        = ScoringConfig.Default;
        string[] models = { "GPT", "Gemini", "Claude", "Grok", "Mistral", "DeepSeek", "Llama" };

        var taskIds = testResults.Keys.Select(k => k.taskId).Distinct()
            .OrderBy(t => t).ToList();

        InitExcelFile(outputPath);

        foreach (var taskId in taskIds)
        {
            string solverFile = solversDir != null
                ? Path.Combine(solversDir, $"Solvers_Task_{taskId}.cs")
                : "";

            var taskRows = new List<FinalResultRowV2>();

            foreach (var model in models)
            {
                (int passed, int failed) = testResults.GetValueOrDefault((taskId, model), (0, 0));
                int total = passed + failed;
                double successRate = total > 0 ? (double)passed / total * 100.0 : 0;

                string code = ExtractModelCode(solverFile, taskId, model);
                string methodName = DetectMethodName(code);

                CodeQualityReport report;
                if (!string.IsNullOrWhiteSpace(code))
                {
                    var spec = new TaskSpecification { MethodName = methodName };
                    report = evaluator.Evaluate(code, spec);
                }
                else
                {
                    report = new CodeQualityReport { ViolationDetails = { "Solver code not found" } };
                }

                var row = BuildScoredRow(taskId, model, report, successRate, 0, 0, cfg);

                // The SonarAnalyzer pass runs on the same snippet alongside
                // the Roslyn metrics; neither replaces the other. It now runs
                // for every extracted solution, not only non-excluded ones,
                // and its status is recorded so a failed scan is never
                // mistaken for a clean file.
                if (!string.IsNullOrWhiteSpace(code))
                {
                    var sa = sonarAnalyzer.Evaluate(code);
                    row.SA_ScanStatus           = sa.Status.ToString();
                    row.SA_Errors               = sa.Errors;
                    row.SA_Warnings             = sa.Warnings;
                    row.SA_Info                 = sa.Info;
                    row.SA_TotalIssues          = sa.TotalIssues;
                    row.SA_AnalyzerCrashes      = sa.AnalyzerCrashes;
                    row.SA_RemediationMinutes   = sa.RemediationEffortMinutes;
                    row.SA_MaintainabilityGrade = sa.MaintainabilityGrade;
                    row.SA_ReliabilityGrade     = sa.ReliabilityGrade;
                    row.SA_TriggeredRules       = sa.TriggeredRules;
                    if (!sa.Succeeded)
                        row.SA_TriggeredRules = sa.FailureDetail;
                }
                else
                {
                    row.SA_ScanStatus = "NotAttempted";
                }

                taskRows.Add(row);
            }

            AppendRowsToExcel(taskRows, outputPath);
            Console.WriteLine($"  [Saved] {taskId} ({taskRows.Count} models)");
        }

        Console.WriteLine($"\nEvaluation report saved to: {outputPath}");
    }

    static void InitExcelFile(string path)
    {
        using var workbook = new ClosedXML.Excel.XLWorkbook();
        var ws = workbook.Worksheets.Add("Results");
        string[] headers =
        {
            "Task ID", "AI Model",
            "Correctness (%)", "Efficiency Score", "Quality Score", "Composite Score",
            "Time (ns)", "Memory (Bytes)",
            "Complexity", "Cognitive Cx", "Nesting", "Naming Violations", "Professionalism",
            "Excluded", "Exclusion Reason",
            // Compile diagnostics (16-17)
            "Compile Errors", "Compile Diagnostics",
            // SonarAnalyzer columns (18-27). The effort minutes and the A-E
            // grades are local formulas, not SonarQube outputs.
            "SA Scan Status", "SA Total Issues", "SA Errors", "SA Warnings", "SA Info",
            "SA Analyzer Crashes", "SA Remediation Effort (min, local)",
            "SA Maintainability Grade (local)", "SA Reliability Grade (local)", "SA Rules",
            // Benchmark provenance (28-29)
            "Benchmark Sizes", "Benchmark Status"
        };
        for (int c = 0; c < headers.Length; c++)
            ws.Cell(1, c + 1).Value = headers[c];
        var header = ws.Range(1, 1, 1, headers.Length);
        header.Style.Font.Bold = true;
        header.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
        workbook.SaveAs(path);
    }

    static void AppendRowsToExcel(List<FinalResultRowV2> rows, string path)
    {
        using var workbook = new ClosedXML.Excel.XLWorkbook(path);
        var ws = workbook.Worksheet("Results");
        int r = (ws.LastRowUsed()?.RowNumber() ?? 1) + 1;
        foreach (var row in rows)
        {
            ws.Cell(r, 1).Value = row.TaskId;
            ws.Cell(r, 2).Value = row.AiModel;
            ws.Cell(r, 3).Value = row.Correctness;
            ws.Cell(r, 4).Value = row.EfficiencyScore;
            ws.Cell(r, 5).Value = row.QualityScore;
            ws.Cell(r, 6).Value = row.CompositeScore;
            ws.Cell(r, 7).Value = row.ExecutionTimeNs;
            ws.Cell(r, 8).Value = row.MemoryBytes;
            ws.Cell(r, 9).Value = row.Complexity;
            ws.Cell(r, 10).Value = row.CognitiveComplexity;
            ws.Cell(r, 11).Value = row.NestingDepth;
            ws.Cell(r, 12).Value = row.NamingViolations;
            ws.Cell(r, 13).Value = row.ProfessionalismScore;
            ws.Cell(r, 14).Value = row.Excluded;
            ws.Cell(r, 15).Value = row.ExclusionReason;
            ws.Cell(r, 16).Value = row.CompileErrorCount;
            ws.Cell(r, 17).Value = row.CompileDiagnostics;
            ws.Cell(r, 18).Value = row.SA_ScanStatus;
            ws.Cell(r, 19).Value = row.SA_TotalIssues;
            ws.Cell(r, 20).Value = row.SA_Errors;
            ws.Cell(r, 21).Value = row.SA_Warnings;
            ws.Cell(r, 22).Value = row.SA_Info;
            ws.Cell(r, 23).Value = row.SA_AnalyzerCrashes;
            ws.Cell(r, 24).Value = row.SA_RemediationMinutes;
            ws.Cell(r, 25).Value = row.SA_MaintainabilityGrade;
            ws.Cell(r, 26).Value = row.SA_ReliabilityGrade;
            ws.Cell(r, 27).Value = row.SA_TriggeredRules;
            ws.Cell(r, 28).Value = "";      // filled by the benchmark phase
            ws.Cell(r, 29).Value = "not-run";
            r++;
        }
        ws.Columns().AdjustToContents();
        workbook.SaveAs(path);
    }

    // -----------------------------------------------------------------------
    //  Incremental benchmark runner with checkpoint / resume support.
    //  Runs each task's BenchmarkRunner type individually, saves results to
    //  Excel immediately after each task, and records the task ID in a
    //  checkpoint file so interrupted runs resume from where they stopped.
    // -----------------------------------------------------------------------
    static void RunBenchmarksIncremental(string outputPath)
    {
        string checkpointPath = Path.ChangeExtension(outputPath, ".checkpoint.json");
        var done = LoadCheckpoint(checkpointPath);
        var cfg  = ScoringConfig.Default;

        var assembly = Assembly.GetExecutingAssembly();
        var benchmarkTypes = assembly.GetTypes()
            .Where(t => t.Name == "BenchmarkRunner" &&
                        t.Namespace != null &&
                        t.Namespace.StartsWith("Benchmarks."))
            .OrderBy(t => t.Namespace)
            .ToList();

        if (benchmarkTypes.Count == 0)
        {
            Console.WriteLine("No benchmark classes found.");
            return;
        }

        string[] models = { "GPT", "Gemini", "Claude", "Grok", "Mistral", "DeepSeek", "Llama" };
        int total = benchmarkTypes.Count;
        int index = 0;

        foreach (var benchType in benchmarkTypes)
        {
            index++;
            string taskId = benchType.Namespace!.Substring("Benchmarks.".Length);

            if (done.Contains(taskId))
            {
                Console.WriteLine($"  [Skip {index}/{total}] {taskId} (already done)");
                continue;
            }

            Console.WriteLine($"\n  [Benchmark {index}/{total}] {taskId}...");

            try
            {
                var config = BenchmarkDotNet.Configs.ManualConfig
                    .Create(BenchmarkDotNet.Configs.DefaultConfig.Instance)
                    .WithOptions(BenchmarkDotNet.Configs.ConfigOptions.DisableOptimizationsValidator);

                var summary = BenchmarkDotNet.Running.BenchmarkRunner.Run(benchType, config);

                var timeByModel = new Dictionary<string, double>(StringComparer.Ordinal);
                var memByModel  = new Dictionary<string, double>(StringComparer.Ordinal);
                var sizes       = new SortedSet<string>(StringComparer.Ordinal);

                foreach (var model in models)
                {
                    var reports = summary.Reports
                        .Where(rp => rp.BenchmarkCase.Descriptor.WorkloadMethod.Name == model
                                  && rp.ResultStatistics != null)
                        .ToList();

                    if (reports.Count > 0)
                    {
                        // t is the mean of the per-size medians, as the paper states.
                        timeByModel[model] = reports.Average(rp => rp.ResultStatistics!.Median);
                        memByModel[model]  = reports.Average(rp => AllocBytesPerOp(rp));

                        // The executed input sizes, recorded so the results file
                        // cannot drift away from the harness source.
                        foreach (var rp in reports)
                            foreach (var param in rp.BenchmarkCase.Parameters.Items)
                                sizes.Add($"{param.Name}={param.Value}");
                    }
                }

                // A run that produced no usable statistics is a FAILURE, not a
                // completed task. Checkpointing it anyway is what made the
                // affected tasks skip permanently on resume, contradicting the
                // message this loop prints when it catches an exception.
                if (timeByModel.Count == 0)
                {
                    RecordBenchmarkFailure(outputPath, taskId,
                        "benchmark produced no usable statistics for any model");
                    Console.WriteLine($"  [Failed] {taskId} - no usable statistics; NOT checkpointed.");
                    continue;
                }

                UpdateBenchmarkResults(outputPath, taskId, timeByModel, memByModel,
                                       string.Join(";", sizes), cfg);

                done.Add(taskId);
                SaveCheckpoint(checkpointPath, done);
                Console.WriteLine($"  [Saved] {taskId} - {timeByModel.Count} model(s), sizes [{string.Join(";", sizes)}]");
            }
            catch (Exception ex)
            {
                // Not checkpointed, so the next run really does retry it.
                RecordBenchmarkFailure(outputPath, taskId, ex.Message);
                Console.WriteLine($"  [Error] {taskId}: {ex.Message}");
                Console.WriteLine($"           Not checkpointed; will retry on next run.");
            }
        }

        Console.WriteLine($"\nBenchmark phase complete. Results: {outputPath}");
        Console.WriteLine($"Checkpoint: {checkpointPath}");
    }

    static HashSet<string> LoadCheckpoint(string path)
    {
        if (!File.Exists(path)) return new HashSet<string>(StringComparer.Ordinal);
        try
        {
            var list = System.Text.Json.JsonSerializer.Deserialize<List<string>>(
                File.ReadAllText(path));
            return new HashSet<string>(list ?? new List<string>(), StringComparer.Ordinal);
        }
        catch { return new HashSet<string>(StringComparer.Ordinal); }
    }

    static void SaveCheckpoint(string path, HashSet<string> done)
    {
        File.WriteAllText(path,
            System.Text.Json.JsonSerializer.Serialize(done.OrderBy(x => x).ToList()));
    }

    // Updates columns 4 (Efficiency), 6 (Composite), 7 (Time ns), 8 (Memory)
    // for every row matching taskId, using real BenchmarkDotNet measurements.
    static void UpdateBenchmarkResults(
        string outputPath,
        string taskId,
        Dictionary<string, double> timeByModel,
        Dictionary<string, double> memByModel,
        string executedSizes,
        ScoringConfig cfg)
    {
        if (!File.Exists(outputPath)) return;

        using var workbook = new ClosedXML.Excel.XLWorkbook(outputPath);
        var ws = workbook.Worksheet("Results");
        int lastRow = ws.LastRowUsed()?.RowNumber() ?? 1;

        for (int r = 2; r <= lastRow; r++)
        {
            if (ws.Cell(r, 1).GetString() != taskId) continue;

            string model = ws.Cell(r, 2).GetString();
            if (!timeByModel.TryGetValue(model, out double timeNs)) continue;
            double memBytes = memByModel.GetValueOrDefault(model, 0.0);

            // Don't overwrite rows that failed to compile
            bool excluded = string.Equals(
                ws.Cell(r, 14).Value.ToString(), "True",
                StringComparison.OrdinalIgnoreCase);
            if (excluded) continue;

            // Recompute scores with real benchmark data so all columns are consistent
            var inputs = new EvaluatedCodeGeneration.ScoreInputs
            {
                TaskId               = taskId,
                Model                = model,
                Compiled             = true,
                SuccessRatePct       = CellDouble(ws.Cell(r, 3)),
                CyclomaticComplexity = (int)CellDouble(ws.Cell(r, 9)),
                MaxNestingDepth      = (int)CellDouble(ws.Cell(r, 11)),
                NamingViolations     = (int)CellDouble(ws.Cell(r, 12)),
                MedianExecutionTimeNs = timeNs,
                AllocatedBytes        = memBytes,
            };

            var score = EvaluatedCodeGeneration.ScoringEngine.Compute(inputs, cfg);

            ws.Cell(r, 4).Value  = score.EfficiencyScore;
            ws.Cell(r, 6).Value  = score.CompositeScore;
            ws.Cell(r, 7).Value  = timeNs;
            ws.Cell(r, 8).Value  = memBytes;
            ws.Cell(r, 28).Value = executedSizes;
            ws.Cell(r, 29).Value = "ok";
        }

        ws.Columns().AdjustToContents();
        workbook.SaveAs(outputPath);
    }

    static double CellDouble(ClosedXML.Excel.IXLCell cell)
    {
        try
        {
            var v = cell.Value;
            if (v.IsNumber) return (double)v;
            return double.TryParse(v.ToString(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out var d) ? d : 0.0;
        }
        catch { return 0.0; }
    }

    // -------------------------------------------------------------------
    //  Allocated bytes per operation, taken from BenchmarkDotNet itself.
    //
    //  This used to be recomputed as total allocated bytes divided by the
    //  sum of Operations over every measurement with IterationMode.Workload,
    //  which spans the pilot, warmup, actual and result stages, while the
    //  numerator covers only the workload iterations. The denominator was
    //  therefore far too large and the reported figure came out roughly two
    //  orders of magnitude low.
    //
    //  GcStats.GetBytesAllocatedPerOperation is the value behind
    //  [MemoryDiagnoser]'s own Allocated column, so the results file now
    //  agrees with the profiler's report instead of contradicting it.
    // -------------------------------------------------------------------
    static double AllocBytesPerOp(BenchmarkDotNet.Reports.BenchmarkReport report) =>
        report.GcStats.GetBytesAllocatedPerOperation(report.BenchmarkCase) ?? 0.0;

    // Appends a benchmark failure to a sidecar file next to the results, so
    // failures survive the run instead of scrolling past on the console.
    static void RecordBenchmarkFailure(string outputPath, string taskId, string reason)
    {
        string path = Path.ChangeExtension(outputPath, ".benchmark-failures.tsv");
        bool isNew = !File.Exists(path);
        string clean = reason.Replace('\t', ' ').Replace('\r', ' ').Replace('\n', ' ');
        using var writer = new StreamWriter(path, append: true);
        if (isNew) writer.WriteLine("timestamp\ttask_id\treason");
        writer.WriteLine($"{DateTime.UtcNow:o}\t{taskId}\t{clean}");
    }
}