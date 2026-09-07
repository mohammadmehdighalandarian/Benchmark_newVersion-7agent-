using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_19
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _x;
        private int _y;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case scenario: use the largest possible values
            // to maximize any potential computation overhead.
            _x = N;
            _y = N;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_19.GPT.Solver.Add(_x, _y);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_19.Gemini.Solver.Add(_x, _y);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_19.Claude.Solver.Add(_x, _y);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_19.Grok.Solver.Add(_x, _y);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_19.Mistral.Solver.Add(_x, _y);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_19.DeepSeek.Solver.Add(_x, _y);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_19.Llama.Solver.Add(_x, _y);
    }
}