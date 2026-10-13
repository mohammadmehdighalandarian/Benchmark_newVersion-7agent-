```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean       | Error     | StdDev     | Median     | Ratio | RatioSD | Rank | Gen0   | Allocated | Alloc Ratio |
|--------- |---- |-----------:|----------:|-----------:|-----------:|------:|--------:|-----:|-------:|----------:|------------:|
| DeepSeek | 10  |   6.153 ns | 0.2400 ns |  0.6887 ns |   5.949 ns |  0.76 |    0.10 |    1 |      - |         - |          NA |
| Mistral  | 10  |   6.232 ns | 0.1834 ns |  0.2961 ns |   6.230 ns |  0.77 |    0.07 |    1 |      - |         - |          NA |
| Gemini   | 10  |   8.012 ns | 0.2067 ns |  0.4361 ns |   7.927 ns |  0.99 |    0.10 |    2 |      - |         - |          NA |
| Claude   | 10  |   8.072 ns | 0.2010 ns |  0.3968 ns |   8.023 ns |  0.99 |    0.09 |    2 |      - |         - |          NA |
| Grok     | 10  |   8.163 ns | 0.2066 ns |  0.3618 ns |   8.162 ns |  1.00 |    0.09 |    2 |      - |         - |          NA |
| GPT      | 10  |   8.181 ns | 0.2540 ns |  0.7081 ns |   8.007 ns |  1.01 |    0.12 |    2 |      - |         - |          NA |
| Llama    | 10  |  27.962 ns | 0.7805 ns |  2.1886 ns |  27.535 ns |  3.44 |    0.39 |    3 | 0.0229 |      72 B |          NA |
|          |     |            |           |            |            |       |         |      |        |           |             |
| GPT      | 100 |  92.710 ns | 1.8291 ns |  4.4869 ns |  90.769 ns |  1.00 |    0.07 |    1 |      - |         - |          NA |
| Mistral  | 100 | 104.121 ns | 2.0907 ns |  5.1678 ns | 103.889 ns |  1.13 |    0.08 |    2 |      - |         - |          NA |
| DeepSeek | 100 | 108.952 ns | 2.8065 ns |  8.0524 ns | 106.872 ns |  1.18 |    0.10 |    2 |      - |         - |          NA |
| Claude   | 100 | 109.768 ns | 2.4607 ns |  6.9806 ns | 107.873 ns |  1.19 |    0.09 |    2 |      - |         - |          NA |
| Gemini   | 100 | 113.723 ns | 3.8115 ns | 11.1785 ns | 114.857 ns |  1.23 |    0.13 |    2 |      - |         - |          NA |
| Grok     | 100 | 132.516 ns | 3.5182 ns | 10.0377 ns | 132.390 ns |  1.43 |    0.13 |    3 |      - |         - |          NA |
| Llama    | 100 | 343.074 ns | 6.9495 ns | 14.6589 ns | 342.637 ns |  3.71 |    0.23 |    4 | 0.1373 |     432 B |          NA |
