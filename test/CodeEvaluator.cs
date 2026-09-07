using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace EvaluatedCodeGeneration
{
    // =====================================================================
    //  CodeEvaluator  (REVISED)
    // ---------------------------------------------------------------------
    //  Responsibilities AFTER revision:
    //    * Compile the extracted solver.
    //    * Run functional unit tests (reflection) -> SuccessRate.
    //    * Extract Roslyn static metrics (now incl. COGNITIVE complexity
    //      and an explicit, reference-backed Professionalism score).
    //
    //  What was REMOVED and WHY:
    //    * MeasurePerformance() Stopwatch loop. The paper reports
    //      BenchmarkDotNet timings (Phase 3), and the Stopwatch path used a
    //      single non-worst-case input and was the source of the bogus
    //      Norm_Performance=0 in the old composite. Efficiency now comes
    //      exclusively from the BenchmarkDotNet harness in Program.cs, so
    //      code and paper finally agree.
    //    * CalculateScore(). Scoring is now centralised in ScoringEngine,
    //      fed with REAL correctness + REAL benchmark numbers.
    // =====================================================================

    public class CodeQualityReport
    {
        public bool Compiles { get; set; }
        public bool PassesTests { get; set; }
        public TestInfo TestInfo { get; set; } = new TestInfo();
        public List<string> ViolationDetails { get; set; } = new List<string>();

        // Static metrics (raw)
        public int CyclomaticComplexity { get; set; }
        public int CognitiveComplexity { get; set; }   // NEW (COMPASS "Bumpy Road"/nesting penalty)
        public int MaxNestingDepth { get; set; }
        public int NamingViolations { get; set; }

        // Professionalism sub-signals (NEW: explicit, documented)
        public bool HasDocumentation { get; set; }
        public bool HasNullChecks { get; set; }
        public int ProfessionalismScore { get; set; }  // 0..3, see AnalyzeProfessionalism
    }

    public class TestInfo
    {
        public bool AllTestPasses { get; set; }
        public int PassTestCount { get; set; }
        public int FailTestCount { get; set; }
        public double SuccessRate { get; set; }
        public double FailRate { get; set; }
    }

    public class TaskSpecification
    {
        public string MethodName { get; set; } = "";
        public List<TestCase> TestCases { get; set; } = new List<TestCase>();
    }

    public class TestCase
    {
        public object[] Inputs { get; set; } = Array.Empty<object>();
        public object? Expected { get; set; }
    }

    public class CodeEvaluator
    {
        private const int ExecutionTimeoutMs = 5000;

        public CodeQualityReport Evaluate(string aiCode, TaskSpecification spec)
        {
            var report = new CodeQualityReport();

            // --- STEP 1: COMPILATION ---
            var compilation = CompileCode(aiCode);
            using var ms = new MemoryStream();
            var emitResult = compilation.Emit(ms);
            report.Compiles = emitResult.Success;

            if (!report.Compiles)
            {
                foreach (var diag in emitResult.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error))
                    report.ViolationDetails.Add($"Compile Error: {diag.GetMessage()}");
                // Do NOT fabricate a score here. The pipeline flags this row
                // as Excluded via ScoringEngine (Bug 3 fix). We still parse
                // static metrics where possible so they can be inspected.
            }
            else
            {
                ms.Seek(0, SeekOrigin.Begin);
                var assembly = Assembly.Load(ms.ToArray());
                var type = assembly.GetTypes()
                    .FirstOrDefault(t => t.Name is "Program" or "Solution" or "Solver");
                var methodInfo = type?
                    .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                    .FirstOrDefault(m => m.Name == spec.MethodName);

                if (methodInfo == null)
                {
                    report.ViolationDetails.Add($"Logic Error: Method '{spec.MethodName}' not found.");
                }
                else if (spec.TestCases.Count > 0)
                {
                    // Optional inline tests (used by unit tests of THIS engine).
                    report.TestInfo = RunFunctionalTests(methodInfo, type!, spec, report);
                    report.PassesTests = report.TestInfo.AllTestPasses;
                }
            }

            // --- STEP 2: STATIC ANALYSIS (always attempt) ---
            var tree = CSharpSyntaxTree.ParseText(aiCode);
            report.CyclomaticComplexity = CalculateCyclomaticComplexity(tree);
            report.CognitiveComplexity = CalculateCognitiveComplexity(tree);
            report.MaxNestingDepth = CalculateMaxNesting(tree);
            AnalyzeNamingConventions(tree, report, spec.MethodName);
            AnalyzeProfessionalism(tree, report);

            return report;
        }

        private TestInfo RunFunctionalTests(MethodInfo method, Type type, TaskSpecification spec, CodeQualityReport report)
        {
            var testDetail = new TestInfo { AllTestPasses = true };
            int totalTests = spec.TestCases.Count;
            if (totalTests == 0) return testDetail;

            object? instance = method.IsStatic ? null : Activator.CreateInstance(type);

            foreach (var test in spec.TestCases)
            {
                try
                {
                    var task = Task.Run(() => method.Invoke(instance, test.Inputs));
                    if (task.Wait(TimeSpan.FromMilliseconds(ExecutionTimeoutMs)))
                    {
                        var actual = task.Result;
                        if (!ObjectsAreEqual(actual, test.Expected))
                        {
                            testDetail.FailTestCount++;
                            testDetail.AllTestPasses = false;
                        }
                        else testDetail.PassTestCount++;
                    }
                    else
                    {
                        testDetail.FailTestCount++;
                        testDetail.AllTestPasses = false;
                        report.ViolationDetails.Add($"Timeout > {ExecutionTimeoutMs}ms (infinite loop?)");
                    }
                }
                catch (Exception ex)
                {
                    testDetail.FailTestCount++;
                    testDetail.AllTestPasses = false;
                    report.ViolationDetails.Add($"Runtime Error: {ex.InnerException?.Message ?? ex.Message}");
                }
            }

            testDetail.SuccessRate = (double)testDetail.PassTestCount / totalTests * 100;
            testDetail.FailRate = 100 - testDetail.SuccessRate;
            return testDetail;
        }

        private bool ObjectsAreEqual(object? actual, object? expected)
        {
            if (actual == null && expected == null) return true;
            if (actual == null || expected == null) return false;
            try { return JsonSerializer.Serialize(actual) == JsonSerializer.Serialize(expected); }
            catch { return actual.Equals(expected); }
        }

        private CSharpCompilation CompileCode(string code)
        {
            var references = new List<MetadataReference>
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(List<>).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Text.RegularExpressions.Regex).Assembly.Location),
                MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
                MetadataReference.CreateFromFile(Assembly.Load("netstandard").Location)
            };
            return CSharpCompilation.Create("DynamicAiAssembly_" + Guid.NewGuid())
                .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
                .AddReferences(references)
                .AddSyntaxTrees(CSharpSyntaxTree.ParseText(code));
        }

        // --- STATIC ANALYSIS HELPERS ---

        private int CalculateCyclomaticComplexity(SyntaxTree tree)
        {
            var root = tree.GetRoot();
            int decisionPoints = root.DescendantTokens().Count(t =>
                t.IsKind(SyntaxKind.IfKeyword) ||
                t.IsKind(SyntaxKind.WhileKeyword) ||
                t.IsKind(SyntaxKind.ForKeyword) ||
                t.IsKind(SyntaxKind.ForEachKeyword) ||
                t.IsKind(SyntaxKind.CaseKeyword) ||
                t.IsKind(SyntaxKind.CatchKeyword) ||
                t.IsKind(SyntaxKind.QuestionQuestionToken) ||
                t.IsKind(SyntaxKind.AmpersandAmpersandToken) ||
                t.IsKind(SyntaxKind.BarBarToken));
            return decisionPoints + 1;
        }

        // -----------------------------------------------------------------
        //  Cognitive Complexity (NEW)
        //  Approximates the SonarSource cognitive-complexity rule: each
        //  control-flow construct adds 1 + its current nesting level. This
        //  is the metric behind COMPASS's "Deep, Nested Complexity" and
        //  "Bumpy Road" issue categories, giving us a directly comparable
        //  quality signal to the COMPASS / CodeScene analysis.
        //  Ref: G. Ann Campbell, "Cognitive Complexity" (SonarSource, 2018).
        // -----------------------------------------------------------------
        private int CalculateCognitiveComplexity(SyntaxTree tree)
        {
            int total = 0;
            foreach (var method in tree.GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>())
                total += CognitiveOf(method.Body, 0);
            return total;
        }

        private int CognitiveOf(SyntaxNode? node, int nesting)
        {
            if (node == null) return 0;
            int score = 0;
            foreach (var child in node.ChildNodes())
            {
                bool increasesNesting =
                    child is IfStatementSyntax ||
                    child is ForStatementSyntax ||
                    child is ForEachStatementSyntax ||
                    child is WhileStatementSyntax ||
                    child is DoStatementSyntax ||
                    child is SwitchStatementSyntax ||
                    child is CatchClauseSyntax;

                if (increasesNesting)
                {
                    score += 1 + nesting;          // base + nesting penalty
                    score += CognitiveOf(child, nesting + 1);
                }
                else
                {
                    // Boolean sequences (&&, ||) add 1 each (flat).
                    if (child is BinaryExpressionSyntax bin &&
                        (bin.IsKind(SyntaxKind.LogicalAndExpression) ||
                         bin.IsKind(SyntaxKind.LogicalOrExpression)))
                        score += 1;
                    score += CognitiveOf(child, nesting);
                }
            }
            return score;
        }

        private int CalculateMaxNesting(SyntaxTree tree)
        {
            int maxDepth = 0;
            foreach (var method in tree.GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>())
                maxDepth = Math.Max(maxDepth, GetNestingDepth(method.Body));
            return maxDepth;
        }

        private int GetNestingDepth(SyntaxNode? node, int depth = 0)
        {
            if (node == null) return depth;
            int max = depth;
            foreach (var child in node.ChildNodes())
            {
                int nextDepth = depth;
                if (child is IfStatementSyntax ||
                    child is ForStatementSyntax ||
                    child is ForEachStatementSyntax ||
                    child is WhileStatementSyntax ||
                    child is DoStatementSyntax)
                    nextDepth++;
                max = Math.Max(max, GetNestingDepth(child, nextDepth));
            }
            return max;
        }

        private void AnalyzeNamingConventions(SyntaxTree tree, CodeQualityReport report, string expectedMethodName)
        {
            var root = tree.GetRoot();
            var method = root.DescendantNodes().OfType<MethodDeclarationSyntax>()
                             .FirstOrDefault(m => m.Identifier.Text == expectedMethodName);
            if (method != null && method.Identifier.Text.Length > 0 && char.IsLower(method.Identifier.Text[0]))
                report.NamingViolations++;

            var identifiers = root.DescendantNodes().OfType<ParameterSyntax>().Select(p => p.Identifier.Text)
                .Concat(root.DescendantNodes().OfType<VariableDeclaratorSyntax>().Select(v => v.Identifier.Text));

            foreach (var name in identifiers)
                if (!string.IsNullOrEmpty(name) && char.IsUpper(name[0]))
                    report.NamingViolations++;
        }

        // -----------------------------------------------------------------
        //  Professionalism (REVISED + documented)
        //  Reviewer 1 asked for the ORIGIN of this metric. It is NOT a C#-
        //  specific invention: it operationalises three widely-cited
        //  production-readiness signals for object-oriented code:
        //    (a) API documentation presence (XML doc comments)            [Microsoft C# Coding Conventions]
        //    (b) defensive null-handling / input validation               [Bloch, Effective Java, Item 49; CWE-476]
        //    (c) idiomatic LINQ/use of standard library over manual loops  [Microsoft .NET API guidelines]
        //  Each contributes 1 point => 0..3. Reported individually too.
        // -----------------------------------------------------------------
        private void AnalyzeProfessionalism(SyntaxTree tree, CodeQualityReport report)
        {
            var root = tree.GetRoot();
            var code = tree.ToString();

            report.HasNullChecks = code.Contains("== null") || code.Contains("is null")
                                   || code.Contains("ArgumentNullException") || code.Contains("?.");
            report.HasDocumentation = root.DescendantTrivia()
                .Any(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                       || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia));

            bool usesLinq = root.DescendantNodes().OfType<InvocationExpressionSyntax>()
                .Any(inv => inv.Expression is MemberAccessExpressionSyntax m &&
                            (m.Name.Identifier.Text is "Select" or "Where" or "Aggregate"
                             or "Sum" or "Any" or "All" or "OrderBy" or "GroupBy"));

            int p = 0;
            if (report.HasDocumentation) p++;
            if (report.HasNullChecks) p++;
            if (usesLinq) p++;
            report.ProfessionalismScore = p;
        }
    }
}