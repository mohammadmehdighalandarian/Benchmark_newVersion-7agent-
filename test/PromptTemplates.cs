// =====================================================================
//  PromptTemplates.cs  -  PHASE 1 (dataset preparation)
// ---------------------------------------------------------------------
//  The two prompt templates used to query the models, recovered verbatim
//  from the stored per-row prompt columns of the task workbook
//  (benchmark.xlsx, sheet "Tasks", column I = our_prompt, column J =
//  benchmark_prompt).
//
//  PROVENANCE. These are not reconstructions. Every one of the 80 stored
//  solution prompts and 80 stored benchmark prompts decomposes exactly
//  into <Prefix> + <input JSON> + <Suffix>, where the input JSON is built
//  from columns A (task_id), B (prompt), F (entry_point) and E
//  (description) of the same row. DatasetPreparation.VerifyAgainstWorkbook
//  re-derives all 160 prompts and asserts byte equality against the stored
//  text, so this file is checkable rather than merely asserted.
//
//  ENCODING. The templates are written with explicit escape sequences
//  rather than as verbatim literals. The stored prompts use LF line endings; a
//  verbatim literal in a CRLF-checked-out file would silently introduce CR
//  characters and break byte equality.
//
//  KNOWN GAP - do not paper over it. BenchmarkPromptPrefix is the
//  FOUR-MODEL template: it names GPT, Gemini, Claude and Grok, and it
//  instructs [Params(100, 1000, 10000)]. The seven-model revision that
//  actually produced the shipped harnesses is not on disk in either
//  repository. The shipped harnesses carry [Params(10, 100)] and seven
//  benchmark methods, so the executed configuration differs from the
//  instruction preserved here. The manuscript must report N = {10, 100},
//  the executed values, not the instructed ones.
// =====================================================================

namespace EvaluatedCodeGeneration
{
    /// <summary>
    /// Fixed prompt templates for Phase 1. A prompt is
    /// <c>Prefix + PromptInput.ToJson(task) + Suffix</c>.
    /// </summary>
    public static class PromptTemplates
    {
        // ---- solution_prompt (workbook column I, "our_prompt") ----

        public const string SolutionPromptPrefix =
            "Role: You are an expert C# Algorithm Developer.\n"
            + "\n"
            + "                Task: I will provide a JSON object containing a C# problem (prompt, entry_point, description). Your goal is to implement the solution method inside a class named Solver. Strict Coding Rules: Class Name: You must wrap the method in a public class Solver. Signature: Use the exact return type and method name defined in the entry_point and prompt. No Namespace: Do NOT wrap your code in a namespace. My system will add that later. No Main: Do NOT include a Main method. Dependencies: Include any necessary using statements (like System.Linq) at the very top.\n"
            + "\n"
            + "                Input JSON: \"";

        public const string SolutionPromptSuffix =
            "\"\n"
            + "\n"
            + "                Output: Provide only the C# code block. No explanations.";

        // ---- benchmark_prompt (workbook column J) ----
        // NOTE: four-model template. See the KNOWN GAP note above.

        public const string BenchmarkPromptPrefix =
            "Role:\n"
            + "You are an expert C# Performance Architect specializing in BenchmarkDotNet.\n"
            + "\n"
            + "Objective:\n"
            + "I will provide a JSON object describing a coding problem. Your task is to write a BenchmarkRunner class that tests 4 existing solutions (GPT, Gemini, Claude, Grok) against each other.\n"
            + "\n"
            + "Input JSON Fields:\n"
            + "\n"
            + "    task_id: Unique ID (e.g., \"csharp/0\").\n"
            + "\n"
            + "    entry_point: The method name to call (e.g., \"BelowZero\").\n"
            + "\n"
            + "    prompt: Contains the method signature and types.\n"
            + "\n"
            + "    description: The logic of the problem.\n"
            + "\n"
            + "Strict Implementation Rules:\n"
            + "\n"
            + "    Namespace Naming:\n"
            + "\n"
            + "        You must sanitize task_id. Replace /, -, and spaces with _.\n"
            + "\n"
            + "        Example: csharp/0 becomes csharp_0.\n"
            + "\n"
            + "        The namespace must be: Benchmarks.{task_id_sanitized}\n"
            + "\n"
            + "    Class & Attributes:\n"
            + "\n"
            + "        Class name: public class BenchmarkRunner\n"
            + "\n"
            + "        Attributes: [MemoryDiagnoser], [RankColumn], [Orderer(SummaryOrderPolicy.FastestToSlowest)]\n"
            + "\n"
            + "        Params: [Params(100, 1000, 10000)] public int N { get; set; }\n"
            + "\n"
            + "    Data Generation ([GlobalSetup]):\n"
            + "\n"
            + "        CRITICAL: Analyze the description and entry_point. You must generate Worst-Case Scenario data.\n"
            + "\n"
            + "        Why? If the code exits early (e.g., finds a value in index 0), the benchmark will show 0ns.\n"
            + "\n"
            + "        Instruction: Create data that forces the solver to process the entire N items.\n"
            + "\n"
            + "        Example: If the problem is \"Return true if sum < 0\", generate a list that stays positive until the very last item.\n"
            + "\n"
            + "    The Benchmark Methods:\n"
            + "\n"
            + "        You must define exactly 4 methods: GPT, Gemini, Claude, Grok.\n"
            + "\n"
            + "        GPT must have [Benchmark(Baseline = true)].\n"
            + "\n"
            + "        The methods must return the result (do not use void) to prevent JIT optimization.\n"
            + "\n"
            + "        Calling Convention: You must call the solvers using this exact fully qualified name pattern:\n"
            + "        return Benchmarks.{task_id_sanitized}.{AI_NAME}.Solver.{entry_point}(_data);\n"
            + "\n"
            + "Input JSON:\n"
            + "\"";

        public const string BenchmarkPromptSuffix =
            "\"\n"
            + "\n"
            + "Output:\n"
            + "Provide ONLY the C# code. Do not include markdown code blocks or explanations.";

        /// <summary>Instantiates the solution prompt for one task.</summary>
        public static string Solution(TaskRecord task) =>
            SolutionPromptPrefix + PromptInput.ToJson(task) + SolutionPromptSuffix;

        /// <summary>Instantiates the benchmark prompt for one task.</summary>
        public static string Benchmark(TaskRecord task) =>
            BenchmarkPromptPrefix + PromptInput.ToJson(task) + BenchmarkPromptSuffix;
    }
}
