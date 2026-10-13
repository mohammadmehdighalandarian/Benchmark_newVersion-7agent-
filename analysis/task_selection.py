"""Compare the 80 HumanEval problems used in the study with the 84 others.
Inputs: data/external/HumanEval.jsonl.gz (official dataset, github.com/openai/human-eval),
        data/task_mapping.csv, data/correctness_n560.csv
Output: analysis/task_selection.txt"""
import ast, csv, gzip, json, os, re
import numpy as np, pandas as pd
from scipy import stats

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
he = [json.loads(l) for l in gzip.open(os.path.join(ROOT, 'data/external/HumanEval.jsonl.gz'), 'rt')]
mapping = {r['task']: int(r['humaneval'].split('/')[1]) for r in csv.DictReader(open(os.path.join(ROOT, 'data/task_mapping.csv')))}
sel = set(mapping.values())

def complexity(src):
    tree = ast.parse(src); d = 1
    for n in ast.walk(tree):
        if isinstance(n, (ast.If, ast.For, ast.While, ast.IfExp, ast.ExceptHandler)): d += 1
        elif isinstance(n, ast.BoolOp): d += len(n.values) - 1
        elif isinstance(n, ast.comprehension): d += 1 + len(n.ifs)
    def depth(node, k=0):
        return max([k] + [depth(c, k + isinstance(c, (ast.If, ast.For, ast.While, ast.With, ast.Try))) for c in ast.iter_child_nodes(node)])
    return d, depth(tree)

rows = []
for p in he:
    i = int(p['task_id'].split('/')[1]); full = p['prompt'] + p['canonical_solution']
    cc, nest = complexity(full)
    entry = [f for f in ast.walk(ast.parse(full)) if isinstance(f, ast.FunctionDef) and f.name == p['entry_point']][0]
    rows.append(dict(
        id=i, selected=i in sel,
        loc=len([l for l in p['canonical_solution'].splitlines() if l.strip() and not l.strip().startswith('#')]),
        cc=cc, nest=nest, words=len((ast.get_docstring(entry) or '').split()),
        asserts=len([l for l in p['test'].splitlines() if l.strip().startswith('assert') and 'candidate' in l]),
        params=len(entry.args.args),
        early=i <= 40,
        helpers=len([n for n in ast.walk(ast.parse(p['prompt'] + '    pass\n')) if isinstance(n, ast.FunctionDef)]) > 1,
        float_tol=bool(re.search(r'abs\(|fabs|1e-|isclose', p['test']))))
df = pd.DataFrame(rows)
out = [f'HumanEval problems: {len(df)}; used in this study: {int(df.selected.sum())}', '']
for c, lab in [('loc', 'lines in reference solution'), ('cc', 'cyclomatic complexity of reference solution'),
               ('nest', 'nesting depth of reference solution'), ('words', 'words in description'),
               ('asserts', 'test assertions'), ('params', 'parameters')]:
    a, b = df[df.selected][c], df[~df.selected][c]
    out.append(f'{lab:45s} used mean {a.mean():6.2f} median {a.median():5.1f} | other mean {b.mean():6.2f} median {b.median():5.1f} | Mann-Whitney p={stats.mannwhitneyu(a, b).pvalue:.3f}')
for c, lab in [('early', 'from HumanEval/0-40'), ('helpers', 'prompt defines helper functions'), ('float_tol', 'tests compare floats with tolerance')]:
    t = pd.crosstab(df.selected, df[c]).reindex(index=[True, False], columns=[True, False]).fillna(0).values
    out.append(f'{lab:45s} used {int(df[df.selected][c].sum())}/80 | other {int(df[~df.selected][c].sum())}/84 | Fisher p={stats.fisher_exact(t)[1]:.3f}')
part = df.assign(part=np.where(df.early, 'HumanEval/0-40', 'HumanEval/41-163')).groupby('part')[['loc', 'cc', 'words']].mean().round(2)
out += ['', 'by position in the dataset (all 164):', part.to_string()]
# fidelity of the translated tests
cs = pd.read_csv(os.path.join(ROOT, 'data/correctness_n560.csv')).groupby('task').n_assertions.first()
eq = sum(int(cs[t]) == int(df.loc[df.id == i, 'asserts'].iloc[0]) for t, i in mapping.items())
out += ['', f'tasks whose C# assertion count equals the HumanEval assert count: {eq}/80']
open(os.path.join(ROOT, 'analysis/task_selection.txt'), 'w').write('\n'.join(out) + '\n')
print('\n'.join(out))
