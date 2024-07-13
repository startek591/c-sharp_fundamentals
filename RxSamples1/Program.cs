using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = Observable.Range(1, 5);

            numbers
            .Where(x => x % 2 == 0) // Filter even numbers
            .Subscribe(x => Console.WriteLine($"Even Number: {x}"));
        }
    }
}
