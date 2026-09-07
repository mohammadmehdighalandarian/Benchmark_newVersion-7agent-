```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean         | Error      | StdDev     | Median       | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|--------- |---- |-------------:|-----------:|-----------:|-------------:|------:|--------:|-----:|-------:|----------:|------------:|
| Mistral  | 10  |           NA |         NA |         NA |           NA |     ? |       ? |    ? |     NA |        NA |           ? |
| Gemini   | 10  |     49.70 ns |   1.079 ns |   2.585 ns |     49.48 ns |  0.88 |    0.06 |    1 | 0.0229 |      72 B |        1.00 |
| DeepSeek | 10  |     50.40 ns |   1.077 ns |   2.681 ns |     49.66 ns |  0.89 |    0.06 |    1 | 0.0229 |      72 B |        1.00 |
| Grok     | 10  |     53.67 ns |   1.151 ns |   2.623 ns |     53.35 ns |  0.95 |    0.06 |    2 | 0.0229 |      72 B |        1.00 |
| GPT      | 10  |     56.48 ns |   1.243 ns |   2.754 ns |     56.24 ns |  1.00 |    0.07 |    2 | 0.0229 |      72 B |        1.00 |
| Llama    | 10  |    851.46 ns |  17.031 ns |  28.455 ns |    848.45 ns | 15.11 |    0.87 |    3 | 0.4816 |    1512 B |       21.00 |
| Claude   | 10  |  1,070.75 ns |  20.642 ns |  45.742 ns |  1,065.34 ns | 19.00 |    1.21 |    4 | 0.5608 |    1760 B |       24.44 |
|          |     |              |            |            |              |       |         |      |        |           |             |
| Mistral  | 100 |           NA |         NA |         NA |           NA |     ? |       ? |    ? |     NA |        NA |           ? |
| GPT      | 100 |    248.84 ns |   5.053 ns |   7.716 ns |    248.73 ns |  1.00 |    0.04 |    1 | 0.0229 |      72 B |        1.00 |
| Gemini   | 100 |    254.66 ns |   5.117 ns |   7.005 ns |    255.36 ns |  1.02 |    0.04 |    1 | 0.0229 |      72 B |        1.00 |
| DeepSeek | 100 |    263.83 ns |   5.367 ns |  12.115 ns |    263.36 ns |  1.06 |    0.06 |    1 | 0.0229 |      72 B |        1.00 |
| Grok     | 100 |    374.18 ns |   7.484 ns |  20.863 ns |    368.14 ns |  1.51 |    0.10 |    2 | 0.0229 |      72 B |        1.00 |
| Llama    | 100 |  9,859.10 ns | 306.763 ns | 880.160 ns |  9,765.08 ns | 39.66 |    3.72 |    3 | 4.6082 |   14472 B |      201.00 |
| Claude   | 100 | 11,536.60 ns | 229.777 ns | 621.215 ns | 11,398.34 ns | 46.40 |    2.86 |    4 | 5.6000 |   17600 B |      244.44 |

Benchmarks with issues:
  BenchmarkRunner.Mistral: DefaultJob [N=10]
  BenchmarkRunner.Mistral: DefaultJob [N=100]
