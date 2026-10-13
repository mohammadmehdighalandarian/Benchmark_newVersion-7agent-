```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |----------:|----------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| Gemini   | 10  |  57.84 ns |  2.039 ns |  5.914 ns |  56.05 ns |  0.98 |    0.11 |    1 |         - |          NA |
| GPT      | 10  |  59.16 ns |  1.251 ns |  3.045 ns |  58.44 ns |  1.00 |    0.07 |    1 |         - |          NA |
| Grok     | 10  |  66.18 ns |  1.423 ns |  3.094 ns |  65.82 ns |  1.12 |    0.08 |    2 |         - |          NA |
| Llama    | 10  |  66.42 ns |  1.722 ns |  4.914 ns |  64.94 ns |  1.13 |    0.10 |    2 |         - |          NA |
| Mistral  | 10  |  68.53 ns |  1.408 ns |  3.207 ns |  68.08 ns |  1.16 |    0.08 |    2 |         - |          NA |
| DeepSeek | 10  |  72.45 ns |  2.694 ns |  7.858 ns |  71.26 ns |  1.23 |    0.15 |    2 |         - |          NA |
| Claude   | 10  |  75.46 ns |  1.544 ns |  2.114 ns |  75.35 ns |  1.28 |    0.07 |    2 |         - |          NA |
|          |     |           |           |           |           |       |         |      |           |             |
| Gemini   | 100 | 530.54 ns | 10.056 ns | 11.971 ns | 528.65 ns |  0.90 |    0.04 |    1 |         - |          NA |
| GPT      | 100 | 593.53 ns | 11.685 ns | 25.894 ns | 590.29 ns |  1.00 |    0.06 |    2 |         - |          NA |
| Mistral  | 100 | 677.13 ns | 13.541 ns | 16.120 ns | 680.84 ns |  1.14 |    0.05 |    3 |         - |          NA |
| Llama    | 100 | 680.22 ns | 13.382 ns | 33.325 ns | 677.10 ns |  1.15 |    0.07 |    3 |         - |          NA |
| DeepSeek | 100 | 680.26 ns | 13.569 ns | 33.284 ns | 669.16 ns |  1.15 |    0.07 |    3 |         - |          NA |
| Grok     | 100 | 710.77 ns | 19.129 ns | 56.102 ns | 690.62 ns |  1.20 |    0.11 |    3 |         - |          NA |
| Claude   | 100 | 770.99 ns | 17.841 ns | 51.477 ns | 761.60 ns |  1.30 |    0.10 |    4 |         - |          NA |
