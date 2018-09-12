using System;
using Akka.Actor;

namespace AkkaBenchmarks
{
    public class HelloActor : ReceiveActor
    {
        private object Some = new object();
        public HelloActor()
        {
            
            Receive(ReceiveHello());
            Receive(ReceiveAsk());
        }

        private Action<HelloMessage> ReceiveHello() 
            => message
                =>
                {
                    message.Tcs.TrySetResult("Hello!");
                };
        
        private Action<AskMessage> ReceiveAsk() 
            => message
                =>
                {
                    Sender.Tell(Some);
                };
    }
}