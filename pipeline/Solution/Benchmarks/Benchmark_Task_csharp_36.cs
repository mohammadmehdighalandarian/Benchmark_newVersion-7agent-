using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_36
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
        // Worst-case input within constraints:
        // Maximum allowed value forces all digit-processing logic
        // to examine every digit and produce the largest binary output.
        _data = 9999;
    }

    [Benchmark(Baseline = true)]
    public string GPT()
    {
        return Benchmarks.csharp_36.GPT.Solver.Solve(_data);
    }

    [Benchmark]
    public string Gemini()
    {
        return Benchmarks.csharp_36.Gemini.Solver.Solve(_data);
    }

    [Benchmark]
    public string Claude()
    {
        return Benchmarks.csharp_36.Claude.Solver.Solve(_data);
    }

    [Benchmark]
    public string Grok()
    {
        return Benchmarks.csharp_36.Grok.Solver.Solve(_data);
    }

    [Benchmark]
    public string Mistral()
    {
        return Benchmarks.csharp_36.Mistral.Solver.Solve(_data);
    }

    [Benchmark]
    public string DeepSeek()
    {
        return Benchmarks.csharp_36.DeepSeek.Solver.Solve(_data);
    }

    [Benchmark]
    public string Llama()
    {
        return Benchmarks.csharp_36.Llama.Solver.Solve(_data);
    }
}

}