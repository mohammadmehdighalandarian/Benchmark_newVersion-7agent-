"""Build the two SonarQube tables used by the analysis from the raw export.

The export (measurements/sonarqube/raw/) was taken from the SonarQube Web
API after the analysis of September 2026: one SonarQube project per model,
each containing that model's 80 solver files (Solvers_Task_csharp_*.cs).

Outputs (measurements/sonarqube/)
  sonar_issues.csv         one row per issue: model, task, rule, severity,
                           type, effort (minutes)
  sonar_file_measures.csv  one row per file: model, task and the file-level
                           measures complexity, cognitive_complexity, ncloc,
                           sqale_index (debt, minutes) and sqale_rating
                           (1 = A). SonarQube omits a measure that has its
                           best value, so a missing cognitive complexity
                           means 0.

Usage: python3 analysis/build_sonar_tables.py [raw_dir] [out_dir]
"""
import glob, json, os, re, sys
import pandas as pd

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
RAW = sys.argv[1] if len(sys.argv) > 1 else os.path.join(ROOT, 'measurements', 'sonarqube', 'raw')
OUT = sys.argv[2] if len(sys.argv) > 2 else os.path.join(ROOT, 'measurements', 'sonarqube')

MODEL = {'gpt': 'GPT', 'gemini': 'Gemini', 'claude': 'Claude', 'grok': 'Grok',
         'mistral': 'Mistral', 'deepseek': 'DeepSeek', 'llama': 'Llama'}
METRICS = [('complexity', 'sq_complexity'), ('cognitive_complexity', 'sq_cognitive'),
           ('ncloc', 'sq_ncloc'), ('sqale_index', 'sq_debt'), ('sqale_rating', 'sq_rating')]


def load(path):
    with open(path, encoding='utf-8-sig') as f:   # the export files start with a BOM
        return json.load(f)


def model_of(path):
    return MODEL[re.search(r'__benchmark-([a-z]+)\.json$', path).group(1)]


def task_of(component):
    return re.search(r'Solvers_Task_(csharp_\d+)\.cs', component).group(1)


def minutes(effort):
    """SonarQube effort strings such as '5min', '1h', '1h30min' -> minutes."""
    h = re.search(r'(\d+)h', effort or '')
    m = re.search(r'(\d+)min', effort or '')
    return (int(h.group(1)) * 60 if h else 0) + (int(m.group(1)) if m else 0)


issues = []
for path in sorted(glob.glob(os.path.join(RAW, 'issues__benchmark-*.json'))):
    model = model_of(path)
    for it in load(path)['issues']:
        issues.append(dict(model=model, task=task_of(it['component']),
                           rule=it['rule'].split(':', 1)[1], severity=it['severity'],
                           type=it['type'], effort=minutes(it.get('effort'))))
issues = pd.DataFrame(issues)

measures = []
for path in sorted(glob.glob(os.path.join(RAW, 'measures_files__benchmark-*.json'))):
    model = model_of(path)
    for comp in load(path)['components']:
        values = {m['metric']: float(m['value']) for m in comp.get('measures', []) if 'value' in m}
        row = dict(model=model, task=task_of(comp['key']))
        row.update({col: values.get(metric) for metric, col in METRICS})
        measures.append(row)
measures = pd.DataFrame(measures)

issues.to_csv(os.path.join(OUT, 'sonar_issues.csv'), index=False)
measures.to_csv(os.path.join(OUT, 'sonar_file_measures.csv'), index=False)
print(f'{len(issues)} issues on {issues.groupby(["model", "task"]).ngroups} solutions, '
      f'{issues.rule.nunique()} rules; {len(measures)} files with measures')
print(issues.type.value_counts().to_dict())
