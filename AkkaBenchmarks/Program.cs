using BenchmarkDotNet.Running;

namespace AkkaBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<AskVsTcsBenchmark>();
        }
    }
}