```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean        | Error      | StdDev     | Median      | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|--------- |---- |------------:|-----------:|-----------:|------------:|------:|--------:|-----:|-------:|----------:|------------:|
| Claude   | 10  |    37.96 ns |   0.777 ns |   0.727 ns |    37.90 ns |  0.96 |    0.04 |    1 |      - |         - |          NA |
| Gemini   | 10  |    38.13 ns |   0.699 ns |   1.047 ns |    37.88 ns |  0.97 |    0.04 |    1 |      - |         - |          NA |
| GPT      | 10  |    39.47 ns |   0.831 ns |   1.341 ns |    39.20 ns |  1.00 |    0.05 |    1 |      - |         - |          NA |
| DeepSeek | 10  |    41.97 ns |   0.887 ns |   2.530 ns |    41.49 ns |  1.06 |    0.07 |    1 |      - |         - |          NA |
| Mistral  | 10  |    50.71 ns |   1.127 ns |   3.197 ns |    49.66 ns |  1.29 |    0.09 |    2 |      - |         - |          NA |
| Llama    | 10  |   265.52 ns |   9.406 ns |  27.437 ns |   270.54 ns |  6.73 |    0.73 |    3 | 0.1478 |     464 B |          NA |
| Grok     | 10  |   659.36 ns |  14.523 ns |  41.670 ns |   643.15 ns | 16.72 |    1.19 |    4 | 0.1297 |     408 B |          NA |
|          |     |             |            |            |             |       |         |      |        |           |             |
| Mistral  | 100 |   255.31 ns |   5.063 ns |   9.754 ns |   255.52 ns |  0.63 |    0.03 |    1 |      - |         - |          NA |
| DeepSeek | 100 |   395.25 ns |   6.636 ns |   5.883 ns |   396.38 ns |  0.97 |    0.04 |    2 |      - |         - |          NA |
| Claude   | 100 |   395.96 ns |   7.902 ns |   7.761 ns |   395.89 ns |  0.97 |    0.04 |    2 |      - |         - |          NA |
| Gemini   | 100 |   406.46 ns |   7.349 ns |  11.867 ns |   404.65 ns |  1.00 |    0.05 |    2 |      - |         - |          NA |
| GPT      | 100 |   408.99 ns |   7.105 ns |  15.595 ns |   409.12 ns |  1.00 |    0.05 |    2 |      - |         - |          NA |
| Llama    | 100 | 2,309.89 ns |  45.542 ns |  97.054 ns | 2,297.35 ns |  5.66 |    0.31 |    3 | 0.6065 |    1904 B |          NA |
| Grok     | 100 | 5,887.99 ns | 130.118 ns | 377.497 ns | 5,824.88 ns | 14.42 |    1.06 |    4 | 0.9308 |    2944 B |          NA |
