using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;
using System;

namespace Benchmarks.csharp_33
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
        // Worst-case happy string:
        // length >= 3 and every 3 consecutive characters are distinct,
        // forcing implementations to scan the entire string.
        char[] chars = new char[N];
        for (int i = 0; i < N; i++)
        {
            chars[i] = (char)('a' + (i % 3));
        }

        _data = new string(chars);
    }

    [Benchmark(Baseline = true)]
    public bool GPT()
    {
        return Benchmarks.csharp_33.GPT.Solver.IsHappy(_data);
    }

    [Benchmark]
    public bool Gemini()
    {
        return Benchmarks.csharp_33.Gemini.Solver.IsHappy(_data);
    }

    [Benchmark]
    public bool Claude()
    {
        return Benchmarks.csharp_33.Claude.Solver.IsHappy(_data);
    }

    [Benchmark]
    public bool Grok()
    {
        return Benchmarks.csharp_33.Grok.Solver.IsHappy(_data);
    }

    [Benchmark]
    public bool Mistral()
    {
        return Benchmarks.csharp_33.Mistral.Solver.IsHappy(_data);
    }

    [Benchmark]
    public bool DeepSeek()
    {
        return Benchmarks.csharp_33.DeepSeek.Solver.IsHappy(_data);
    }

    [Benchmark]
    public bool Llama()
    {
        return Benchmarks.csharp_33.Llama.Solver.IsHappy(_data);
    }
}

}