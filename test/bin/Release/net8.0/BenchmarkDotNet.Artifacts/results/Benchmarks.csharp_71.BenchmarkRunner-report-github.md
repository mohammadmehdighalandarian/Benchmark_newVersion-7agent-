```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean        | Error     | StdDev    | Median      | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |------------:|----------:|----------:|------------:|------:|--------:|-----:|----------:|------------:|
| Grok     | 10  |    89.53 ns |  2.414 ns |  6.567 ns |    88.18 ns |  0.73 |    0.05 |    1 |         - |          NA |
| Gemini   | 10  |   119.78 ns |  0.533 ns |  0.445 ns |   119.89 ns |  0.98 |    0.02 |    2 |         - |          NA |
| GPT      | 10  |   122.73 ns |  2.500 ns |  2.338 ns |   122.12 ns |  1.00 |    0.03 |    2 |         - |          NA |
| DeepSeek | 10  |   135.88 ns |  2.772 ns |  6.424 ns |   134.98 ns |  1.11 |    0.06 |    3 |         - |          NA |
| Mistral  | 10  |   267.91 ns |  5.193 ns |  7.612 ns |   265.86 ns |  2.18 |    0.07 |    4 |         - |          NA |
| Llama    | 10  |   270.22 ns |  5.303 ns | 11.069 ns |   268.49 ns |  2.20 |    0.10 |    4 |         - |          NA |
| Claude   | 10  |   313.32 ns |  8.777 ns | 24.755 ns |   306.54 ns |  2.55 |    0.21 |    5 |         - |          NA |
|          |     |             |           |           |             |       |         |      |           |             |
| Grok     | 100 |   280.64 ns |  5.596 ns | 13.726 ns |   279.12 ns |  0.63 |    0.06 |    1 |         - |          NA |
| Gemini   | 100 |   434.50 ns |  9.223 ns | 25.247 ns |   429.84 ns |  0.98 |    0.10 |    2 |         - |          NA |
| DeepSeek | 100 |   441.65 ns | 12.580 ns | 35.483 ns |   430.84 ns |  0.99 |    0.11 |    2 |         - |          NA |
| GPT      | 100 |   447.39 ns | 13.548 ns | 39.088 ns |   435.81 ns |  1.01 |    0.12 |    2 |         - |          NA |
| Mistral  | 100 |   866.19 ns | 22.301 ns | 64.344 ns |   851.82 ns |  1.95 |    0.21 |    3 |         - |          NA |
| Llama    | 100 |   877.03 ns | 24.173 ns | 68.576 ns |   849.00 ns |  1.97 |    0.22 |    3 |         - |          NA |
| Claude   | 100 | 1,067.42 ns | 30.953 ns | 86.284 ns | 1,069.17 ns |  2.40 |    0.27 |    4 |         - |          NA |
