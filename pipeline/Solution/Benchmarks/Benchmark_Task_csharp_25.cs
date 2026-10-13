using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_25
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private List<int> _data;

    [GlobalSetup]
    public void Setup()
    {
        _data = new List<int>(N);

        for (int i = 0; i < N; i++)
        {
            _data.Add(i + 1);
        }
    }

    [Benchmark(Baseline = true)]
    public List<int> GPT()
    {
        return Benchmarks.csharp_25.GPT.Solver.Derivative(_data);
    }

    [Benchmark]
    public List<int> Gemini()
    {
        return Benchmarks.csharp_25.Gemini.Solver.Derivative(_data);
    }

    [Benchmark]
    public List<int> Claude()
    {
        return Benchmarks.csharp_25.Claude.Solver.Derivative(_data);
    }

    [Benchmark]
    public List<int> Grok()
    {
        return Benchmarks.csharp_25.Grok.Solver.Derivative(_data);
    }

    [Benchmark]
    public List<int> Mistral()
    {
        return Benchmarks.csharp_25.Mistral.Solver.Derivative(_data);
    }

    [Benchmark]
    public List<int> DeepSeek()
    {
        return Benchmarks.csharp_25.DeepSeek.Solver.Derivative(_data);
    }

    [Benchmark]
    public List<int> Llama()
    {
        return Benchmarks.csharp_25.Llama.Solver.Derivative(_data);
    }
}

}