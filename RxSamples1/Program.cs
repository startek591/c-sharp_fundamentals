using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = Observable.Range(1, 5);

            // Count the elements in the sequence
            numbers.Count().Subscribe(count =>
            {
                Console.WriteLine($"Number of elements: {count}");
            });
        }
    }
}