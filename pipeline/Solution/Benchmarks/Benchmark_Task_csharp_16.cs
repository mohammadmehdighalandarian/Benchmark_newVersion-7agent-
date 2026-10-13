using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_16
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
            // Worst-case: a non-palindrome where the mismatch is at the very last character.
            // This forces solvers to compare all the way to the middle before discovering it's not a palindrome.
            // e.g. "aaa...aab" — first half all 'a', last char 'b', so comparison reaches index N/2 before failing.
            var chars = new char[N];
            for (int i = 0; i < N - 1; i++)
                chars[i] = 'a';
            chars[N - 1] = 'b';
            _data = new string(chars);
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_16.GPT.Solver.IsPalindrome(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_16.Gemini.Solver.IsPalindrome(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_16.Claude.Solver.IsPalindrome(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_16.Grok.Solver.IsPalindrome(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_16.Mistral.Solver.IsPalindrome(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_16.DeepSeek.Solver.IsPalindrome(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_16.Llama.Solver.IsPalindrome(_data);
    }
}