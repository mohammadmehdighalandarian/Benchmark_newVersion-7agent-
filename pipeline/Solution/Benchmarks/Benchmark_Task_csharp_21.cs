using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_21
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
            // Worst-case: large N forces maximum recursive/iterative depth
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_21.GPT.Solver.Fib(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_21.Gemini.Solver.Fib(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_21.Claude.Solver.Fib(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_21.Grok.Solver.Fib(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_21.Mistral.Solver.Fib(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_21.DeepSeek.Solver.Fib(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_21.Llama.Solver.Fib(_data);
    }
}