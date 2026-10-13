using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_47
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
            // Worst-case: use N directly so the function must compute all N elements,
            // including large factorials and sums, forcing full traversal.
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT() =>
            Benchmarks.csharp_47.GPT.Solver.F(_data);

        [Benchmark]
        public List<int> Gemini() =>
            Benchmarks.csharp_47.Gemini.Solver.F(_data);

        [Benchmark]
        public List<int> Claude() =>
            Benchmarks.csharp_47.Claude.Solver.F(_data);

        [Benchmark]
        public List<int> Grok() =>
            Benchmarks.csharp_47.Grok.Solver.F(_data);

        [Benchmark]
        public List<int> Mistral() =>
            Benchmarks.csharp_47.Mistral.Solver.F(_data);

        [Benchmark]
        public List<int> DeepSeek() =>
            Benchmarks.csharp_47.DeepSeek.Solver.F(_data);

        [Benchmark]
        public List<int> Llama() =>
            Benchmarks.csharp_47.Llama.Solver.F(_data);
    }
}