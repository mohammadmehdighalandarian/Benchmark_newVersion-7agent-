using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_27
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private string _data = string.Empty;

    [GlobalSetup]
    public void Setup()
    {
        // Worst-case input:
        // Long string requiring full traversal with only the final character
        // being a vowel ('y' counts only at the end).
        _data = new string('b', N - 1) + "y";
    }

    [Benchmark(Baseline = true)]
    public int GPT()
    {
        return Benchmarks.csharp_27.GPT.Solver.VowelsCount(_data);
    }

    [Benchmark]
    public int Gemini()
    {
        return Benchmarks.csharp_27.Gemini.Solver.VowelsCount(_data);
    }

    [Benchmark]
    public int Claude()
    {
        return Benchmarks.csharp_27.Claude.Solver.VowelsCount(_data);
    }

    [Benchmark]
    public int Grok()
    {
        return Benchmarks.csharp_27.Grok.Solver.VowelsCount(_data);
    }

    [Benchmark]
    public int Mistral()
    {
        return Benchmarks.csharp_27.Mistral.Solver.VowelsCount(_data);
    }

    [Benchmark]
    public int DeepSeek()
    {
        return Benchmarks.csharp_27.DeepSeek.Solver.VowelsCount(_data);
    }

    [Benchmark]
    public int Llama()
    {
        return Benchmarks.csharp_27.Llama.Solver.VowelsCount(_data);
    }
}

}