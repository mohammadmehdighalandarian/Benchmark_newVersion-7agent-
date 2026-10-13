using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_34
{
[MemoryDiagnoser]
[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkRunner
{
[Params(10,100)]
public int N { get; set; }

    private List<object> _data;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _data = new List<object>(N);

        // Worst-case: values that force all threshold comparisons
        // to fall through to the final branch (0.0 => E).
        for (int i = 0; i < N; i++)
        {
            _data.Add(0.0);
        }
    }

    [Benchmark(Baseline = true)]
    public List<string> GPT()
    {
        return Benchmarks.csharp_34.GPT.Solver.NumericalLetterGrade(_data);
    }

    [Benchmark]
    public List<string> Gemini()
    {
        return Benchmarks.csharp_34.Gemini.Solver.NumericalLetterGrade(_data);
    }

    [Benchmark]
    public List<string> Claude()
    {
        return Benchmarks.csharp_34.Claude.Solver.NumericalLetterGrade(_data);
    }

    [Benchmark]
    public List<string> Grok()
    {
        return Benchmarks.csharp_34.Grok.Solver.NumericalLetterGrade(_data);
    }

    [Benchmark]
    public List<string> Mistral()
    {
        return Benchmarks.csharp_34.Mistral.Solver.NumericalLetterGrade(_data);
    }

    [Benchmark]
    public List<string> DeepSeek()
    {
        return Benchmarks.csharp_34.DeepSeek.Solver.NumericalLetterGrade(_data);
    }

    [Benchmark]
    public List<string> Llama()
    {
        return Benchmarks.csharp_34.Llama.Solver.NumericalLetterGrade(_data);
    }
}

}