using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_26
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
        // Worst-case input: large n forces full computation.
        _data = N;
    }

    [Benchmark(Baseline = true)]
    public int GPT()
    {
        return Benchmarks.csharp_26.GPT.Solver.Fibfib(_data);
    }

    [Benchmark]
    public int Gemini()
    {
        return Benchmarks.csharp_26.Gemini.Solver.Fibfib(_data);
    }

    [Benchmark]
    public int Claude()
    {
        return Benchmarks.csharp_26.Claude.Solver.Fibfib(_data);
    }

    [Benchmark]
    public int Grok()
    {
        return Benchmarks.csharp_26.Grok.Solver.Fibfib(_data);
    }

    [Benchmark]
    public int Mistral()
    {
        return Benchmarks.csharp_26.Mistral.Solver.Fibfib(_data);
    }

    [Benchmark]
    public int DeepSeek()
    {
        return Benchmarks.csharp_26.DeepSeek.Solver.Fibfib(_data);
    }

    [Benchmark]
    public int Llama()
    {
        return Benchmarks.csharp_26.Llama.Solver.Fibfib(_data);
    }
}

}