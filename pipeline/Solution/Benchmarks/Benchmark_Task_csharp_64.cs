using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_64
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
            // Worst-case: use the largest N to maximize recursive/iterative depth
            _data = N;
        }

        [Benchmark(Baseline = true)]
        public int GPT() => Benchmarks.csharp_64.GPT.Solver.SpecialFactorial(_data);

        [Benchmark]
        public int Gemini() => Benchmarks.csharp_64.Gemini.Solver.SpecialFactorial(_data);

        [Benchmark]
        public int Claude() => Benchmarks.csharp_64.Claude.Solver.SpecialFactorial(_data);

        [Benchmark]
        public int Grok() => Benchmarks.csharp_64.Grok.Solver.SpecialFactorial(_data);

        [Benchmark]
        public int Mistral() => Benchmarks.csharp_64.Mistral.Solver.SpecialFactorial(_data);

        [Benchmark]
        public int DeepSeek() => Benchmarks.csharp_64.DeepSeek.Solver.SpecialFactorial(_data);

        [Benchmark]
        public int Llama() => Benchmarks.csharp_64.Llama.Solver.SpecialFactorial(_data);
    }
}