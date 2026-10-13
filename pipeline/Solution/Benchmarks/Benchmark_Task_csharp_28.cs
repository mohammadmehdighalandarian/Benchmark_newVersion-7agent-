using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_28
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
private List<int> _data;

    [Params(10,100)]
    public int N { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _data = new List<int>(N);

        // Worst-case scenario:
        // Every value appears exactly once, forcing full traversal,
        // dictionary/group construction, and evaluation of all entries.
        // No value can satisfy frequency >= value, so result is -1.
        for (int i = 1; i <= N; i++)
        {
            _data.Add(i);
        }
    }

    [Benchmark(Baseline = true)]
    public int GPT()
    {
        return Benchmarks.csharp_28.GPT.Solver.Search(_data);
    }

    [Benchmark]
    public int Gemini()
    {
        return Benchmarks.csharp_28.Gemini.Solver.Search(_data);
    }

    [Benchmark]
    public int Claude()
    {
        return Benchmarks.csharp_28.Claude.Solver.Search(_data);
    }

    [Benchmark]
    public int Grok()
    {
        return Benchmarks.csharp_28.Grok.Solver.Search(_data);
    }

    [Benchmark]
    public int Mistral()
    {
        return Benchmarks.csharp_28.Mistral.Solver.Search(_data);
    }

    [Benchmark]
    public int DeepSeek()
    {
        return Benchmarks.csharp_28.DeepSeek.Solver.Search(_data);
    }

    [Benchmark]
    public int Llama()
    {
        return Benchmarks.csharp_28.Llama.Solver.Search(_data);
    }
}

}