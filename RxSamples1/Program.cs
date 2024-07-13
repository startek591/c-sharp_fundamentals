using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = Observable.Range(1, 5);

            // Get the first element in the sequence
            numbers.FirstAsync().Subscribe(first =>
            {
                Console.WriteLine($"First element: {first}");
            });
        }
    }
}