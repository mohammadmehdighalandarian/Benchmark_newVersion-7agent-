using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.csharp_15
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<int> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: large unsorted list forcing full sort of N elements
            // Use a reverse-sorted list to maximize comparison operations in sorting
            _data = Enumerable.Range(1, N).Select(i => N - i + 1).ToList();
        }

        [Benchmark(Baseline = true)]
        public object GPT() => Benchmarks.csharp_15.GPT.Solver.Median(_data);

        [Benchmark]
        public object Gemini() => Benchmarks.csharp_15.Gemini.Solver.Median(_data);

        [Benchmark]
        public object Claude() => Benchmarks.csharp_15.Claude.Solver.Median(_data);

        [Benchmark]
        public object Grok() => Benchmarks.csharp_15.Grok.Solver.Median(_data);

        [Benchmark]
        public object Mistral() => Benchmarks.csharp_15.Mistral.Solver.Median(_data);

        [Benchmark]
        public object DeepSeek() => Benchmarks.csharp_15.DeepSeek.Solver.Median(_data);

        [Benchmark]
        public object Llama() => Benchmarks.csharp_15.Llama.Solver.Median(_data);
    }
}