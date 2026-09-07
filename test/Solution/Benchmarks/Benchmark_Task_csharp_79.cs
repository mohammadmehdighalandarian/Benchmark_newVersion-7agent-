using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_79
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _a;
        private int _b;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: a=1, b=9 forces scanning all single digits (max even digits: 2,4,6,8)
            // For larger N we can't truly scale this problem (it's bounded by single digits 1-9),
            // but we simulate worst-case by using a=1 and b=9 repeatedly via N iterations overhead.
            // Since GenerateIntegers only cares about a and b (not N), we set worst-case inputs
            // that maximize internal work: full range scan from 1 to 9.
            _a = 1;
            _b = 9;
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.GPT.Solver.GenerateIntegers(_a, _b);
            return result;
        }

        [Benchmark]
        public List<int> Gemini()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.Gemini.Solver.GenerateIntegers(_a, _b);
            return result;
        }

        [Benchmark]
        public List<int> Claude()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.Claude.Solver.GenerateIntegers(_a, _b);
            return result;
        }

        [Benchmark]
        public List<int> Grok()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.Grok.Solver.GenerateIntegers(_a, _b);
            return result;
        }

        [Benchmark]
        public List<int> Mistral()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.Mistral.Solver.GenerateIntegers(_a, _b);
            return result;
        }

        [Benchmark]
        public List<int> DeepSeek()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.DeepSeek.Solver.GenerateIntegers(_a, _b);
            return result;
        }

        [Benchmark]
        public List<int> Llama()
        {
            List<int> result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_79.Llama.Solver.GenerateIntegers(_a, _b);
            return result;
        }
    }
}