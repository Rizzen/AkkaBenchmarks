using System.Threading.Tasks;

namespace AkkaBenchmarks
{
    public class HelloMessage
    {
        public TaskCompletionSource<object> Tcs { get; set; }
    }
}