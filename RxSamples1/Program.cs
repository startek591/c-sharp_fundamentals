using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            // Create a sequence of integers
            var numbers = new[] { 1, 2, 0, 4, 5 };

            var query = numbers.ToObservable()
                .Select(x => 10 / x)
                .Catch<int, DivideByZeroException>(ex =>
                {
                    Console.WriteLine($"Caught exception: {ex.Message}");
                    return Observable.Empty<int>(); // Return an empty sequence as fallback
                });

            query.Subscribe(
                result => Console.WriteLine($"Result: {result}"),
                ex => Console.WriteLine($"Sequence faulted: {ex.Message}"),
                () => Console.WriteLine("Sequence completed")
            );
        }
    }
}
