// =====================================================================
//  TsvExport.cs  -  PHASE 4 export
// ---------------------------------------------------------------------
//  The pipeline wrote .xlsx only; the TSV analysed in the paper was
//  produced by a manual export from Excel. This writes the TSV directly.
//
//  This is AUTOMATION OF A MANUAL STEP. It does not change any reported
//  number. FromWorkbook reads the workbook the pipeline already produced
//  and serialises it, so its output is the shipped result set, not a
//  recomputation of it.
//
//  PRECISION. Excel's own export rounds to the displayed number of
//  digits. This writes doubles with the round-trip format ("R"), which is
//  the shortest string that parses back to the identical double, so no
//  precision is lost between the workbook and the TSV.
//
//  ESCAPING. TSV has no quoting convention, so any tab, carriage return,
//  newline or backslash inside a value is escaped (\t, \r, \n, \\).
//  Without this a compiler diagnostic in an exclusion reason would break
//  the column alignment of the whole file.
// =====================================================================

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using ClosedXML.Excel;

namespace EvaluatedCodeGeneration
{
    public static class TsvExport
    {
        /// <summary>
        /// Serialises an existing results workbook to TSV. This is the
        /// automated equivalent of the manual Excel export: it reproduces
        /// the shipped numbers rather than recomputing them.
        /// </summary>
        public static int FromWorkbook(string xlsxPath, string tsvPath, string sheetName = "Results")
        {
            if (!File.Exists(xlsxPath))
                throw new FileNotFoundException("Results workbook not found.", xlsxPath);

            using var workbook = new XLWorkbook(xlsxPath);
            var ws = workbook.Worksheets.Contains(sheetName)
                ? workbook.Worksheet(sheetName)
                : workbook.Worksheet(1);

            int lastRow = ws.LastRowUsed()?.RowNumber() ?? 0;
            int lastCol = ws.LastColumnUsed()?.ColumnNumber() ?? 0;

            var sb = new StringBuilder();
            for (int r = 1; r <= lastRow; r++)
            {
                for (int c = 1; c <= lastCol; c++)
                {
                    if (c > 1) sb.Append('\t');
                    sb.Append(Format(ws.Cell(r, c)));
                }
                sb.Append('\n');
            }

            File.WriteAllText(tsvPath, sb.ToString(), new UTF8Encoding(false));

            int dataRows = Math.Max(0, lastRow - 1);
            Console.WriteLine($"  [TSV] {dataRows} data row(s) x {lastCol} column(s) -> {tsvPath}");
            return dataRows;
        }

        /// <summary>
        /// Writes result rows straight to TSV, for runs that do not need to
        /// go through the workbook at all.
        /// </summary>
        public static void FromRows(IReadOnlyList<Program.FinalResultRowV2> rows, string tsvPath)
        {
            string[] headers =
            {
                "Task ID", "AI Model",
                "Correctness (%)", "Efficiency Score", "Quality Score", "Composite Score",
                "Time (ns)", "Memory (Bytes)",
                "Complexity", "Cognitive Cx", "Nesting", "Naming Violations", "Professionalism",
                "Excluded", "Exclusion Reason",
                "Compile Errors", "Compile Diagnostics",
                "SA Scan Status", "SA Total Issues", "SA Errors", "SA Warnings", "SA Info",
                "SA Analyzer Crashes", "SA Remediation Effort (min, local)",
                "SA Maintainability Grade (local)", "SA Reliability Grade (local)", "SA Rules",
                "Benchmark Sizes", "Benchmark Status"
            };

            var sb = new StringBuilder();
            sb.Append(string.Join("\t", headers)).Append('\n');

            foreach (var row in rows)
            {
                sb.Append(Escape(row.TaskId)).Append('\t')
                  .Append(Escape(row.AiModel)).Append('\t')
                  .Append(Num(row.Correctness)).Append('\t')
                  .Append(Num(row.EfficiencyScore)).Append('\t')
                  .Append(Num(row.QualityScore)).Append('\t')
                  .Append(Num(row.CompositeScore)).Append('\t')
                  .Append(Num(row.ExecutionTimeNs)).Append('\t')
                  .Append(Num(row.MemoryBytes)).Append('\t')
                  .Append(row.Complexity).Append('\t')
                  .Append(row.CognitiveComplexity).Append('\t')
                  .Append(row.NestingDepth).Append('\t')
                  .Append(row.NamingViolations).Append('\t')
                  .Append(row.ProfessionalismScore).Append('\t')
                  .Append(row.Excluded ? "TRUE" : "FALSE").Append('\t')
                  .Append(Escape(row.ExclusionReason)).Append('\t')
                  .Append(row.CompileErrorCount).Append('\t')
                  .Append(Escape(row.CompileDiagnostics)).Append('\t')
                  .Append(Escape(row.SA_ScanStatus)).Append('\t')
                  .Append(row.SA_TotalIssues).Append('\t')
                  .Append(row.SA_Errors).Append('\t')
                  .Append(row.SA_Warnings).Append('\t')
                  .Append(row.SA_Info).Append('\t')
                  .Append(row.SA_AnalyzerCrashes).Append('\t')
                  .Append(Num(row.SA_RemediationMinutes)).Append('\t')
                  .Append(Escape(row.SA_MaintainabilityGrade)).Append('\t')
                  .Append(Escape(row.SA_ReliabilityGrade)).Append('\t')
                  .Append(Escape(row.SA_TriggeredRules)).Append('\t')
                  .Append("").Append('\t')          // Benchmark Sizes: phase 3 fills this
                  .Append("not-run").Append('\n');  // Benchmark Status
            }

            File.WriteAllText(tsvPath, sb.ToString(), new UTF8Encoding(false));
            Console.WriteLine($"  [TSV] {rows.Count} data row(s) -> {tsvPath}");
        }

        // -----------------------------------------------------------------

        private static string Format(IXLCell cell)
        {
            var v = cell.Value;
            if (v.IsBlank) return "";
            if (v.IsNumber) return Num(v.GetNumber());
            if (v.IsBoolean) return v.GetBoolean() ? "TRUE" : "FALSE";
            return Escape(cell.GetString());
        }

        // "R" is the round-trip format: the shortest string that parses back
        // to the identical double. Integral values print without a decimal
        // point, which keeps counts readable.
        private static string Num(double d) => d.ToString("R", CultureInfo.InvariantCulture);

        private static string Escape(string? s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s.Replace("\\", "\\\\")
                    .Replace("\t", "\\t")
                    .Replace("\r", "\\r")
                    .Replace("\n", "\\n");
        }
    }
}
