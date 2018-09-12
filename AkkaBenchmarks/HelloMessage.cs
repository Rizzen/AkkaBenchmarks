using System.Threading.Tasks;

namespace AkkaBenchmarks
{
    public class HelloMessage
    {
        public TaskCompletionSource<string> Tcs { get; set; }
    }
}