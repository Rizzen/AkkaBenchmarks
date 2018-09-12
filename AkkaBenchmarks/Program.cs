using System;
using System.Threading.Tasks;
using Akka.Actor;
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