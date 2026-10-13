```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i5-8250U CPU 1.60GHz (Max: 1.80GHz) (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3


```
| Method   | N   | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Rank | Allocated | Alloc Ratio |
|--------- |---- |----------:|----------:|----------:|----------:|------:|--------:|-----:|----------:|------------:|
| Grok     | 10  | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| DeepSeek | 10  | 0.0041 ns | 0.0100 ns | 0.0209 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| Mistral  | 10  | 0.0219 ns | 0.0218 ns | 0.0569 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| GPT      | 10  | 0.0266 ns | 0.0329 ns | 0.0353 ns | 0.0127 ns |     ? |       ? |    2 |         - |           ? |
| Llama    | 10  | 0.0605 ns | 0.0314 ns | 0.0906 ns | 0.0000 ns |     ? |       ? |    2 |         - |           ? |
| Claude   | 10  | 0.0796 ns | 0.0388 ns | 0.0690 ns | 0.0669 ns |     ? |       ? |    3 |         - |           ? |
| Gemini   | 10  | 0.0990 ns | 0.0372 ns | 0.1056 ns | 0.0767 ns |     ? |       ? |    3 |         - |           ? |
|          |     |           |           |           |           |       |         |      |           |             |
| Mistral  | 100 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| Gemini   | 100 | 0.0083 ns | 0.0139 ns | 0.0300 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| DeepSeek | 100 | 0.0651 ns | 0.0602 ns | 0.1647 ns | 0.0000 ns |     ? |       ? |    1 |         - |           ? |
| GPT      | 100 | 0.0722 ns | 0.0334 ns | 0.0875 ns | 0.0460 ns |     ? |       ? |    2 |         - |           ? |
| Grok     | 100 | 0.0785 ns | 0.0393 ns | 0.0971 ns | 0.0395 ns |     ? |       ? |    2 |         - |           ? |
| Llama    | 100 | 0.0868 ns | 0.0379 ns | 0.0950 ns | 0.0595 ns |     ? |       ? |    3 |         - |           ? |
| Claude   | 100 | 0.1614 ns | 0.0449 ns | 0.0630 ns | 0.1575 ns |     ? |       ? |    4 |         - |           ? |
