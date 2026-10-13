```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean         | Error       | StdDev       | Median       | Ratio | RatioSD | Rank | Gen0     | Allocated | Alloc Ratio |
|--------- |---- |-------------:|------------:|-------------:|-------------:|------:|--------:|-----:|---------:|----------:|------------:|
| Llama    | 10  |           NA |          NA |           NA |           NA |     ? |       ? |    ? |       NA |        NA |           ? |
| Gemini   | 10  |     952.2 ns |    31.80 ns |     90.72 ns |     915.1 ns |  0.73 |    0.10 |    1 |   0.5627 |   1.73 KB |        1.00 |
| DeepSeek | 10  |     968.0 ns |    22.79 ns |     63.90 ns |     948.5 ns |  0.74 |    0.09 |    1 |   0.5636 |   1.73 KB |        1.00 |
| Grok     | 10  |   1,258.7 ns |    56.38 ns |    163.56 ns |   1,192.2 ns |  0.97 |    0.16 |    2 |   0.5608 |   1.73 KB |        1.00 |
| GPT      | 10  |   1,320.1 ns |    55.01 ns |    152.42 ns |   1,285.6 ns |  1.01 |    0.16 |    2 |   0.5608 |   1.73 KB |        1.00 |
| Mistral  | 10  |   6,353.3 ns |   149.32 ns |    418.70 ns |   6,230.3 ns |  4.87 |    0.60 |    3 |   3.3417 |  10.26 KB |        5.94 |
| Claude   | 10  |   6,456.5 ns |   199.15 ns |    571.39 ns |   6,309.3 ns |  4.95 |    0.68 |    3 |   3.3264 |   10.2 KB |        5.91 |
|          |     |              |             |              |              |       |         |      |          |           |             |
| Llama    | 100 |           NA |          NA |           NA |           NA |     ? |       ? |    ? |       NA |        NA |           ? |
| DeepSeek | 100 |  29,526.7 ns |   575.46 ns |    961.47 ns |  29,483.8 ns |  0.87 |    0.04 |    1 |   5.2795 |   16.2 KB |        1.31 |
| GPT      | 100 |  33,959.1 ns |   658.09 ns |    943.81 ns |  33,900.2 ns |  1.00 |    0.04 |    2 |   3.9673 |  12.34 KB |        1.00 |
| Grok     | 100 |  34,430.6 ns |   670.56 ns |  1,789.85 ns |  34,117.6 ns |  1.01 |    0.06 |    2 |   3.9673 |  12.34 KB |        1.00 |
| Gemini   | 100 |  36,510.1 ns |   727.85 ns |  1,980.18 ns |  35,963.6 ns |  1.08 |    0.07 |    3 |   5.2490 |   16.2 KB |        1.31 |
| Mistral  | 100 | 221,180.4 ns | 4,407.43 ns | 11,533.48 ns | 219,315.8 ns |  6.52 |    0.38 |    4 | 101.5625 | 311.61 KB |       25.26 |
| Claude   | 100 | 226,419.0 ns | 4,912.08 ns | 13,611.36 ns | 223,777.8 ns |  6.67 |    0.44 |    4 | 101.0742 | 310.85 KB |       25.20 |

Benchmarks with issues:
  BenchmarkRunner.Llama: DefaultJob [N=10]
  BenchmarkRunner.Llama: DefaultJob [N=100]
