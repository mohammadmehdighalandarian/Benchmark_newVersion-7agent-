using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_0
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
            _data = new List<int>(N);

            for (int i = 0; i < N - 1; i++)
            {
                _data.Add(1);
            }

            _data.Add(-(N + 1));
        }

        [Benchmark(Baseline = true)]
        public bool GPT()
        {
            return Benchmarks.csharp_0.GPT.Solver.BelowZero(_data);
        }

        [Benchmark]
        public bool Gemini()
        {
            return Benchmarks.csharp_0.Gemini.Solver.BelowZero(_data);
        }

        [Benchmark]
        public bool Claude()
        {
            return Benchmarks.csharp_0.Claude.Solver.BelowZero(_data);
        }

        [Benchmark]
        public bool Grok()
        {
            return Benchmarks.csharp_0.Grok.Solver.BelowZero(_data);
        }

        [Benchmark]
        public bool Mistral()
        {
            return Benchmarks.csharp_0.Mistral.Solver.BelowZero(_data);
        }

        [Benchmark]
        public bool DeepSeek()
        {
            return Benchmarks.csharp_0.DeepSeek.Solver.BelowZero(_data);
        }

        [Benchmark]
        public bool Llama()
        {
            return Benchmarks.csharp_0.Llama.Solver.BelowZero(_data);
        }
    }
}