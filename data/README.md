# Data files

All tables have one row per solution, identified by `task` (`csharp_0` to `csharp_79`)
and `model` (GPT, Gemini, Claude, Grok, Mistral, DeepSeek, Llama), unless noted.

## results/evaluation_results.txt

Tab-separated record written by the pipeline in June 2026 (560 rows, full numeric
precision). The analysis reads it together with the corrected tables below.

| Column | Meaning |
|---|---|
| Task ID, AI Model | task and model |
| Correctness (%) | passed / executed assertions, as stored (see `correctness_n560.csv`) |
| Efficiency Score | 100 * 10^4 / (10^4 + t), t = time in ns; 0 without a time |
| Quality Score, Composite Score | old definitions with a naming term; not used in the paper |
| Time (ns), Memory (Bytes) | stored benchmark values (411 rows); see `runtime_n560.csv` |
| Complexity | cyclomatic complexity |
| Cognitive Cx, Nesting | stored values of the original analyser; see `structural_n560.csv` |
| Naming Violations | naming check; not used in the paper |
| Professionalism | XML documentation comment + null check + LINQ use (0 to 3) |
| Excluded, Exclusion Reason | TRUE for the 104 rows that the old compile check rejected |
| SQ Total Issues ... SQ Rules | the in-process SonarAnalyzer pass (456 rows). Despite the prefix, these are not SonarQube results: the debt minutes and the A to E ratings are local formulas. The SonarQube results are in `measurements/sonarqube/`. |

## results/evaluation_results.xlsx

Workbook of a later, partial run of the updated pipeline (29 columns). The in-process
analyser columns are prefixed `SA` and there are columns for compile errors and for the
executed benchmark sizes. The benchmark phase ran only for `csharp_0`, so for the other
tasks time and efficiency are 0 and the composite has no efficiency term. Not used in
the paper.

## correctness_n560.csv

Built by `analysis/build_correctness.py`.

| Column | Meaning |
|---|---|
| n_assertions | assertions of the task (TestUtils.Check calls in its test method) |
| passed, failed, executed | from the re-run of the test methods (`tools/rerun_tests`); executed = passed + failed |
| correctness_pipeline | stored correctness: passed / executed |
| correctness | passed / n_assertions; assertions not executed after an exception count as failed. Used in the paper. |

## structural_n560.csv

Built by `analysis/build_structural.py` from `tools/remeasure/remeasure.tsv`.

| Column | Meaning |
|---|---|
| cx | cyclomatic complexity (identical to the stored value) |
| nest_stored, nest | nesting depth: stored / corrected (an `else if` continues its chain). `nest` is used in the paper. |
| cog_stored, cog | cognitive complexity: stored / corrected (Campbell's rules). `cog` is used in the paper. |
| doc, nullcheck, linq | the three professionalism signals |

## runtime_n560.csv

Built by `analysis/build_runtime.py` from the BenchmarkDotNet reports in
`measurements/benchmarkdotnet/results/` (512 solutions on 74 tasks).

| Column | Meaning |
|---|---|
| t10, t100 | median time per operation in ns at N = 10 and N = 100 (the mean where a report has no median column) |
| t_source | `median` or `mean` |
| time_ns | mean of t10 and t100 |
| alloc10, alloc100, alloc_B | bytes allocated per operation at each size, and their mean |

## task_mapping.csv

One row per task: the HumanEval problem it comes from, the C# entry point, the return
type and the parameters.

## external/

`HumanEval.jsonl.gz` is the original HumanEval dataset (MIT licence, see
`HumanEval_LICENSE.txt`). It is used only by `analysis/task_selection.py` to compare the
80 tasks with the other 84 HumanEval problems (Table 1 of the paper).

## SonarQube tables (measurements/sonarqube/)

Built by `analysis/build_sonar_tables.py` from the raw export in `raw/`.

- `sonar_issues.csv`: one row per issue with `rule` (without the `csharpsquid:` prefix),
  `severity`, `type` and `effort` in minutes (752 issues).
- `sonar_file_measures.csv`: one row per solution file with SonarQube's cyclomatic
  complexity (`sq_complexity`), cognitive complexity (`sq_cognitive`; empty means 0,
  because SonarQube omits best values), lines of code (`sq_ncloc`), technical debt in
  minutes (`sq_debt`) and maintainability rating (`sq_rating`, 1 = A).
