```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |----------:|----------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| Llama    | 10  | 0.0294 ns | 0.0277 ns | 0.0794 ns | 0.0000 ns |  0.07 |    0.20 |    1 |         - |          NA |
| Claude   | 10  | 0.2980 ns | 0.0519 ns | 0.1128 ns | 0.2998 ns |  0.72 |    0.36 |    2 |         - |          NA |
| Gemini   | 10  | 0.3242 ns | 0.0512 ns | 0.1068 ns | 0.3130 ns |  0.78 |    0.36 |    2 |         - |          NA |
| Grok     | 10  | 0.3375 ns | 0.0514 ns | 0.1084 ns | 0.3328 ns |  0.81 |    0.37 |    2 |         - |          NA |
| Mistral  | 10  | 0.4337 ns | 0.0525 ns | 0.1073 ns | 0.4247 ns |  1.05 |    0.42 |    3 |         - |          NA |
| GPT      | 10  | 0.4537 ns | 0.0522 ns | 0.1384 ns | 0.4430 ns |  1.09 |    0.48 |    3 |         - |          NA |
| DeepSeek | 10  | 0.6150 ns | 0.1128 ns | 0.3272 ns | 0.5963 ns |  1.48 |    0.94 |    4 |         - |          NA |
|          |     |           |           |           |           |       |         |      |           |             |
| Mistral  | 100 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| GPT      | 100 | 0.0214 ns | 0.0373 ns | 0.1051 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| Grok     | 100 | 0.1346 ns | 0.0752 ns | 0.2170 ns | 0.0000 ns |     ? |       ? |    2 |         - |           ? |
| DeepSeek | 100 | 0.2649 ns | 0.0320 ns | 0.0267 ns | 0.2631 ns |     ? |       ? |    3 |         - |           ? |
| Gemini   | 100 | 0.6414 ns | 0.1327 ns | 0.3806 ns | 0.5525 ns |     ? |       ? |    4 |         - |           ? |
| Llama    | 100 | 0.6871 ns | 0.1196 ns | 0.3354 ns | 0.6288 ns |     ? |       ? |    4 |         - |           ? |
| Claude   | 100 | 0.8978 ns | 0.1034 ns | 0.3000 ns | 0.8941 ns |     ? |       ? |    5 |         - |           ? |
