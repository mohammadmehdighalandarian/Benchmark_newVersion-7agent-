using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_53
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _data;
        private int _n;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: generate N words each with exactly 4 consonants (e.g., "strk")
            // plus one word with a different count at the end, so all words must be examined.
            // We use n=3 consonants as our target, and generate words with 4 consonants
            // so none match — forcing full traversal of all N words.
            _n = 3;
            var consonantWord = "strng"; // 5 consonants - won't match n=3
            var words = new string[N];
            for (int i = 0; i < N - 1; i++)
                words[i] = consonantWord;
            // Last word matches to ensure we process everything
            words[N - 1] = "cat"; // 2 consonants — still no match for n=3; full scan happens
            _data = string.Join(" ", words);
        }

        [Benchmark(Baseline = true)]
        public List<string> GPT() =>
            Benchmarks.csharp_53.GPT.Solver.SelectWords(_data, _n);

        [Benchmark]
        public List<string> Gemini() =>
            Benchmarks.csharp_53.Gemini.Solver.SelectWords(_data, _n);

        [Benchmark]
        public List<string> Claude() =>
            Benchmarks.csharp_53.Claude.Solver.SelectWords(_data, _n);

        [Benchmark]
        public List<string> Grok() =>
            Benchmarks.csharp_53.Grok.Solver.SelectWords(_data, _n);

        [Benchmark]
        public List<string> Mistral() =>
            Benchmarks.csharp_53.Mistral.Solver.SelectWords(_data, _n);

        [Benchmark]
        public List<string> DeepSeek() =>
            Benchmarks.csharp_53.DeepSeek.Solver.SelectWords(_data, _n);

        [Benchmark]
        public List<string> Llama() =>
            Benchmarks.csharp_53.Llama.Solver.SelectWords(_data, _n);
    }
}