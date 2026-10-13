using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_51
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _s;
        private string _c;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: generate a long palindrome string so the solver must process all N chars
            // and the result is a palindrome (no early exit possible).
            // _c will remove only characters not part of the palindrome core,
            // so the filtered string remains long and is a palindrome.
            // Strategy: s = "aXaXa...XaXa" (palindrome of length N using 'a' and 'b'),
            // c = "X" so all 'X' are removed, leaving "aaa...a" which IS a palindrome.
            // This forces full scan of N characters.

            var half = N / 2;
            var sb = new System.Text.StringBuilder(N);
            // Build palindrome: "abcabc...cbacba" using only 'a','b','c'
            // Remove 'd' from c so nothing is removed and string stays length N — palindrome needed
            // Better: make s a palindrome of length N with chars from 'a'-'z' excluding chars in c
            // c = "z" (rare char), s = palindrome of length N using 'a'-'y'
            // Build palindrome: first half random from 'a'-'y', mirror for second half
            var rand = new Random(42);
            char[] firstHalf = new char[half];
            for (int i = 0; i < half; i++)
                firstHalf[i] = (char)('a' + rand.Next(0, 25)); // 'a' to 'y'

            for (int i = 0; i < half; i++)
                sb.Append(firstHalf[i]);
            if (N % 2 == 1)
                sb.Append('a');
            for (int i = half - 1; i >= 0; i--)
                sb.Append(firstHalf[i]);

            _s = sb.ToString();
            _c = "z"; // 'z' not in s, so nothing is deleted; full string is processed and checked
        }

        [Benchmark(Baseline = true)]
        public List<object> GPT() => Benchmarks.csharp_51.GPT.Solver.ReverseDelete(_s, _c);

        [Benchmark]
        public List<object> Gemini() => Benchmarks.csharp_51.Gemini.Solver.ReverseDelete(_s, _c);

        [Benchmark]
        public List<object> Claude() => Benchmarks.csharp_51.Claude.Solver.ReverseDelete(_s, _c);

        [Benchmark]
        public List<object> Grok() => Benchmarks.csharp_51.Grok.Solver.ReverseDelete(_s, _c);

        [Benchmark]
        public List<object> Mistral() => Benchmarks.csharp_51.Mistral.Solver.ReverseDelete(_s, _c);

        [Benchmark]
        public List<object> DeepSeek() => Benchmarks.csharp_51.DeepSeek.Solver.ReverseDelete(_s, _c);

        [Benchmark]
        public List<object> Llama() => Benchmarks.csharp_51.Llama.Solver.ReverseDelete(_s, _c);
    }
}