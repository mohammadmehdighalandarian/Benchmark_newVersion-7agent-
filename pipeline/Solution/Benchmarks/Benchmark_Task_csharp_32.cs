using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_32
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
        // Worst-case input: largest positive int produces the longest
        // binary representation for an int and maximizes processing work.
        _data = int.MaxValue;
    }

    [Benchmark(Baseline = true)]
    public string GPT()
    {
        return Benchmarks.csharp_32.GPT.Solver.DecimalToBinary(_data);
    }

    [Benchmark]
    public string Gemini()
    {
        return Benchmarks.csharp_32.Gemini.Solver.DecimalToBinary(_data);
    }

    [Benchmark]
    public string Claude()
    {
        return Benchmarks.csharp_32.Claude.Solver.DecimalToBinary(_data);
    }

    [Benchmark]
    public string Grok()
    {
        return Benchmarks.csharp_32.Grok.Solver.DecimalToBinary(_data);
    }

    [Benchmark]
    public string Mistral()
    {
        return Benchmarks.csharp_32.Mistral.Solver.DecimalToBinary(_data);
    }

    [Benchmark]
    public string DeepSeek()
    {
        return Benchmarks.csharp_32.DeepSeek.Solver.DecimalToBinary(_data);
    }

    [Benchmark]
    public string Llama()
    {
        return Benchmarks.csharp_32.Llama.Solver.DecimalToBinary(_data);
    }
}

}