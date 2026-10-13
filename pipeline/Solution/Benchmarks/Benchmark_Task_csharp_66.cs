using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_66
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private (string x, string n)[] _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new (string x, string n)[N];
            // Worst-case: fractions that do NOT simplify to a whole number
            // Use fractions like "7/10" and "10/2" which yield False
            // This forces full computation (no early exit path) - result is False
            for (int i = 0; i < N; i++)
            {
                _data[i] = ("7/10", "10/2");
            }
        }

        [Benchmark(Baseline = true)]
        public bool GPT()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.GPT.Solver.Simplify(x, n);
            return result;
        }

        [Benchmark]
        public bool Gemini()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.Gemini.Solver.Simplify(x, n);
            return result;
        }

        [Benchmark]
        public bool Claude()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.Claude.Solver.Simplify(x, n);
            return result;
        }

        [Benchmark]
        public bool Grok()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.Grok.Solver.Simplify(x, n);
            return result;
        }

        [Benchmark]
        public bool Mistral()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.Mistral.Solver.Simplify(x, n);
            return result;
        }

        [Benchmark]
        public bool DeepSeek()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.DeepSeek.Solver.Simplify(x, n);
            return result;
        }

        [Benchmark]
        public bool Llama()
        {
            bool result = false;
            foreach (var (x, n) in _data)
                result = Benchmarks.csharp_66.Llama.Solver.Simplify(x, n);
            return result;
        }
    }
}