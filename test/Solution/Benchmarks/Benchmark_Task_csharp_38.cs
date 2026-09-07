using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_38
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
            // Worst-case: all elements are distinct and sorted descending,
            // so every algorithm must scan all N elements to find the 2nd smallest.
            // The smallest is at the very end, and the 2nd smallest is one before it.
            _data = Enumerable.Range(0, N).Select(i => N - i).ToList();
        }

        [Benchmark(Baseline = true)]
        public object GPT() => Benchmarks.csharp_38.GPT.Solver.NextSmallest(_data);

        [Benchmark]
        public object Gemini() => Benchmarks.csharp_38.Gemini.Solver.NextSmallest(_data);

        [Benchmark]
        public object Claude() => Benchmarks.csharp_38.Claude.Solver.NextSmallest(_data);

        [Benchmark]
        public object Grok() => Benchmarks.csharp_38.Grok.Solver.NextSmallest(_data);

        [Benchmark]
        public object Mistral() => Benchmarks.csharp_38.Mistral.Solver.NextSmallest(_data);

        [Benchmark]
        public object DeepSeek() => Benchmarks.csharp_38.DeepSeek.Solver.NextSmallest(_data);

        [Benchmark]
        public object Llama() => Benchmarks.csharp_38.Llama.Solver.NextSmallest(_data);
    }
}