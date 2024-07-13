using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = new[] { 1, 2, 0, 4, 5 };

            var query = numbers.ToObservable()
                .Select(x => 10 / x)
                .OnErrorResumeNext(Observable.Return(-1)); // Fallback to -1 on error

            query.Subscribe(
                result => Console.WriteLine($"Result: {result}"),
                ex => Console.WriteLine($"Sequence faulted: {ex.Message}"),
                () => Console.WriteLine("Sequence completed")
            );
        }
    }
}
