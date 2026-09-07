using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_3
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)] 
        public int N { get; set; }

        private List<string> _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new List<string>(N);

            // Worst-case:
            // Longest string is the last element, forcing a full scan.
            for (int i = 0; i < N - 1; i++)
            {
                _data.Add("a");
            }

            _data.Add(new string('x', N + 1));
        }

        [Benchmark(Baseline = true)]
        public object GPT()
        {
            return Benchmarks.csharp_3.GPT.Solver.Longest(_data);
        }

        [Benchmark]
        public object Gemini()
        {
            return Benchmarks.csharp_3.Gemini.Solver.Longest(_data);
        }

        [Benchmark]
        public object Claude()
        {
            return Benchmarks.csharp_3.Claude.Solver.Longest(_data);
        }

        [Benchmark]
        public object Grok()
        {
            return Benchmarks.csharp_3.Grok.Solver.Longest(_data);
        }

        [Benchmark]
        public object Mistral()
        {
            return Benchmarks.csharp_3.Mistral.Solver.Longest(_data);
        }

        [Benchmark]
        public object DeepSeek()
        {
            return Benchmarks.csharp_3.DeepSeek.Solver.Longest(_data);
        }

        [Benchmark]
        public object Llama()
        {
            return Benchmarks.csharp_3.Llama.Solver.Longest(_data);
        }
    }
}