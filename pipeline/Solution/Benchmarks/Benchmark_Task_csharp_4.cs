using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_4
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)] 
        public int N { get; set; }

        private int _a;
        private int _b;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case scenario for GCD: use consecutive Fibonacci numbers,
            // which are the worst case for the Euclidean algorithm (maximum iterations).
            // We scale them up with N to ensure the workload grows with N.
            // fib(k) and fib(k+1) require k divisions in Euclidean GCD.
            long fibPrev = 1;
            long fibCurr = 1;
            for (int i = 2; i < N; i++)
            {
                long next = fibPrev + fibCurr;
                fibPrev = fibCurr;
                fibCurr = next;
                // Clamp to int range to avoid overflow
                if (fibCurr > int.MaxValue / 2)
                {
                    fibPrev = fibPrev % 46368;
                    fibCurr = fibCurr % 75025;
                }
            }
            _a = (int)(fibCurr);
            _b = (int)(fibPrev);
        }

        [Benchmark(Baseline = true)]
        public int GPT()
        {
            return Benchmarks.csharp_4.GPT.Solver.GreatestCommonDivisor(_a, _b);
        }

        [Benchmark]
        public int Gemini()
        {
            return Benchmarks.csharp_4.Gemini.Solver.GreatestCommonDivisor(_a, _b);
        }

        [Benchmark]
        public int Claude()
        {
            return Benchmarks.csharp_4.Claude.Solver.GreatestCommonDivisor(_a, _b);
        }

        [Benchmark]
        public int Grok()
        {
            return Benchmarks.csharp_4.Grok.Solver.GreatestCommonDivisor(_a, _b);
        }

        [Benchmark]
        public int Mistral()
        {
            return Benchmarks.csharp_4.Mistral.Solver.GreatestCommonDivisor(_a, _b);
        }

        [Benchmark]
        public int DeepSeek()
        {
            return Benchmarks.csharp_4.DeepSeek.Solver.GreatestCommonDivisor(_a, _b);
        }

        [Benchmark]
        public int Llama()
        {
            return Benchmarks.csharp_4.Llama.Solver.GreatestCommonDivisor(_a, _b);
        }
    }
}