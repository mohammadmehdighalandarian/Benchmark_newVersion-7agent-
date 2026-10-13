"""Build data/correctness_n560.csv: correctness with unexecuted assertions
counted as failed.

Each generated test method runs all assertions of a task inside one
try/catch, so an exception thrown by a solution stops the remaining
assertions. The pipeline originally scored only the assertions that had
run. tools/rerun_tests re-executes every test method from the compiled
pipeline and records how many assertions passed and failed; the number of
assertions per task is counted here from the test sources (one
TestUtils.Check call per assertion). Correctness is passed / assertions.

csharp_43 Llama is not re-run (about 20 s and 8.6 GB of memory before an
overflow ends its loop); its stored result, 0 of 5 assertions passed, is
used. The corrected pipeline (pipeline/ProgramMain.cs) gives the same
correctness for all 560 solutions.

Output columns: task, model, n_assertions, passed, failed, executed,
correctness_pipeline (stored value), correctness (used in the paper).

Usage: python3 analysis/build_correctness.py [rerun_scores.tsv] [evaluation_results.txt]
"""
import glob, os, re, sys
import pandas as pd

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
RERUN = sys.argv[1] if len(sys.argv) > 1 else os.path.join(ROOT, 'tools', 'rerun_tests', 'rerun_scores.tsv')
EVAL = sys.argv[2] if len(sys.argv) > 2 else os.path.join(ROOT, 'data', 'results', 'evaluation_results.txt')
TESTS = os.path.join(ROOT, 'pipeline', 'Solution', 'Tests')
OUT = os.path.join(ROOT, 'data', 'correctness_n560.csv')

# assertions per test method, from the test sources
n = []
for path in glob.glob(os.path.join(TESTS, 'Tests_Task_*.cs')):
    task = re.search(r'Tests_Task_(csharp_\d+)\.cs$', path).group(1)
    src = open(path, encoding='utf-8-sig').read()
    for model, body in re.findall(r'public void Run_(\w+)\(\)(.*?)(?=public void Run_|\Z)', src, re.S):
        n.append(dict(task=task, model=model, n_assertions=body.count('TestUtils.Check(')))
n = pd.DataFrame(n)

rr = pd.read_csv(RERUN, sep='\t')
ev = pd.read_csv(EVAL, sep='\t').rename(columns={'Task ID': 'task', 'AI Model': 'model',
                                                 'Correctness (%)': 'correctness_pipeline'})
d = n.merge(rr, on=['task', 'model'], how='inner', validate='one_to_one').merge(
    ev[['task', 'model', 'correctness_pipeline']], on=['task', 'model'], validate='one_to_one')
assert len(d) == 560, len(d)

skipped = d.status == 'skipped'
d['passed'] = pd.to_numeric(d.passed, errors='coerce')
d['failed'] = pd.to_numeric(d.failed, errors='coerce')
# a pair that was not re-run keeps its stored result, taken as complete
d.loc[skipped, 'passed'] = (d.loc[skipped, 'correctness_pipeline'] / 100 * d.loc[skipped, 'n_assertions']).round()
d.loc[skipped, 'failed'] = d.loc[skipped, 'n_assertions'] - d.loc[skipped, 'passed']
d['passed'] = d.passed.astype(int); d['failed'] = d.failed.astype(int)
d['executed'] = d.passed + d.failed
assert (d.executed <= d.n_assertions).all()

# the re-run reproduces every stored score under the old definition
old = (100 * d.passed / d.executed).where(d.executed > 0, 0.0)
assert ((old - d.correctness_pipeline).abs() < 1e-6).all(), 'stored scores are not reproduced'

d['correctness'] = 100 * d.passed / d.n_assertions
out = d[['task', 'model', 'n_assertions', 'passed', 'failed', 'executed', 'correctness_pipeline', 'correctness']]
out = out.set_index(['task', 'model']).reindex(
    pd.MultiIndex.from_frame(ev[['task', 'model']])).reset_index()   # row order of the results file
out.to_csv(OUT, index=False)
stopped = out[out.executed < out.n_assertions]
print(f'{len(out)} solutions, {out.n_assertions.groupby(out.task).first().sum()} assertions per model; '
      f'{len(stopped)} tests stopped by an exception; '
      f'{int(((out.correctness - out.correctness_pipeline).abs() > 1e-6).sum())} scores change')
