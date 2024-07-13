using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = Observable.Range(1, 5);

            // Check if any element satisfies the condition
            numbers.Any(x => x > 3).Subscribe(hasElement =>
            {
                Console.WriteLine($"Any element greater than 3: {hasElement}");
            });
        }
    }
}