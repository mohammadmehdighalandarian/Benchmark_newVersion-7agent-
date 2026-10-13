using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_30
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private List<int> _data;
    private int _w;

    [GlobalSetup]
    public void Setup()
    {
        _data = new List<int>(N);

        for (int i = 0; i < N / 2; i++)
        {
            _data.Add(1);
        }

        if ((N & 1) == 1)
        {
            _data.Add(1);
        }

        for (int i = N / 2 - 1; i >= 0; i--)
        {
            _data.Add(1);
        }

        int sum = _data.Count;
        _w = sum;
    }

    [Benchmark(Baseline = true)]
    public bool GPT()
    {
        return Benchmarks.csharp_30.GPT.Solver.WillItFly(_data, _w);
    }

    [Benchmark]
    public bool Gemini()
    {
        return Benchmarks.csharp_30.Gemini.Solver.WillItFly(_data, _w);
    }

    [Benchmark]
    public bool Claude()
    {
        return Benchmarks.csharp_30.Claude.Solver.WillItFly(_data, _w);
    }

    [Benchmark]
    public bool Grok()
    {
        return Benchmarks.csharp_30.Grok.Solver.WillItFly(_data, _w);
    }

    [Benchmark]
    public bool Mistral()
    {
        return Benchmarks.csharp_30.Mistral.Solver.WillItFly(_data, _w);
    }

    [Benchmark]
    public bool DeepSeek()
    {
        return Benchmarks.csharp_30.DeepSeek.Solver.WillItFly(_data, _w);
    }

    [Benchmark]
    public bool Llama()
    {
        return Benchmarks.csharp_30.Llama.Solver.WillItFly(_data, _w);
    }
}

}