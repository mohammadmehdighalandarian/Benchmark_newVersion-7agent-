using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_57
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
            // Worst-case: use a large N to force computation of the full Tribonacci sequence
            // The function computes all values from 0..n, so largest N forces maximum work
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public List<object> GPT() =>
            Benchmarks.csharp_57.GPT.Solver.Tri(_data);

        [Benchmark]
        public List<object> Gemini() =>
            Benchmarks.csharp_57.Gemini.Solver.Tri(_data);

        [Benchmark]
        public List<object> Claude() =>
            Benchmarks.csharp_57.Claude.Solver.Tri(_data);

        [Benchmark]
        public List<object> Grok() =>
            Benchmarks.csharp_57.Grok.Solver.Tri(_data);

        [Benchmark]
        public List<object> Mistral() =>
            Benchmarks.csharp_57.Mistral.Solver.Tri(_data);

        [Benchmark]
        public List<object> DeepSeek() =>
            Benchmarks.csharp_57.DeepSeek.Solver.Tri(_data);

        [Benchmark]
        public List<object> Llama() =>
            Benchmarks.csharp_57.Llama.Solver.Tri(_data);
    }
}