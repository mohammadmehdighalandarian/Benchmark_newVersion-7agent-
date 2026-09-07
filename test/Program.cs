// =====================================================================
//  Program.cs  —  SCORING PATCH  (revision)
// ---------------------------------------------------------------------
//  This file contains DROP-IN replacements for the scoring / result-
//  mapping portion of Program.cs. Paste these members into the Program
//  class and update the call sites as indicated. It does three things:
//
//    (A) Builds a fully-populated ScoreInputs per (task, model) from the
//        REAL correctness (Phase 1) and REAL BenchmarkDotNet median time +
//        allocations (Phase 3), then calls ScoringEngine.Compute().
//        -> Fixes Bug 1 (composite no longer averages in two forced zeros)
//        -> Fixes Bug 2 (efficiency comes from BenchmarkDotNet, not Stopwatch)
//        -> Fixes Bug 3 (non-compiling rows are Excluded, not scored 0)
//
//    (B) Adds an optional k>1 multi-run loop so Pass@1 determinism can be
//        verified empirically (Reviewer 1).
//
//    (C) Writes the three independent COMPASS axes (Correctness, Efficiency,
//        Quality) plus the documented Composite to Excel, with an
//        Excluded flag column.
// =====================================================================

using EvaluatedCodeGeneration;

public partial class Program
{
    // Expanded result row: 3 COMPASS axes + composite + provenance flags.
    public class FinalResultRowV2
    {
        public string TaskId { get; set; } = "";
        public string AiModel { get; set; } = "";

        public double Correctness { get; set; }       // %
        public double EfficiencyScore { get; set; }   // 0..100
        public double QualityScore { get; set; }      // 0..100 (structural+style)
        public double CompositeScore { get; set; }    // 0..100 (weighted, documented)

        public double ExecutionTimeNs { get; set; }   // BenchmarkDotNet median
        public double MemoryBytes { get; set; }

        public int Complexity { get; set; }
        public int CognitiveComplexity { get; set; }
        public int NestingDepth { get; set; }
        public int NamingViolations { get; set; }
        public int ProfessionalismScore { get; set; }

        public bool Excluded { get; set; }
        public string ExclusionReason { get; set; } = "";

        // SonarQube metrics (from SonarAnalyzer.CSharp — kept separate from the
        // existing Roslyn metrics so both measurement sources are in the paper)
        public int    SQ_TotalIssues          { get; set; }
        public int    SQ_Errors               { get; set; }   // Error severity (Blocker/Critical)
        public int    SQ_Warnings             { get; set; }   // Warning severity (Major)
        public int    SQ_Info                 { get; set; }   // Info/Hidden severity (Minor)
        public double SQ_TechDebtMinutes      { get; set; }
        public string SQ_MaintainabilityRating { get; set; } = "";
        public string SQ_ReliabilityRating    { get; set; } = "";
        public string SQ_TriggeredRules       { get; set; } = "";
    }

    // -----------------------------------------------------------------
    //  Call this AFTER Phase 1 (correctness) AND Phase 3 (benchmarks)
    //  have populated correctness, ExecutionTimeNs and MemoryBytes.
    //  `staticReports` maps (taskId, model) -> CodeQualityReport from
    //  CodeEvaluator. `correctness`, `timeNs`, `memBytes` likewise.
    // -----------------------------------------------------------------
    public static FinalResultRowV2 BuildScoredRow(
        string taskId,
        string model,
        CodeQualityReport report,        // from CodeEvaluator.Evaluate (static metrics + compile flag)
        double successRatePct,           // from Phase 1 reflection tests
        double medianTimeNs,             // from Phase 3 BenchmarkDotNet (0 if missing)
        double allocatedBytes,           // from Phase 3 BenchmarkDotNet
        ScoringConfig cfg)
    {
        var inputs = new ScoreInputs
        {
            TaskId = taskId,
            Model = model,
            Compiled = report.Compiles,
            SuccessRatePct = successRatePct,
            CyclomaticComplexity = report.CyclomaticComplexity,
            MaxNestingDepth = report.MaxNestingDepth,
            NamingViolations = report.NamingViolations,
            HasDocumentation = report.HasDocumentation,
            HasNullChecks = report.HasNullChecks,
            MedianExecutionTimeNs = medianTimeNs,
            AllocatedBytes = allocatedBytes
        };

        var s = ScoringEngine.Compute(inputs, cfg);

        return new FinalResultRowV2
        {
            TaskId = taskId,
            AiModel = model,
            Correctness = s.CorrectnessScore,
            EfficiencyScore = s.EfficiencyScore,
            QualityScore = s.QualityScore,
            CompositeScore = s.CompositeScore,
            ExecutionTimeNs = medianTimeNs,
            MemoryBytes = allocatedBytes,
            Complexity = report.CyclomaticComplexity,
            CognitiveComplexity = report.CognitiveComplexity,
            NestingDepth = report.MaxNestingDepth,
            NamingViolations = report.NamingViolations,
            ProfessionalismScore = report.ProfessionalismScore,
            Excluded = s.Excluded,
            ExclusionReason = s.ExclusionReason ?? ""
        };
    }

    // -----------------------------------------------------------------
    //  REVISED Excel writer: emits the three COMPASS axes + composite,
    //  cognitive complexity, professionalism, and the Excluded flag.
    // -----------------------------------------------------------------
    public static void SaveToExcelV2(System.Collections.Generic.List<FinalResultRowV2> data, string path)
    {
        using var workbook = new ClosedXML.Excel.XLWorkbook();
        var ws = workbook.Worksheets.Add("Results");

        string[] headers =
        {
            "Task ID", "AI Model",
            "Correctness (%)", "Efficiency Score", "Quality Score", "Composite Score",
            "Time (ns)", "Memory (Bytes)",
            "Complexity", "Cognitive Cx", "Nesting", "Naming Violations", "Professionalism",
            "Excluded", "Exclusion Reason"
        };
        for (int c = 0; c < headers.Length; c++)
            ws.Cell(1, c + 1).Value = headers[c];

        var header = ws.Range(1, 1, 1, headers.Length);
        header.Style.Font.Bold = true;
        header.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;

        int r = 2;
        foreach (var row in data)
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
            r++;
        }

        ws.Columns().AdjustToContents();
        workbook.SaveAs(path);
    }
}

/*  ------------------------------------------------------------------
    WIRING INSTRUCTIONS (where to change the existing Program.Main):

    1) Mark the existing `public class Program` as `public partial class
       Program` so these members merge in. (One word change.)

    2) Replace the Phase-1+Phase-3 result construction. The old loop did:

           row.QualityScore = qualityReport.FinalScore;   // BROKEN

       Instead, collect three dictionaries keyed by (taskId, model):
           - correctness[(t,m)]  = row.Correctness   (already computed)
           - report[(t,m)]       = evaluator.Evaluate(aiCode, emptySpec)
           - timeNs[(t,m)]       = report.ResultStatistics.Mean   (Phase 3)
           - memBytes[(t,m)]     = GcStats allocated bytes         (Phase 3)

       THEN, after Phase 3 mapping, build final rows:

           var cfg = ScoringConfig.Default;       // equal weights, explicit
           var finalV2 = new List<FinalResultRowV2>();
           foreach (var key in report.Keys)
           {
               finalV2.Add(BuildScoredRow(
                   key.taskId, key.model,
                   report[key],
                   correctness.GetValueOrDefault(key, 0),
                   timeNs.GetValueOrDefault(key, 0),
                   memBytes.GetValueOrDefault(key, 0),
                   cfg));
           }
           SaveToExcelV2(finalV2, excelPath);

       // For the RQ3 robustness check (quality WITHOUT correctness):
       //   var cfgRobust = ScoringConfig.QualityOnly;
       //   ... rebuild rows with cfgRobust, save to a second sheet/file.

    3) MULTI-RUN (Reviewer 1, Pass@1 determinism):
       Wrap Phases 2-3 in `for (int run = 0; run < K; run++)` (e.g. K=5),
       collect one ScoreResult per run per (task,model), then call
       ScoringEngine.Aggregate(taskId, model, runsForThatPair) to get
       mean / median / SD for each axis. Report the SDs in the paper as the
       empirical determinism evidence (replaces the temperature=0 assumption).
    ------------------------------------------------------------------ */
    