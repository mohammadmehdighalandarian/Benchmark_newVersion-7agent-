# Re-measurement of the structural metrics

`Program.cs` parses the stored solutions (`pipeline/Solution/Solvers/Solvers_Task_csharp_*.cs`)
with Roslyn and writes one row per solution:

- `cx`: cyclomatic complexity, exactly as in the pipeline (1 + `if`, `while`, `for`,
  `foreach`, `case`, `catch`, `&&`, `||`, `??`).
- `nest_orig`, `nest_flat`: nesting depth of `if`/`for`/`foreach`/`while`/`do` statements.
  `orig` counts an `else if` as one more level (the analyser that produced
  `data/results/evaluation_results.txt`); `flat` lets an `else if` continue its chain
  (used in the paper).
- `cog_orig`, `cog_flat`: cognitive complexity. `flat` follows Campbell's specification
  (`else if` and `else` add one without a nesting penalty; a run of identical logical
  operators adds one) and is used in the paper. `cog_orig` is an approximation of the
  original analyser and is not used.
- `doc`, `nullcheck`, `linq`: the three professionalism signals of the pipeline.

With the original rules the tool reproduces the stored cyclomatic complexity, nesting
depth and professionalism indicator of all 560 solutions. `analysis/build_structural.py`
checks this and writes `data/structural_n560.csv` from `remeasure.tsv`.

The corrected analyser in `pipeline/CodeEvaluator.cs` gives the same cyclomatic
complexity, nesting depth and cognitive complexity as the `flat` columns for all 560
solutions.

## Run

From this folder:

    dotnet run -c Release -- ../../pipeline/Solution/Solvers > remeasure.tsv

Without access to NuGet, point `RoslynDir` at a folder that contains
`Microsoft.CodeAnalysis.dll`, `Microsoft.CodeAnalysis.CSharp.dll`,
`System.Collections.Immutable.dll` and `System.Reflection.Metadata.dll`, for example the
pipeline's build output:

    dotnet build -c Release -p:RoslynDir=../../pipeline/bin/Release/net8.0
    dotnet bin/Release/net8.0/remeasure.dll ../../pipeline/Solution/Solvers > remeasure.tsv
