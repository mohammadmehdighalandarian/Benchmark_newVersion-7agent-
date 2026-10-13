using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// Raised when a task's test harness cannot be generated faithfully.
/// Generating a partial or empty one is the failure mode this replaces:
/// it compiles, reports success, and inflates correctness.
/// </summary>
public sealed class TestGenerationException : Exception
{
    public string TaskId { get; }

    public TestGenerationException(string taskId, string reason)
        : base($"[{taskId}] test generation failed: {reason}")
        => TaskId = taskId;
}

public class SolutionWriter
{
    /// <summary>
    /// Tasks whose test harness could not be generated. A task listed here
    /// has no test file, so it cannot be scored as passing by default. The
    /// caller is expected to persist this list.
    /// </summary>
    public List<TestGenerationException> Failures { get; } = new List<TestGenerationException>();

    public void CreateFiles(SolutionExport data)
    {
        string safeTaskId = data.TaskId.Replace("/", "_").Replace("-", "_").Replace(" ", "");

        // This calculates the real source folder, not the bin folder
        string projectRoot = GetProjectRoot();

        string baseSolutionFolder = Path.Combine(projectRoot, "Solution");

        string solversFolder = Path.Combine(baseSolutionFolder, "Solvers");
        string benchmarksFolder = Path.Combine(baseSolutionFolder, "Benchmarks");
        string testsFolder = Path.Combine(baseSolutionFolder, "Tests");

        if (!Directory.Exists(solversFolder)) Directory.CreateDirectory(solversFolder);
        if (!Directory.Exists(benchmarksFolder)) Directory.CreateDirectory(benchmarksFolder);
        if (!Directory.Exists(testsFolder)) Directory.CreateDirectory(testsFolder);

        Console.WriteLine($"--- Processing Task: {safeTaskId} ---");

        CreateSolversFile(data, safeTaskId, solversFolder);
        CreateBenchmarkFile(data, safeTaskId, benchmarksFolder);

        // A failed test generation is recorded and leaves NO test file
        // behind, rather than writing a sentinel comment into one. The task
        // then has no assertions to pass, which is the honest outcome.
        try
        {
            CreateTestFile(data, safeTaskId, testsFolder);
        }
        catch (TestGenerationException ex)
        {
            Failures.Add(ex);
            Console.WriteLine($"   [FAILED]  Test: {ex.Message}");
        }
    }

    // ---------------------------------------------------------
    // 1. SOLVERS GENERATION
    // ---------------------------------------------------------
    private void CreateSolversFile(SolutionExport data, string safeTaskId, string folder)
    {
        string fileName = $"Solvers_Task_{safeTaskId}.cs";
        string fullPath = Path.Combine(folder, fileName);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"// Auto-generated Solvers for Task: {safeTaskId}");
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine("using System.Linq;");
        sb.AppendLine("using System.Text.RegularExpressions;");
        sb.AppendLine("using System.Text;");
        sb.AppendLine();

        // GPT
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.GPT");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.ChatGpt));
        sb.AppendLine("}");
        sb.AppendLine();

        // Gemini
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.Gemini");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.Gemini));
        sb.AppendLine("}");
        sb.AppendLine();

        // Claude
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.Claude");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.Claude));
        sb.AppendLine("}");
        sb.AppendLine();

        // Grok
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.Grok");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.Grok));
        sb.AppendLine("}");
        sb.AppendLine();

        // Mistral
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.Mistral");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.Mistral));
        sb.AppendLine("}");
        sb.AppendLine();

        // DeepSeek
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.DeepSeek");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.DeepSeek));
        sb.AppendLine("}");
        sb.AppendLine();

        // Llama
        sb.AppendLine($"namespace Benchmarks.{safeTaskId}.Llama");
        sb.AppendLine("{");
        sb.AppendLine(CleanCode(data.Llama));
        sb.AppendLine("}");

        File.WriteAllText(fullPath, sb.ToString());
        Console.WriteLine($"   [Created] Solver: {fileName}");
    }

    // ---------------------------------------------------------
    // 2. BENCHMARK GENERATION
    // ---------------------------------------------------------
    private void CreateBenchmarkFile(SolutionExport data, string safeTaskId, string folder)
    {
        string fileName = $"Benchmark_Task_{safeTaskId}.cs";
        string fullPath = Path.Combine(folder, fileName);

        string content = CleanCode(data.Benchmark);

        if (!content.Contains("using BenchmarkDotNet"))
        {
            content = "using BenchmarkDotNet.Attributes;\n" + content;
        }

        // Standardize naming
        content = content.Replace(".ChatGpt.Solver", ".GPT.Solver");

        File.WriteAllText(fullPath, content);
        Console.WriteLine($"   [Created] Benchmark: {fileName}");
    }

    // ---------------------------------------------------------
    // 3. TEST GENERATION
    // ---------------------------------------------------------
    private void CreateTestFile(SolutionExport data, string safeTaskId, string folder)
    {
        string fileName = $"Tests_Task_{safeTaskId}.cs";
        string fullPath = Path.Combine(folder, fileName);
        string entryPoint = data.EntryPoint;

        // 1. Extract the raw body (raises if extraction fails)
        string rawBody = ExtractMethodBodyRobust(data.Test, safeTaskId);

        // 2. CONVERT TO NON-BREAKING LOGIC (raises if assertions are dropped)
        string instrumentedBody = InstrumentTestCode(rawBody, safeTaskId);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"// Auto-generated Tests for Task: {safeTaskId}");
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine("using System.Linq;");
        sb.AppendLine("using KellermanSoftware.CompareNetObjects;");
        sb.AppendLine("using Tests.Shared;"); // Import our new helper
        sb.AppendLine();

        sb.AppendLine($"namespace Tests.{safeTaskId}");
        sb.AppendLine("{");
        sb.AppendLine("    public class TestRunner");
        sb.AppendLine("    {");

        sb.AppendLine(CreateTestMethod("Run_GPT",      instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.GPT.Solver"));
        sb.AppendLine(CreateTestMethod("Run_Gemini",   instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.Gemini.Solver"));
        sb.AppendLine(CreateTestMethod("Run_Claude",   instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.Claude.Solver"));
        sb.AppendLine(CreateTestMethod("Run_Grok",     instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.Grok.Solver"));
        sb.AppendLine(CreateTestMethod("Run_Mistral",  instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.Mistral.Solver"));
        sb.AppendLine(CreateTestMethod("Run_DeepSeek", instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.DeepSeek.Solver"));
        sb.AppendLine(CreateTestMethod("Run_Llama",    instrumentedBody, entryPoint, $"Benchmarks.{safeTaskId}.Llama.Solver"));

        sb.AppendLine("    }");
        sb.AppendLine("}");

        File.WriteAllText(fullPath, sb.ToString());
        Console.WriteLine($"   [Created] Test: {fileName}");
    }

    // --- HELPER METHODS ---

    // Assertions in the source test body, counted by their comparison call
    // rather than by the shape the rewriter happens to recognise.
    private static readonly Regex SourceAssertionPattern =
        new Regex(@"compareLogic\s*\.\s*Compare\s*\(", RegexOptions.IgnoreCase);

    private static readonly Regex InstrumentedAssertionPattern =
        new Regex(@"TestUtils\s*\.\s*Check\s*\(");

    // -------------------------------------------------------------------
    //  Rewrites assertions into non-throwing, counted TestUtils.Check calls.
    //
    //  The regex recognises one exact shape. An assertion written any other
    //  way used to be left un-instrumented, which meant it never entered the
    //  pass or fail counts: it did not fail, it disappeared, and the task's
    //  correctness was then computed over a reduced denominator.
    //
    //  The rewrite is still pattern-based, but it is now CHECKED: the number
    //  of assertions in the source must equal the number instrumented, and a
    //  shortfall raises instead of passing silently.
    // -------------------------------------------------------------------
    private string InstrumentTestCode(string code, string taskId)
    {
        string pattern = @"if\s*\(\!([a-zA-Z0-9_]+)\.AreEqual\)\s*\{\s*throw new Exception\(\""(.*?)\""\);\s*\}";
        string replacement = "TestUtils.Check($1, \"$2\");";
        string instrumented = Regex.Replace(code, pattern, replacement);

        int expected = SourceAssertionPattern.Matches(code).Count;
        int actual   = InstrumentedAssertionPattern.Matches(instrumented).Count;

        if (actual < expected)
            throw new TestGenerationException(taskId,
                $"instrumentation dropped {expected - actual} of {expected} assertion(s): " +
                "they would neither pass nor fail, and correctness would be computed " +
                "over a reduced denominator.");

        return instrumented;
    }

    private string CreateTestMethod(string methodName, string body, string entryPoint, string namespacePrefix)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"        public void {methodName}()");
        sb.AppendLine("        {");
        sb.AppendLine("            TestUtils.Reset();");
        sb.AppendLine("            try {");
        sb.AppendLine(InjectNamespace(body, entryPoint, namespacePrefix));
        sb.AppendLine("            } catch (Exception ex) { Console.WriteLine(\"CRITICAL FAIL: \" + ex.Message); }");
        sb.AppendLine("        }");
        return sb.ToString();
    }

    // -------------------------------------------------------------------
    //  Extracts the body of the test harness's Main method.
    //
    //  Every failure path used to return either a sentinel comment or the
    //  unchanged input, and the result was written into generated source
    //  regardless. The worst case produced a test method containing zero
    //  assertions, which compiled and reported success: a solution whose
    //  tests could not be extracted scored as passing.
    //
    //  All four now raise. A test file is never generated from an
    //  extraction that did not work.
    // -------------------------------------------------------------------
    private string ExtractMethodBodyRobust(string rawCode, string taskId)
    {
        if (string.IsNullOrEmpty(rawCode))
            throw new TestGenerationException(taskId, "no test code in the source record.");

        var mainMatch = Regex.Match(rawCode, @"Main\s*\(.*?\)");
        if (!mainMatch.Success)
            throw new TestGenerationException(taskId,
                "no Main( signature found, so the assertion body could not be located.");

        int startIndex = rawCode.IndexOf('{', mainMatch.Index);
        if (startIndex == -1)
            throw new TestGenerationException(taskId,
                "Main( found but no opening brace follows it.");

        int openBraces = 0;
        int endIndex = -1;

        for (int i = startIndex; i < rawCode.Length; i++)
        {
            if (rawCode[i] == '{') openBraces++;
            if (rawCode[i] == '}') openBraces--;

            if (openBraces == 0)
            {
                endIndex = i;
                break;
            }
        }

        if (endIndex == -1)
            throw new TestGenerationException(taskId,
                "braces in the test body are unbalanced, so its extent could not be determined. " +
                "Note the counter is not aware of string literals, character literals or " +
                "comments, so a brace inside any of those will trip this.");

        return rawCode.Substring(startIndex + 1, endIndex - startIndex - 1).Trim();
    }

    private string InjectNamespace(string codeBody, string entryPoint, string fullNamespace)
    {
        string pattern = $@"\b{entryPoint}\s*\(";
        string replacement = $"{fullNamespace}.{entryPoint}(";
        return Regex.Replace(codeBody, pattern, replacement);
    }

    private string CleanCode(string raw)
    {
        if (string.IsNullOrWhiteSpace(raw)) return "";
        return raw.Replace("```csharp", "").Replace("```", "").Trim();
    }

    // --- CRITICAL FIX: FINDING THE REAL PROJECT ROOT ---
    private string GetProjectRoot()
    {
        // Start where the .exe runs (usually bin/Debug/net8.0)
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        DirectoryInfo dir = new DirectoryInfo(currentDirectory);

        // Keep going up ONE folder at a time until we find a .csproj file
        while (dir != null && dir.GetFiles("*.csproj").Length == 0)
        {
            dir = dir.Parent;
        }

        // Return the folder containing the .csproj, or current dir if failed
        return dir != null ? dir.FullName : currentDirectory;
    }
}