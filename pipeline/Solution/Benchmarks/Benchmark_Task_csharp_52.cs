using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_52
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<List<int>> _data;
        private int _capacity;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: N rows, each row fully filled with 1s, capacity = 1
            // Forces maximum bucket lowerings: every cell is 1, bucket capacity is 1
            _capacity = 1;
            _data = new List<List<int>>();
            int cols = 100; // max column length per constraints
            for (int i = 0; i < N; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < cols; j++)
                    row.Add(1);
                _data.Add(row);
            }
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_52.GPT.Solver.MaxFill(_data, _capacity);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_52.Gemini.Solver.MaxFill(_data, _capacity);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_52.Claude.Solver.MaxFill(_data, _capacity);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_52.Grok.Solver.MaxFill(_data, _capacity);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_52.Mistral.Solver.MaxFill(_data, _capacity);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_52.DeepSeek.Solver.MaxFill(_data, _capacity);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_52.Llama.Solver.MaxFill(_data, _capacity);
    }
}