using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_45
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _x;
        private int _y;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: x is odd and y = x + 1 (even), so the solver must
            // check all the way to the upper bound to find the largest even number.
            // Using large values forces full range traversal logic.
            _x = N;                  // could be odd or even
            _y = N + N;              // large upper bound; biggest even is _y if even, else _y - 1
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_45.GPT.Solver.ChooseNum(_x, _y);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_45.Gemini.Solver.ChooseNum(_x, _y);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_45.Claude.Solver.ChooseNum(_x, _y);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_45.Grok.Solver.ChooseNum(_x, _y);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_45.Mistral.Solver.ChooseNum(_x, _y);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_45.DeepSeek.Solver.ChooseNum(_x, _y);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_45.Llama.Solver.ChooseNum(_x, _y);
    }
}