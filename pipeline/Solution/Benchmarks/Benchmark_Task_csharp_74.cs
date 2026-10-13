using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_74
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _a;
        private string _b;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: build a long string 'a' that doesn't contain any rotation of 'b'
            // Use a pattern that forces checking all rotations without early success
            // 'b' will be a string whose no rotation appears in 'a'
            // a = "aaaa...a" repeated N times
            // b = "ab" + repeated 'a' so no rotation of b is a substring of a easily
            // Better: a = string of 'x' repeated N, b = "xy" - no rotation of b ("xy","yx") appears in a
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < N; i++)
                sb.Append('x');
            _a = sb.ToString();
            _b = "xy"; // rotations: "xy", "yx" - neither appears in all-x string
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_74.GPT.Solver.CycpatternCheck(_a, _b);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_74.Gemini.Solver.CycpatternCheck(_a, _b);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_74.Claude.Solver.CycpatternCheck(_a, _b);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_74.Grok.Solver.CycpatternCheck(_a, _b);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_74.Mistral.Solver.CycpatternCheck(_a, _b);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_74.DeepSeek.Solver.CycpatternCheck(_a, _b);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_74.Llama.Solver.CycpatternCheck(_a, _b);
    }
}