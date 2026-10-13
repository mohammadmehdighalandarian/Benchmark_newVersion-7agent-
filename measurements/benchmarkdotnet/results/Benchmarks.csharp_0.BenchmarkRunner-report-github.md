```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean      | Error    | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |----------:|---------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| Gemini   | 10  |  13.30 ns | 0.308 ns |  0.548 ns |  13.35 ns |  0.98 |    0.11 |    1 |         - |          NA |
| GPT      | 10  |  13.65 ns | 0.512 ns |  1.485 ns |  13.21 ns |  1.01 |    0.15 |    1 |         - |          NA |
| Mistral  | 10  |  13.80 ns | 0.520 ns |  1.440 ns |  13.38 ns |  1.02 |    0.15 |    1 |         - |          NA |
| DeepSeek | 10  |  13.96 ns | 0.335 ns |  0.971 ns |  13.81 ns |  1.03 |    0.13 |    1 |         - |          NA |
| Llama    | 10  |  13.97 ns | 0.424 ns |  1.216 ns |  13.72 ns |  1.03 |    0.14 |    1 |         - |          NA |
| Grok     | 10  |  14.25 ns | 0.496 ns |  1.431 ns |  14.10 ns |  1.06 |    0.15 |    1 |         - |          NA |
| Claude   | 10  |  16.86 ns | 1.090 ns |  3.127 ns |  16.76 ns |  1.25 |    0.26 |    2 |         - |          NA |
|          |     |           |          |           |           |       |         |      |           |             |
| Llama    | 100 | 153.56 ns | 3.097 ns |  7.882 ns | 152.43 ns |  0.99 |    0.07 |    1 |         - |          NA |
| GPT      | 100 | 156.07 ns | 3.175 ns |  8.850 ns | 154.26 ns |  1.00 |    0.08 |    1 |         - |          NA |
| Gemini   | 100 | 161.97 ns | 4.169 ns | 12.094 ns | 158.75 ns |  1.04 |    0.10 |    1 |         - |          NA |
| Mistral  | 100 | 163.35 ns | 5.346 ns | 15.253 ns | 159.33 ns |  1.05 |    0.11 |    1 |         - |          NA |
| DeepSeek | 100 | 163.45 ns | 5.984 ns | 17.266 ns | 156.63 ns |  1.05 |    0.12 |    1 |         - |          NA |
| Grok     | 100 | 167.25 ns | 6.483 ns | 18.706 ns | 161.90 ns |  1.07 |    0.13 |    1 |         - |          NA |
| Claude   | 100 | 168.28 ns | 5.087 ns | 13.925 ns | 163.17 ns |  1.08 |    0.11 |    1 |         - |          NA |
