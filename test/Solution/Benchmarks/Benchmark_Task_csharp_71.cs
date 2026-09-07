using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_71
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _n;
        private int _x;
        private int _y;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case scenario: use a large prime number so primality check
            // must iterate through all divisors up to sqrt(n) without early exit.
            // We pick a large prime close to N * 1000 to scale with N and force
            // maximum iterations in the primality check loop.
            // For N=100 -> ~100003, N=1000 -> ~1000003, N=10000 -> ~10000019
            _n = LargestPrimeUpTo(N * 1000 + 100);
            _x = 34;
            _y = 12;
        }

        private static int LargestPrimeUpTo(int limit)
        {
            for (int candidate = limit; candidate >= 2; candidate--)
            {
                if (IsPrime(candidate))
                    return candidate;
            }
            return 2;
        }

        private static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; (long)i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_71.GPT.Solver.XOrY(_n, _x, _y);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_71.Gemini.Solver.XOrY(_n, _x, _y);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_71.Claude.Solver.XOrY(_n, _x, _y);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_71.Grok.Solver.XOrY(_n, _x, _y);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_71.Mistral.Solver.XOrY(_n, _x, _y);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_71.DeepSeek.Solver.XOrY(_n, _x, _y);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_71.Llama.Solver.XOrY(_n, _x, _y);
    }
}