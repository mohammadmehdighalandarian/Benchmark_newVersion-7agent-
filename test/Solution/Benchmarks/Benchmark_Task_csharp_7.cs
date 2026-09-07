using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_7
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
            var chars = new char[N];
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                    chars[i] = (char)('a' + (i % 26));
                else
                    chars[i] = (char)('A' + (i % 26));
            }
            _data = new string(chars);
        }

        [Benchmark(Baseline = true)]
        public string GPT() => Benchmarks.csharp_7.GPT.Solver.FlipCase(_data);

        [Benchmark]
        public string Gemini() => Benchmarks.csharp_7.Gemini.Solver.FlipCase(_data);

        [Benchmark]
        public string Claude() => Benchmarks.csharp_7.Claude.Solver.FlipCase(_data);

        [Benchmark]
        public string Grok() => Benchmarks.csharp_7.Grok.Solver.FlipCase(_data);

        [Benchmark]
        public string Mistral() => Benchmarks.csharp_7.Mistral.Solver.FlipCase(_data);

        [Benchmark]
        public string DeepSeek() => Benchmarks.csharp_7.DeepSeek.Solver.FlipCase(_data);

        [Benchmark]
        public string Llama() => Benchmarks.csharp_7.Llama.Solver.FlipCase(_data);
    }
}