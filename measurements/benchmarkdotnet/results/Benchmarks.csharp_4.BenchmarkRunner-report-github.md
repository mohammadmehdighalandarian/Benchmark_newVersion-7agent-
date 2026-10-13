```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean      | Error    | StdDev    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |----------:|---------:|----------:|------:|--------:|-----:|----------:|------------:|
| Mistral  | 10  |  35.00 ns | 0.251 ns |  0.446 ns |  0.79 |    0.17 |    1 |         - |          NA |
| DeepSeek | 10  |  35.06 ns | 0.224 ns |  0.209 ns |  0.79 |    0.17 |    1 |         - |          NA |
| Llama    | 10  |  37.38 ns | 0.278 ns |  0.309 ns |  0.84 |    0.18 |    2 |         - |          NA |
| Claude   | 10  |  38.02 ns | 0.796 ns |  1.983 ns |  0.86 |    0.19 |    2 |         - |          NA |
| Gemini   | 10  |  40.03 ns | 0.858 ns |  2.433 ns |  0.90 |    0.20 |    2 |         - |          NA |
| Grok     | 10  |  43.12 ns | 1.573 ns |  4.563 ns |  0.97 |    0.24 |    2 |         - |          NA |
| GPT      | 10  |  46.67 ns | 3.525 ns | 10.393 ns |  1.05 |    0.33 |    2 |         - |          NA |
|          |     |           |          |           |       |         |      |           |             |
| Mistral  | 100 | 213.09 ns | 0.610 ns |  0.541 ns |  0.96 |    0.00 |    1 |         - |          NA |
| Grok     | 100 | 214.46 ns | 0.662 ns |  0.619 ns |  0.97 |    0.00 |    1 |         - |          NA |
| Claude   | 100 | 214.51 ns | 3.207 ns |  2.843 ns |  0.97 |    0.01 |    1 |         - |          NA |
| DeepSeek | 100 | 215.10 ns | 1.542 ns |  1.514 ns |  0.97 |    0.01 |    1 |         - |          NA |
| Gemini   | 100 | 218.71 ns | 0.690 ns |  0.645 ns |  0.99 |    0.00 |    1 |         - |          NA |
| GPT      | 100 | 221.29 ns | 0.811 ns |  0.719 ns |  1.00 |    0.00 |    1 |         - |          NA |
| Llama    | 100 | 231.66 ns | 4.673 ns |  9.223 ns |  1.05 |    0.04 |    1 |         - |          NA |
