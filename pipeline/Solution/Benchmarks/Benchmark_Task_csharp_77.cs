using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_77
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: string of length N with alternating upper/lower letters
            // so every character must be processed (case-swapped), no early exit.
            var chars = new char[N];
            for (int i = 0; i < N; i++)
            {
                chars[i] = (i % 2 == 0) ? 'a' : 'Z';
            }
            _data = new string(chars);
        }

        [Benchmark(Baseline = true)]
        public string GPT() => Benchmarks.csharp_77.GPT.Solver.Solve(_data);

        [Benchmark]
        public string Gemini() => Benchmarks.csharp_77.Gemini.Solver.Solve(_data);

        [Benchmark]
        public string Claude() => Benchmarks.csharp_77.Claude.Solver.Solve(_data);

        [Benchmark]
        public string Grok() => Benchmarks.csharp_77.Grok.Solver.Solve(_data);

        [Benchmark]
        public string Mistral() => Benchmarks.csharp_77.Mistral.Solver.Solve(_data);

        [Benchmark]
        public string DeepSeek() => Benchmarks.csharp_77.DeepSeek.Solver.Solve(_data);

        [Benchmark]
        public string Llama() => Benchmarks.csharp_77.Llama.Solver.Solve(_data);
    }
}