using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ClosedXML.Excel;

public class SolutionExport
{
    public string TaskId { get; set; }
    public string Benchmark { get; set; }
    public string Test { get; set; }
    public string ChatGpt { get; set; }
    public string Gemini { get; set; }
    public string Grok { get; set; }
    public string Claude { get; set; }
    public string Mistral { get; set; }
    public string DeepSeek { get; set; }
    public string Llama { get; set; }
    public string EntryPoint { get; set; }

    public static List<SolutionExport> ReadSolutions(string filePath)
    {
        var solutions = new List<SolutionExport>();
        using var workbook = new XLWorkbook(filePath);
        var ws = workbook.Worksheet(1);

        foreach (var row in ws.RowsUsed().Skip(1))
        {
            solutions.Add(new SolutionExport
            {
                TaskId    = row.Cell("A").GetString(),
                ChatGpt   = row.Cell("K").GetString(),
                Gemini    = row.Cell("L").GetString(),
                Grok      = row.Cell("M").GetString(),
                Claude    = row.Cell("N").GetString(),
                Mistral   = row.Cell("O").GetString(),
                DeepSeek  = row.Cell("P").GetString(),
                Llama     = row.Cell("Q").GetString(),
                Benchmark = row.Cell("T").GetString(),
                Test      = row.Cell("C").GetString(),
                EntryPoint = row.Cell("F").GetString(),
            });
        }
        return solutions;
    }

    public static void ExportSolutions(List<SolutionExport> solutions, string outputDir)
    {
        var solversDir   = Path.Combine(outputDir, "Solvers");
        var testsDir     = Path.Combine(outputDir, "Tests");
        var benchmarkDir = Path.Combine(outputDir, "Benchmarks");

        Directory.CreateDirectory(solversDir);
        Directory.CreateDirectory(testsDir);
        Directory.CreateDirectory(benchmarkDir);

        foreach (var sol in solutions)
        {
            var taskId = sol.TaskId;
            var models = new (string Label, string Code)[]
            {
                ("GPT",      sol.ChatGpt),
                ("Gemini",   sol.Gemini),
                ("Grok",     sol.Grok),
                ("Claude",   sol.Claude),
                ("Mistral",  sol.Mistral),
                ("DeepSeek", sol.DeepSeek),
                ("Llama",    sol.Llama),
            };

            WriteSolverFile(taskId, models, solversDir);
            WriteTestFile(taskId, models, sol.Test, testsDir);
            WriteBenchmarkFile(taskId, models, sol.Benchmark, benchmarkDir);
        }
    }

    // -------------------------------------------------------------------------
    // Solver file: one namespace block per model, each containing Solver class
    // -------------------------------------------------------------------------
    private static void WriteSolverFile(
        string taskId,
        (string Label, string Code)[] models,
        string dir)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"// Auto-generated Solvers for Task: {taskId}");

        foreach (var (label, code) in models)
        {
            if (string.IsNullOrWhiteSpace(code)) continue;

            sb.AppendLine($"namespace Benchmarks.{taskId}.{label}");
            sb.AppendLine("{");
            sb.AppendLine("    public class Solver");
            sb.AppendLine("    {");
            foreach (var line in SplitLines(code))
                sb.AppendLine("        " + line);
            sb.AppendLine("    }");
            sb.AppendLine("}");
            sb.AppendLine();
        }

        File.WriteAllText(
            Path.Combine(dir, $"Solvers_Task_{taskId}.cs"),
            sb.ToString());
    }

    // -------------------------------------------------------------------------
    // Test file: TestRunner class with Run_<Model>() per model.
    // The Test column uses {NS} as a placeholder for the solver namespace.
    // -------------------------------------------------------------------------
    private static void WriteTestFile(
        string taskId,
        (string Label, string Code)[] models,
        string testTemplate,
        string dir)
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"// Auto-generated Tests for Task: {taskId}");
        sb.AppendLine("using System;");
        sb.AppendLine("using Tests.Shared;");
        sb.AppendLine();
        sb.AppendLine($"namespace Tests.{taskId}");
        sb.AppendLine("{");
        sb.AppendLine("    public class TestRunner");
        sb.AppendLine("    {");

        foreach (var (label, _) in models)
        {
            var solverNs = $"Benchmarks.{taskId}.{label}.Solver";
            var body = testTemplate?.Replace("{NS}", solverNs) ?? "";

            sb.AppendLine($"        public void Run_{label}()");
            sb.AppendLine("        {");
            foreach (var line in SplitLines(body))
                sb.AppendLine("            " + line);
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(
            Path.Combine(dir, $"Tests_Task_{taskId}.cs"),
            sb.ToString());
    }

    // -------------------------------------------------------------------------
    // Benchmark file: BenchmarkRunner class with setup code + one [Benchmark]
    // method per model.
    //
    // The Benchmark column format:
    //   - Setup code (field declarations + [GlobalSetup] method body)
    //   - A trailing comment line: // CALL:<ReturnType> <MethodCall(args)>
    //     e.g.  // CALL:bool IsAnagram(_s, _t)
    //
    // The generator reads the CALL line, strips it from the setup block, and
    // emits one [Benchmark] method per model that calls
    //   Benchmarks.<taskId>.<Model>.Solver.<MethodCall>
    // -------------------------------------------------------------------------
    private static void WriteBenchmarkFile(
        string taskId,
        (string Label, string Code)[] models,
        string benchmarkContent,
        string dir)
    {
        // Split setup code from the CALL directive
        var lines = SplitLines(benchmarkContent ?? "").ToList();
        string returnType  = "void";
        string methodCall  = "Solve()";
        var setupLines     = new List<string>();

        foreach (var line in lines)
        {
            var trimmed = line.TrimStart();
            if (trimmed.StartsWith("// CALL:", StringComparison.OrdinalIgnoreCase))
            {
                // Format: // CALL:ReturnType MethodCall(args)
                var payload = trimmed.Substring("// CALL:".Length).Trim();
                var spaceIdx = payload.IndexOf(' ');
                if (spaceIdx > 0)
                {
                    returnType = payload.Substring(0, spaceIdx).Trim();
                    methodCall = payload.Substring(spaceIdx + 1).Trim();
                }
            }
            else
            {
                setupLines.Add(line);
            }
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("using BenchmarkDotNet.Attributes;");
        sb.AppendLine("using BenchmarkDotNet.Order;");
        sb.AppendLine();
        sb.AppendLine($"namespace Benchmarks.{taskId}");
        sb.AppendLine("{");
        sb.AppendLine("    [MemoryDiagnoser]");
        sb.AppendLine("    [RankColumn]");
        sb.AppendLine("    [Orderer(SummaryOrderPolicy.FastestToSlowest)]");
        sb.AppendLine("    public class BenchmarkRunner");
        sb.AppendLine("    {");

        // Emit setup code
        foreach (var line in setupLines)
            sb.AppendLine("        " + line);

        if (setupLines.Any(l => !string.IsNullOrWhiteSpace(l)))
            sb.AppendLine();

        // Emit one [Benchmark] method per model
        bool first = true;
        foreach (var (label, _) in models)
        {
            var solverNs = $"Benchmarks.{taskId}.{label}.Solver";
            var attr = first ? "[Benchmark(Baseline = true)]" : "[Benchmark]";
            sb.AppendLine($"        {attr}");
            sb.AppendLine($"        public {returnType} {label}()");
            sb.AppendLine("        {");
            sb.AppendLine($"            return {solverNs}.{methodCall};");
            sb.AppendLine("        }");
            sb.AppendLine();
            first = false;
        }

        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(
            Path.Combine(dir, $"Benchmark_Task_{taskId}.cs"),
            sb.ToString());
    }

    private static IEnumerable<string> SplitLines(string text) =>
        (text ?? "").Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
}