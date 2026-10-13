using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_20
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _s0;
        private string _s1;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: both strings share exactly the same unique characters,
            // so no early exit is possible — solver must process all characters.
            // Build strings of length N with identical character sets but different distributions.
            // Use all 26 lowercase letters to maximize hash-set work.
            var sb0 = new System.Text.StringBuilder();
            var sb1 = new System.Text.StringBuilder();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            // Fill s0: repeat alphabet chars to reach length N
            for (int i = 0; i < N; i++)
                sb0.Append(alphabet[i % alphabet.Length]);

            // Fill s1: reverse order repetition — same unique chars, different distribution
            for (int i = 0; i < N; i++)
                sb1.Append(alphabet[(alphabet.Length - 1) - (i % alphabet.Length)]);

            _s0 = sb0.ToString();
            _s1 = sb1.ToString();
        }

        [Benchmark(Baseline = true)]
        public bool GPT() =>
            Benchmarks.csharp_20.GPT.Solver.SameChars(_s0, _s1);

        [Benchmark]
        public bool Gemini() =>
            Benchmarks.csharp_20.Gemini.Solver.SameChars(_s0, _s1);

        [Benchmark]
        public bool Claude() =>
            Benchmarks.csharp_20.Claude.Solver.SameChars(_s0, _s1);

        [Benchmark]
        public bool Grok() =>
            Benchmarks.csharp_20.Grok.Solver.SameChars(_s0, _s1);

        [Benchmark]
        public bool Mistral() =>
            Benchmarks.csharp_20.Mistral.Solver.SameChars(_s0, _s1);

        [Benchmark]
        public bool DeepSeek() =>
            Benchmarks.csharp_20.DeepSeek.Solver.SameChars(_s0, _s1);

        [Benchmark]
        public bool Llama() =>
            Benchmarks.csharp_20.Llama.Solver.SameChars(_s0, _s1);
    }
}