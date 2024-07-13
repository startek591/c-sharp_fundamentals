using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace RxSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create an observable that emits values every 300 milliseconds
            var source = Observable.Interval(TimeSpan.FromMilliseconds(300));

            // Throttle the emissions to one every second
            var throttled = source.Throttle(TimeSpan.FromSeconds(1));

            // Subscribe to the throttled observable
            throttled.Subscribe(
                value => Console.WriteLine($"Throttled value: {value}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed"));

            await Task.Delay(TimeSpan.FromSeconds(10)); // Keep the program running
        }
    }
}
