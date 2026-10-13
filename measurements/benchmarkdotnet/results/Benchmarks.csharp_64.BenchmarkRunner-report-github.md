```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean         | Error       | StdDev      | Median       | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |-------------:|------------:|------------:|-------------:|------:|--------:|-----:|----------:|------------:|
| Llama    | 10  |           NA |          NA |          NA |           NA |     ? |       ? |    ? |        NA |           ? |
| Claude   | 10  |     4.771 ns |   0.2076 ns |   0.5922 ns |     4.572 ns |  0.95 |    0.19 |    1 |         - |          NA |
| Gemini   | 10  |     4.990 ns |   0.2474 ns |   0.7058 ns |     4.749 ns |  0.99 |    0.21 |    1 |         - |          NA |
| GPT      | 10  |     5.182 ns |   0.3451 ns |   0.9845 ns |     4.706 ns |  1.03 |    0.26 |    1 |         - |          NA |
| DeepSeek | 10  |    32.104 ns |   1.5714 ns |   4.5589 ns |    31.131 ns |  6.39 |    1.37 |    2 |         - |          NA |
| Grok     | 10  |    35.139 ns |   1.2931 ns |   3.6682 ns |    33.632 ns |  6.99 |    1.34 |    2 |         - |          NA |
| Mistral  | 10  |    36.160 ns |   1.6268 ns |   4.7195 ns |    35.768 ns |  7.19 |    1.49 |    2 |         - |          NA |
|          |     |              |             |             |              |       |         |      |           |             |
| Llama    | 100 |           NA |          NA |          NA |           NA |     ? |       ? |    ? |        NA |           ? |
| GPT      | 100 |    88.928 ns |   1.7323 ns |   1.9949 ns |    87.932 ns |  1.00 |    0.03 |    1 |         - |          NA |
| Claude   | 100 |    95.000 ns |   1.7216 ns |   4.2230 ns |    93.813 ns |  1.07 |    0.05 |    2 |         - |          NA |
| Gemini   | 100 |   130.145 ns |   3.9937 ns |  11.7756 ns |   129.009 ns |  1.46 |    0.14 |    3 |         - |          NA |
| Mistral  | 100 | 3,044.539 ns |  25.6638 ns |  25.2052 ns | 3,039.314 ns | 34.25 |    0.78 |    4 |         - |          NA |
| DeepSeek | 100 | 3,160.007 ns |  63.0836 ns | 148.6955 ns | 3,121.051 ns | 35.55 |    1.83 |    4 |         - |          NA |
| Grok     | 100 | 4,945.366 ns | 139.2306 ns | 403.9331 ns | 4,898.550 ns | 55.64 |    4.68 |    5 |         - |          NA |

Benchmarks with issues:
  BenchmarkRunner.Llama: DefaultJob [N=10]
  BenchmarkRunner.Llama: DefaultJob [N=100]
