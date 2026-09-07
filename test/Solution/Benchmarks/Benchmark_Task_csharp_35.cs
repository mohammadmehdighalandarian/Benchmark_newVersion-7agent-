using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_35
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private string _data;

    [GlobalSetup]
    public void Setup()
    {
        // Worst-case scenario:
        // Use a string length that is NOT prime and large enough to force
        // divisor checking work. N values (100,1000,10000) are all non-prime.
        _data = new string('a', N);
    }

    [Benchmark(Baseline = true)]
    public bool GPT()
    {
        return Benchmarks.csharp_35.GPT.Solver.PrimeLength(_data);
    }

    [Benchmark]
    public bool Gemini()
    {
        return Benchmarks.csharp_35.Gemini.Solver.PrimeLength(_data);
    }

    [Benchmark]
    public bool Claude()
    {
        return Benchmarks.csharp_35.Claude.Solver.PrimeLength(_data);
    }

    [Benchmark]
    public bool Grok()
    {
        return Benchmarks.csharp_35.Grok.Solver.PrimeLength(_data);
    }

    [Benchmark]
    public bool Mistral()
    {
        return Benchmarks.csharp_35.Mistral.Solver.PrimeLength(_data);
    }

    [Benchmark]
    public bool DeepSeek()
    {
        return Benchmarks.csharp_35.DeepSeek.Solver.PrimeLength(_data);
    }

    [Benchmark]
    public bool Llama()
    {
        return Benchmarks.csharp_35.Llama.Solver.PrimeLength(_data);
    }
}

}