using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_70
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private (string planet1, string planet2)[] _data;

        private static readonly string[] ValidPlanets = new[]
        {
            "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
        };

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: pairs that span the widest range (Mercury to Neptune),
            // forcing iteration through all 6 in-between planets.
            // We repeat N times to match the N parameter.
            _data = new (string, string)[N];
            for (int i = 0; i < N; i++)
            {
                _data[i] = ("Mercury", "Neptune");
            }
        }

        [Benchmark(Baseline = true)]
        public object GPT()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.GPT.Solver.Bf(p1, p2);
            return result;
        }

        [Benchmark]
        public object Gemini()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.Gemini.Solver.Bf(p1, p2);
            return result;
        }

        [Benchmark]
        public object Claude()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.Claude.Solver.Bf(p1, p2);
            return result;
        }

        [Benchmark]
        public object Grok()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.Grok.Solver.Bf(p1, p2);
            return result;
        }

        [Benchmark]
        public object Mistral()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.Mistral.Solver.Bf(p1, p2);
            return result;
        }

        [Benchmark]
        public object DeepSeek()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.DeepSeek.Solver.Bf(p1, p2);
            return result;
        }

        [Benchmark]
        public object Llama()
        {
            object result = null;
            foreach (var (p1, p2) in _data)
                result = Benchmarks.csharp_70.Llama.Solver.Bf(p1, p2);
            return result;
        }
    }
}