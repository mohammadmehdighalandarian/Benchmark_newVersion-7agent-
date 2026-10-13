```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |-----------:|----------:|----------:|-----------:|------:|--------:|-----:|----------:|------------:|
| Mistral  | 10  |   4.414 ns | 0.1336 ns | 0.3016 ns |   4.384 ns |  0.52 |    0.04 |    1 |         - |          NA |
| GPT      | 10  |   8.498 ns | 0.2114 ns | 0.2434 ns |   8.440 ns |  1.00 |    0.04 |    2 |         - |          NA |
| Claude   | 10  |   9.291 ns | 0.2196 ns | 0.2255 ns |   9.236 ns |  1.09 |    0.04 |    3 |         - |          NA |
| Gemini   | 10  |  10.649 ns | 0.2549 ns | 0.4464 ns |  10.467 ns |  1.25 |    0.06 |    4 |         - |          NA |
| DeepSeek | 10  |  10.861 ns | 0.2669 ns | 0.5511 ns |  10.797 ns |  1.28 |    0.07 |    4 |         - |          NA |
| Grok     | 10  |  10.894 ns | 0.2379 ns | 0.4167 ns |  10.840 ns |  1.28 |    0.06 |    4 |         - |          NA |
| Llama    | 10  |  11.628 ns | 0.2762 ns | 0.6177 ns |  11.591 ns |  1.37 |    0.08 |    5 |         - |          NA |
|          |     |            |           |           |            |       |         |      |           |             |
| Mistral  | 100 |  52.177 ns | 1.0784 ns | 1.0592 ns |  52.261 ns |  0.43 |    0.03 |    1 |         - |          NA |
| DeepSeek | 100 | 119.137 ns | 2.2914 ns | 3.8284 ns | 118.866 ns |  0.97 |    0.07 |    2 |         - |          NA |
| GPT      | 100 | 122.683 ns | 2.7376 ns | 7.9424 ns | 119.860 ns |  1.00 |    0.09 |    2 |         - |          NA |
| Llama    | 100 | 122.844 ns | 2.4914 ns | 5.2552 ns | 122.426 ns |  1.01 |    0.07 |    2 |         - |          NA |
| Grok     | 100 | 125.451 ns | 2.5830 ns | 7.1144 ns | 124.481 ns |  1.03 |    0.09 |    2 |         - |          NA |
| Gemini   | 100 | 141.621 ns | 2.7705 ns | 3.6025 ns | 142.375 ns |  1.16 |    0.08 |    3 |         - |          NA |
| Claude   | 100 | 141.867 ns | 2.8908 ns | 5.7062 ns | 141.537 ns |  1.16 |    0.08 |    3 |         - |          NA |
