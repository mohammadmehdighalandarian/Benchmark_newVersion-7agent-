using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_6
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)] 
        public int N { get; set; }

        private List<double> _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new List<double>(N);
            for (int i = 0; i < N; i++)
            {
                _data.Add(i * 1.0);
            }
        }

        [Benchmark(Baseline = true)]
        public List<double> GPT() =>
            Benchmarks.csharp_6.GPT.Solver.RescaleToUnit(_data);

        [Benchmark]
        public List<double> Gemini() =>
            Benchmarks.csharp_6.Gemini.Solver.RescaleToUnit(_data);

        [Benchmark]
        public List<double> Claude() =>
            Benchmarks.csharp_6.Claude.Solver.RescaleToUnit(_data);

        [Benchmark]
        public List<double> Grok() =>
            Benchmarks.csharp_6.Grok.Solver.RescaleToUnit(_data);

        [Benchmark]
        public List<double> Mistral() =>
            Benchmarks.csharp_6.Mistral.Solver.RescaleToUnit(_data);

        [Benchmark]
        public List<double> DeepSeek() =>
            Benchmarks.csharp_6.DeepSeek.Solver.RescaleToUnit(_data);

        [Benchmark]
        public List<double> Llama() =>
            Benchmarks.csharp_6.Llama.Solver.RescaleToUnit(_data);
    }
}