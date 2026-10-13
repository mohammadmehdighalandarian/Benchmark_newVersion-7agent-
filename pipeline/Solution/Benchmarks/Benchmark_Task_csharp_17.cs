using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using System.Text;

namespace Benchmarks.csharp_17
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _data;

        [GlobalSetup]
        public void Setup()
        {
            // Worst-case: string of N consonants with no vowels to remove early exit,
            // but we also want to stress the removal path: use all consonants so every
            // character must be checked and kept. Alternatively, use alternating vowels
            // and consonants so the scanner must process all N chars and do many removals.
            // Worst-case for removal algorithms: dense vowels forcing maximum work across full string.
            var sb = new StringBuilder(N);
            for (int i = 0; i < N; i++)
            {
                // Alternate between vowels and consonants to maximize branching/filtering work
                sb.Append(i % 2 == 0 ? 'a' : 'b');
            }
            _data = sb.ToString();
        }

        [Benchmark(Baseline = true)]
        public string GPT() => Benchmarks.csharp_17.GPT.Solver.RemoveVowels(_data);

        [Benchmark]
        public string Gemini() => Benchmarks.csharp_17.Gemini.Solver.RemoveVowels(_data);

        [Benchmark]
        public string Claude() => Benchmarks.csharp_17.Claude.Solver.RemoveVowels(_data);

        [Benchmark]
        public string Grok() => Benchmarks.csharp_17.Grok.Solver.RemoveVowels(_data);

        [Benchmark]
        public string Mistral() => Benchmarks.csharp_17.Mistral.Solver.RemoveVowels(_data);

        [Benchmark]
        public string DeepSeek() => Benchmarks.csharp_17.DeepSeek.Solver.RemoveVowels(_data);

        [Benchmark]
        public string Llama() => Benchmarks.csharp_17.Llama.Solver.RemoveVowels(_data);
    }
}