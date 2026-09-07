using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_2
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
    [Params(10,100)] 
public int N { get; set; }


    private (string a, string b) _data;

    [GlobalSetup]
    public void Setup()
    {
        var a = new string('1', N);
        var b = new string('0', N);
        _data = (a, b);
    }

    [Benchmark(Baseline = true)]
    public string GPT()
    {
        return Benchmarks.csharp_2.GPT.Solver.StringXor(_data.a, _data.b);
    }

    [Benchmark]
    public string Gemini()
    {
        return Benchmarks.csharp_2.Gemini.Solver.StringXor(_data.a, _data.b);
    }

    [Benchmark]
    public string Claude()
    {
        return Benchmarks.csharp_2.Claude.Solver.StringXor(_data.a, _data.b);
    }

    [Benchmark]
    public string Grok()
    {
        return Benchmarks.csharp_2.Grok.Solver.StringXor(_data.a, _data.b);
    }

    [Benchmark]
    public string Mistral()
    {
        return Benchmarks.csharp_2.Mistral.Solver.StringXor(_data.a, _data.b);
    }

    [Benchmark]
    public string DeepSeek()
    {
        return Benchmarks.csharp_2.DeepSeek.Solver.StringXor(_data.a, _data.b);
    }

    [Benchmark]
    public string Llama()
    {
        return Benchmarks.csharp_2.Llama.Solver.StringXor(_data.a, _data.b);
    }
}


}