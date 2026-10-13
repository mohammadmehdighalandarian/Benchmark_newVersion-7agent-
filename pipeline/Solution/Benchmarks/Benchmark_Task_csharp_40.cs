using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_40
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<int> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: fill list with composite numbers, place a large prime at the end
            // This forces all solvers to scan the entire list and check primality of a large number
            _data = new List<int>(N);
            for (int i = 0; i < N - 1; i++)
            {
                // Use composite numbers (multiples of 2 or 3) to avoid early large prime hits
                _data.Add((i % 2 == 0) ? (i + 2) * 2 : (i + 3) * 3);
            }
            // Place a large prime at the end to force full traversal and large primality check
            // 999983 is a large prime number
            _data.Add(999983);
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_40.GPT.Solver.Skjkasdkd(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_40.Gemini.Solver.Skjkasdkd(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_40.Claude.Solver.Skjkasdkd(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_40.Grok.Solver.Skjkasdkd(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_40.Mistral.Solver.Skjkasdkd(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_40.DeepSeek.Solver.Skjkasdkd(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_40.Llama.Solver.Skjkasdkd(_data);
    }
}