// Re-measures nesting depth and cognitive complexity of the 560 stored solutions.
// "orig" rules reproduce the analyser that produced evaluation_results.txt;
// "flat" rules treat an `else if` as a continuation of the chain (no extra level),
// as the cognitive complexity specification does.
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var dir = args[0];
Console.WriteLine("task\tmodel\tcx\tnest_orig\tnest_flat\tcog_orig\tcog_flat\tdoc\tnullcheck\tlinq");
foreach (var f in Directory.GetFiles(dir, "Solvers_Task_csharp_*.cs"))
{
    var task = Regex.Match(f, @"csharp_\d+").Value;
    var root = CSharpSyntaxTree.ParseText(File.ReadAllText(f)).GetRoot();
    foreach (var ns in root.DescendantNodes().OfType<BaseNamespaceDeclarationSyntax>())
    {
        var name = ns.Name.ToString();
        var m = Regex.Match(name, @"\.(\w+)$"); if (!m.Success) continue;
        var methods = ns.DescendantNodes().OfType<MethodDeclarationSyntax>().ToList();
        int no = 0, nf = 0, co = 0, cf = 0, cx = 0;
        foreach (var md in methods)
        {
            SyntaxNode body = (SyntaxNode)md.Body ?? md.ExpressionBody;
            no = Math.Max(no, NestOrig(body)); nf = Math.Max(nf, NestFlat(body, 0));
            co += CogOrig(body, 0); cf += CogFlat(body, 0);
        }
        // cyclomatic complexity exactly as the original analyser: 1 + decision tokens in the solution
        cx = 1 + ns.Members.SelectMany(mm => mm.DescendantTokens()).Count(t =>
            t.IsKind(SyntaxKind.IfKeyword) || t.IsKind(SyntaxKind.WhileKeyword) || t.IsKind(SyntaxKind.ForKeyword) ||
            t.IsKind(SyntaxKind.ForEachKeyword) || t.IsKind(SyntaxKind.CaseKeyword) || t.IsKind(SyntaxKind.CatchKeyword) ||
            t.IsKind(SyntaxKind.QuestionQuestionToken) || t.IsKind(SyntaxKind.AmpersandAmpersandToken) || t.IsKind(SyntaxKind.BarBarToken));
        var text = string.Concat(ns.Members.Select(mm => mm.ToFullString()));
        int doc = ns.DescendantTrivia().Any(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)) ? 1 : 0;
        int nul = (text.Contains("== null") || text.Contains("is null") || text.Contains("ArgumentNullException") || text.Contains("?.")) ? 1 : 0;
        string[] ops = { "Select", "Where", "Aggregate", "Sum", "Any", "All", "OrderBy", "GroupBy" };
        int linq = ns.DescendantNodes().OfType<InvocationExpressionSyntax>().Any(inv => inv.Expression is MemberAccessExpressionSyntax ma && ops.Contains(ma.Name.Identifier.Text)) ? 1 : 0;
        Console.WriteLine($"{task}\t{m.Groups[1].Value}\t{cx}\t{no}\t{nf}\t{co}\t{cf}\t{doc}\t{nul}\t{linq}");
    }
}

static int NestOrig(SyntaxNode node, int depth = 0)
{
    if (node == null) return depth; int max = depth;
    foreach (var child in node.ChildNodes())
    {
        int next = depth;
        if (child is IfStatementSyntax || child is ForStatementSyntax || child is ForEachStatementSyntax ||
            child is WhileStatementSyntax || child is DoStatementSyntax) next++;
        max = Math.Max(max, NestOrig(child, next));
    }
    return max;
}
static int NestFlat(SyntaxNode node, int depth)
{
    if (node == null) return depth; int max = depth;
    foreach (var child in node.ChildNodes())
    {
        int next = depth;
        bool isElseIf = child is IfStatementSyntax && child.Parent is ElseClauseSyntax;
        if ((child is IfStatementSyntax && !isElseIf) || child is ForStatementSyntax || child is ForEachStatementSyntax ||
            child is WhileStatementSyntax || child is DoStatementSyntax) next++;
        // an else-if body sits at the level of the chain: the chain's `if` already added one level
        max = Math.Max(max, NestFlat(child, next));
    }
    return max;
}
// Cognitive complexity, original behaviour: every nested `if` (including else-if) gets +1+nesting.
static int CogOrig(SyntaxNode node, int nesting)
{
    if (node == null) return 0;
    switch (node)
    {
        case IfStatementSyntax:
        case ForStatementSyntax: case ForEachStatementSyntax: case WhileStatementSyntax:
        case DoStatementSyntax: case SwitchStatementSyntax: case CatchClauseSyntax:
        case ConditionalExpressionSyntax:
            return 1 + nesting + Children(node, nesting + 1, CogOrig);
        default:
            int s = (node is BinaryExpressionSyntax b && (b.IsKind(SyntaxKind.LogicalAndExpression) || b.IsKind(SyntaxKind.LogicalOrExpression))) ? 1 : 0;
            return s + Children(node, nesting, CogOrig);
    }
}
static int Children(SyntaxNode n, int nesting, Func<SyntaxNode, int, int> f)
{ int s = 0; foreach (var c in n.ChildNodes()) s += f(c, nesting); return s; }
// Cognitive complexity per the current repository code (flat else-if, boolean runs).
static int CogFlat(SyntaxNode node, int nesting)
{
    if (node == null) return 0;
    switch (node)
    {
        case IfStatementSyntax ifs: return IfChain(ifs, nesting);
        case ForStatementSyntax: case ForEachStatementSyntax: case WhileStatementSyntax:
        case DoStatementSyntax: case SwitchStatementSyntax: case CatchClauseSyntax:
        case ConditionalExpressionSyntax:
            return 1 + nesting + Children(node, nesting + 1, CogFlat);
        default:
            int s = 0;
            if (node is BinaryExpressionSyntax b && (b.IsKind(SyntaxKind.LogicalAndExpression) || b.IsKind(SyntaxKind.LogicalOrExpression))
                && !(b.Parent is BinaryExpressionSyntax p && p.Kind() == b.Kind())) s = 1;
            return s + Children(node, nesting, CogFlat);
    }
}
static int IfChain(IfStatementSyntax ifs, int nesting)
{
    int s = 1 + nesting + CogFlat(ifs.Condition, nesting) + CogFlat(ifs.Statement, nesting + 1);
    var e = ifs.Else;
    while (e != null)
    {
        if (e.Statement is IfStatementSyntax ei) { s += 1 + CogFlat(ei.Condition, nesting) + CogFlat(ei.Statement, nesting + 1); e = ei.Else; }
        else { s += 1 + CogFlat(e.Statement, nesting + 1); e = null; }
    }
    return s;
}
