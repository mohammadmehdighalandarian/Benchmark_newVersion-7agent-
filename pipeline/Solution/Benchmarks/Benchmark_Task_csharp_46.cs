using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_46
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int _n;
        private int _m;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: large range requiring full average computation
            // n < m so we don't get early -1 return, and range is N wide
            _n = 1;
            _m = _n + N - 1;
        }

        [Benchmark(Baseline = true)]
        public object GPT() => Benchmarks.csharp_46.GPT.Solver.RoundedAvg(_n, _m);

        [Benchmark]
        public object Gemini() => Benchmarks.csharp_46.Gemini.Solver.RoundedAvg(_n, _m);

        [Benchmark]
        public object Claude() => Benchmarks.csharp_46.Claude.Solver.RoundedAvg(_n, _m);

        [Benchmark]
        public object Grok() => Benchmarks.csharp_46.Grok.Solver.RoundedAvg(_n, _m);

        [Benchmark]
        public object Mistral() => Benchmarks.csharp_46.Mistral.Solver.RoundedAvg(_n, _m);

        [Benchmark]
        public object DeepSeek() => Benchmarks.csharp_46.DeepSeek.Solver.RoundedAvg(_n, _m);

        [Benchmark]
        public object Llama() => Benchmarks.csharp_46.Llama.Solver.RoundedAvg(_n, _m);
    }
}