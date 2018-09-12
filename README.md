# AkkaBenchmarks
``` ini

BenchmarkDotNet=v0.11.1, OS=Windows 10.0.14393.2368 (1607/AnniversaryUpdate/Redstone1)
Intel Core i5-2500 CPU 3.30GHz (Max: 3.70GHz) (Sandy Bridge), 1 CPU, 4 logical and 4 physical cores
Frequency=3215348 Hz, Resolution=311.0083 ns, Timer=TSC
.NET Core SDK=2.1.400
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  Job-QSGQUO : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT

InvocationCount=75000  UnrollFactor=25000  

```
|           Method |        Mean |      Error |    StdDev |
|----------------- |------------:|-----------:|----------:|
| TscTellBenchmark |    265.1 ns |   6.110 ns |  14.16 ns |
|     AskBenchmark | 11,122.3 ns | 209.703 ns | 215.35 ns |
