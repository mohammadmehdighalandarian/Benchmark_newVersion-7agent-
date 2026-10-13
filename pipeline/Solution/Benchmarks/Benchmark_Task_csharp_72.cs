using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_72
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<object> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: fill list with odd integers so every element is processed and contributes
            _data = new List<object>(N);
            for (int i = 0; i < N; i++)
            {
                // Use odd positive integers to maximize processing (no early exits, all qualify)
                _data.Add((object)(2 * i + 1));
            }
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_72.GPT.Solver.DoubleTheDifference(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_72.Gemini.Solver.DoubleTheDifference(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_72.Claude.Solver.DoubleTheDifference(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_72.Grok.Solver.DoubleTheDifference(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_72.Mistral.Solver.DoubleTheDifference(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_72.DeepSeek.Solver.DoubleTheDifference(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_72.Llama.Solver.DoubleTheDifference(_data);
    }
}