# Re-running the functional tests

`Program.cs` loads the compiled pipeline (`test.dll`), runs every generated test method
(`Tests.<task>.TestRunner.Run_<model>`) and records how many assertions passed and
failed. A test method that does not finish within 60 seconds is reported as `timeout`.
`csharp_43` Llama is skipped: its solution loops until an integer overflows, which takes
about 20 seconds and 8.6 GB of memory.

The output, `rerun_scores.tsv`, has one row per solution (`task`, `model`, `passed`,
`failed`, `status`). It reproduces the stored correctness of the other 559 solutions
exactly. `analysis/build_correctness.py` combines it with the number of assertions per
task to build `data/correctness_n560.csv`, in which assertions that did not run because
a solution threw are counted as failed.

## Run

Build the pipeline first (`dotnet build -c Release` in `pipeline/`), then from this folder:

    dotnet run -c Release -- ../../pipeline/bin/Release/net8.0

The tool writes `rerun_scores.tsv` to the current folder.
