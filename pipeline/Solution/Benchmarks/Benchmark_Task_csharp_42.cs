using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_42
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string[] _data;

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _data = new string[N];
            for (int i = 0; i < N; i++)
            {
                // Worst-case: values ending in exactly .5 force the tie-breaking
                // logic (round away from zero) to be exercised on every call.
                // Alternate between positive and negative to stress both branches.
                double intPart = rng.Next(1, 100000);
                string sign = (i % 2 == 0) ? "" : "-";
                _data[i] = $"{sign}{intPart}.5";
            }
        }

        [Benchmark(Baseline = true)]
        public int GPT()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.GPT.Solver.ClosestInteger(_data[i]);
            return result;
        }

        [Benchmark]
        public int Gemini()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.Gemini.Solver.ClosestInteger(_data[i]);
            return result;
        }

        [Benchmark]
        public int Claude()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.Claude.Solver.ClosestInteger(_data[i]);
            return result;
        }

        [Benchmark]
        public int Grok()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.Grok.Solver.ClosestInteger(_data[i]);
            return result;
        }

        [Benchmark]
        public int Mistral()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.Mistral.Solver.ClosestInteger(_data[i]);
            return result;
        }

        [Benchmark]
        public int DeepSeek()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.DeepSeek.Solver.ClosestInteger(_data[i]);
            return result;
        }

        [Benchmark]
        public int Llama()
        {
            int result = 0;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_42.Llama.Solver.ClosestInteger(_data[i]);
            return result;
        }
    }
}