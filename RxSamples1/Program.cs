using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var random = new Random();
            var source = Observable.Interval(TimeSpan.FromMilliseconds(5))
                .Select(_ => random.Next(0, 5));

            var debounced = source.Throttle(TimeSpan.FromSeconds(1));

            debounced.Subscribe(
                onNext: value => Console.WriteLine($"Debounced value: {value}"),
                onCompleted: () => Console.WriteLine("Sequence completed.")
            );

            Console.ReadLine();
        }
    }
}