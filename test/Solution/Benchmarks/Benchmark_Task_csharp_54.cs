using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_54
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<int> _data;
        private int _k;

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _data = new List<int>(N);
            // Worst-case: all elements distinct and spread across range, k = N (must process all)
            for (int i = 0; i < N; i++)
            {
                _data.Add(rng.Next(-1000, 1001));
            }
            _k = N; // k = N forces processing of all elements to find all maximums
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT()
        {
            return Benchmarks.csharp_54.GPT.Solver.Maximum(_data, _k);
        }

        [Benchmark]
        public List<int> Gemini()
        {
            return Benchmarks.csharp_54.Gemini.Solver.Maximum(_data, _k);
        }

        [Benchmark]
        public List<int> Claude()
        {
            return Benchmarks.csharp_54.Claude.Solver.Maximum(_data, _k);
        }

        [Benchmark]
        public List<int> Grok()
        {
            return Benchmarks.csharp_54.Grok.Solver.Maximum(_data, _k);
        }

        [Benchmark]
        public List<int> Mistral()
        {
            return Benchmarks.csharp_54.Mistral.Solver.Maximum(_data, _k);
        }

        [Benchmark]
        public List<int> DeepSeek()
        {
            return Benchmarks.csharp_54.DeepSeek.Solver.Maximum(_data, _k);
        }

        [Benchmark]
        public List<int> Llama()
        {
            return Benchmarks.csharp_54.Llama.Solver.Maximum(_data, _k);
        }
    }
}