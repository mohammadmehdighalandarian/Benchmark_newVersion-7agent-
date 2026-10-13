# Known issues

Defects found by auditing the pipeline against the claims made about it (see also
`VERIFICATION_REPORT_2026-08.txt`). The paper treats measurement validity as a result in
its own right (Sections 3.7 and 5.4), and anyone who reuses this framework should know
where it misled us. Each entry says whether it is fixed in the code and how it affects the
reported numbers.

## Fixed, with corrected data in the repository

**Unexecuted assertions were not counted.** All assertions of a task run inside one
try/catch in the generated test method, so an exception thrown by a solution stopped the
remaining assertions, and the pipeline scored only the assertions that had run. In nine
solutions an exception stopped the test; four scores were overstated (csharp_5 Mistral
100% instead of 20%, csharp_15 Grok 66.7% instead of 40%, csharp_64 Llama 100% instead of
50%, csharp_70 Mistral 100% instead of 57.1%). *Fixed* in `ProgramMain.RunAndScoreTests`,
which reads the expected number of assertions from the test sources. The paper uses
`data/correctness_n560.csv`.

**Nesting depth counted `else if` as a further level.** A chain of n `else if` branches
reported a depth of n + 1 (13 or 14 on csharp_34, where the real depth is 2). *Fixed* in
`CodeEvaluator.GetNestingDepth`. Nesting depth changes for 32 solutions on 12 tasks; the
paper uses the re-measured values in `data/structural_n560.csv`.

**Cognitive complexity did not follow the specification.** `else if` was charged a
growing nesting penalty and every logical operator counted separately, so csharp_34
scored 91 or 105 where SonarQube reports 15. *Fixed* (flat `else if` and `else`, one
increment per run of identical operators). The value changes for 151 solutions; the
corrected values agree with SonarQube's (r = 0.996, 96.6% identical).

**The compile check used a reduced reference set.** Each solution was recompiled in
isolation against seven hand-picked references, so 104 solutions were recorded as not
compiling, although all of them compile in the project where their tests ran. *Fixed*:
the check now uses the references of the running process and the file-level `using`
directives. In the results file of June 2026 these 104 rows are still flagged
`Excluded`; the paper uses all 560 solutions.

**Allocated bytes per operation used the wrong divisor.** The figure was systematically
too low. *Fixed*: the pipeline now takes BenchmarkDotNet's own per-operation value. The
paper uses the `Allocated` column of the BenchmarkDotNet reports (`data/runtime_n560.csv`).

**The results file had times for only 411 solutions.** The benchmark phase did not write
times for rows flagged as not compiling. The paper rebuilds time and allocation from the
BenchmarkDotNet reports: 512 solutions on 74 tasks.

## Fixed, no effect on the reported numbers

- **Naming in the quality score.** The naming check counts mostly identifiers that the
  prompt fixes (the entry-point name and its parameters). The scores no longer give it
  any weight (`ScoringConfig.W_Style = 0`), so the pipeline's quality score is
  `Q = 50 * (s_Cx + s_Nest)` as in the paper. The check itself is unchanged and still
  written to the results file.
- **Failed benchmark runs were checkpointed as complete**, so a resumed run skipped them.
  Failures are now written to `evaluation_results.benchmark-failures.tsv` and are not
  checkpointed.
- **Silent failures in test generation.** Extraction and instrumentation problems now
  raise instead of writing a test without assertions. The `audit-assertions` command
  confirms that the shipped tests contain all 677 assertions per model.
- **Analyser types that failed to load.** `Microsoft.CodeAnalysis.CSharp.Workspaces` is
  now referenced, so all SonarAnalyzer types load. In June 2026, 447 analyser types
  covering 463 rules ran; the rules raised on the 456 analysed solutions are the same in
  the later run.
- **Manual steps.** The TSV export, the prompt preparation and the recording of the
  executed benchmark sizes are now commands of the pipeline.

## Not changed (documented in the paper)

- **No execution timeout in the functional tests.** csharp_43 Llama runs for about
  20 seconds and allocates about 8.6 GB before an integer overflow ends its loop.
- **The null check is a text search** (`== null`, `is null`, `ArgumentNullException`,
  `?.`), which also matches comments and strings. The professionalism indicator is used
  only in the sensitivity analysis of RQ5.
- **In-process analyser ratings are local formulas.** The A to E grades and remediation
  minutes of the in-process SonarAnalyzer pass are not SonarQube outputs. The paper's
  SonarQube results come from the platform export in `measurements/sonarqube/`.
- **Timer resolution.** 22 solutions on five tasks were measured below 1 ns, two of them
  at 0 ns (paper Section 3.7). RQ4 reports how the results change without these tasks.
- **Missing runtime data.** 48 of the 560 solutions have no time: csharp_11 has no
  harness, one build failed because a file was locked, four tasks exceeded
  BenchmarkDotNet's two-minute build timeout, and six solutions threw on the benchmark
  inputs.

## Gaps in reproducibility

- **Generation.** The solutions were generated in June 2026 at temperature 0, outside
  this code. The raw API responses were not stored, and four of the seven models were
  recorded only by their display name. The `generate` command was added later; it sets
  the temperature explicitly, refuses moving model aliases and stores every raw
  response.
- **Task workbook.** The seven-model task workbook is not in the repository, and
  `DatasetPreparation.DefaultWorkbookPath` points to the first author's machine. The
  prompts that were sent are in `pipeline/Phase1_Prompts/`, and the tests in
  `pipeline/Solution/Tests/`.
- **Unused code.** `CodeGenerator.cs` (an earlier four-model generator),
  `SolutionExport`'s alternative output shape, `Model/AiScore.cs` and
  `Program.SaveToExcelV2` are not called by the pipeline.
