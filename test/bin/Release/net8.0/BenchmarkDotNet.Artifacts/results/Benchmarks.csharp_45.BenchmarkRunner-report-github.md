```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |----------:|----------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| Claude   | 10  | 0.1055 ns | 0.0443 ns | 0.0915 ns | 0.0787 ns |  0.11 |    0.09 |    1 |         - |          NA |
| DeepSeek | 10  | 0.7241 ns | 0.0565 ns | 0.0912 ns | 0.6963 ns |  0.73 |    0.14 |    2 |         - |          NA |
| Gemini   | 10  | 0.7382 ns | 0.0582 ns | 0.1574 ns | 0.7259 ns |  0.75 |    0.20 |    2 |         - |          NA |
| Grok     | 10  | 0.9189 ns | 0.0614 ns | 0.1154 ns | 0.9071 ns |  0.93 |    0.18 |    3 |         - |          NA |
| GPT      | 10  | 1.0131 ns | 0.0645 ns | 0.1547 ns | 0.9960 ns |  1.02 |    0.22 |    3 |         - |          NA |
| Mistral  | 10  | 1.0903 ns | 0.1215 ns | 0.3563 ns | 0.9536 ns |  1.10 |    0.40 |    3 |         - |          NA |
| Llama    | 10  | 1.2050 ns | 0.1446 ns | 0.4240 ns | 1.1918 ns |  1.22 |    0.47 |    3 |         - |          NA |
|          |     |           |           |           |           |       |         |      |           |             |
| Claude   | 100 | 0.1294 ns | 0.0464 ns | 0.0906 ns | 0.1239 ns |  0.14 |    0.10 |    1 |         - |          NA |
| Gemini   | 100 | 0.4354 ns | 0.0591 ns | 0.0768 ns | 0.4203 ns |  0.48 |    0.10 |    2 |         - |          NA |
| Mistral  | 100 | 0.6998 ns | 0.1147 ns | 0.3382 ns | 0.5876 ns |  0.78 |    0.38 |    3 |         - |          NA |
| DeepSeek | 100 | 0.7987 ns | 0.0626 ns | 0.1693 ns | 0.7593 ns |  0.89 |    0.21 |    4 |         - |          NA |
| Llama    | 100 | 0.9101 ns | 0.0571 ns | 0.1141 ns | 0.8995 ns |  1.01 |    0.16 |    5 |         - |          NA |
| GPT      | 100 | 0.9113 ns | 0.0634 ns | 0.0949 ns | 0.8995 ns |  1.01 |    0.14 |    5 |         - |          NA |
| Grok     | 100 | 1.0666 ns | 0.1212 ns | 0.3553 ns | 0.9588 ns |  1.18 |    0.41 |    5 |         - |          NA |
