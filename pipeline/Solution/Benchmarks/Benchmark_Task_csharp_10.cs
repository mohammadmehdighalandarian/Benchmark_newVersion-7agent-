using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_10
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
            // Worst-case scenario: generate N elements where all are unique and spread across a wide range,
            // forcing all solvers to process every element, sort, and deduplicate the full list.
            // We also add duplicates in a pattern that ensures the entire list must be scanned.
            _data = new List<int>(N * 2);
            for (int i = 0; i < N; i++)
            {
                _data.Add(i);         // unique value
                _data.Add(i / 2);     // duplicate to force dedup work
            }
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT()
        {
            return Benchmarks.csharp_10.GPT.Solver.Unique(_data);
        }

        [Benchmark]
        public List<int> Gemini()
        {
            return Benchmarks.csharp_10.Gemini.Solver.Unique(_data);
        }

        [Benchmark]
        public List<int> Claude()
        {
            return Benchmarks.csharp_10.Claude.Solver.Unique(_data);
        }

        [Benchmark]
        public List<int> Grok()
        {
            return Benchmarks.csharp_10.Grok.Solver.Unique(_data);
        }

        [Benchmark]
        public List<int> Mistral()
        {
            return Benchmarks.csharp_10.Mistral.Solver.Unique(_data);
        }

        [Benchmark]
        public List<int> DeepSeek()
        {
            return Benchmarks.csharp_10.DeepSeek.Solver.Unique(_data);
        }

        [Benchmark]
        public List<int> Llama()
        {
            return Benchmarks.csharp_10.Llama.Solver.Unique(_data);
        }
    }
}