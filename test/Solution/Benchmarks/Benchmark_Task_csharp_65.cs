using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_65
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
            // Worst-case: N words, all with non-prime lengths (e.g., length 4 = "abcd"),
            // except the very last word which has a prime length (e.g., length 2 = "ab").
            // This forces the solver to iterate through all N words before finding a prime-length word.
            // Word of length 4: "word" (4 = 2*2, not prime)
            // Word of length 2: "ab" (2 = prime)
            var words = new List<string>(N);
            for (int i = 0; i < N - 1; i++)
            {
                words.Add("abcd"); // length 4, not prime
            }
            words.Add("ab"); // length 2, prime — only match, at the end
            _data = string.Join(" ", words);
        }

        [Benchmark(Baseline = true)]
        public string GPT() =>
            Benchmarks.csharp_65.GPT.Solver.WordsInSentence(_data);

        [Benchmark]
        public string Gemini() =>
            Benchmarks.csharp_65.Gemini.Solver.WordsInSentence(_data);

        [Benchmark]
        public string Claude() =>
            Benchmarks.csharp_65.Claude.Solver.WordsInSentence(_data);

        [Benchmark]
        public string Grok() =>
            Benchmarks.csharp_65.Grok.Solver.WordsInSentence(_data);

        [Benchmark]
        public string Mistral() =>
            Benchmarks.csharp_65.Mistral.Solver.WordsInSentence(_data);

        [Benchmark]
        public string DeepSeek() =>
            Benchmarks.csharp_65.DeepSeek.Solver.WordsInSentence(_data);

        [Benchmark]
        public string Llama() =>
            Benchmarks.csharp_65.Llama.Solver.WordsInSentence(_data);
    }
}