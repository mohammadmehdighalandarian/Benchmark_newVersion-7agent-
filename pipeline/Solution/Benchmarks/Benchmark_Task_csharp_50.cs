using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_50
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<int> _lst1;
        private List<int> _lst2;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: lst1 has N odd numbers, lst2 has exactly N even numbers
            // This forces solvers to scan all of lst1 and all of lst2 before concluding YES
            _lst1 = new List<int>(N);
            _lst2 = new List<int>(N);

            for (int i = 0; i < N; i++)
            {
                _lst1.Add(2 * i + 1); // all odd
                _lst2.Add(2 * i);     // all even
            }
        }

        [Benchmark(Baseline = true)]
        public string GPT() => Benchmarks.csharp_50.GPT.Solver.Exchange(_lst1, _lst2);

        [Benchmark]
        public string Gemini() => Benchmarks.csharp_50.Gemini.Solver.Exchange(_lst1, _lst2);

        [Benchmark]
        public string Claude() => Benchmarks.csharp_50.Claude.Solver.Exchange(_lst1, _lst2);

        [Benchmark]
        public string Grok() => Benchmarks.csharp_50.Grok.Solver.Exchange(_lst1, _lst2);

        [Benchmark]
        public string Mistral() => Benchmarks.csharp_50.Mistral.Solver.Exchange(_lst1, _lst2);

        [Benchmark]
        public string DeepSeek() => Benchmarks.csharp_50.DeepSeek.Solver.Exchange(_lst1, _lst2);

        [Benchmark]
        public string Llama() => Benchmarks.csharp_50.Llama.Solver.Exchange(_lst1, _lst2);
    }
}