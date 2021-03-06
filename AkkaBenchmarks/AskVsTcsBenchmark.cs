using System.Threading.Tasks;
using Akka.Actor;
using BenchmarkDotNet.Attributes;

namespace AkkaBenchmarks
{
    [InvocationCount(75000,25000)]
    [MarkdownExporter]
    [MemoryDiagnoser]
    public class AskVsTcsBenchmark
    {
        private readonly ActorSystem system;
        private readonly IActorRef actor;
        private HelloMessage helloMessage;
        private AskMessage askMessage;
        
        public AskVsTcsBenchmark()
        {
            system = ActorSystem.Create("HelloSystem");
            actor = system.ActorOf(Props.Create<HelloActor>());
        }

        [IterationSetup]
        public void IterationSetup()
        {
            helloMessage = new HelloMessage {Tcs = new TaskCompletionSource<object>()};
            askMessage = new AskMessage();
        }
        
        [Benchmark]
        public async Task<object> TscTellBenchmark()
        {
            actor.Tell(helloMessage);
            return (await helloMessage.Tcs.Task);
        }
        
        [Benchmark]
        public async Task<object> AskBenchmark()
        {
            return await actor.Ask<object>(askMessage);;
        }
    }
}