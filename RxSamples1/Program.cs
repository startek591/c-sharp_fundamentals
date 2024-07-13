using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers = new[] { 1, 2, 2, 3, 4, 4, 5 };
            var observableNumbers = numbers.ToObservable();
            var distinctNumbers = observableNumbers.Distinct();

            distinctNumbers.Subscribe(
                onNext: n => Console.WriteLine($"Distinct number: {n}"),
                onCompleted: () => Console.WriteLine("Sequence completed.")
            );

            Console.ReadLine();
        }
    }
}