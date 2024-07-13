using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var interval = Observable.Interval(TimeSpan.FromSeconds(1));
            var filteredInterval = interval.Where(i => i % 2 == 0);

            filteredInterval.Subscribe(
                onNext: i => Console.WriteLine($"Even interval: {i}"),
                onCompleted: () => Console.WriteLine("Sequence completed.")
            );

            Console.ReadLine();
        }
    }
}