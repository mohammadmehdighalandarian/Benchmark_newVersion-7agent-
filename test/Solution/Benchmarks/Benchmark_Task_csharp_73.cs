using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using System.Collections.Generic;

namespace Benchmarks.csharp_73
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkRunner
    {
        [Params(10,100)]
        public int N { get; set; }

        private string _className;
        private List<string> _extensions;

        [GlobalSetup]
        public void Setup()
        {
            _className = "MyClass";
            _extensions = new List<string>();

            // Worst-case: all extensions have the same strength except the last one which is strongest.
            // This forces solvers to scan all N extensions to find the winner at the end.
            for (int i = 0; i < N - 1; i++)
            {
                // Each has equal strength: 1 CAP, 1 lowercase => strength = 0
                _extensions.Add("Aa");
            }
            // Last extension is the strongest: all uppercase => strength = N (large positive)
            _extensions.Add("ZZZZZZZZZZ"); // CAP=10, SM=0, strength=10
        }

        [Benchmark(Baseline = true)]
        public string GPT() => Benchmarks.csharp_73.GPT.Solver.StrongestExtension(_className, _extensions);

        [Benchmark]
        public string Gemini() => Benchmarks.csharp_73.Gemini.Solver.StrongestExtension(_className, _extensions);

        [Benchmark]
        public string Claude() => Benchmarks.csharp_73.Claude.Solver.StrongestExtension(_className, _extensions);

        [Benchmark]
        public string Grok() => Benchmarks.csharp_73.Grok.Solver.StrongestExtension(_className, _extensions);

        [Benchmark]
        public string Mistral() => Benchmarks.csharp_73.Mistral.Solver.StrongestExtension(_className, _extensions);

        [Benchmark]
        public string DeepSeek() => Benchmarks.csharp_73.DeepSeek.Solver.StrongestExtension(_className, _extensions);

        [Benchmark]
        public string Llama() => Benchmarks.csharp_73.Llama.Solver.StrongestExtension(_className, _extensions);
    }
}