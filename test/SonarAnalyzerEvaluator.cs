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
    /// <summary>
    /// Outcome of one analyzer scan. A scan that failed must never look like
    /// a clean file: previously any timeout or exception returned all-zero
    /// counts with an "A" grade, distinguishable from a perfect result only
    /// by a sentinel string in the rules column.
    /// </summary>
    public enum ScanStatus
    {
        Ok,
        AnalyzersUnavailable,
        TimedOut,
        Faulted,
    }

    // =========================================================================
    //  SonarAnalyzerReport
    // -------------------------------------------------------------------------
    //  Results from running the SonarAnalyzer.CSharp rules on one snippet.
    //
    //  NAMING. This is SonarAnalyzer, the Roslyn rule engine, loaded in
    //  process. It is not SonarQube, the platform, and nothing here talks to
    //  a SonarQube server. The two derived measures below are the authors'
    //  own formulas over the issue counts, not SonarQube outputs:
    //    * RemediationEffortMinutes is a local 30/10/2 minutes-per-severity
    //      proxy. It is NOT SQALE technical debt.
    //    * The A-to-E values are local grades over local thresholds. They are
    //      NOT SonarQube maintainability or reliability ratings.
    // =========================================================================
    public class SonarAnalyzerReport
    {
        public ScanStatus Status { get; set; } = ScanStatus.Ok;

        /// <summary>True only when the scan actually completed.</summary>
        public bool Succeeded => Status == ScanStatus.Ok;

        public int TotalIssues => Errors + Warnings + Info;
        public int Errors   { get; set; }    // DiagnosticSeverity.Error
        public int Warnings { get; set; }    // DiagnosticSeverity.Warning
        public int Info     { get; set; }    // DiagnosticSeverity.Info/Hidden

        /// <summary>
        /// Local remediation-effort proxy in minutes (Error 30, Warning 10,
        /// Info 2). Not SQALE debt; see the class note.
        /// </summary>
        public double RemediationEffortMinutes { get; set; }

        /// <summary>Local grade over warning+info count. Not a SonarQube rating.</summary>
        public string MaintainabilityGrade { get; set; } = "";

        /// <summary>Local grade over error count. Not a SonarQube rating.</summary>
        public string ReliabilityGrade { get; set; } = "";

        /// <summary>Comma-separated triggered rule IDs.</summary>
        public string TriggeredRules { get; set; } = "";

        /// <summary>
        /// Count of AD0001 diagnostics: analyzers that crashed while running.
        /// These used to be dropped, which hid rules that never got to fire.
        /// </summary>
        public int AnalyzerCrashes { get; set; }

        /// <summary>Detail for a failed scan, empty when Status is Ok.</summary>
        public string FailureDetail { get; set; } = "";
    }

    /// <summary>
    /// What the analyzer load actually produced. Recorded so the effective
    /// rule set is in the output rather than inferred afterwards.
    /// </summary>
    public sealed class AnalyzerLoadInfo
    {
        public string AssemblyName    { get; set; } = "";
        public string AssemblyVersion { get; set; } = "";
        public int TypesDiscovered    { get; set; }
        public int TypesFailedToLoad  { get; set; }
        public int Instantiated       { get; set; }
        public int FailedToInstantiate{ get; set; }
        public int DistinctRuleIds    { get; set; }

        public string Summary =>
            $"{AssemblyName} {AssemblyVersion}: {Instantiated} analyzer(s) covering " +
            $"{DistinctRuleIds} rule(s); {TypesFailedToLoad} type(s) failed to load, " +
            $"{FailedToInstantiate} failed to instantiate.";
    }

    // =========================================================================
    //  SonarAnalyzerEvaluator
    // -------------------------------------------------------------------------
    //  Loads SonarAnalyzer.CSharp.dll (copied to the output directory by the
    //  CopySonarAnalyzerToOutput MSBuild target), caches the instantiated
    //  analyzers, and runs them against a fresh in-memory compilation per
    //  snippet.
    // =========================================================================
    public class SonarAnalyzerEvaluator
    {
        private static ImmutableArray<DiagnosticAnalyzer>? _cached;
        private static readonly object _initLock = new();

        private const double CostError   = 30.0;   // minutes, local proxy
        private const double CostWarning = 10.0;
        private const double CostInfo    =  2.0;
        private const int    DefaultTimeoutMs = 60_000;

        /// <summary>The analyzer load result, available after the first scan.</summary>
        public static AnalyzerLoadInfo LoadInfo { get; private set; } = new AnalyzerLoadInfo();

        public SonarAnalyzerReport Evaluate(string code, int timeoutMs = DefaultTimeoutMs)
        {
            var report = new SonarAnalyzerReport();
            try
            {
                var analyzers = GetAnalyzers();
                if (analyzers.IsEmpty)
                {
                    report.Status = ScanStatus.AnalyzersUnavailable;
                    report.FailureDetail = "SonarAnalyzer.CSharp could not be loaded.";
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
                    // AD0001 means an analyzer threw while running. It is not
                    // a finding about the code, so it is not counted as an
                    // issue, but it IS recorded: dropping it hid rules that
                    // never got the chance to fire.
                    if (d.Id == "AD0001")
                    {
                        report.AnalyzerCrashes++;
                        continue;
                    }

                    switch (d.Severity)
                    {
                        case DiagnosticSeverity.Error:
                            report.Errors++;
                            report.RemediationEffortMinutes += CostError;
                            break;
                        case DiagnosticSeverity.Warning:
                            report.Warnings++;
                            report.RemediationEffortMinutes += CostWarning;
                            break;
                        default:
                            report.Info++;
                            report.RemediationEffortMinutes += CostInfo;
                            break;
                    }
                    ruleIds.Add(d.Id);
                }

                report.TriggeredRules       = string.Join(",", ruleIds);
                report.MaintainabilityGrade = MaintainabilityGrade(report.Warnings + report.Info);
                report.ReliabilityGrade     = ReliabilityGrade(report.Errors);
                report.Status               = ScanStatus.Ok;
            }
            catch (OperationCanceledException)
            {
                report.Status = ScanStatus.TimedOut;
                report.FailureDetail = $"scan exceeded {timeoutMs} ms";
            }
            catch (Exception ex)
            {
                report.Status = ScanStatus.Faulted;
                report.FailureDetail = ex.Message.Replace('\n', ' ').Replace('\t', ' ');
            }
            return report;
        }

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

        // -----------------------------------------------------------------
        //  Loads every DiagnosticAnalyzer in SonarAnalyzer.CSharp.dll, and
        //  RECORDS what happened. Types that fail to load and analyzers that
        //  fail to construct are both counted, so the effective rule set is
        //  a recorded fact rather than something inferred later.
        // -----------------------------------------------------------------
        private static ImmutableArray<DiagnosticAnalyzer> LoadAnalyzers()
        {
            Assembly? asm = FindSonarAssembly();
            if (asm == null)
            {
                Console.WriteLine("[SonarAnalyzer] SonarAnalyzer.CSharp.dll not found - analyzer pass unavailable.");
                LoadInfo = new AnalyzerLoadInfo { AssemblyName = "(not found)" };
                return ImmutableArray<DiagnosticAnalyzer>.Empty;
            }

            var info = new AnalyzerLoadInfo
            {
                AssemblyName    = asm.GetName().Name ?? "",
                AssemblyVersion = asm.GetName().Version?.ToString() ?? "",
            };

            var daType = typeof(DiagnosticAnalyzer);
            List<Type> types;
            try
            {
                types = asm.GetTypes()
                    .Where(t => !t.IsAbstract && daType.IsAssignableFrom(t) &&
                                t.GetConstructor(Type.EmptyTypes) != null)
                    .ToList();
            }
            catch (ReflectionTypeLoadException ex)
            {
                // Reached when a dependency of the analyzer assembly is
                // missing. Referencing Microsoft.CodeAnalysis.CSharp.Workspaces
                // is what keeps this branch from being taken.
                info.TypesFailedToLoad = ex.LoaderExceptions?.Length ?? 0;
                types = (ex.Types ?? Array.Empty<Type>())
                    .Where(t => t != null && !t!.IsAbstract && daType.IsAssignableFrom(t!) &&
                                t!.GetConstructor(Type.EmptyTypes) != null)
                    .Select(t => t!)
                    .ToList();
            }

            info.TypesDiscovered = types.Count;

            var list = new List<DiagnosticAnalyzer>();
            var ruleIds = new HashSet<string>(StringComparer.Ordinal);
            foreach (var t in types)
            {
                try
                {
                    var analyzer = (DiagnosticAnalyzer)Activator.CreateInstance(t)!;
                    list.Add(analyzer);
                    foreach (var d in analyzer.SupportedDiagnostics) ruleIds.Add(d.Id);
                }
                catch
                {
                    info.FailedToInstantiate++;
                }
            }

            info.Instantiated    = list.Count;
            info.DistinctRuleIds = ruleIds.Count;
            LoadInfo = info;

            Console.WriteLine($"[SonarAnalyzer] {info.Summary}");
            if (info.TypesFailedToLoad > 0)
                Console.WriteLine("[SonarAnalyzer] WARNING: some analyzer types failed to load; " +
                                  "the effective rule set is smaller than the package provides.");
            return list.ToImmutableArray();
        }

        private static Assembly? FindSonarAssembly()
        {
            var loaded = AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "SonarAnalyzer.CSharp");
            if (loaded != null) return loaded;

            string exeDir  = AppDomain.CurrentDomain.BaseDirectory;
            string dllPath = Path.Combine(exeDir, "SonarAnalyzer.CSharp.dll");
            if (File.Exists(dllPath))
                return Assembly.LoadFrom(dllPath);

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
            return CSharpCompilation.Create(
                "SonarAnalysis_" + Guid.NewGuid(),
                new[] { tree },
                CodeEvaluator.CompilationReferences,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary,
                    reportSuppressedDiagnostics: false));
        }

        // Local grades over local thresholds. Not SonarQube ratings.
        private static string MaintainabilityGrade(int count) =>
            count == 0 ? "A" : count <= 3 ? "B" : count <= 7 ? "C" : count <= 15 ? "D" : "E";

        private static string ReliabilityGrade(int count) =>
            count == 0 ? "A" : count == 1 ? "B" : count <= 3 ? "C" : count <= 7 ? "D" : "E";
    }
}
