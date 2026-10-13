"""Figures for the manuscript, all at n = 560. Vector PDFs in figures/.
Usage: python3 analysis/figures_n560.py [path/to/evaluation_results.txt]"""
import os, sys
import numpy as np, pandas as pd, matplotlib
matplotlib.use('Agg')
import matplotlib.pyplot as plt
from matplotlib.patches import FancyBboxPatch, FancyArrowPatch

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
EVAL = sys.argv[1] if len(sys.argv) > 1 else os.path.join(ROOT, 'data', 'results', 'evaluation_results.txt')
OUT = os.path.join(ROOT, 'figures'); os.makedirs(OUT, exist_ok=True)
RNG = np.random.default_rng(42)
plt.rcParams.update({'font.size': 9, 'axes.spines.top': False, 'axes.spines.right': False,
                     'pdf.fonttype': 42, 'font.family': 'DejaVu Sans'})
ORDER = ['Gemini', 'Claude', 'Grok', 'DeepSeek', 'GPT', 'Llama', 'Mistral']
PAL = {'Gemini': '#0072B2', 'Grok': '#009E73', 'DeepSeek': '#56B4E9', 'GPT': '#E69F00',
       'Claude': '#CC79A7', 'Mistral': '#D55E00', 'Llama': '#777777'}

d = pd.read_csv(EVAL, sep='\t').rename(columns={'Task ID': 'task', 'AI Model': 'model',
     'Correctness (%)': 'cor', 'Complexity': 'cx', 'Cognitive Cx': 'cog', 'Nesting': 'nest',
     'Naming Violations': 'nam', 'Professionalism': 'prof'})
cc = pd.read_csv(os.path.join(ROOT, 'data', 'correctness_n560.csv'))
d = d.merge(cc[['task', 'model', 'correctness']], on=['task', 'model'], how='left')
d['cor'] = d['correctness']
st = pd.read_csv(os.path.join(ROOT, 'data', 'structural_n560.csv'))   # re-measured nesting and cognitive
d = d.drop(columns=['nest', 'cog']).merge(st[['task', 'model', 'nest', 'cog']], on=['task', 'model'], how='left')
d['Q'] = 50 * ((1 - d.cx.clip(upper=15) / 15) + (1 - d.nest.clip(upper=5) / 5))
rt = pd.read_csv(os.path.join(ROOT, 'data', 'runtime_n560.csv'))
d = d.merge(rt[['task', 'model', 'time_ns', 'alloc_B']], on=['task', 'model'], how='left')
iss = pd.read_csv(os.path.join(ROOT, 'measurements', 'sonarqube', 'sonar_issues.csv'))

def save(fig, name):
    fig.savefig(os.path.join(OUT, name + '.pdf'), bbox_inches='tight', metadata={'CreationDate': None})  # reproducible bytes
    fig.savefig(os.path.join(OUT, name + '.png'), bbox_inches='tight', dpi=160)
    plt.close(fig)

# ---- Fig. 1: study design -------------------------------------------------
fig, ax = plt.subplots(figsize=(7.0, 1.9)); ax.axis('off')
boxes = [('Tasks', '80 C# tasks\nfrom HumanEval\n677 assertions'),
         ('Generation', '7 LLMs\none prompt\ntemperature 0\n560 solutions'),
         ('Assembly', '.NET 8 project\nper task\n(solutions, tests,\nharness)'),
         ('Measurement', 'P1 unit tests\nP2 Roslyn\nP3 profiling\nP4 SonarQube'),
         ('Analysis', 'per-solution\nrecords\nRQ1 to RQ5')]
w, gap, x0 = 0.166, 0.035, 0.014
for i, (t, s) in enumerate(boxes):
    x = x0 + i * (w + gap)
    ax.add_patch(FancyBboxPatch((x, 0.06), w, 0.86, boxstyle='round,pad=0.01',
                                fc='#F3F3F3', ec='#555555', lw=0.9, transform=ax.transAxes))
    ax.text(x + w / 2, 0.80, t, ha='center', va='center', fontsize=8.2, fontweight='bold', transform=ax.transAxes)
    ax.text(x + w / 2, 0.38, s, ha='center', va='center', fontsize=6.9, transform=ax.transAxes)
    if i < len(boxes) - 1:
        ax.add_patch(FancyArrowPatch((x + w + 0.002, 0.49), (x + w + gap - 0.002, 0.49), transform=ax.transAxes,
                                     arrowstyle='-|>', mutation_scale=11, lw=1.1, color='#555555'))
save(fig, 'fig_design')

# ---- Fig. 2: variance decomposition -------------------------------------
def decomp(col, frame):
    p = frame.pivot_table(index='task', columns='model', values=col).dropna(); g = p.values.mean()
    st = p.shape[1] * ((p.mean(axis=1) - g) ** 2).sum(); sm = p.shape[0] * ((p.mean(axis=0) - g) ** 2).sum()
    ss = ((p.values - g) ** 2).sum(); return 100 * st / ss, 100 * sm / ss, 100 * (ss - st - sm) / ss
labels = ['Cyclomatic\ncomplexity', 'Nesting\ndepth', 'Cognitive\ncomplexity']
vals = [decomp(c, d) for c in ['cx', 'nest', 'cog']]
fig, ax = plt.subplots(figsize=(5.2, 2.1))
left = np.zeros(3)
for k, (lab, col) in enumerate([('Task', '#4C72B0'), ('Model', '#DD8452'), ('Residual', '#BBBBBB')]):
    v = np.array([x[k] for x in vals]); ax.barh(labels, v, left=left, color=col, label=lab, height=0.55)
    for j, vv in enumerate(v):
        if k == 1:   # the model share is narrow: label it just to the right of its segment
            ax.text(left[j] + vv + 0.8, j, f'{vv:.1f}%', ha='left', va='center', fontsize=7.5, color='#8C3B0C')
        else:
            ax.text(left[j] + vv / 2 + (4 if k == 2 else 0), j, f'{vv:.1f}%', ha='center', va='center',
                    fontsize=7.5, color='white' if k == 0 else 'black')
    left += v
ax.set_xlim(0, 100); ax.set_xlabel('Share of total sum of squares (%)'); ax.invert_yaxis()
ax.legend(ncol=3, fontsize=7.5, frameon=False, loc='lower center', bbox_to_anchor=(0.5, 1.0))
save(fig, 'fig_vardecomp')

# ---- Fig. 3: SonarQube rules beyond S1118 by model ----------------------
ex = iss[iss.rule != 'S1118']
vc = ex.rule.value_counts()
vc = vc.sort_index().sort_values(ascending=False, kind='stable')   # ties ordered by rule name
top = vc[vc >= 7].index.tolist()          # all rules raised at least seven times (12 rules; four tie at 7)
M = ex[ex.rule.isin(top)].pivot_table(index='rule', columns='model', values='task', aggfunc='count').reindex(
    index=top, columns=ORDER).fillna(0).astype(int)
fig, ax = plt.subplots(figsize=(5.6, 3.8))
im = ax.imshow(M.values, cmap='Blues', aspect='auto', vmin=0)
ax.set_xticks(range(len(ORDER))); ax.set_xticklabels(ORDER, rotation=30, ha='right')
ax.set_yticks(range(len(top))); ax.set_yticklabels(top)
for i in range(M.shape[0]):
    for j in range(M.shape[1]):
        v = M.values[i, j]
        if v: ax.text(j, i, str(v), ha='center', va='center', fontsize=7.5, color='white' if v >= 5 else 'black')
ax.spines[:].set_visible(False); ax.set_xticks(np.arange(-.5, 7, 1), minor=True)
ax.set_yticks(np.arange(-.5, len(top), 1), minor=True); ax.grid(which='minor', color='white', lw=1.2)
ax.tick_params(which='minor', length=0)
cb = fig.colorbar(im, ax=ax, fraction=0.04, pad=0.02); cb.set_label('Issues', fontsize=8)
save(fig, 'fig_rules')

# ---- Fig. 4: execution time distributions ------------------------------
b = d[d.time_ns > 0]
fig, ax = plt.subplots(figsize=(6.2, 2.7))
data = [np.log10(b[b.model == m].time_ns) for m in ORDER]
vp = ax.violinplot(data, showmedians=True, widths=0.8)
for body, m in zip(vp['bodies'], ORDER): body.set_facecolor(PAL[m]); body.set_alpha(0.55)
for part in ['cmedians', 'cmins', 'cmaxes', 'cbars']: vp[part].set_color('#333333'); vp[part].set_linewidth(0.8)
outl = d[(d.task == 'csharp_43') & (d.model == 'Llama')].time_ns.iloc[0]
ax.plot(ORDER.index('Llama') + 1, np.log10(outl), marker='*', color='black', ms=9)
ax.annotate('csharp_43', (ORDER.index('Llama') + 1, np.log10(outl)), xytext=(8, -3), textcoords='offset points', fontsize=7.5)
ax.set_xticks(range(1, 8)); ax.set_xticklabels(ORDER)
ax.set_ylabel('Execution time (log$_{10}$ ns)')
save(fig, 'fig_time')

# ---- Fig. 5: correctness vs quality + weight sensitivity ----------------
fig, axs = plt.subplots(1, 2, figsize=(6.8, 2.7))
ax = axs[0]
for m in ORDER:
    s = d[d.model == m]
    ax.scatter(s.Q + RNG.normal(0, 0.6, len(s)), s['cor'] + RNG.normal(0, 0.8, len(s)), s=9, alpha=0.6,
               color=PAL[m], label=m, lw=0)
ax.set_xlabel('Structural quality $Q$'); ax.set_ylabel('Correctness (%)')
ax.legend(fontsize=6.3, frameon=False, ncol=2, loc='lower left', markerscale=1.4)
Z = pd.DataFrame(index=d.index)
for col, inv in [('cx', True), ('nest', True), ('prof', False)]:
    v = d[col].astype(float); vn = (v - v.min()) / (v.max() - v.min()); Z[col] = 1 - vn if inv else vn
W = np.random.default_rng(7).dirichlet(np.ones(3), size=10000); qs = Z.values @ W.T
cm = d['cor'].values - d['cor'].mean(); qsc = qs - qs.mean(axis=0)
rs = (cm @ qsc) / (np.sqrt((cm ** 2).sum()) * np.sqrt((qsc ** 2).sum(axis=0)))
ax = axs[1]; ax.hist(rs, bins=40, color='#4C72B0', alpha=0.85)
ax.axvline(0, color='black', lw=0.8); ax.set_xlim(-0.2, 0.2)
ax.set_xlabel('Pearson $r$ (correctness, weighted quality)'); ax.set_ylabel('Weightings')
save(fig, 'fig_ortho')

# ---- Fig. 6: rank by correctness vs rank by quality ---------------------
rk = pd.DataFrame({'c': d.groupby('model')['cor'].mean(), 'q': d.groupby('model').Q.mean()}).loc[ORDER]
rk['rc'] = rk.c.rank(ascending=False); rk['rq'] = rk.q.rank(ascending=False)
fig, ax = plt.subplots(figsize=(3.6, 3.0))
for m in ORDER:
    ax.plot([0, 1], [rk.loc[m, 'rc'], rk.loc[m, 'rq']], '-o', color=PAL[m], lw=1.6, ms=5)
    ax.text(-0.06, rk.loc[m, 'rc'], m, ha='right', va='center', fontsize=7.8)
    ax.text(1.06, rk.loc[m, 'rq'], m, ha='left', va='center', fontsize=7.8)
ax.set_xlim(-0.55, 1.55); ax.set_ylim(7.6, 0.4); ax.set_xticks([0, 1])
ax.set_xticklabels(['Correctness\nrank', 'Quality\nrank']); ax.set_yticks([])
for s in ['left', 'bottom']: ax.spines[s].set_visible(False)
ax.tick_params(axis='x', length=0)
save(fig, 'fig_reversal')
print('figures written to', OUT)
