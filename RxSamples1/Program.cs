using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace RxSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create an observable that emits values every 500 milliseconds
            var source = Observable.Interval(TimeSpan.FromMilliseconds(500));

            // Timeout each emission if no new value is emitted within 1 second
            var timedOut = source.Timeout(TimeSpan.FromSeconds(1));

            // Subscribe to the timed out observable
            timedOut.Subscribe(
                value => Console.WriteLine($"Timed out value: {value}"),
                ex => Console.WriteLine($"Timeout Error: {ex.Message}"),
                () => Console.WriteLine("Completed"));

            await Task.Delay(TimeSpan.FromSeconds(10)); //  Keep the program running
        }
    }
}
