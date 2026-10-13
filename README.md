# Quality of LLM-generated C# code: replication package

This repository contains the evaluation framework, the generated code, the raw
measurements and the analysis scripts for the paper

> *Beyond Functional Correctness: An Empirical Study of the Quality of LLM-Generated C# Code*
> (submitted to Software Quality Journal).

The paper extends the workshop paper *Benchmarking the Titans: A Multi-Dimensional
Empirical Evaluation of LLM Code Generation Quality in the .NET Ecosystem* (LLM4SE 2026,
[arXiv:2608.22529](https://arxiv.org/abs/2608.22529)).

Seven LLMs (GPT, Gemini, Claude, Grok, DeepSeek, Llama and Mistral) solved 80 C# tasks
derived from HumanEval, which gives 560 solutions. Each solution was measured in four
ways: unit tests for functional correctness, Roslyn metrics for structural quality,
BenchmarkDotNet for execution time and memory allocation, and SonarQube for
static-analysis issues. The exact model versions are listed in the paper (Section 3.3).

## Layout

```
pipeline/                the C# evaluation framework (.NET 8, project test.csproj)
  Phase1_Prompts/        the prompts of each task (solution prompt, benchmark prompt, input)
  Solution/Solvers/      the 560 generated solutions: one file per task, one namespace per model
  Solution/Tests/        the C# versions of the HumanEval assertions (677 per model)
  Solution/Benchmarks/   the BenchmarkDotNet harnesses (79 tasks; csharp_11 has none)
data/
  results/               the pipeline's results file and workbook (see below)
  correctness_n560.csv   correctness, unexecuted assertions counted as failed
  structural_n560.csv    cyclomatic complexity, re-measured nesting depth and cognitive complexity
  runtime_n560.csv       execution time and allocation per solution
  task_mapping.csv       C# task -> HumanEval problem, entry point and signature
  external/              HumanEval (MIT licence), used only for Table 1
measurements/
  benchmarkdotnet/       BenchmarkDotNet reports (results/) and run logs (logs/)
  sonarqube/raw/         the SonarQube Web API export, one project per model
  sonarqube/*.csv        issues and file measures built from the export
analysis/                Python scripts that produce every number, table and figure in the paper
figures/                 the figures, as written by analysis/figures_n560.py
tools/remeasure/         Roslyn tool that re-measures the structural metrics
tools/rerun_tests/       re-runs the compiled test methods
docs/                    pipeline description, known issues, and the audit of August 2026
```

`data/README.md` describes the columns of every data file.

## Reproducing the results in the paper

The analysis needs Python 3.13 and the packages in `analysis/requirements.txt`.

```bash
pip install -r analysis/requirements.txt

# Optional: rebuild the derived tables from the raw outputs (they are already in the repository)
python analysis/build_correctness.py    # tools/rerun_tests output + test sources -> data/correctness_n560.csv
python analysis/build_structural.py     # tools/remeasure output -> data/structural_n560.csv
python analysis/build_runtime.py        # BenchmarkDotNet reports -> data/runtime_n560.csv
python analysis/build_sonar_tables.py   # SonarQube export -> measurements/sonarqube/*.csv

# Every number in the paper, the figures and Table 1
python analysis/analysis_n560.py > analysis/results_n560.txt
python analysis/figures_n560.py
python analysis/task_selection.py
```

`analysis/results_n560.txt` is organised by research question:

| Paper | Section of `results_n560.txt` |
|---|---|
| Section 3.7 (data preparation and validation) | DATASET |
| RQ1, functional correctness | RQ1 CORRECTNESS |
| RQ2, structural quality | RQ2 STRUCTURAL QUALITY |
| RQ3, SonarQube | RQ3 SONARQUBE, RQ3b IN-PROCESS ANALYZER PASS |
| RQ4, runtime | RQ4 RUNTIME |
| RQ5, correctness and structure | RQ5 CORRECTNESS vs STRUCTURAL QUALITY, AGGREGATION |
| Table 1 (task selection) | `analysis/task_selection.txt` |

## The results file and the corrections

`data/results/evaluation_results.txt` is the per-solution record written by the pipeline
in June 2026. The analysis reads it and applies the corrections described in Section 3.7
of the paper:

1. **Correctness.** An exception thrown by a solution stopped the remaining assertions
   of its test, and the pipeline scored only the assertions that had run. Unexecuted
   assertions now count as failed (`data/correctness_n560.csv`). Four scores change.
2. **Nesting depth and cognitive complexity.** The original analyser counted every
   `else if` as one more nesting level. Both metrics were re-measured from the stored
   solutions (`data/structural_n560.csv`): nesting depth changes for 32 solutions on 12
   tasks and cognitive complexity for 151 solutions. Cyclomatic complexity is unchanged.
3. **Compilation.** The original compile check marked 104 solutions as not compiling,
   but all 560 compile in the project in which their tests ran. These rows have
   `Excluded = TRUE` and scores of 0 in the results file; the analysis uses all 560.
4. **Runtime.** The results file has times for 411 solutions only. Time and allocation
   were rebuilt from the BenchmarkDotNet reports (`data/runtime_n560.csv`, 512
   solutions on 74 tasks).

The `Quality Score` and `Composite Score` columns of the results file follow the old
definitions, which included a naming term. The paper does not use them: the analysis
recomputes the structural score `Q = 50 * (s_Cx + s_Nest)` from the corrected metrics.

`data/results/evaluation_results.xlsx` is the workbook of a later, partial run of the
updated pipeline (committed on 9 September 2026). It has the corrected compile check (no
solution is excluded) and the corrected cognitive complexity, but nesting depth still
uses the old rule, and the benchmark phase ran only for `csharp_0` (column
`Benchmark Status`), so its time, efficiency and composite columns are not usable. The
analysis does not read it.

## Running the pipeline

The pipeline is a .NET 8 console application. It needs the .NET 8 SDK and access to
NuGet. From `pipeline/`:

```bash
dotnet build -c Release
dotnet run -c Release -- correctness     # tests, Roslyn metrics, in-process SonarAnalyzer pass
dotnet run -c Release -- benchmark       # BenchmarkDotNet, resumable; takes several hours
dotnet run -c Release -- export-tsv      # writes the TSV next to the workbook
```

The outputs are written next to the executable (`pipeline/bin/Release/net8.0/`).
`docs/EVALUATION_FLOW.txt` describes all commands, including prompt preparation and
generation. With the current code, the `correctness` command reproduces the corrected
correctness, the cyclomatic complexity, the re-measured nesting depth and cognitive
complexity, and Q of all 560 solutions. Execution times depend on the machine.

The solutions in `pipeline/Solution/Solvers/` were generated in June 2026 at temperature
0. The raw API responses were not stored, and the models change over time, so
generating them again will not give the same code. The `generate` command, which reads
pinned model identifiers from a configuration file and stores every raw response, was
added after the study and was not used for this corpus.

## Measurement environment

The measurements in the paper were taken on Windows 11 (build 10.0.26200) with an Intel
Core i5-8250U (4 cores, 8 threads), .NET 8.0.11 (SDK 9.0.100) and BenchmarkDotNet
0.15.8. SonarQube Community Build 26.9.0.129388 analysed the solutions with the default
Sonar way profile for C# (326 rules) in September 2026.

## Known issues

`docs/KNOWN_ISSUES.md` lists the defects found in the pipeline, which of them are fixed,
and how each one affects the reported numbers.

## Citation

Until the journal paper is published, please cite the workshop paper (arXiv:2608.22529).
`CITATION.cff` gives the authors of this repository.

## License

The code, the scripts and the data produced in this study are released under the MIT
License (`LICENSE`). Third-party material keeps its own terms: the tasks are derived from
HumanEval (MIT, `data/external/HumanEval_LICENSE.txt`), the rule descriptions in
`measurements/sonarqube/raw/rules__*.json` come from SonarSource, and the generated
solutions were produced with the models' public APIs.
