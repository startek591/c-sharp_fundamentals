using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = Observable.Range(1, 10);
            var oddNumbers = numbers.Where(n => n % 2 != 0);

            oddNumbers.Subscribe(
                onNext: n => Console.WriteLine($"Odd number: {n}"),
                onCompleted: () => Console.WriteLine("Sequence completed.")
            );

            Console.ReadLine();
        }
    }
}