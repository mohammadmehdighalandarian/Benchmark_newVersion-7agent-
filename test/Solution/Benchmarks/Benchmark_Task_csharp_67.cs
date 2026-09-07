using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_67
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<int> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: generate N integers where digit sums are all distinct and spread out,
            // forcing the sort to compare and reorder all N elements.
            // We use numbers with varying digit sums (including negatives) to maximize comparison work.
            _data = new List<int>(N);
            var rng = new System.Random(42);
            for (int i = 0; i < N; i++)
            {
                // Mix of positive and negative numbers with varied digit sums
                // to prevent early exit and force full sort traversal
                int val = rng.Next(-9999, 10000);
                if (val == 0) val = 1;
                _data.Add(val);
            }
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT() =>
            Benchmarks.csharp_67.GPT.Solver.OrderByPoints(_data);

        [Benchmark]
        public List<int> Gemini() =>
            Benchmarks.csharp_67.Gemini.Solver.OrderByPoints(_data);

        [Benchmark]
        public List<int> Claude() =>
            Benchmarks.csharp_67.Claude.Solver.OrderByPoints(_data);

        [Benchmark]
        public List<int> Grok() =>
            Benchmarks.csharp_67.Grok.Solver.OrderByPoints(_data);

        [Benchmark]
        public List<int> Mistral() =>
            Benchmarks.csharp_67.Mistral.Solver.OrderByPoints(_data);

        [Benchmark]
        public List<int> DeepSeek() =>
            Benchmarks.csharp_67.DeepSeek.Solver.OrderByPoints(_data);

        [Benchmark]
        public List<int> Llama() =>
            Benchmarks.csharp_67.Llama.Solver.OrderByPoints(_data);
    }
}