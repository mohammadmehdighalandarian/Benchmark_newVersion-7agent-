// =====================================================================
//  DatasetPreparation.cs  -  PHASE 1 driver
// ---------------------------------------------------------------------
//  Phase 1 of the pipeline as specified: read the task spreadsheet, build
//  the two prompts for every task from the templates in PromptTemplates,
//  and persist every instantiated prompt to disk so the exact text sent
//  for any task can be recovered later.
//
//  This is AUTOMATION OF A STEP THAT WAS PERFORMED MANUALLY. It does not
//  change any reported number: nothing here feeds the scoring path. Its
//  purpose is that Phase 1 stops being absent from the artifact.
//
//  VerifyAgainstWorkbook is the evidence that the templates are faithful:
//  it re-derives all 160 prompts and compares them byte for byte against
//  the prompts stored per row in the workbook.
// =====================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using ClosedXML.Excel;

namespace EvaluatedCodeGeneration
{
    /// <summary>
    /// The JSON object embedded in both prompts. Property order is
    /// significant: it is the order in the stored prompts, and
    /// System.Text.Json emits properties in declaration order.
    /// </summary>
    public sealed class PromptInput
    {
        [JsonPropertyName("task_id")]     public string TaskId      { get; set; } = "";
        [JsonPropertyName("prompt")]      public string Prompt      { get; set; } = "";
        [JsonPropertyName("entry_point")] public string EntryPoint  { get; set; } = "";
        [JsonPropertyName("description")] public string Description { get; set; } = "";

        // Default options on purpose. The stored prompts carry the default
        // JavaScriptEncoder escapes (\u003C, \u003E, \u0027), so anything
        // less strict than the default would fail VerifyAgainstWorkbook.
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions();

        public static string ToJson(TaskRecord task) => JsonSerializer.Serialize(
            new PromptInput
            {
                TaskId      = task.task_id     ?? "",
                Prompt      = task.prompt      ?? "",
                EntryPoint  = task.entry_point ?? "",
                Description = task.description ?? "",
            },
            Options);
    }

    public static class DatasetPreparation
    {
        /// <summary>
        /// Where the task workbook was found during the source audit. It is
        /// NOT in this repository - see the reproducibility note printed by
        /// LoadTasks. Override with the command-line argument.
        /// </summary>
        public const string DefaultWorkbookPath =
            @"C:\Users\moham\OneDrive\Desktop\llm4se-csharp-benchmark_paper\Code\test\bin\Debug\net8.0\benchmark.xlsx";

        /// <summary>Namespace-safe form of a task id: "csharp/1" -> "csharp_1".</summary>
        public static string SafeTaskId(string taskId) =>
            (taskId ?? "").Replace("/", "_").Replace("-", "_").Replace(" ", "");

        // -----------------------------------------------------------------
        //  Load
        // -----------------------------------------------------------------

        /// <summary>
        /// Reads the "Tasks" sheet into TaskRecord. Columns A-H map to the
        /// TaskRecord fields one for one; that is the schema the type was
        /// written to read.
        /// </summary>
        public static List<TaskRecord> LoadTasks(string workbookPath)
        {
            if (!File.Exists(workbookPath))
                throw new FileNotFoundException(
                    "Task workbook not found. Phase 1 cannot run without it. " +
                    "The workbook is not part of this repository; see the audit's Appendix C.",
                    workbookPath);

            using var workbook = new XLWorkbook(workbookPath);
            var ws = workbook.Worksheets.Contains("Tasks")
                ? workbook.Worksheet("Tasks")
                : workbook.Worksheet(1);

            var tasks = new List<TaskRecord>();
            foreach (var row in ws.RowsUsed().Skip(1))
            {
                var record = new TaskRecord
                {
                    task_id            = row.Cell("A").GetString(),
                    prompt             = row.Cell("B").GetString(),
                    test               = row.Cell("C").GetString(),
                    language           = row.Cell("D").GetString(),
                    description        = row.Cell("E").GetString(),
                    entry_point        = row.Cell("F").GetString(),
                    canonical_solution = row.Cell("G").GetString(),
                    natural_language   = row.Cell("H").GetString(),
                };
                if (!string.IsNullOrWhiteSpace(record.task_id))
                    tasks.Add(record);
            }
            return tasks;
        }

        // -----------------------------------------------------------------
        //  Persist
        // -----------------------------------------------------------------

        /// <summary>
        /// Writes one directory per task containing the instantiated
        /// solution prompt, benchmark prompt and input JSON, plus a
        /// manifest with a SHA-256 of each prompt so drift is detectable.
        /// </summary>
        public static void WritePrompts(IReadOnlyList<TaskRecord> tasks, string outDir)
        {
            Directory.CreateDirectory(outDir);

            var manifest = new StringBuilder();
            manifest.Append("task_id\tentry_point\tsolution_prompt_chars\tsolution_prompt_sha256")
                    .Append("\tbenchmark_prompt_chars\tbenchmark_prompt_sha256\n");

            foreach (var task in tasks)
            {
                string safeId = SafeTaskId(task.task_id);
                string taskDir = Path.Combine(outDir, safeId);
                Directory.CreateDirectory(taskDir);

                string solution  = PromptTemplates.Solution(task);
                string benchmark = PromptTemplates.Benchmark(task);
                string inputJson = PromptInput.ToJson(task);

                WriteLf(Path.Combine(taskDir, "solution_prompt.txt"),  solution);
                WriteLf(Path.Combine(taskDir, "benchmark_prompt.txt"), benchmark);
                WriteLf(Path.Combine(taskDir, "input.json"),           inputJson);

                manifest.Append(task.task_id).Append('\t')
                        .Append(task.entry_point).Append('\t')
                        .Append(solution.Length).Append('\t')
                        .Append(Sha256(solution)).Append('\t')
                        .Append(benchmark.Length).Append('\t')
                        .Append(Sha256(benchmark)).Append('\n');
            }

            WriteLf(Path.Combine(outDir, "manifest.tsv"), manifest.ToString());
            Console.WriteLine($"  [Phase 1] {tasks.Count} task(s) -> {outDir}");
            Console.WriteLine($"  [Phase 1] manifest.tsv written with SHA-256 per prompt.");
        }

        // -----------------------------------------------------------------
        //  Verify
        // -----------------------------------------------------------------

        /// <summary>
        /// Re-derives both prompts for every task from the templates and
        /// compares them byte for byte with the prompts stored in columns I
        /// (our_prompt) and J (benchmark_prompt). Returns the number of
        /// mismatches; 0 means the templates in source reproduce the corpus
        /// exactly.
        /// </summary>
        public static int VerifyAgainstWorkbook(string workbookPath)
        {
            using var workbook = new XLWorkbook(workbookPath);
            var ws = workbook.Worksheets.Contains("Tasks")
                ? workbook.Worksheet("Tasks")
                : workbook.Worksheet(1);

            int checkedCount = 0, mismatches = 0;

            foreach (var row in ws.RowsUsed().Skip(1))
            {
                string taskId = row.Cell("A").GetString();
                if (string.IsNullOrWhiteSpace(taskId)) continue;

                var task = new TaskRecord
                {
                    task_id     = taskId,
                    prompt      = row.Cell("B").GetString(),
                    description = row.Cell("E").GetString(),
                    entry_point = row.Cell("F").GetString(),
                };

                string storedSolution  = row.Cell("I").GetString();
                string storedBenchmark = row.Cell("J").GetString();

                mismatches += Compare(taskId, "solution_prompt",  PromptTemplates.Solution(task),  storedSolution);
                mismatches += Compare(taskId, "benchmark_prompt", PromptTemplates.Benchmark(task), storedBenchmark);
                checkedCount += 2;
            }

            Console.WriteLine($"  [Verify] {checkedCount - mismatches}/{checkedCount} stored prompts reproduced exactly.");
            if (mismatches > 0)
                Console.WriteLine($"  [Verify] {mismatches} MISMATCH(ES) - the templates in source do not match the corpus.");
            return mismatches;
        }

        private static int Compare(string taskId, string which, string derived, string stored)
        {
            if (string.IsNullOrEmpty(stored))
            {
                Console.WriteLine($"  [Verify] {taskId}/{which}: no stored prompt in workbook (skipped).");
                return 0;
            }
            if (string.Equals(derived, stored, StringComparison.Ordinal)) return 0;

            int i = 0;
            while (i < derived.Length && i < stored.Length && derived[i] == stored[i]) i++;
            Console.WriteLine($"  [Verify] {taskId}/{which}: differs at index {i} " +
                              $"(derived len {derived.Length}, stored len {stored.Length}).");
            Console.WriteLine($"           derived: ...{Excerpt(derived, i)}");
            Console.WriteLine($"           stored : ...{Excerpt(stored, i)}");
            return 1;
        }

        private static string Excerpt(string s, int index)
        {
            int start = Math.Max(0, index - 20);
            int len = Math.Min(60, s.Length - start);
            return len <= 0 ? "<end>" : s.Substring(start, len).Replace("\n", "\\n").Replace("\r", "\\r");
        }

        // -----------------------------------------------------------------
        //  Assertion-count audit (measurement only - see note)
        // -----------------------------------------------------------------

        /// <summary>
        /// Counts the assertions in each task's stored `test` field and
        /// compares them with the instrumented assertions that survived into
        /// the generated test file. A shortfall means the instrumentation
        /// regex dropped assertions for that task, so its correctness
        /// percentage was computed over a reduced denominator.
        ///
        /// This REPORTS; it changes nothing. It exists because the shortfall
        /// can be measured from artifacts already on disk, and the size of it
        /// is what decides whether that defect matters.
        /// </summary>
        public static void AuditAssertionCounts(string workbookPath, string testsDir)
        {
            const int ModelsPerTask = 7;

            if (!Directory.Exists(testsDir))
            {
                Console.WriteLine($"  [Assertions] tests directory not found: {testsDir}");
                return;
            }

            using var workbook = new XLWorkbook(workbookPath);
            var ws = workbook.Worksheets.Contains("Tasks")
                ? workbook.Worksheet("Tasks")
                : workbook.Worksheet(1);

            var sourceRe = new Regex(@"compareLogic\s*\.\s*Compare\s*\(", RegexOptions.IgnoreCase);
            var checkRe  = new Regex(@"TestUtils\s*\.\s*Check\s*\(");

            int tasksChecked = 0, tasksShort = 0, totalSource = 0, totalKept = 0;
            var shortfalls = new List<string>();

            foreach (var row in ws.RowsUsed().Skip(1))
            {
                string taskId = row.Cell("A").GetString();
                if (string.IsNullOrWhiteSpace(taskId)) continue;

                string safeId = SafeTaskId(taskId);
                string testFile = Path.Combine(testsDir, $"Tests_Task_{safeId}.cs");
                if (!File.Exists(testFile)) continue;

                int sourceCount = sourceRe.Matches(row.Cell("C").GetString()).Count;
                int keptPerModel = checkRe.Matches(File.ReadAllText(testFile)).Count / ModelsPerTask;

                tasksChecked++;
                totalSource += sourceCount;
                totalKept   += keptPerModel;

                if (keptPerModel < sourceCount)
                {
                    tasksShort++;
                    shortfalls.Add($"    {taskId,-12} source {sourceCount,4}  instrumented {keptPerModel,4}  " +
                                   $"lost {sourceCount - keptPerModel,4}");
                }
            }

            Console.WriteLine($"  [Assertions] {tasksChecked} task(s) compared.");
            Console.WriteLine($"  [Assertions] assertions in source: {totalSource}; instrumented: {totalKept}; " +
                              $"lost: {totalSource - totalKept}.");
            if (tasksShort == 0)
            {
                Console.WriteLine("  [Assertions] no task lost an assertion to the instrumentation regex.");
            }
            else
            {
                Console.WriteLine($"  [Assertions] {tasksShort} task(s) lost assertions - their correctness " +
                                  "percentages are over a reduced denominator:");
                foreach (var line in shortfalls) Console.WriteLine(line);
            }
        }

        // -----------------------------------------------------------------
        //  Helpers
        // -----------------------------------------------------------------

        // Prompts are written with LF endings so a file round-trips to the
        // same SHA-256 regardless of the checkout's line-ending settings.
        private static void WriteLf(string path, string content) =>
            File.WriteAllText(path, content.Replace("\r\n", "\n"), new UTF8Encoding(false));

        private static string Sha256(string text)
        {
            byte[] hash = SHA256.HashData(new UTF8Encoding(false).GetBytes(text.Replace("\r\n", "\n")));
            return Convert.ToHexString(hash).ToLowerInvariant();
        }
    }
}
