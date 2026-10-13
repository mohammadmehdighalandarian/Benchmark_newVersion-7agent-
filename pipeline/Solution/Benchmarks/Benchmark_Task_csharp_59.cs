using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace Benchmarks.csharp_59
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
            // Worst-case: generate a string that has valid nested brackets
            // but requires scanning the entire string.
            // Pattern: many non-nested pairs followed by a nested pair at the end.
            // e.g., "[][][][]...[[]]" — forces full traversal before finding nesting.
            var sb = new System.Text.StringBuilder();
            // Fill with non-nested pairs up to N-4 characters
            int nonNestedPairs = (N - 4) / 2;
            for (int i = 0; i < nonNestedPairs; i++)
            {
                sb.Append("[]");
            }
            // Append a nested pair at the end
            sb.Append("[[]]");
            _data = sb.ToString();
        }

        [Benchmark(Baseline = true)]
        public bool GPT() => Benchmarks.csharp_59.GPT.Solver.IsNested(_data);

        [Benchmark]
        public bool Gemini() => Benchmarks.csharp_59.Gemini.Solver.IsNested(_data);

        [Benchmark]
        public bool Claude() => Benchmarks.csharp_59.Claude.Solver.IsNested(_data);

        [Benchmark]
        public bool Grok() => Benchmarks.csharp_59.Grok.Solver.IsNested(_data);

        [Benchmark]
        public bool Mistral() => Benchmarks.csharp_59.Mistral.Solver.IsNested(_data);

        [Benchmark]
        public bool DeepSeek() => Benchmarks.csharp_59.DeepSeek.Solver.IsNested(_data);

        [Benchmark]
        public bool Llama() => Benchmarks.csharp_59.Llama.Solver.IsNested(_data);
    }
}