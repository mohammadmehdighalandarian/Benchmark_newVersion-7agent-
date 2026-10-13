using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using System.Collections.Generic;

namespace Benchmarks.csharp_13
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
            // Worst-case: no two elements sum to zero.
            // Use all positive integers 1..N so no pair can sum to zero.
            _data = new List<int>(N);
            for (int i = 1; i <= N; i++)
            {
                _data.Add(i);
            }
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_13.GPT.Solver.PairsSumToZero(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_13.Gemini.Solver.PairsSumToZero(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_13.Claude.Solver.PairsSumToZero(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_13.Grok.Solver.PairsSumToZero(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_13.Mistral.Solver.PairsSumToZero(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_13.DeepSeek.Solver.PairsSumToZero(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_13.Llama.Solver.PairsSumToZero(_data);
    }
}