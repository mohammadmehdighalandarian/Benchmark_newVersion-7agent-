using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using System.Collections.Generic;

namespace Benchmarks.csharp_8
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)] 
        public int N { get; set; }

        private List<int> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: all negative numbers except the last one, forcing full list traversal
            _data = new List<int>(N);
            for (int i = 0; i < N - 1; i++)
            {
                _data.Add(-1);
            }
            _data.Add(1);
        }

        [Benchmark(Baseline = true)]
        public List<int> GPT() => Benchmarks.csharp_8.GPT.Solver.GetPositive(_data);

        [Benchmark]
        public List<int> Gemini() => Benchmarks.csharp_8.Gemini.Solver.GetPositive(_data);

        [Benchmark]
        public List<int> Claude() => Benchmarks.csharp_8.Claude.Solver.GetPositive(_data);

        [Benchmark]
        public List<int> Grok() => Benchmarks.csharp_8.Grok.Solver.GetPositive(_data);

        [Benchmark]
        public List<int> Mistral() => Benchmarks.csharp_8.Mistral.Solver.GetPositive(_data);

        [Benchmark]
        public List<int> DeepSeek() => Benchmarks.csharp_8.DeepSeek.Solver.GetPositive(_data);

        [Benchmark]
        public List<int> Llama() => Benchmarks.csharp_8.Llama.Solver.GetPositive(_data);
    }
}