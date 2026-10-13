using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_1
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{ [Params(10,100)]
public int N { get; set; }


    private List<int> _data;

    [GlobalSetup]
    public void Setup()
    {
        _data = new List<int>(N);

        for (int i = 0; i < N; i++)
        {
            _data.Add(1);
        }
    }

    [Benchmark(Baseline = true)]
    public object GPT()
    {
        return Benchmarks.csharp_1.GPT.Solver.SumProduct(_data);
    }

    [Benchmark]
    public object Gemini()
    {
        return Benchmarks.csharp_1.Gemini.Solver.SumProduct(_data);
    }

    [Benchmark]
    public object Claude()
    {
        return Benchmarks.csharp_1.Claude.Solver.SumProduct(_data);
    }

    [Benchmark]
    public object Grok()
    {
        return Benchmarks.csharp_1.Grok.Solver.SumProduct(_data);
    }

    [Benchmark]
    public object Mistral()
    {
        return Benchmarks.csharp_1.Mistral.Solver.SumProduct(_data);
    }

    [Benchmark]
    public object DeepSeek()
    {
        return Benchmarks.csharp_1.DeepSeek.Solver.SumProduct(_data);
    }

    [Benchmark]
    public object Llama()
    {
        return Benchmarks.csharp_1.Llama.Solver.SumProduct(_data);
    }
}


}