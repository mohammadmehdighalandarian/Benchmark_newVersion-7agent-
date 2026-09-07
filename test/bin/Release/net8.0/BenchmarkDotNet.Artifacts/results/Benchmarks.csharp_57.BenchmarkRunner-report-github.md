```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|--------- |---- |-----------:|----------:|----------:|-----------:|------:|--------:|-----:|-------:|----------:|------------:|
| Llama    | 10  |         NA |        NA |        NA |         NA |     ? |       ? |    ? |     NA |        NA |           ? |
| Mistral  | 10  |   223.7 ns |   4.53 ns |   5.57 ns |   224.8 ns |  0.86 |    0.11 |    1 | 0.1884 |     592 B |        0.82 |
| Grok     | 10  |   227.1 ns |  10.59 ns |  29.70 ns |   217.5 ns |  0.87 |    0.16 |    1 | 0.1879 |     592 B |        0.82 |
| Gemini   | 10  |   241.4 ns |   5.24 ns |  14.79 ns |   237.9 ns |  0.93 |    0.13 |    2 | 0.1884 |     592 B |        0.82 |
| GPT      | 10  |   265.4 ns |  12.28 ns |  36.03 ns |   254.9 ns |  1.02 |    0.19 |    2 | 0.2289 |     720 B |        1.00 |
| DeepSeek | 10  |   906.3 ns |  33.60 ns |  95.31 ns |   914.5 ns |  3.47 |    0.58 |    3 | 0.5045 |    1584 B |        2.20 |
| Claude   | 10  | 1,000.9 ns |  61.02 ns | 176.07 ns |   977.1 ns |  3.84 |    0.84 |    3 | 0.5045 |    1584 B |        2.20 |
|          |     |            |           |           |            |       |         |      |        |           |             |
| Llama    | 100 |         NA |        NA |        NA |         NA |     ? |       ? |    ? |     NA |        NA |           ? |
| Grok     | 100 | 1,539.6 ns |  30.89 ns |  42.28 ns | 1,542.3 ns |  0.96 |    0.04 |    1 | 1.4687 |    4616 B |        0.84 |
| GPT      | 100 | 1,607.6 ns |  31.44 ns |  46.09 ns | 1,602.4 ns |  1.00 |    0.04 |    1 | 1.7395 |    5464 B |        1.00 |
| Mistral  | 100 | 1,849.7 ns |  76.08 ns | 210.81 ns | 1,858.9 ns |  1.15 |    0.13 |    2 | 1.4706 |    4616 B |        0.84 |
| Gemini   | 100 | 1,879.0 ns |  78.55 ns | 224.12 ns | 1,896.4 ns |  1.17 |    0.14 |    2 | 1.4706 |    4616 B |        0.84 |
| DeepSeek | 100 | 6,536.7 ns | 129.67 ns | 313.16 ns | 6,554.3 ns |  4.07 |    0.22 |    3 | 4.7150 |   14808 B |        2.71 |
| Claude   | 100 | 7,244.3 ns | 190.74 ns | 528.55 ns | 7,117.5 ns |  4.51 |    0.35 |    4 | 4.7150 |   14808 B |        2.71 |

Benchmarks with issues:
  BenchmarkRunner.Llama: DefaultJob [N=10]
  BenchmarkRunner.Llama: DefaultJob [N=100]
