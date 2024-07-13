using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            // Create a sequence of integers
            var numbers = Observable.Range(1, 5);

            // Aggregate the sequence into a single sum
            var sum = numbers.Aggregate((acc, x) => acc + x);

            // Subscribe to the sum result
            sum.Subscribe(result =>
            {
                Console.WriteLine($"Sum: {result}");
            });

            Console.ReadLine(); // Keep console open
        }
    }
}
