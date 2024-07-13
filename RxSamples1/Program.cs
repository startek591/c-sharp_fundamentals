using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace RxSamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create an observable that emits values every second
            var source = Observable.Interval(TimeSpan.FromSeconds(1));

            // Delay each emitted value by 3 seconds
            var delayed = source.Delay(TimeSpan.FromSeconds(3));

            // Subscribe to the delayed observable
            delayed.Subscribe(
                value => Console.WriteLine($"Delayed value: {value}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed"));

            await Task.Delay(TimeSpan.FromSeconds(10));
        }
    }
}
