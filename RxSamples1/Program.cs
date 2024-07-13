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
             .Select(x => x * 10) // Transform each number
             .Subscribe(x => Console.WriteLine($"Transformed: {x}"));
        }
    }
}
