using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_23
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
        // Worst-case scenario:
        // Use a large composite number with a large prime factor so that
        // factorization algorithms must perform substantial work before
        // discovering the largest prime factor.
        int candidate = N switch
        {
            100 => 9991 * 97,
            1000 => 9973 * 89,
            _ => 9949 * 83
        };

        _data = candidate;
    }

    [Benchmark(Baseline = true)]
    public int GPT()
    {
        return Benchmarks.csharp_23.GPT.Solver.LargestPrimeFactor(_data);
    }

    [Benchmark]
    public int Gemini()
    {
        return Benchmarks.csharp_23.Gemini.Solver.LargestPrimeFactor(_data);
    }

    [Benchmark]
    public int Claude()
    {
        return Benchmarks.csharp_23.Claude.Solver.LargestPrimeFactor(_data);
    }

    [Benchmark]
    public int Grok()
    {
        return Benchmarks.csharp_23.Grok.Solver.LargestPrimeFactor(_data);
    }

    [Benchmark]
    public int Mistral()
    {
        return Benchmarks.csharp_23.Mistral.Solver.LargestPrimeFactor(_data);
    }

    [Benchmark]
    public int DeepSeek()
    {
        return Benchmarks.csharp_23.DeepSeek.Solver.LargestPrimeFactor(_data);
    }

    [Benchmark]
    public int Llama()
    {
        return Benchmarks.csharp_23.Llama.Solver.LargestPrimeFactor(_data);
    }
}

}