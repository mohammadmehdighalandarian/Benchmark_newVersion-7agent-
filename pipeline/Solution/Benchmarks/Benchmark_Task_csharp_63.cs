using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_63
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
            // Worst-case: interleaved negatives and positives spread across all N elements,
            // so every element must be examined to find the true largest negative and smallest positive.
            // We also ensure the largest negative and smallest positive are at the very end.
            _data = new List<int>(N);
            for (int i = 0; i < N - 2; i++)
            {
                if (i % 2 == 0)
                    _data.Add(-(i + 10));  // large-magnitude negatives (not the largest negative)
                else
                    _data.Add(i + 10);     // large positives (not the smallest positive)
            }
            // Place the actual answers at the end to force full traversal
            _data.Add(-1);  // largest negative
            _data.Add(1);   // smallest positive
        }

        [Benchmark(Baseline = true)]
        public List<object> GPT() =>
            Benchmarks.csharp_63.GPT.Solver.LargestSmallestIntegers(_data);

        [Benchmark]
        public List<object> Gemini() =>
            Benchmarks.csharp_63.Gemini.Solver.LargestSmallestIntegers(_data);

        [Benchmark]
        public List<object> Claude() =>
            Benchmarks.csharp_63.Claude.Solver.LargestSmallestIntegers(_data);

        [Benchmark]
        public List<object> Grok() =>
            Benchmarks.csharp_63.Grok.Solver.LargestSmallestIntegers(_data);

        [Benchmark]
        public List<object> Mistral() =>
            Benchmarks.csharp_63.Mistral.Solver.LargestSmallestIntegers(_data);

        [Benchmark]
        public List<object> DeepSeek() =>
            Benchmarks.csharp_63.DeepSeek.Solver.LargestSmallestIntegers(_data);

        [Benchmark]
        public List<object> Llama() =>
            Benchmarks.csharp_63.Llama.Solver.LargestSmallestIntegers(_data);
    }
}