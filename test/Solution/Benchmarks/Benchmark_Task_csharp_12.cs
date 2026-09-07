using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using System.Collections.Generic;

namespace Benchmarks.csharp_12
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
            // Worst-case: no three elements sum to zero.
            // Use all positive distinct integers so no triple can sum to zero,
            // forcing every algorithm to exhaust all combinations before returning false.
            _data = new List<int>(N);
            for (int i = 1; i <= N; i++)
            {
                _data.Add(i);
            }
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_12.GPT.Solver.TriplesSumToZero(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_12.Gemini.Solver.TriplesSumToZero(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_12.Claude.Solver.TriplesSumToZero(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_12.Grok.Solver.TriplesSumToZero(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_12.Mistral.Solver.TriplesSumToZero(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_12.DeepSeek.Solver.TriplesSumToZero(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_12.Llama.Solver.TriplesSumToZero(_data);
    }
}