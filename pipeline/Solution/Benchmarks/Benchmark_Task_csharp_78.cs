using System;
using System.Security.Cryptography;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_78
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
            // Worst-case: generate a long string of N characters to maximize MD5 computation work
            var sb = new StringBuilder(N);
            for (int i = 0; i < N; i++)
            {
                sb.Append((char)('a' + (i % 26)));
            }
            _data = sb.ToString();
        }

        [Benchmark(Baseline = true)]
        public object GPT() => Benchmarks.csharp_78.GPT.Solver.StringToMd5(_data);

        [Benchmark]
        public object Gemini() => Benchmarks.csharp_78.Gemini.Solver.StringToMd5(_data);

        [Benchmark]
        public object Claude() => Benchmarks.csharp_78.Claude.Solver.StringToMd5(_data);

        [Benchmark]
        public object Grok() => Benchmarks.csharp_78.Grok.Solver.StringToMd5(_data);

        [Benchmark]
        public object Mistral() => Benchmarks.csharp_78.Mistral.Solver.StringToMd5(_data);

        [Benchmark]
        public object DeepSeek() => Benchmarks.csharp_78.DeepSeek.Solver.StringToMd5(_data);

        [Benchmark]
        public object Llama() => Benchmarks.csharp_78.Llama.Solver.StringToMd5(_data);
    }
}