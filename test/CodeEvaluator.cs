using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

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
        public List<string> ViolationDetails { get; set; } = new List<string>();

        // Compiler diagnostics, retained so a compile failure can be
        // diagnosed after the fact. These used to be written into
        // ViolationDetails and then dropped on the floor: BuildScoredRow
        // never copied them and no writer emitted them.
        public int CompileErrorCount { get; set; }
        public string CompileDiagnostics { get; set; } = "";

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

    public class TaskSpecification
    {
        public string MethodName { get; set; } = "";
    }

    public class CodeEvaluator
    {
        // NO EXECUTION TIMEOUT IS ENFORCED. There used to be a 5000 ms
        // constant here, used only by an inline-test path the pipeline never
        // reached: the call site always built an empty TestCases list.
        // Correctness came from the reflection runner in ProgramMain, which
        // has no timeout, so the constant described a bound that never
        // applied. The dead path and the constant are removed rather than
        // wired up: the manuscript reports that no timeout was enforced, and
        // enforcing one now would change what csharp_43 looks like, since
        // that solution ran for 21 seconds precisely because nothing
        // stopped it.

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
                var errors = emitResult.Diagnostics
                    .Where(d => d.Severity == DiagnosticSeverity.Error)
                    .ToList();

                report.CompileErrorCount = errors.Count;
                report.CompileDiagnostics = string.Join("; ", errors
                    .Select(d => $"{d.Id} {d.GetMessage()}")
                    .Distinct()
                    .Take(10));

                foreach (var diag in errors)
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
                    report.ViolationDetails.Add($"Logic Error: Method '{spec.MethodName}' not found.");
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

        // -----------------------------------------------------------------
        //  Reference set for the isolated compile.
        //
        //  This used to be seven hand-listed metadata references (object,
        //  Enumerable, List<>, Console, Regex, System.Runtime, netstandard).
        //  Any solution touching anything outside that closure failed the
        //  isolated compile while compiling and passing its tests in the
        //  real project build, so the Excluded column measured the sandbox
        //  rather than the model.
        //
        //  The trusted-platform-assemblies list is the set the host process
        //  was actually compiled and started against: the framework plus
        //  every package this project references, including
        //  KellermanSoftware.Compare-NET-Objects. Using it makes the
        //  isolated compile agree with the real build by construction, and
        //  it cannot drift as packages are added.
        // -----------------------------------------------------------------
        private static readonly Lazy<List<MetadataReference>> ProjectReferences =
            new Lazy<List<MetadataReference>>(BuildProjectReferences);

        /// <summary>Number of metadata references the isolated compile uses.</summary>
        public static int ReferenceCount => ProjectReferences.Value.Count;

        /// <summary>
        /// The shared reference set, so the analyzer pass compiles each
        /// snippet against exactly what the compile check does.
        /// </summary>
        public static IReadOnlyList<MetadataReference> CompilationReferences => ProjectReferences.Value;

        private static List<MetadataReference> BuildProjectReferences()
        {
            var refs = new List<MetadataReference>();
            var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            void TryAdd(string path)
            {
                if (string.IsNullOrEmpty(path)) return;
                if (!path.EndsWith(".dll", StringComparison.OrdinalIgnoreCase)) return;
                if (!File.Exists(path)) return;
                if (!seen.Add(Path.GetFileName(path))) return;
                try { refs.Add(MetadataReference.CreateFromFile(path)); }
                catch { /* native or unreadable image: not a managed reference */ }
            }

            if (AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") is string tpa)
                foreach (var path in tpa.Split(Path.PathSeparator))
                    TryAdd(path);

            // Anything pulled in at runtime (Assembly.LoadFrom) is not on the
            // TPA list; include it so the closure matches the live process.
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                if (!asm.IsDynamic)
                    TryAdd(asm.Location);

            return refs;
        }

        private CSharpCompilation CompileCode(string code)
        {
            return CSharpCompilation.Create("DynamicAiAssembly_" + Guid.NewGuid())
                .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
                .AddReferences(ProjectReferences.Value)
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
            {
                SyntaxNode? body = method.Body ?? (SyntaxNode?)method.ExpressionBody;
                total += ScoreNode(body, 0);
            }
            return total;
        }

        // -----------------------------------------------------------------
        //  Cognitive complexity, following Campbell's specification.
        //
        //  Two rules were previously missing, and both inflate the metric:
        //
        //  1. NESTING SATURATION ON else-if. An `else if` is a flat +1 and
        //     its body stays at the nesting level of the original `if`. The
        //     old code saw the chained `if` as a child of the else clause
        //     and recursed with nesting+1 each time, so a chain of n
        //     `else if`s cost 1+2+...+n instead of n. On csharp_34 (an
        //     11-long grade-boundary chain) that produced 91 to 105 against
        //     SonarQube's 15; this implementation returns 15.
        //
        //  2. BOOLEAN SEQUENCES. A run of the same logical operator is one
        //     increment, not one per operator: `a && b && c` scores 1, and
        //     `a && b || c` scores 2 because the operator changes.
        //
        //  Cyclomatic complexity already agreed closely with SonarQube
        //  (r = 0.986) and is deliberately left alone.
        // -----------------------------------------------------------------
        private int ScoreNode(SyntaxNode? node, int nesting)
        {
            if (node == null) return 0;

            switch (node)
            {
                // Reached only for a fresh `if`. An `else if` is consumed by
                // the else-chain walk inside ScoreIfChain and never arrives
                // here, which is what keeps its nesting level flat.
                case IfStatementSyntax ifs:
                    return ScoreIfChain(ifs, nesting);

                case ForStatementSyntax:
                case ForEachStatementSyntax:
                case WhileStatementSyntax:
                case DoStatementSyntax:
                case SwitchStatementSyntax:
                case CatchClauseSyntax:
                case ConditionalExpressionSyntax:
                    return 1 + nesting + ScoreChildren(node, nesting + 1);

                default:
                    int score = 0;
                    if (node is BinaryExpressionSyntax bin && IsLogical(bin) && !ContinuesRun(bin))
                        score += 1;
                    return score + ScoreChildren(node, nesting);
            }
        }

        private int ScoreChildren(SyntaxNode node, int nesting)
        {
            int score = 0;
            foreach (var child in node.ChildNodes())
                score += ScoreNode(child, nesting);
            return score;
        }

        private int ScoreIfChain(IfStatementSyntax ifs, int nesting)
        {
            int score = 1 + nesting;
            score += ScoreNode(ifs.Condition, nesting);
            score += ScoreNode(ifs.Statement, nesting + 1);

            var elseClause = ifs.Else;
            while (elseClause != null)
            {
                if (elseClause.Statement is IfStatementSyntax elseIf)
                {
                    score += 1;                                   // flat: no nesting penalty
                    score += ScoreNode(elseIf.Condition, nesting);
                    score += ScoreNode(elseIf.Statement, nesting + 1);
                    elseClause = elseIf.Else;
                }
                else
                {
                    score += 1;                                   // plain `else`
                    score += ScoreNode(elseClause.Statement, nesting + 1);
                    elseClause = null;
                }
            }
            return score;
        }

        private static bool IsLogical(BinaryExpressionSyntax b) =>
            b.IsKind(SyntaxKind.LogicalAndExpression) || b.IsKind(SyntaxKind.LogicalOrExpression);

        // True when this operator continues a run of the same operator, so
        // only the outermost node of each run is charged.
        private static bool ContinuesRun(BinaryExpressionSyntax b) =>
            b.Parent is BinaryExpressionSyntax parent && parent.Kind() == b.Kind();

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