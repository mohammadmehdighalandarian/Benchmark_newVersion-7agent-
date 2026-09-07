using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_39
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: Generate N sentences, with "I" sentences only at the end
            // This forces all solvers to process the entire string
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < N - 1; i++)
            {
                sb.Append("The sky is blue. The sun is shining. We love this weather! Are you happy? ");
            }
            // Last sentence starts with "I" to ensure at least one boredom is found at the end
            sb.Append("I am finally bored.");
            _data = sb.ToString();
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_39.GPT.Solver.IsBored(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_39.Gemini.Solver.IsBored(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_39.Claude.Solver.IsBored(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_39.Grok.Solver.IsBored(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_39.Mistral.Solver.IsBored(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_39.DeepSeek.Solver.IsBored(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_39.Llama.Solver.IsBored(_data);
    }
}