"""Build data/structural_n560.csv from the re-measurement tool's output.

tools/remeasure parses the stored solutions with Roslyn and writes, per
solution, the cyclomatic complexity, the nesting depth and the cognitive
complexity under the original and under the corrected rules, and the three
professionalism signals. This script checks that the original rules
reproduce the values stored by the pipeline and keeps the corrected ones.

Output columns
  cx                     cyclomatic complexity (identical to the stored value)
  nest_stored, nest      nesting depth: stored value / corrected (an `else if`
                         continues its chain instead of adding a level)
  cog_stored, cog        cognitive complexity: stored value / corrected
                         (Campbell's rules; used in the paper)
  doc, nullcheck, linq   professionalism signals (their sum is the stored
                         professionalism indicator)

Usage: python3 analysis/build_structural.py [remeasure.tsv] [evaluation_results.txt]
"""
import os, sys
import pandas as pd

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
TSV = sys.argv[1] if len(sys.argv) > 1 else os.path.join(ROOT, 'tools', 'remeasure', 'remeasure.tsv')
EVAL = sys.argv[2] if len(sys.argv) > 2 else os.path.join(ROOT, 'data', 'results', 'evaluation_results.txt')
OUT = os.path.join(ROOT, 'data', 'structural_n560.csv')

rm = pd.read_csv(TSV, sep='\t')
ev = pd.read_csv(EVAL, sep='\t').rename(columns={'Task ID': 'task', 'AI Model': 'model'})
d = rm.merge(ev[['task', 'model', 'Complexity', 'Nesting', 'Cognitive Cx', 'Professionalism']],
             on=['task', 'model'], how='inner', validate='one_to_one')
assert len(d) == 560, len(d)
assert (d.cx == d.Complexity).all(), 'cyclomatic complexity is not reproduced'
assert (d.nest_orig == d.Nesting).all(), 'stored nesting depth is not reproduced by the original rule'
assert (d.doc + d.nullcheck + d.linq == d.Professionalism).all(), 'professionalism is not reproduced'

out = pd.DataFrame({'task': d.task, 'model': d.model, 'cx': d.cx,
                    'nest_stored': d.Nesting, 'nest': d.nest_flat,
                    'cog_stored': d['Cognitive Cx'], 'cog': d.cog_flat,
                    'doc': d.doc, 'nullcheck': d.nullcheck, 'linq': d.linq})
out = out.sort_values(['task', 'model']).reset_index(drop=True)
out.to_csv(OUT, index=False)
print(f'{len(out)} solutions; nesting changed for {(out.nest != out.nest_stored).sum()} solutions on '
      f'{out[out.nest != out.nest_stored].task.nunique()} tasks; cognitive changed for '
      f'{(out.cog != out.cog_stored).sum()} solutions')
