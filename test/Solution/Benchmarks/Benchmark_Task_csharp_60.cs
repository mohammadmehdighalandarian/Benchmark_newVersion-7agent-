using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_60
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<object> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: generate N floating-point numbers with fractional parts
            // so that Ceiling always rounds up, maximizing computation for all elements.
            var random = new Random(42);
            _data = new List<object>(N);
            for (int i = 0; i < N; i++)
            {
                // Use doubles with fractional parts to force Ceiling rounding on every element
                double value = (random.NextDouble() * 200.0) - 100.0; // range [-100.0, 100.0)
                // Ensure fractional part is non-zero to always trigger ceiling rounding
                if (value == Math.Floor(value))
                    value += 0.5;
                _data.Add(value);
            }
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_60.GPT.Solver.SumSquares(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_60.Gemini.Solver.SumSquares(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_60.Claude.Solver.SumSquares(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_60.Grok.Solver.SumSquares(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_60.Mistral.Solver.SumSquares(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_60.DeepSeek.Solver.SumSquares(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_60.Llama.Solver.SumSquares(_data);
    }
}