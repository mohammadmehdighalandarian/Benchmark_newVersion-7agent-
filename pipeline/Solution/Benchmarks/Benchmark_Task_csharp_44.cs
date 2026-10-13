using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_44
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
            // Worst-case: generate a long string with N words separated by a mix of commas and spaces
            // so the solver must process every token in the string
            var words = new System.Text.StringBuilder();
            for (int i = 0; i < N; i++)
            {
                if (i > 0)
                {
                    // Alternate between comma+space and just space to exercise both separators
                    words.Append(i % 2 == 0 ? ", " : " ");
                }
                words.Append("word" + i);
            }
            _data = words.ToString();
        }

        [Benchmark(Baseline = true)]
        public List<string> GPT() =>
            Benchmarks.csharp_44.GPT.Solver.WordsString(_data);

        [Benchmark]
        public List<string> Gemini() =>
            Benchmarks.csharp_44.Gemini.Solver.WordsString(_data);

        [Benchmark]
        public List<string> Claude() =>
            Benchmarks.csharp_44.Claude.Solver.WordsString(_data);

        [Benchmark]
        public List<string> Grok() =>
            Benchmarks.csharp_44.Grok.Solver.WordsString(_data);

        [Benchmark]
        public List<string> Mistral() =>
            Benchmarks.csharp_44.Mistral.Solver.WordsString(_data);

        [Benchmark]
        public List<string> DeepSeek() =>
            Benchmarks.csharp_44.DeepSeek.Solver.WordsString(_data);

        [Benchmark]
        public List<string> Llama() =>
            Benchmarks.csharp_44.Llama.Solver.WordsString(_data);
    }
}