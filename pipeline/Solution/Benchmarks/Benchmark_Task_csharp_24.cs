using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_24
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private int _data;

    [GlobalSetup]
    public void Setup()
    {
        _data = N;
    }

    [Benchmark(Baseline = true)]
    public int GPT()
    {
        return Benchmarks.csharp_24.GPT.Solver.SumToN(_data);
    }

    [Benchmark]
    public int Gemini()
    {
        return Benchmarks.csharp_24.Gemini.Solver.SumToN(_data);
    }

    [Benchmark]
    public int Claude()
    {
        return Benchmarks.csharp_24.Claude.Solver.SumToN(_data);
    }

    [Benchmark]
    public int Grok()
    {
        return Benchmarks.csharp_24.Grok.Solver.SumToN(_data);
    }

    [Benchmark]
    public int Mistral()
    {
        return Benchmarks.csharp_24.Mistral.Solver.SumToN(_data);
    }

    [Benchmark]
    public int DeepSeek()
    {
        return Benchmarks.csharp_24.DeepSeek.Solver.SumToN(_data);
    }

    [Benchmark]
    public int Llama()
    {
        return Benchmarks.csharp_24.Llama.Solver.SumToN(_data);
    }
}

}