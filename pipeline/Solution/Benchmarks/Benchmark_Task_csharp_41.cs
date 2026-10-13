using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_41
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private Dictionary<object, string> _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: all keys are lowercase strings — solver must iterate entire dictionary
            // to confirm all keys are lowercase before returning true.
            _data = new Dictionary<object, string>();
            for (int i = 0; i < N; i++)
            {
                _data[$"key{i}"] = "value";
            }
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_41.GPT.Solver.CheckDictCase(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_41.Gemini.Solver.CheckDictCase(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_41.Claude.Solver.CheckDictCase(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_41.Grok.Solver.CheckDictCase(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_41.Mistral.Solver.CheckDictCase(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_41.DeepSeek.Solver.CheckDictCase(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_41.Llama.Solver.CheckDictCase(_data);
    }
}