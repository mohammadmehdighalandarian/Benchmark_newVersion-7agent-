using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_61
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
            // Worst-case: a string with N/2 words separated by spaces,
            // ending with a single alphabetical character (returns True).
            // This forces solvers to scan to the very end and check last char.
            var sb = new System.Text.StringBuilder();
            int wordCount = N / 6;
            for (int i = 0; i < wordCount; i++)
            {
                sb.Append("word ");
            }
            // End with a single alphabetical character (not part of a word)
            sb.Append('z');
            _data = sb.ToString();
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_61.GPT.Solver.CheckIfLastCharIsALetter(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_61.Gemini.Solver.CheckIfLastCharIsALetter(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_61.Claude.Solver.CheckIfLastCharIsALetter(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_61.Grok.Solver.CheckIfLastCharIsALetter(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_61.Mistral.Solver.CheckIfLastCharIsALetter(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_61.DeepSeek.Solver.CheckIfLastCharIsALetter(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_61.Llama.Solver.CheckIfLastCharIsALetter(_data);
    }
}