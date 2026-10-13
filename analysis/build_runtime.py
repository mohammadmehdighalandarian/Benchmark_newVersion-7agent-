"""Build per-solution runtime and allocation records from the BenchmarkDotNet
report CSVs (one per task). Time per solution = mean of the two per-size
medians (N = 10 and N = 100), as in the pipeline. Where a report omits the
Median column (BenchmarkDotNet hides it when it does not differ from the
mean), the Mean is used. Allocation is BenchmarkDotNet's per-operation
'Allocated' value."""
import glob, os, re, sys
import pandas as pd, numpy as np

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
SRC = sys.argv[1] if len(sys.argv) > 1 else os.path.join(ROOT, 'measurements', 'benchmarkdotnet', 'results')
OUT = sys.argv[2] if len(sys.argv) > 2 else os.path.join(ROOT, 'data', 'runtime_n560.csv')

def ns(v):
    if v is None or (isinstance(v, float) and np.isnan(v)): return np.nan
    s = str(v).replace(',', '').strip()
    m = re.match(r'([0-9]*\.?[0-9]+)\s*(ns|us|μs|ms|s)?$', s)
    if not m: return np.nan
    x = float(m.group(1)); u = m.group(2) or 'ns'
    return x * {'ns':1, 'us':1e3, 'μs':1e3, 'ms':1e6, 's':1e9}[u]

def by(v):
    if v is None or (isinstance(v, float) and np.isnan(v)): return np.nan
    s = str(v).replace(',', '').strip()
    if s in ('-', 'NA', ''): return 0.0
    m = re.match(r'([0-9]*\.?[0-9]+)\s*(B|KB|MB|GB)?$', s)
    if not m: return np.nan
    return float(m.group(1)) * {'B':1, 'KB':1024, 'MB':1024**2, 'GB':1024**3}[m.group(2) or 'B']

rows = []
for f in sorted(glob.glob(os.path.join(SRC, 'Benchmarks.csharp_*.BenchmarkRunner-report.csv'))):
    task = re.search(r'(csharp_\d+)', f).group(1)
    d = pd.read_csv(f)
    has_med = 'Median' in d.columns
    for _, r in d.iterrows():
        t = ns(r['Median']) if has_med else ns(r['Mean'])
        rows.append(dict(task=task, model=r['Method'], N=int(r['N']), t=t,
                         t_source='median' if has_med else 'mean',
                         alloc=by(r['Allocated']) if 'Allocated' in d.columns else np.nan))
long = pd.DataFrame(rows)
w = long.pivot_table(index=['task','model'], columns='N', values=['t','alloc'], aggfunc='first')
w.columns = [f'{a}{b}' for a, b in w.columns]
w = w.reset_index()
src = long.groupby(['task','model'])['t_source'].first().reset_index()
w = w.merge(src, on=['task','model'])
w['time_ns'] = w[['t10','t100']].mean(axis=1, skipna=False)
w['alloc_B'] = w[['alloc10','alloc100']].mean(axis=1, skipna=False)
w.to_csv(OUT, index=False)
print(w.shape, w['time_ns'].notna().sum(), 'with time;', w['task'].nunique(), 'tasks')
print(w['t_source'].value_counts().to_dict())
