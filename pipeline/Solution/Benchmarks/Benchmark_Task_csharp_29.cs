using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_29
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private (int a, int b, int c)[] _data;

    [GlobalSetup]
    public void Setup()
    {
        _data = new (int a, int b, int c)[N];

        // Worst-case style dataset:
        // Valid triangles requiring full Heron's formula computation.
        // Benchmark methods iterate through all N items.
        for (int i = 0; i < N; i++)
        {
            _data[i] = (1000 + i, 1001 + i, 1002 + i);
        }
    }

    [Benchmark(Baseline = true)]
    public object GPT()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.GPT.Solver.TriangleArea(a, b, c);
        }
        return result;
    }

    [Benchmark]
    public object Gemini()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.Gemini.Solver.TriangleArea(a, b, c);
        }
        return result;
    }

    [Benchmark]
    public object Claude()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.Claude.Solver.TriangleArea(a, b, c);
        }
        return result;
    }

    [Benchmark]
    public object Grok()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.Grok.Solver.TriangleArea(a, b, c);
        }
        return result;
    }

    [Benchmark]
    public object Mistral()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.Mistral.Solver.TriangleArea(a, b, c);
        }
        return result;
    }

    [Benchmark]
    public object DeepSeek()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.DeepSeek.Solver.TriangleArea(a, b, c);
        }
        return result;
    }

    [Benchmark]
    public object Llama()
    {
        object result = null;
        foreach (var (a, b, c) in _data)
        {
            result = Benchmarks.csharp_29.Llama.Solver.TriangleArea(a, b, c);
        }
        return result;
    }
}

}