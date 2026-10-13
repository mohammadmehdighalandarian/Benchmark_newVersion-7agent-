using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_37
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private List<List<int>> _data;
        private int _x;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: x appears at the end of every row (last column),
            // forcing each solver to scan all columns in all rows.
            _x = 99;
            _data = new List<List<int>>();
            for (int row = 0; row < N; row++)
            {
                var r = new List<int>();
                for (int col = 0; col < N; col++)
                {
                    // Fill with non-target values, place target only at last column
                    r.Add(col == N - 1 ? _x : col);
                }
                _data.Add(r);
            }
        }

        [Benchmark(Baseline = true)]
        public List<List<int>> GPT() =>
            Benchmarks.csharp_37.GPT.Solver.GetRow(_data, _x);

        [Benchmark]
        public List<List<int>> Gemini() =>
            Benchmarks.csharp_37.Gemini.Solver.GetRow(_data, _x);

        [Benchmark]
        public List<List<int>> Claude() =>
            Benchmarks.csharp_37.Claude.Solver.GetRow(_data, _x);

        [Benchmark]
        public List<List<int>> Grok() =>
            Benchmarks.csharp_37.Grok.Solver.GetRow(_data, _x);

        [Benchmark]
        public List<List<int>> Mistral() =>
            Benchmarks.csharp_37.Mistral.Solver.GetRow(_data, _x);

        [Benchmark]
        public List<List<int>> DeepSeek() =>
            Benchmarks.csharp_37.DeepSeek.Solver.GetRow(_data, _x);

        [Benchmark]
        public List<List<int>> Llama() =>
            Benchmarks.csharp_37.Llama.Solver.GetRow(_data, _x);
    }
}