using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_68
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
            // Worst-case: all numbers > 10 with both first and last digits odd
            // Forces full iteration with maximum qualifying elements
            // Using numbers like 11, 13, 15, 17, 19, 31, 33, 35, ... (both first and last digit odd, > 10)
            _data = new List<int>(N);
            int[] candidates = new[] { 11, 13, 15, 17, 19, 31, 33, 35, 37, 39,
                                        51, 53, 55, 57, 59, 71, 73, 75, 77, 79,
                                        91, 93, 95, 97, 99, 111, 119, 131, 311, 999 };
            for (int i = 0; i < N; i++)
            {
                _data.Add(candidates[i % candidates.Length]);
            }
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_68.GPT.Solver.SpecialFilter(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_68.Gemini.Solver.SpecialFilter(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_68.Claude.Solver.SpecialFilter(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_68.Grok.Solver.SpecialFilter(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_68.Mistral.Solver.SpecialFilter(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_68.DeepSeek.Solver.SpecialFilter(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_68.Llama.Solver.SpecialFilter(_data);
    }
}