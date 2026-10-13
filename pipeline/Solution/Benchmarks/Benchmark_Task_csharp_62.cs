using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_62
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
            // Worst-case scenario: strictly increasing sequence so no element violates the condition
            // until the very last element, which is less than its predecessor.
            // This forces the solver to scan all N elements.
            _data = new List<int>(N);
            for (int i = 0; i < N - 1; i++)
            {
                _data.Add(i * 2); // strictly increasing
            }
            // Last element is less than second-to-last, making index N-1 the answer
            _data.Add(_data[N - 2] - 1);
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_62.GPT.Solver.CanArrange(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_62.Gemini.Solver.CanArrange(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_62.Claude.Solver.CanArrange(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_62.Grok.Solver.CanArrange(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_62.Mistral.Solver.CanArrange(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_62.DeepSeek.Solver.CanArrange(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_62.Llama.Solver.CanArrange(_data);
    }
}