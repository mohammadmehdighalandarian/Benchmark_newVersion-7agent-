
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_75
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private int[] _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = new int[N];
            // Worst-case: use values that require processing through all roman numeral lookups.
            // Numbers like 888 ("dccclxxxviii") are among the longest roman numerals,
            // requiring maximum iterations through the value table.
            // We cycle through 1..1000 to cover all cases, with emphasis on complex values.
            for (int i = 0; i < N; i++)
            {
                // Cycle through 1-1000, ensuring full range coverage
                _data[i] = (i % 1000) + 1;
            }
        }

        [Benchmark(Baseline = true)]
        public string GPT()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.GPT.Solver.IntToMiniRoman(_data[i]);
            return result;
        }

        [Benchmark]
        public string Gemini()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.Gemini.Solver.IntToMiniRoman(_data[i]);
            return result;
        }

        [Benchmark]
        public string Claude()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.Claude.Solver.IntToMiniRoman(_data[i]);
            return result;
        }

        [Benchmark]
        public string Grok()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.Grok.Solver.IntToMiniRoman(_data[i]);
            return result;
        }

        [Benchmark]
        public string Mistral()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.Mistral.Solver.IntToMiniRoman(_data[i]);
            return result;
        }

        [Benchmark]
        public string DeepSeek()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.DeepSeek.Solver.IntToMiniRoman(_data[i]);
            return result;
        }

        [Benchmark]
        public string Llama()
        {
            string result = null;
            for (int i = 0; i < N; i++)
                result = Benchmarks.csharp_75.Llama.Solver.IntToMiniRoman(_data[i]);
            return result;
        }
    }
}