using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_14
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: use N directly as the input to force computing the N-th Fib4 element
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_14.GPT.Solver.Fib4(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_14.Gemini.Solver.Fib4(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_14.Claude.Solver.Fib4(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_14.Grok.Solver.Fib4(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_14.Mistral.Solver.Fib4(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_14.DeepSeek.Solver.Fib4(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_14.Llama.Solver.Fib4(_data);
    }
}