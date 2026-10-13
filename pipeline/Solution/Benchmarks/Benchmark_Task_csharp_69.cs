using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_69
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
            // Worst-case: use N directly as the input size.
            // Larger N means more triples to check (O(n^3) brute force or O(n^2) optimized).
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_69.GPT.Solver.GetMaxTriples(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_69.Gemini.Solver.GetMaxTriples(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_69.Claude.Solver.GetMaxTriples(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_69.Grok.Solver.GetMaxTriples(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_69.Mistral.Solver.GetMaxTriples(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_69.DeepSeek.Solver.GetMaxTriples(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_69.Llama.Solver.GetMaxTriples(_data);
    }
}