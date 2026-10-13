"""Every number reported in the manuscript, computed at n = 560.

Inputs
  data/results/evaluation_results.txt
                              per-solution record written by the pipeline
  data/correctness_n560.csv   correctness with unexecuted assertions counted
                              as failed (analysis/build_correctness.py)
  data/structural_n560.csv    re-measured nesting depth and cognitive
                              complexity (analysis/build_structural.py)
  data/runtime_n560.csv       per-solution runtime and allocation, rebuilt
                              from the BenchmarkDotNet reports
                              (analysis/build_runtime.py)
  measurements/sonarqube/*.csv
                              tables built from the SonarQube Community Build
                              export (analysis/build_sonar_tables.py)

Usage: python3 analysis/analysis_n560.py [path/to/evaluation_results.txt] > analysis/results_n560.txt
"""
import sys, os, re
from collections import Counter
import numpy as np, pandas as pd
from scipy import stats

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
EVAL = sys.argv[1] if len(sys.argv) > 1 else os.path.join(ROOT, 'data', 'results', 'evaluation_results.txt')
RNG = np.random.default_rng(42)
MODELS = ['Gemini', 'Claude', 'Grok', 'DeepSeek', 'GPT', 'Llama', 'Mistral']

def hdr(s): print('\n' + '=' * 72 + '\n' + s + '\n' + '=' * 72)

def holm(ps):
    ps = np.asarray(ps, float); o = np.argsort(ps); m = len(ps)
    adj = np.empty(m); run = 0.0
    for k, i in enumerate(o):
        run = max(run, min(1.0, (m - k) * ps[i])); adj[i] = run
    return adj

def cliff(x, y):
    x, y = np.asarray(x), np.asarray(y)
    gt = sum((xi > y).sum() for xi in x); lt = sum((xi < y).sum() for xi in x)
    return (gt - lt) / (len(x) * len(y))

def mag(d):
    d = abs(d)
    return 'negligible' if d < 0.147 else 'small' if d < 0.33 else 'medium' if d < 0.474 else 'large'

def boot_mean(v, n=10000):
    v = np.asarray(v); idx = RNG.integers(0, len(v), (n, len(v)))
    return np.percentile(v[idx].mean(axis=1), [2.5, 97.5])

def boot_r(x, y, n=10000):
    x, y = np.asarray(x, float), np.asarray(y, float); rs = np.empty(n)
    for k in range(n):
        i = RNG.integers(0, len(x), len(x)); rs[k] = np.corrcoef(x[i], y[i])[0, 1]
    return np.percentile(rs, [2.5, 97.5])

def decomp(df, col, task='task', model='model'):
    """Two-way SS decomposition on a complete task x model panel."""
    p = df.pivot_table(index=task, columns=model, values=col).dropna()
    g = p.values.mean()
    ss_t = p.shape[1] * ((p.mean(axis=1) - g) ** 2).sum()
    ss_m = p.shape[0] * ((p.mean(axis=0) - g) ** 2).sum()
    ss = ((p.values - g) ** 2).sum()
    return 100 * ss_t / ss, 100 * ss_m / ss, 100 * (ss - ss_t - ss_m) / ss, p.shape[0]

# ---------------------------------------------------------------- data
d = pd.read_csv(EVAL, sep='\t')
d = d.rename(columns={'Task ID': 'task', 'AI Model': 'model', 'Correctness (%)': 'cor',
                      'Complexity': 'cx', 'Cognitive Cx': 'cog', 'Nesting': 'nest',
                      'Naming Violations': 'nam', 'Professionalism': 'prof'})
cc = pd.read_csv(os.path.join(ROOT, 'data', 'correctness_n560.csv'))
d = d.merge(cc[['task', 'model', 'n_assertions', 'executed', 'correctness']], on=['task', 'model'], how='left')
d['cor_pipeline'] = d['cor']
d['cor'] = d['correctness']      # assertions not executed after an exception count as failed
# The framework's stored quality score also had a naming term; it is reproduced here only as a check.
d['Q_fw'] = (100 / 90) * (90 - 2 * d.cx.clip(upper=15) - 6 * d.nest.clip(upper=5) - 3 * d.nam.clip(upper=10))
# Structural metrics re-measured from the stored solutions (tools/remeasure): the original analyser
# counted every `else if` as one more nesting level, in nesting depth and in cognitive complexity.
st = pd.read_csv(os.path.join(ROOT, 'data', 'structural_n560.csv'))
d = d.merge(st[['task', 'model', 'cx', 'nest', 'cog', 'doc', 'nullcheck', 'linq']].rename(
    columns={'cx': 'cx_rm', 'nest': 'nest_rm', 'cog': 'cog_rm'}), on=['task', 'model'], how='left')
assert (d.cx_rm == d.cx).all(), 'cyclomatic complexity must be reproduced exactly'
d['nest_stored'], d['cog_stored'] = d['nest'], d['cog']
d['nest'], d['cog'] = d['nest_rm'], d['cog_rm']
# Structural score used in the paper: complexity and nesting only (naming is not assessed).
d['Q'] = 50 * ((1 - d.cx.clip(upper=15) / 15) + (1 - d.nest.clip(upper=5) / 5))
rt = pd.read_csv(os.path.join(ROOT, 'data', 'runtime_n560.csv'))
d = d.merge(rt[['task', 'model', 't10', 't100', 'alloc10', 'alloc100', 'time_ns', 'alloc_B', 't_source']],
            on=['task', 'model'], how='left')
sq_f = pd.read_csv(os.path.join(ROOT, 'measurements', 'sonarqube', 'sonar_file_measures.csv'))
sq_i = pd.read_csv(os.path.join(ROOT, 'measurements', 'sonarqube', 'sonar_issues.csv'))
d = d.merge(sq_f, on=['task', 'model'], how='left')
d['sq_cognitive'] = d['sq_cognitive'].fillna(0)   # SonarQube omits best values
iss = sq_i.groupby(['task', 'model']).size().rename('sq_issues')
d = d.merge(iss, left_on=['task', 'model'], right_index=True, how='left')
d['sq_issues'] = d['sq_issues'].fillna(0)
d['sq_extra'] = d['sq_issues'] - sq_i[sq_i.rule == 'S1118'].groupby(['task', 'model']).size().reindex(
    pd.MultiIndex.from_frame(d[['task', 'model']])).fillna(0).values

hdr('DATASET')
print('solutions', len(d), 'tasks', d.task.nunique(), 'models', d.model.nunique())
q_check = d[~d.Excluded]
print('framework score formula reproduces stored score on originally included rows: max abs diff',
      round((q_check.Q_fw - q_check['Quality Score']).abs().max(), 9), 'n =', len(q_check))
print('rows originally flagged did-not-compile:', int(d.Excluded.sum()))
print('re-measurement: cyclomatic reproduced for all rows;',
      'nesting changed for', int((d.nest != d.nest_stored).sum()), 'solutions on', d[d.nest != d.nest_stored].task.nunique(), 'tasks;',
      'cognitive changed for', int((d.cog != d.cog_stored).sum()), 'solutions')
print('  nesting change distribution (stored - corrected):', (d.nest_stored - d.nest).value_counts().sort_index().to_dict())
print('  csharp_34 stored nesting', sorted(d[d.task == 'csharp_34'].nest_stored.unique()), 'corrected', sorted(d[d.task == 'csharp_34'].nest.unique()),
      ' stored cognitive', sorted(d[d.task == 'csharp_34'].cog_stored.unique()), 'corrected', sorted(d[d.task == 'csharp_34'].cog.unique()))
print('  solutions with cx > 15:', int((d.cx > 15).sum()), ' nest > 5 stored:', int((d.nest_stored > 5).sum()),
      ' corrected:', int((d.nest > 5).sum()), ' corrected nest == 5:', int((d.nest == 5).sum()), ' max corrected nest', int(d.nest.max()))
stop = d[d.executed < d.n_assertions]
print('tests stopped early by an exception:', len(stop), ' scores changed by counting unexecuted assertions:',
      int(((d['cor'] - d.cor_pipeline).abs() > 1e-6).sum()))
print(stop[['task', 'model', 'cor_pipeline', 'cor', 'executed', 'n_assertions']].to_string())
r0 = stats.pearsonr(d.cor_pipeline, d.Q)[0]; print(f'r(pipeline correctness, Q) = {r0:.4f}')
print('pipeline means:', d.groupby('model').cor_pipeline.mean().round(2).to_dict())

# ---------------------------------------------------------------- RQ1
hdr('RQ1 CORRECTNESS')
C = d.pivot_table(index='task', columns='model', values='cor')[MODELS]
for m in MODELS:
    lo, hi = boot_mean(C[m])
    print(f'{m:9s} mean {C[m].mean():6.2f}  CI [{lo:6.2f},{hi:6.2f}]  fully correct {int((C[m]==100).sum()):2d}/80  zero {int((C[m]==0).sum())}')
print('spread', round(C.mean().max() - C.mean().min(), 2), ' overall mean', round(C.values.mean(), 2))
fr = stats.friedmanchisquare(*[C[m] for m in MODELS])
print(f'Friedman chi2={fr.statistic:.2f} p={fr.pvalue:.2e}')
pairs = [(a, b) for i, a in enumerate(MODELS) for b in MODELS[i + 1:]]
raw = []
for a, b in pairs:
    try: raw.append(stats.wilcoxon(C[a], C[b], zero_method='wilcox').pvalue)
    except ValueError: raw.append(1.0)
adj = holm(raw)
for (a, b), p, pa in zip(pairs, raw, adj):
    dd = cliff(C[a], C[b])
    if pa < 0.05 or a == 'Gemini': print(f'  {a:8s} vs {b:8s} p_holm={pa:.3f} delta={dd:+.3f} ({mag(dd)})')
binary_tasks = ((C == 0) | (C == 100)).all(axis=1).sum()
print('tasks whose seven outcomes are all 0 or 100:', int(binary_tasks))
print('tasks solved fully by all seven:', int((C == 100).all(axis=1).sum()))
print('tasks failed (score<100) by all seven:', list(C.index[(C < 100).all(axis=1)]))
print('task means lowest 5:', C.mean(axis=1).sort_values().head(5).round(1).to_dict())

# ---------------------------------------------------------------- RQ2
hdr('RQ2 STRUCTURAL QUALITY')
g = d.groupby('model')
tab = pd.DataFrame({'Q': g.Q.mean(), 'cx': g.cx.mean(), 'cog': g.cog.mean(), 'nest': g.nest.mean(),
                    'nam_any': g.nam.apply(lambda s: (s > 0).sum()), 'prof': g.prof.mean()}).loc[MODELS]
print(tab.round(2).to_string())
print('quality spread', round(tab.Q.max() - tab.Q.min(), 2))
Qp = d.pivot_table(index='task', columns='model', values='Q')[MODELS]
frq = stats.friedmanchisquare(*[Qp[m] for m in MODELS])
print(f'Friedman on Q: chi2={frq.statistic:.2f} p={frq.pvalue:.2e}')
rawq = []
for a, b in pairs:
    try: rawq.append(stats.wilcoxon(Qp[a], Qp[b]).pvalue)
    except ValueError: rawq.append(1.0)
adjq = holm(rawq)
sig = [(a, b, round(pa, 4), round(cliff(Qp[a], Qp[b]), 3)) for (a, b), pa in zip(pairs, adjq) if pa < 0.05]
print('significant Q pairs (Holm):', sig)
for col in ['cx', 'nest', 'cog']:
    t, m_, r, n = decomp(d, col); print(f'decomp {col:4s}: task {t:.1f}%  model {m_:.1f}%  resid {r:.1f}%  (tasks {n})')
for a, b in [('cx', 'nest'), ('cog', 'nest'), ('cog', 'cx')]:
    print(f'r({a},{b}) = {stats.pearsonr(d[a], d[b])[0]:.3f}')
print('solutions with any naming violation:', int((d.nam > 0).sum()), ' total violations:', int(d.nam.sum()))
print('naming violations by task (top):', d[d.nam > 0].groupby('task').size().sort_values(ascending=False).head(5).to_dict())
print('professionalism distribution:', d.prof.value_counts().sort_index().to_dict())
print('professionalism signals reproduced:', bool(((d.doc + d.nullcheck + d.linq) == d.prof).all()))
print('solutions per model with a doc comment / null check / LINQ operator:')
print(d.groupby('model')[['doc', 'nullcheck', 'linq']].sum().loc[MODELS].to_string())
# Does the model ranking depend on the form of Q?  (a) each metric on its own
for col in ['cx', 'nest', 'cog', 'sq_complexity', 'sq_cognitive']:
    P = d.pivot_table(index='task', columns='model', values=col)[MODELS].dropna()
    f = stats.friedmanchisquare(*[P[m] for m in MODELS])
    print(f'Friedman {col:13s} chi2={f.statistic:.2f} p={f.pvalue:.2g} tasks={len(P)}  means', P.mean().round(2).to_dict())
# (b) model ranking over 10,000 random weightings of the two terms of Q
T = pd.DataFrame({'tcx': 1 - d.cx.clip(upper=15) / 15, 'tn': 1 - d.nest.clip(upper=5) / 5,
                  'model': d.model}).groupby('model').mean().loc[MODELS]
rank_q = T.mean(axis=1).rank(ascending=False).values
Wq = np.random.default_rng(9).dirichlet(np.ones(2), size=10000)
R = (-(T.values @ Wq.T)).argsort(axis=0).argsort(axis=0) + 1          # models x weightings
for i, m in enumerate(MODELS):
    print(f'  weighting ranks {m:9s} rank under Q {int(rank_q[i])}  same rank {np.mean(R[i] == rank_q[i]) * 100:5.1f}%'
          f'  first {np.mean(R[i] == 1) * 100:5.1f}%  last {np.mean(R[i] == 7) * 100:5.1f}%  range {R[i].min()}-{R[i].max()}')
tau = np.array([stats.kendalltau(R[:, k], rank_q)[0] for k in range(R.shape[1])])
print(f'Kendall tau with the ranking by Q: median {np.median(tau):.2f} min {tau.min():.2f}')

# ---------------------------------------------------------------- RQ3 SonarQube
hdr('RQ3 SONARQUBE (platform pass, 560 solutions)')
print('issues total', len(sq_i), ' by type', sq_i.type.value_counts().to_dict())
print('by severity', sq_i.severity.value_counts().to_dict())
print('S1118 issues', int((sq_i.rule == 'S1118').sum()), ' solutions with S1118',
      sq_i[sq_i.rule == 'S1118'].groupby(['task', 'model']).ngroups)
extra = sq_i[sq_i.rule != 'S1118']
print('issues beyond S1118', len(extra), ' solutions with any', extra.groupby(['task', 'model']).ngroups,
      ' distinct rules', extra.rule.nunique())
pm = pd.DataFrame({
    'issues': sq_i.groupby('model').size(),
    'extra': extra.groupby('model').size(),
    'sol_with_extra': extra.groupby('model').apply(lambda s: s.groupby('task').ngroups),
    'bugs': sq_i[sq_i.type == 'BUG'].groupby('model').size(),
    'vulns': sq_i[sq_i.type == 'VULNERABILITY'].groupby('model').size(),
    'effort': d.groupby('model').sq_debt.sum(),
    'effort_per_sol': d.groupby('model').sq_debt.mean(),
}).fillna(0).loc[MODELS]
print(pm.round(2).to_string())
print('extra issues per solution: Friedman over tasks')
E = d.pivot_table(index='task', columns='model', values='sq_extra')[MODELS]
fre = stats.friedmanchisquare(*[E[m] for m in MODELS]); print(f'  chi2={fre.statistic:.2f} p={fre.pvalue:.3f}')
print('top rules beyond S1118 per model:')
for m in MODELS:
    c = extra[extra.model == m].rule.value_counts().head(3).to_dict(); print(f'  {m:9s} {c}')
print('rule frequency overall (beyond S1118):', extra.rule.value_counts().head(8).to_dict())
# Do the models differ in which rules they trigger?  Permutation test that shuffles the seven
# solutions of each task between the models; statistic: chi-square of the model x rule table.
def rule_profile_test(rules, n_perm=10000, seed=10):
    tasks_ = sorted(d.task.unique()); ti = {t: k for k, t in enumerate(tasks_)}
    mi = {m: k for k, m in enumerate(MODELS)}; ri = {r: k for k, r in enumerate(rules)}
    X = np.zeros((len(tasks_), len(MODELS), len(rules)))
    for _, row in extra[extra.rule.isin(rules)].iterrows():
        X[ti[row.task], mi[row.model], ri[row.rule]] += 1
    def chi2(T):
        T = T[:, T.sum(axis=0) > 0]; E = T.sum(1, keepdims=True) * T.sum(0, keepdims=True) / T.sum()
        return ((T - E) ** 2 / E).sum()
    obs = chi2(X.sum(0)); rng = np.random.default_rng(seed); ge = 0
    for _ in range(n_perm):
        ge += chi2(np.stack([X[k][rng.permutation(len(MODELS))] for k in range(len(tasks_))]).sum(0)) >= obs
    return obs, (ge + 1) / (n_perm + 1)
vc_ = extra.rule.value_counts(); frequent = vc_[vc_ >= 7].index.tolist()
o1, p1 = rule_profile_test(frequent); o2, p2 = rule_profile_test(extra.rule.unique().tolist())
print(f'rule profile permutation test: {len(frequent)} rules with >= 7 issues chi2={o1:.1f} p={p1:.4f}; '
      f'all {extra.rule.nunique()} rules chi2={o2:.1f} p={p2:.4f}')
print('effort distribution (min):', d.sq_debt.value_counts().sort_index().to_dict())
print('maintainability rating values:', d.sq_rating.value_counts().to_dict())
# agreement of complexity measures
r_cx = stats.pearsonr(d.cx, d.sq_complexity)[0]
print(f'cyclomatic ours vs SQ: r={r_cx:.3f} exact={100*(d.cx==d.sq_complexity).mean():.1f}% within1={100*((d.cx-d.sq_complexity).abs()<=1).mean():.1f}% means {d.sq_complexity.mean():.2f} vs {d.cx.mean():.2f}')
rho_cg = stats.spearmanr(d.cog, d.sq_cognitive)[0]; r_cg = stats.pearsonr(d.cog, d.sq_cognitive)[0]
nz = d[d.task != 'csharp_34']; r_cg34 = stats.pearsonr(nz.cog, nz.sq_cognitive)[0]
print(f'cognitive ours vs SQ: rho={rho_cg:.3f} r={r_cg:.3f} r_excl34={r_cg34:.3f} exact={100*(d.cog==d.sq_cognitive).mean():.1f}% within1={100*((d.cog-d.sq_cognitive).abs()<=1).mean():.1f}%')
r_st = stats.pearsonr(d.cog_stored, d.sq_cognitive)[0]; print(f'cognitive as originally stored vs SQ: r={r_st:.3f}')
print('csharp_34 ours cog', sorted(d[d.task=="csharp_34"].cog.unique()), 'SQ', sorted(d[d.task=="csharp_34"].sq_cognitive.unique()))
for col in ['sq_complexity', 'sq_cognitive']:
    t, m_, r, n = decomp(d, col); print(f'decomp {col}: task {t:.1f}% model {m_:.1f}% resid {r:.1f}%')
for col, lab in [('Q', 'quality'), ('cx', 'cyclomatic'), ('cog', 'cognitive'), ('nest', 'nesting'), ('cor', 'correctness')]:
    rr, pp = stats.pearsonr(d.sq_debt, d[col]); print(f'SQALE effort vs {lab}: r={rr:.3f} p={pp:.2g}')
rr, pp = stats.pearsonr(d.sq_issues, d['cor']); print(f'SQ issues vs correctness: r={rr:.3f} p={pp:.2f}')
rr, pp = stats.pearsonr(d.sq_extra, d['cor']); print(f'SQ extra issues vs correctness: r={rr:.3f} p={pp:.2f}')

hdr('RQ3b IN-PROCESS ANALYZER PASS (run only on the 456 rows not flagged)')
inc = d[~d.Excluded].copy()
rules = inc['SQ Rules'].fillna('')
base = rules.str.contains('S1118') & rules.str.contains('S3903') & rules.str.contains('S3904')
print('n', len(inc), ' baseline triple present on', f'{100*base.mean():.1f}%')
inc['excess'] = inc['SQ Total Issues'] - 3
print('solutions with any issue beyond the triple:', int((inc.excess > 0).sum()), ' max excess', int(inc.excess.max()))
cnt = Counter(x for s in rules for x in s.split(',') if x and x not in ('S1118', 'S3903', 'S3904'))
print('excess rule counts:', cnt.most_common(6))

# ---------------------------------------------------------------- RQ4 runtime
hdr('RQ4 RUNTIME (BenchmarkDotNet reports)')
b = d[d.time_ns.notna()]
print('solutions with runtime', len(b), ' tasks', b.task.nunique(), ' zero-time', int((b.time_ns == 0).sum()))
print('mean used instead of median (BDN omitted median):', int((b.t_source == 'mean').sum()))
missing = d[d.time_ns.isna()].groupby('task').size()
print('solutions without runtime by task:', missing.to_dict())
for m in MODELS:
    s = b[b.model == m]
    print(f'{m:9s} n={len(s):2d} median time {s.time_ns.median():8.1f} ns   median alloc {s.alloc_B.median():6.0f} B   zero-alloc {int((s.alloc_B==0).sum()):2d}')
T = b.pivot_table(index='task', columns='model', values='time_ns')[MODELS]
Tc = T.dropna(); Tc = Tc[(Tc > 0).all(axis=1)]
frt = stats.friedmanchisquare(*[np.log10(Tc[m]) for m in MODELS])
print(f'tasks with all seven (t>0): {len(Tc)}  Friedman log-time chi2={frt.statistic:.2f} p={frt.pvalue:.3g}')
rawt = [stats.wilcoxon(np.log10(Tc[a]), np.log10(Tc[b_])).pvalue for a, b_ in pairs]
adjt = holm(rawt)
print('significant time pairs (Holm):', [(a, b_, round(pa, 4), round(cliff(Tc[a], Tc[b_]), 3)) for (a, b_), pa in zip(pairs, adjt) if pa < 0.05])
# Times below 1 ns are below the timer resolution; "fastest" is only defined where the fastest time is >= 1 ns.
subns = sorted(set(b[b.time_ns < 1].task))
print('solutions with time below 1 ns:', int((b.time_ns < 1).sum()), 'on tasks', subns)
Tf = T[T.min(axis=1) >= 1]
fast = Tf.idxmin(axis=1).value_counts().reindex(MODELS).fillna(0).astype(int)
print('fastest solution per task (tasks whose fastest time >= 1 ns):', fast.to_dict(), ' tasks', len(Tf))
Tc2 = Tc.drop(index=[t for t in subns if t in Tc.index])
f2 = stats.friedmanchisquare(*[np.log10(Tc2[m]) for m in MODELS])
adj2 = holm([stats.wilcoxon(np.log10(Tc2[a]), np.log10(Tc2[c])).pvalue for a, c in pairs])
sig2 = [abs(cliff(Tc2[a], Tc2[c])) for (a, c), pa in zip(pairs, adj2) if pa < 0.05]
print(f'without the sub-ns tasks: {len(Tc2)} tasks, Friedman chi2={f2.statistic:.2f} p={f2.pvalue:.2g}, '
      f'{len(sig2)} Holm pairs, max |delta|={max(sig2):.3f}')
med_rank = b.groupby('model').time_ns.median().rank().astype(int).to_dict()
print('rank by median time (1=fastest):', med_rank)
A = b.pivot_table(index='task', columns='model', values='alloc_B')[MODELS].dropna()
fra = stats.friedmanchisquare(*[A[m] for m in MODELS]); print(f'Friedman allocation chi2={fra.statistic:.2f} p={fra.pvalue:.3g} tasks {len(A)}')
# growth exponent
gk = b[(b.t10 > 0) & (b.t100 > 0)].copy()
gk['k'] = np.log(gk.t100 / gk.t10) / np.log(10)
print('growth: solutions', len(gk), 'tasks', gk.task.nunique())
for m in MODELS:
    s = gk[gk.model == m]
    print(f'  {m:9s} n={len(s)} median k={s.k.median():.3f} flat(<0.3)={int((s.k<0.3).sum())} superlinear(>1.4)={int((s.k>1.4).sum())}')
K = gk.pivot_table(index='task', columns='model', values='k')[MODELS].dropna()
frk = stats.friedmanchisquare(*[K[m] for m in MODELS]); print(f'Friedman k over {len(K)} tasks chi2={frk.statistic:.2f} p={frk.pvalue:.3f}')
t_, m_, r_, n_ = decomp(gk, 'k'); print(f'decomp k: task {t_:.1f}% model {m_:.1f}% resid {r_:.1f}% (tasks {n_})')
sup = gk[gk.k > 1.4]; print('superlinear total', len(sup), ' by task', sup.groupby('task').size().to_dict())
g2 = b[(b.t10 >= 1) & (b.t100 >= 1)].copy(); g2['k'] = np.log(g2.t100 / g2.t10) / np.log(10)
K2 = g2.pivot_table(index='task', columns='model', values='k')[MODELS].dropna()
fk2 = stats.friedmanchisquare(*[K2[m] for m in MODELS])
print(f'growth with both medians >= 1 ns: {len(g2)} solutions, Friedman over {len(K2)} tasks chi2={fk2.statistic:.2f} '
      f'p={fk2.pvalue:.2f}, task share {decomp(g2, "k")[0]:.1f}%')
print('median k overall', round(gk.k.median(), 3), ' range of model medians',
      round(gk.groupby('model').k.median().min(), 3), round(gk.groupby('model').k.median().max(), 3))
x = d[(d.task == 'csharp_43')][['model', 't10', 't100', 'alloc10', 'alloc100', 'cor', 'cx', 'Q']]
print('csharp_43:\n', x.to_string())

# ---------------------------------------------------------------- RQ5
hdr('RQ5 CORRECTNESS vs STRUCTURAL QUALITY')
r, p = stats.pearsonr(d['cor'], d.Q); RNG = np.random.default_rng(42); lo, hi = boot_r(d['cor'], d.Q); rho, prho = stats.spearmanr(d['cor'], d.Q)
print(f'r={r:.4f} CI[{lo:.3f},{hi:.3f}] p={p:.3f}; rho={rho:.4f} p={prho:.3f}')
for m in MODELS:
    s = d[d.model == m]; rr, pp = stats.pearsonr(s['cor'], s.Q); print(f'  {m:9s} r={rr:+.3f} p={pp:.3f}')
Z = pd.DataFrame(index=d.index)
for col, inv in [('cx', True), ('nest', True), ('prof', False)]:
    v = d[col].astype(float); vn = (v - v.min()) / (v.max() - v.min()); Z[col] = 1 - vn if inv else vn
W = np.random.default_rng(7).dirichlet(np.ones(3), size=10000); qs = Z.values @ W.T
cm = d['cor'].values - d['cor'].mean(); qsc = qs - qs.mean(axis=0)
rs = (cm @ qsc) / (np.sqrt((cm ** 2).sum()) * np.sqrt((qsc ** 2).sum(axis=0)))
print(f'Dirichlet 3 comps (cx, nest, prof): range [{rs.min():.3f},{rs.max():.3f}] max|r|={np.abs(rs).max():.3f}')
Z5 = Z.copy(); v = d.cog.astype(float); Z5['cog'] = 1 - (v - v.min()) / (v.max() - v.min())
W5 = np.random.default_rng(8).dirichlet(np.ones(4), size=10000); qs5 = Z5.values @ W5.T; qsc5 = qs5 - qs5.mean(axis=0)
rs5 = (cm @ qsc5) / (np.sqrt((cm ** 2).sum()) * np.sqrt((qsc5 ** 2).sum(axis=0)))
print(f'Dirichlet 4 comps (+cog): range [{rs5.min():.3f},{rs5.max():.3f}] max|r|={np.abs(rs5).max():.3f}')
# correctness against each metric on its own, including measures computed by SonarQube
for col in ['cx', 'nest', 'cog', 'nam', 'sq_complexity', 'sq_cognitive', 'sq_debt', 'sq_issues', 'sq_ncloc']:
    rr, pp = stats.pearsonr(d['cor'], d[col]); rs_, ps_ = stats.spearmanr(d['cor'], d[col])
    print(f'  correctness vs {col:13s} r={rr:+.3f} p={pp:.2f}  rho={rs_:+.3f} p={ps_:.2f}')
rk = pd.DataFrame({'c': C.mean(), 'q': Qp.mean()}).loc[MODELS]
rk['rc'] = rk.c.rank(ascending=False).astype(int); rk['rq'] = rk.q.rank(ascending=False).astype(int)
rr, pp = stats.spearmanr(rk.rc, rk.rq); print(f'rank correlation of orderings rho={rr:.3f} p={pp:.3f}'); print(rk.round(2).to_string())
# within-task
w = d[['task', 'cor', 'cx', 'nest', 'Q']].copy()
for col in ['cor', 'cx', 'nest', 'Q']:
    w[col + '_r'] = w.groupby('task')[col].transform(lambda s: s - s.mean())
for col in ['cx', 'nest', 'Q']:
    msk = (w.groupby('task')['cor'].transform('std') > 0) & (w.groupby('task')[col].transform('std') > 0)
    x_, y_ = w.loc[msk, col + '_r'], w.loc[msk, 'cor_r']; n_, k_ = int(msk.sum()), w.loc[msk, 'task'].nunique()
    rr = np.corrcoef(x_, y_)[0, 1]; df_ = n_ - k_ - 1          # one degree of freedom lost per removed task mean
    pp = 2 * stats.t.sf(abs(rr) * np.sqrt(df_ / (1 - rr ** 2)), df_)
    print(f'within-task {col} vs correctness: r={rr:+.3f} p={pp:.3g} n={n_} tasks={k_} df={df_}')
CT = d.pivot_table(index='task', columns='model', values='cor').mean(axis=1)
QT = d.pivot_table(index='task', columns='model', values='Q').mean(axis=1)
rr, pp = stats.pearsonr(CT, QT); print(f'between tasks (task means): r(correctness, Q)={rr:+.3f} p={pp:.2f}')
# aggregation comparison
hdr('AGGREGATION: correctness-free Q vs composite containing correctness')
eff = np.where(d.time_ns > 0, 100 * 1e4 / (1e4 + d.time_ns), np.nan)
n_c = d['cor'] / 100; n_cx = (1 - d.cx / 15).clip(0, 1); n_ne = (1 - d.nest / 5).clip(0, 1)
n_ef = eff / 100
num = n_c + n_cx + n_ne + np.nan_to_num(n_ef); den = 3 + (~np.isnan(n_ef)).astype(int)
d['comp'] = 100 * num / den
rows = []
for m in MODELS:
    s = d[d.model == m]; ok = s[s['cor'] == 100]; bad = s[s['cor'] < 100]
    rows.append(dict(model=m, n_pass=len(ok), Q_pass=ok.Q.mean(), n_fail=len(bad), Q_fail=bad.Q.mean(),
                     dQ=ok.Q.mean() - bad.Q.mean(), comp_pass=ok.comp.mean(), comp_fail=bad.comp.mean(),
                     dComp=ok.comp.mean() - bad.comp.mean(),
                     p_Q=stats.mannwhitneyu(ok.Q, bad.Q).pvalue if len(bad) > 0 else np.nan))
agg = pd.DataFrame(rows).set_index('model'); print(agg.round(2).to_string())
ok = d[d['cor'] == 100]; bad = d[d['cor'] < 100]
print(f'pooled: Q pass {ok.Q.mean():.2f} fail {bad.Q.mean():.2f} (MWU p={stats.mannwhitneyu(ok.Q, bad.Q).pvalue:.3f}); comp pass {ok.comp.mean():.2f} fail {bad.comp.mean():.2f} (p={stats.mannwhitneyu(ok.comp, bad.comp).pvalue:.2g})')
print('r(correctness, composite) =', round(stats.pearsonr(d['cor'], d.comp)[0], 3))
