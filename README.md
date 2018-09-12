# AkkaBenchmarks
``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.14393.2368 (1607/AnniversaryUpdate/Redstone1)
Intel Core i5-2500 CPU 3.30GHz (Max: 3.70GHz) (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
Frequency=3215348 Hz, Resolution=311.0083 ns, Timer=TSC
.NET Core SDK=2.1.400
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Job-WBGJEC : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT

InvocationCount=75000  UnrollFactor=25000  

```
|           Method |       Mean |      Error |    StdDev |     Median |  Gen 0 | Allocated |
|----------------- |-----------:|-----------:|----------:|-----------:|-------:|----------:|
| TscTellBenchmark |   227.0 ns |   7.487 ns |  12.30 ns |   222.1 ns | 0.0133 |      75 B |
|     AskBenchmark | 9,562.6 ns | 183.313 ns | 469.90 ns | 9,344.3 ns | 0.5467 |    1528 B |
