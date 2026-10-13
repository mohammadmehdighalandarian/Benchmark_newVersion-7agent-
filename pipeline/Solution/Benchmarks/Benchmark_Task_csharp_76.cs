using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_76
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private (int a, int b, int c)[] _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new (int a, int b, int c)[N];
            // Worst-case: non-right-angle triangles that require full Pythagorean check
            // Use values where a^2 + b^2 != c^2 for all permutations
            for (int i = 0; i < N - 1; i++)
            {
                _data[i] = (1, 2, 3); // not a right triangle, forces full check
            }
            // Last item is a right triangle to ensure worst-case path is exercised
            _data[N - 1] = (3, 4, 5);
        }

        [Benchmark(Baseline = true)]
        public bool GPT()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.GPT.Solver.RightAngleTriangle(a, b, c);
            return result;
        }

        [Benchmark]
        public bool Gemini()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.Gemini.Solver.RightAngleTriangle(a, b, c);
            return result;
        }

        [Benchmark]
        public bool Claude()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.Claude.Solver.RightAngleTriangle(a, b, c);
            return result;
        }

        [Benchmark]
        public bool Grok()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.Grok.Solver.RightAngleTriangle(a, b, c);
            return result;
        }

        [Benchmark]
        public bool Mistral()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.Mistral.Solver.RightAngleTriangle(a, b, c);
            return result;
        }

        [Benchmark]
        public bool DeepSeek()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.DeepSeek.Solver.RightAngleTriangle(a, b, c);
            return result;
        }

        [Benchmark]
        public bool Llama()
        {
            bool result = false;
            foreach (var (a, b, c) in _data)
                result = Benchmarks.csharp_76.Llama.Solver.RightAngleTriangle(a, b, c);
            return result;
        }
    }
}