using System.Reflection;
using System.Runtime.Loader;
var dir = args[0];
AppDomain.CurrentDomain.AssemblyResolve += (s, e) => {
    var p = Path.Combine(dir, new AssemblyName(e.Name).Name + ".dll");
    try { return File.Exists(p) ? Assembly.LoadFrom(p) : null; } catch { return null; }
};
var asm = Assembly.LoadFrom(Path.Combine(dir, "test.dll"));
var tu = asm.GetType("Tests.Shared.TestUtils");
var getScore = tu.GetMethod("GetScore");
Type[] all; try { all = asm.GetTypes(); } catch (ReflectionTypeLoadException ex) { all = ex.Types.Where(t => t != null).ToArray(); }
var runners = all.Where(t => t.Name == "TestRunner" && t.Namespace != null && t.Namespace.StartsWith("Tests.")).OrderBy(t => t.Namespace).ToList();
var realOut = Console.Out;
Console.SetOut(TextWriter.Null);
var lines = new List<string>{"task\tmodel\tpassed\tfailed\tstatus"};
foreach (var rt in runners) {
    var task = rt.Namespace.Substring("Tests.".Length);
    var inst = Activator.CreateInstance(rt);
    foreach (var m in rt.GetMethods().Where(m => m.Name.StartsWith("Run_")).OrderBy(m => m.Name)) {
        var model = m.Name.Substring(4);
        if (task == "csharp_43" && model == "Llama") { lines.Add($"{task}\t{model}\tNA\tNA\tskipped"); continue; }
        string status = "ok"; int p = -1, f = -1;
        var job = Task.Run(() => {
            m.Invoke(inst, null);
            var sc = getScore.Invoke(null, null);
            p = (int)sc.GetType().GetProperty("Passed").GetValue(sc);
            f = (int)sc.GetType().GetProperty("Failed").GetValue(sc);
        });
        try { if (!job.Wait(TimeSpan.FromSeconds(60))) status = "timeout"; }
        catch (Exception ex) { status = "error:" + (ex.InnerException?.GetType().Name ?? ex.GetType().Name); }
        lines.Add($"{task}\t{model}\t{p}\t{f}\t{status}");
    }
}
Console.SetOut(realOut);
File.WriteAllLines("rerun_scores.tsv", lines);
Console.WriteLine($"done {lines.Count - 1}");
