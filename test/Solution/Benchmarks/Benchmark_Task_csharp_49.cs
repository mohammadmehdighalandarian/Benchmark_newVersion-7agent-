using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_49
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
            // Worst-case: array that requires checking all elements.
            // A sorted array is trivially True (0 descent points), but to stress
            // solvers that iterate the full array, we use an array with exactly
            // one "wrap" descent at the very last position:
            // [2, 3, 4, ..., N, 1] — sorted ascending except the last element
            // is the minimum, forcing every solver to scan all N elements before
            // concluding there is exactly one descent point (=> True).
            _data = new List<int>(N);
            for (int i = 2; i <= N; i++)
                _data.Add(i);
            _data.Add(1);
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_49.GPT.Solver.MoveOneBall(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_49.Gemini.Solver.MoveOneBall(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_49.Claude.Solver.MoveOneBall(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_49.Grok.Solver.MoveOneBall(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_49.Mistral.Solver.MoveOneBall(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_49.DeepSeek.Solver.MoveOneBall(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_49.Llama.Solver.MoveOneBall(_data);
    }
}