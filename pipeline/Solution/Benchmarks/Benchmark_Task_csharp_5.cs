using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmarks.csharp_5
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)] 
        public int N { get; set; }

        private string _data;

        private static readonly string[] _wordNumbers = new[]
        {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case scenario: generate N number words in DESCENDING order (nine down to zero, cycling)
            // This forces a full sort with maximum displacement of elements rather than nearly-sorted data.
            var words = new string[N];
            int numWords = _wordNumbers.Length;
            for (int i = 0; i < N; i++)
            {
                // Fill descending: nine, eight, seven, ..., zero, nine, eight, ...
                words[i] = _wordNumbers[(numWords - 1) - (i % numWords)];
            }
            _data = string.Join(" ", words);
        }

        [Benchmark(Baseline = true)]
        public string GPT()
        {
            return Benchmarks.csharp_5.GPT.Solver.SortNumbers(_data);
        }

        [Benchmark]
        public string Gemini()
        {
            return Benchmarks.csharp_5.Gemini.Solver.SortNumbers(_data);
        }

        [Benchmark]
        public string Claude()
        {
            return Benchmarks.csharp_5.Claude.Solver.SortNumbers(_data);
        }

        [Benchmark]
        public string Grok()
        {
            return Benchmarks.csharp_5.Grok.Solver.SortNumbers(_data);
        }

        [Benchmark]
        public string Mistral()
        {
            return Benchmarks.csharp_5.Mistral.Solver.SortNumbers(_data);
        }

        [Benchmark]
        public string DeepSeek()
        {
            return Benchmarks.csharp_5.DeepSeek.Solver.SortNumbers(_data);
        }

        [Benchmark]
        public string Llama()
        {
            return Benchmarks.csharp_5.Llama.Solver.SortNumbers(_data);
        }
    }
}