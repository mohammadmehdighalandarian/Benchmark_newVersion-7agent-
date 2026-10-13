```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean       | Error     | StdDev     | Median     | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |-----------:|----------:|-----------:|-----------:|------:|--------:|-----:|----------:|------------:|
| Grok     | 10  |   1.025 ns | 0.0906 ns |  0.1240 ns |   1.037 ns |  0.06 |    0.01 |    1 |         - |          NA |
| Gemini   | 10  |   2.135 ns | 0.0822 ns |  0.0769 ns |   2.139 ns |  0.12 |    0.01 |    2 |         - |          NA |
| Mistral  | 10  |   2.794 ns | 0.2408 ns |  0.7025 ns |   2.511 ns |  0.16 |    0.04 |    3 |         - |          NA |
| DeepSeek | 10  |  17.126 ns | 0.3829 ns |  0.7735 ns |  17.076 ns |  0.99 |    0.09 |    4 |         - |          NA |
| GPT      | 10  |  17.489 ns | 0.5586 ns |  1.6029 ns |  16.992 ns |  1.01 |    0.13 |    4 |         - |          NA |
| Claude   | 10  |  17.531 ns | 0.3911 ns |  0.9593 ns |  17.389 ns |  1.01 |    0.10 |    4 |         - |          NA |
| Llama    | 10  |  17.571 ns | 0.3928 ns |  0.8371 ns |  17.516 ns |  1.01 |    0.10 |    4 |         - |          NA |
|          |     |            |           |            |            |       |         |      |           |             |
| Mistral  | 100 |   2.223 ns | 0.0901 ns |  0.1625 ns |   2.223 ns |  0.01 |    0.00 |    1 |         - |          NA |
| Grok     | 100 |   3.031 ns | 0.1599 ns |  0.4430 ns |   2.975 ns |  0.02 |    0.00 |    2 |         - |          NA |
| Gemini   | 100 |   3.231 ns | 0.3950 ns |  1.1332 ns |   3.034 ns |  0.02 |    0.01 |    2 |         - |          NA |
| GPT      | 100 | 185.182 ns | 3.7606 ns |  9.7072 ns | 182.092 ns |  1.00 |    0.07 |    3 |         - |          NA |
| DeepSeek | 100 | 197.653 ns | 7.1214 ns | 19.9693 ns | 192.099 ns |  1.07 |    0.12 |    3 |         - |          NA |
| Llama    | 100 | 208.736 ns | 8.8263 ns | 25.6068 ns | 203.738 ns |  1.13 |    0.15 |    3 |         - |          NA |
| Claude   | 100 | 216.514 ns | 8.4844 ns | 24.0689 ns | 220.064 ns |  1.17 |    0.14 |    3 |         - |          NA |
