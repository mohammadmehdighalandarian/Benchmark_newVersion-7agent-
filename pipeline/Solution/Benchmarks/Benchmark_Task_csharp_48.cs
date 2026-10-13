using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_48
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
            // Worst-case: use the maximum allowed value (1000) capped by N
            // This forces solvers to iterate through the full range up to min(N, 1000)
            _data = Math.Min(N, 1000);
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT() => Benchmarks.csharp_48.GPT.Solver.EvenOddPalindrome(_data);

        [Benchmark]
        public List<int> Gemini() => Benchmarks.csharp_48.Gemini.Solver.EvenOddPalindrome(_data);

        [Benchmark]
        public List<int> Claude() => Benchmarks.csharp_48.Claude.Solver.EvenOddPalindrome(_data);

        [Benchmark]
        public List<int> Grok() => Benchmarks.csharp_48.Grok.Solver.EvenOddPalindrome(_data);

        [Benchmark]
        public List<int> Mistral() => Benchmarks.csharp_48.Mistral.Solver.EvenOddPalindrome(_data);

        [Benchmark]
        public List<int> DeepSeek() => Benchmarks.csharp_48.DeepSeek.Solver.EvenOddPalindrome(_data);

        [Benchmark]
        public List<int> Llama() => Benchmarks.csharp_48.Llama.Solver.EvenOddPalindrome(_data);
    }
}