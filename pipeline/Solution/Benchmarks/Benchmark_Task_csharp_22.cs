using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_22
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private List<int> _data1;
    private List<int> _data2;

    [GlobalSetup]
    public void Setup()
    {
        _data1 = new List<int>(N);
        _data2 = new List<int>(N);

        for (int i = 0; i < N; i++)
        {
            _data1.Add(i);
            _data2.Add(i + N);
        }

        _data2[N - 1] = N - 1;
    }

    [Benchmark(Baseline = true)]
    public List<int> GPT()
    {
        return Benchmarks.csharp_22.GPT.Solver.Common(_data1, _data2);
    }

    [Benchmark]
    public List<int> Gemini()
    {
        return Benchmarks.csharp_22.Gemini.Solver.Common(_data1, _data2);
    }

    [Benchmark]
    public List<int> Claude()
    {
        return Benchmarks.csharp_22.Claude.Solver.Common(_data1, _data2);
    }

    [Benchmark]
    public List<int> Grok()
    {
        return Benchmarks.csharp_22.Grok.Solver.Common(_data1, _data2);
    }

    [Benchmark]
    public List<int> Mistral()
    {
        return Benchmarks.csharp_22.Mistral.Solver.Common(_data1, _data2);
    }

    [Benchmark]
    public List<int> DeepSeek()
    {
        return Benchmarks.csharp_22.DeepSeek.Solver.Common(_data1, _data2);
    }

    [Benchmark]
    public List<int> Llama()
    {
        return Benchmarks.csharp_22.Llama.Solver.Common(_data1, _data2);
    }
}

}