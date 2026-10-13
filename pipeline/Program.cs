// =====================================================================
//  Program.cs  -  result row and scoring helper
// ---------------------------------------------------------------------
//  The second part of the partial Program class (the driver is in
//  ProgramMain.cs). It defines the per-solution result row and
//  BuildScoredRow, which turns the measured values into the scores
//  through ScoringEngine.Compute:
//
//    (A) Correctness comes from the reflection tests, the static metrics
//        from CodeEvaluator, and time and allocation from BenchmarkDotNet,
//        so the composite no longer averages in two forced zeros and
//        efficiency no longer comes from a Stopwatch loop.
//    (B) Rows that do not compile are flagged as Excluded instead of being
//        scored 0.
//
//  SaveToExcelV2 is an older writer that the pipeline no longer calls;
//  the workbook is written by InitExcelFile and AppendRowsToExcel in
//  ProgramMain.cs.
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

        // Compiler diagnostics from the isolated compile. Previously
        // collected and then discarded, which made a compile failure
        // impossible to diagnose after the fact.
        public int    CompileErrorCount   { get; set; }
        public string CompileDiagnostics  { get; set; } = "";

        // SonarAnalyzer metrics - kept separate from the Roslyn metrics so
        // both measurement sources are in the paper. The effort minutes and
        // the A-E grades are local formulas, not SonarQube outputs.
        public string SA_ScanStatus            { get; set; } = "";
        public int    SA_TotalIssues           { get; set; }
        public int    SA_Errors                { get; set; }
        public int    SA_Warnings              { get; set; }
        public int    SA_Info                  { get; set; }
        public int    SA_AnalyzerCrashes       { get; set; }
        public double SA_RemediationMinutes    { get; set; }
        public string SA_MaintainabilityGrade  { get; set; } = "";
        public string SA_ReliabilityGrade      { get; set; } = "";
        public string SA_TriggeredRules        { get; set; } = "";
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
            ExclusionReason = s.ExclusionReason ?? "",
            CompileErrorCount = report.CompileErrorCount,
            CompileDiagnostics = report.CompileDiagnostics
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
