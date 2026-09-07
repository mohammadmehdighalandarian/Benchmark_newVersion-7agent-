using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_9
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
            // Worst-case: use a large prime number that forces full trial division up to sqrt(n)
            // 999983 is a prime, forcing solvers to check all divisors up to ~1000
            // Scale with N to stress-test: pick the Nth large prime-like candidate
            // We use a large prime close to N*100 to ensure worst-case primality check
            _data = GetLargePrimeNearN(N);
        }

        private int GetLargePrimeNearN(int n)
        {
            // Generate a prime number that is large relative to N,
            // forcing solvers to iterate up to sqrt(candidate) steps.
            // We find the largest prime <= n * 1000 + 7 to ensure worst-case.
            int candidate = n * 1000 + 7;
            while (!NaiveIsPrime(candidate))
            {
                candidate += 2;
            }
            return candidate;
        }

        private bool NaiveIsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_9.GPT.Solver.IsPrime(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_9.Gemini.Solver.IsPrime(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_9.Claude.Solver.IsPrime(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_9.Grok.Solver.IsPrime(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_9.Mistral.Solver.IsPrime(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_9.DeepSeek.Solver.IsPrime(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_9.Llama.Solver.IsPrime(_data);
    }
}