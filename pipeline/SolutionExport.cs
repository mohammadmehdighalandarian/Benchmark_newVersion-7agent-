using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ClosedXML.Excel;

public class SolutionExport
{
    public string TaskId { get; set; }
    public string Benchmark { get; set; }
    public string Test { get; set; }
    public string ChatGpt { get; set; }
    public string Gemini { get; set; }
    public string Grok { get; set; }
    public string Claude { get; set; }
    public string Mistral { get; set; }
    public string DeepSeek { get; set; }
    public string Llama { get; set; }
    public string EntryPoint { get; set; }

    public static List<SolutionExport> ReadSolutions(string filePath)
    {
        var solutions = new List<SolutionExport>();
        using var workbook = new XLWorkbook(filePath);
        var ws = workbook.Worksheet(1);

        foreach (var row in ws.RowsUsed().Skip(1))
        {
            solutions.Add(new SolutionExport
            {
                TaskId    = row.Cell("A").GetString(),
                ChatGpt   = row.Cell("K").GetString(),
                Gemini    = row.Cell("L").GetString(),
                Grok      = row.Cell("M").GetString(),
                Claude    = row.Cell("N").GetString(),
                Mistral   = row.Cell("O").GetString(),
                DeepSeek  = row.Cell("P").GetString(),
                Llama     = row.Cell("Q").GetString(),
                Benchmark = row.Cell("T").GetString(),
                Test      = row.Cell("C").GetString(),
                EntryPoint = row.Cell("F").GetString(),
            });
        }
        return solutions;
    }

    // -------------------------------------------------------------------
    //  The generator that used to live here (ExportSolutions and its three
    //  Write*File helpers) has been REMOVED.
    //
    //  It was a second, never-invoked generator that emitted a different
    //  shape from the one that produced the shipped corpus: it wrapped each
    //  answer in its own `public class Solver` and expected an {NS}
    //  placeholder in the test column. SolutionWriter is what actually
    //  built the 80 solver, test and benchmark files. Keeping both meant
    //  the repository contained two contradictory answers to "how is the
    //  corpus assembled", and the wrong one could be wired up by mistake.
    //
    //  This class is now only what it is used for: the DTO and the
    //  workbook reader above.
    // -------------------------------------------------------------------
}
