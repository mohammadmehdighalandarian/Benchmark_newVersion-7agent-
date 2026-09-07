using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_31
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
        // Use a value less than 100 that is NOT the product of exactly
        // three primes and typically forces full search/exhaustive checking.
        // 97 is prime and should require complete evaluation.
        _data = 97;
    }

    [Benchmark(Baseline = true)]
    public bool GPT()
    {
        return Benchmarks.csharp_31.GPT.Solver.IsMultiplyPrime(_data);
    }

    [Benchmark]
    public bool Gemini()
    {
        return Benchmarks.csharp_31.Gemini.Solver.IsMultiplyPrime(_data);
    }

    [Benchmark]
    public bool Claude()
    {
        return Benchmarks.csharp_31.Claude.Solver.IsMultiplyPrime(_data);
    }

    [Benchmark]
    public bool Grok()
    {
        return Benchmarks.csharp_31.Grok.Solver.IsMultiplyPrime(_data);
    }

    [Benchmark]
    public bool Mistral()
    {
        return Benchmarks.csharp_31.Mistral.Solver.IsMultiplyPrime(_data);
    }

    [Benchmark]
    public bool DeepSeek()
    {
        return Benchmarks.csharp_31.DeepSeek.Solver.IsMultiplyPrime(_data);
    }

    [Benchmark]
    public bool Llama()
    {
        return Benchmarks.csharp_31.Llama.Solver.IsMultiplyPrime(_data);
    }
}

}