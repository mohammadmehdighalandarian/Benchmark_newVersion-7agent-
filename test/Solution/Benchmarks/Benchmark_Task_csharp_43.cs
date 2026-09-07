using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_43
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: large N forces processing all N levels
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT() => Benchmarks.csharp_43.GPT.Solver.MakeAPile(_data);

        [Benchmark]
        public List<int> Gemini() => Benchmarks.csharp_43.Gemini.Solver.MakeAPile(_data);

        [Benchmark]
        public List<int> Claude() => Benchmarks.csharp_43.Claude.Solver.MakeAPile(_data);

        [Benchmark]
        public List<int> Grok() => Benchmarks.csharp_43.Grok.Solver.MakeAPile(_data);

        [Benchmark]
        public List<int> Mistral() => Benchmarks.csharp_43.Mistral.Solver.MakeAPile(_data);

        [Benchmark]
        public List<int> DeepSeek() => Benchmarks.csharp_43.DeepSeek.Solver.MakeAPile(_data);

        [Benchmark]
        public List<int> Llama() => Benchmarks.csharp_43.Llama.Solver.MakeAPile(_data);
    }
}