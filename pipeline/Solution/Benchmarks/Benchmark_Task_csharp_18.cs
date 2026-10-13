using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_18
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<int> _data;
        private int _threshold;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: all numbers are below threshold except the very last one,
            // forcing every solver to iterate through the entire list before returning false.
            _threshold = 50;
            _data = new List<int>(N);
            for (int i = 0; i < N - 1; i++)
            {
                _data.Add(1); // all below threshold
            }
            _data.Add(_threshold); // last element equals threshold, triggering false at the end
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_18.GPT.Solver.BelowThreshold(_data, _threshold);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_18.Gemini.Solver.BelowThreshold(_data, _threshold);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_18.Claude.Solver.BelowThreshold(_data, _threshold);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_18.Grok.Solver.BelowThreshold(_data, _threshold);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_18.Mistral.Solver.BelowThreshold(_data, _threshold);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_18.DeepSeek.Solver.BelowThreshold(_data, _threshold);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_18.Llama.Solver.BelowThreshold(_data, _threshold);
    }
}