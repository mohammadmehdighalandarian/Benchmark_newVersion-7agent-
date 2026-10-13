using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_58
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
            // Worst-case: all digits are odd, so the solver must multiply every digit.
            // Build an N-digit number composed entirely of '3's (an odd digit).
            // For large N, we cap at a value that fits in int (max ~10 digits).
            // Since int has at most 10 digits, we use min(N, 9) threes to stay within int range.
            int digitCount = Math.Min(N, 9);
            int value = 0;
            for (int i = 0; i < digitCount; i++)
            {
                value = value * 10 + 3;
            }
            _data = value;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_58.GPT.Solver.Digits(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_58.Gemini.Solver.Digits(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_58.Claude.Solver.Digits(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_58.Grok.Solver.Digits(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_58.Mistral.Solver.Digits(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_58.DeepSeek.Solver.Digits(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_58.Llama.Solver.Digits(_data);
    }
}