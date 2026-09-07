using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EvaluatedCodeGeneration
{
    // =========================================================================
    //  SonarQubeReport
    // -------------------------------------------------------------------------
    //  Results from running SonarAnalyzer.CSharp rules on a single code snippet.
    //  Stored alongside (not replacing) the existing Roslyn static metrics so
    //  both measurement approaches are available in the paper.
    // =========================================================================
    public class SonarQubeReport
    {
        public int TotalIssues       => Errors + Warnings + Info;
        public int Errors   { get; set; }    // DiagnosticSeverity.Error   (Blocker/Critical)
        public int Warnings { get; set; }    // DiagnosticSeverity.Warning (Major)
        public int Info     { get; set; }    // DiagnosticSeverity.Info/Hidden (Minor/Info)

        // Simplified technical-debt estimate (minutes), following SonarQube's
        // remediation-cost model: Error=30 min, Warning=10 min, Info=2 min.
        public double TechDebtMinutes { get; set; }

        // Maintainability  A (0 issues) … E (>15 warnings/info)
        // Reliability      A (0 errors)  … E (>7 errors)
        public string MaintainabilityRating { get; set; } = "A";
        public string ReliabilityRating     { get; set; } = "A";

        // Comma-separated list of triggered SonarQube rule IDs (S####).
        // Kept for qualitative inspection / appendix reference in the paper.
        public string TriggeredRules { get; set; } = "";
    }

    // =========================================================================
    //  SonarQubeEvaluator
    // -------------------------------------------------------------------------
    //  Loads SonarAnalyzer.CSharp.dll (copied to the output directory by the
    //  CopySonarAnalyzerToOutput MSBuild target in test.csproj) at first call,
    //  caches the instantiated DiagnosticAnalyzer list, and runs it against a
    //  fresh in-memory Roslyn compilation for every code snippet.
    // =========================================================================
    public class SonarQubeEvaluator
    {
        private static ImmutableArray<DiagnosticAnalyzer>? _cached;
        private static readonly object _initLock = new();

        private const double CostError   = 30.0;   // minutes
        private const double CostWarning = 10.0;
        private const double CostInfo    =  2.0;
        private const int    DefaultTimeoutMs = 60_000;

        public SonarQubeReport Evaluate(string code, int timeoutMs = DefaultTimeoutMs)
        {
            var report = new SonarQubeReport();
            try
            {
                var analyzers = GetAnalyzers();
                if (analyzers.IsEmpty)
                {
                    report.TriggeredRules = "NO_ANALYZERS";
                    return report;
                }

                var tree        = CSharpSyntaxTree.ParseText(code);
                var compilation = BuildCompilation(tree);

                var withAnalyzers = compilation.WithAnalyzers(
                    analyzers,
                    new AnalyzerOptions(ImmutableArray<AdditionalText>.Empty));

                using var cts = new CancellationTokenSource(timeoutMs);
                var diagnostics = withAnalyzers
                    .GetAnalyzerDiagnosticsAsync(cts.Token)
                    .GetAwaiter()
                    .GetResult();

                var ruleIds = new SortedSet<string>();
                foreach (var d in diagnostics)
                {
                    // Skip meta-diagnostics about the analyser itself
                    if (d.Id == "AD0001") continue;

                    switch (d.Severity)
                    {
                        case DiagnosticSeverity.Error:
                            report.Errors++;
                            report.TechDebtMinutes += CostError;
                            break;
                        case DiagnosticSeverity.Warning:
                            report.Warnings++;
                            report.TechDebtMinutes += CostWarning;
                            break;
                        default:
                            report.Info++;
                            report.TechDebtMinutes += CostInfo;
                            break;
                    }
                    ruleIds.Add(d.Id);
                }

                report.TriggeredRules         = string.Join(",", ruleIds);
                report.MaintainabilityRating  = Maintainability(report.Warnings + report.Info);
                report.ReliabilityRating      = Reliability(report.Errors);
            }
            catch (OperationCanceledException)
            {
                report.TriggeredRules = "TIMEOUT";
            }
            catch (Exception ex)
            {
                report.TriggeredRules = "ERROR:" + ex.Message.Replace('\n', ' ');
            }
            return report;
        }

        // Loads and caches all DiagnosticAnalyzer instances from SonarAnalyzer.CSharp.dll.
        private static ImmutableArray<DiagnosticAnalyzer> GetAnalyzers()
        {
            if (_cached.HasValue) return _cached.Value;
            lock (_initLock)
            {
                if (_cached.HasValue) return _cached.Value;
                _cached = LoadAnalyzers();
            }
            return _cached.Value;
        }

        private static ImmutableArray<DiagnosticAnalyzer> LoadAnalyzers()
        {
            Assembly? asm = FindSonarAssembly();
            if (asm == null)
            {
                Console.WriteLine("[SonarQube] SonarAnalyzer.CSharp.dll not found — skipping SonarQube evaluation.");
                return ImmutableArray<DiagnosticAnalyzer>.Empty;
            }

            var daType = typeof(DiagnosticAnalyzer);
            IEnumerable<Type> types;
            try
            {
                types = asm.GetTypes()
                    .Where(t => !t.IsAbstract &&
                                daType.IsAssignableFrom(t) &&
                                t.GetConstructor(Type.EmptyTypes) != null);
            }
            catch (ReflectionTypeLoadException ex)
            {
                types = (ex.Types ?? Array.Empty<Type>())
                    .Where(t => t != null && !t!.IsAbstract && daType.IsAssignableFrom(t!))!;
            }

            var list = new List<DiagnosticAnalyzer>();
            foreach (var t in types)
            {
                try { list.Add((DiagnosticAnalyzer)Activator.CreateInstance(t)!); }
                catch { /* skip analyzers that can't be instantiated in isolation */ }
            }

            Console.WriteLine($"[SonarQube] Loaded {list.Count} analyzers from {asm.GetName().Name} {asm.GetName().Version}");
            return list.ToImmutableArray();
        }

        private static Assembly? FindSonarAssembly()
        {
            // 1. Already loaded in this process?
            var loaded = AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "SonarAnalyzer.CSharp");
            if (loaded != null) return loaded;

            // 2. Copied next to the executable by the MSBuild CopySonarAnalyzerToOutput target
            string exeDir  = AppDomain.CurrentDomain.BaseDirectory;
            string dllPath = Path.Combine(exeDir, "SonarAnalyzer.CSharp.dll");
            if (File.Exists(dllPath))
                return Assembly.LoadFrom(dllPath);

            // 3. Fallback: search the NuGet package cache
            string nugetPkgs = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".nuget", "packages", "sonaranalyzer.csharp");
            if (Directory.Exists(nugetPkgs))
            {
                string? latestVersionDir = Directory.GetDirectories(nugetPkgs)
                    .OrderByDescending(d => d)
                    .FirstOrDefault();
                if (latestVersionDir != null)
                {
                    string fallback = Path.Combine(latestVersionDir, "analyzers", "SonarAnalyzer.CSharp.dll");
                    if (File.Exists(fallback)) return Assembly.LoadFrom(fallback);
                }
            }

            return null;
        }

        private static CSharpCompilation BuildCompilation(SyntaxTree tree)
        {
            var refs = new[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(List<>).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Text.RegularExpressions.Regex).Assembly.Location),
                MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
            };
            return CSharpCompilation.Create(
                "SonarAnalysis_" + Guid.NewGuid(),
                new[] { tree },
                refs,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                    reportSuppressedDiagnostics: false));
        }

        // Maintainability: based on warning+info count (code smells proxy)
        private static string Maintainability(int count) =>
            count == 0 ? "A" : count <= 3 ? "B" : count <= 7 ? "C" : count <= 15 ? "D" : "E";

        // Reliability: based on error count (bug proxy)
        private static string Reliability(int count) =>
            count == 0 ? "A" : count == 1 ? "B" : count <= 3 ? "C" : count <= 7 ? "D" : "E";
    }
}