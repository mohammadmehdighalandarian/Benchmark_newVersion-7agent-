using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_56
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<(List<int>, List<int>)> _data;

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _data = new List<(List<int>, List<int>)>(N);

            for (int i = 0; i < N; i++)
            {
                // Worst-case: intervals that intersect and produce a prime-length intersection
                // Intersection length of 2 (prime): e.g., interval1=[-5,5], interval2=[-3,-1] => intersection [-3,-1], length=2
                // Vary to ensure full processing with prime and non-prime results
                int start1 = rng.Next(-100, 0);
                int end1 = rng.Next(start1 + 4, start1 + 20);
                int start2 = start1 + 1;
                int end2 = start2 + 2; // intersection length = 2 (prime), forces full computation

                _data.Add((new List<int> { start1, end1 }, new List<int> { start2, end2 }));
            }
        }

        [Benchmark(Baseline = true)]
        public string GPT()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.GPT.Solver.Intersection(a, b);
            return result;
        }

        [Benchmark]
        public string Gemini()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.Gemini.Solver.Intersection(a, b);
            return result;
        }

        [Benchmark]
        public string Claude()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.Claude.Solver.Intersection(a, b);
            return result;
        }

        [Benchmark]
        public string Grok()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.Grok.Solver.Intersection(a, b);
            return result;
        }

        [Benchmark]
        public string Mistral()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.Mistral.Solver.Intersection(a, b);
            return result;
        }

        [Benchmark]
        public string DeepSeek()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.DeepSeek.Solver.Intersection(a, b);
            return result;
        }

        [Benchmark]
        public string Llama()
        {
            string result = null;
            foreach (var (a, b) in _data)
                result = Benchmarks.csharp_56.Llama.Solver.Intersection(a, b);
            return result;
        }
    }
}