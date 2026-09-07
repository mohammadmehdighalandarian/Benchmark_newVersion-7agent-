```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean     | Error    | StdDev   | Median   | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |---------:|---------:|---------:|---------:|------:|--------:|-----:|----------:|------------:|
| Mistral  | 10  |       NA |       NA |       NA |       NA |     ? |       ? |    ? |        NA |           ? |
| Gemini   | 10  | 145.4 ns |  3.41 ns |  9.79 ns | 143.1 ns |  0.98 |    0.11 |    1 |         - |          NA |
| Grok     | 10  | 149.1 ns |  3.80 ns | 10.73 ns | 146.7 ns |  1.00 |    0.12 |    1 |         - |          NA |
| GPT      | 10  | 150.3 ns |  5.36 ns | 15.62 ns | 145.4 ns |  1.01 |    0.14 |    1 |         - |          NA |
| DeepSeek | 10  | 220.5 ns |  6.67 ns | 19.35 ns | 215.6 ns |  1.48 |    0.19 |    2 |         - |          NA |
| Llama    | 10  | 318.9 ns | 10.63 ns | 29.63 ns | 314.6 ns |  2.14 |    0.29 |    3 |         - |          NA |
| Claude   | 10  | 351.7 ns | 15.25 ns | 43.74 ns | 337.5 ns |  2.36 |    0.37 |    3 |         - |          NA |
|          |     |          |          |          |          |       |         |      |           |             |
| Mistral  | 100 |       NA |       NA |       NA |       NA |     ? |       ? |    ? |        NA |           ? |
| Grok     | 100 | 138.6 ns |  2.75 ns |  5.23 ns | 138.3 ns |  0.98 |    0.05 |    1 |         - |          NA |
| GPT      | 100 | 141.0 ns |  2.86 ns |  5.79 ns | 140.3 ns |  1.00 |    0.06 |    1 |         - |          NA |
| Gemini   | 100 | 143.2 ns |  2.91 ns |  7.18 ns | 141.5 ns |  1.02 |    0.07 |    1 |         - |          NA |
| DeepSeek | 100 | 194.5 ns |  3.61 ns |  3.37 ns | 194.1 ns |  1.38 |    0.06 |    2 |         - |          NA |
| Llama    | 100 | 306.7 ns |  5.82 ns | 14.38 ns | 304.7 ns |  2.18 |    0.13 |    3 |         - |          NA |
| Claude   | 100 | 317.1 ns |  6.16 ns | 14.40 ns | 315.2 ns |  2.25 |    0.14 |    3 |         - |          NA |

Benchmarks with issues:
  BenchmarkRunner.Mistral: DefaultJob [N=10]
  BenchmarkRunner.Mistral: DefaultJob [N=100]
