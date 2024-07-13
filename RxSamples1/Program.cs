using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var source1 = Observable.Interval(TimeSpan.FromSeconds(1)).Take(3);
            var source2 = Observable.Interval(TimeSpan.FromSeconds(0.5)).Take(4);

            var merged = source1.Merge(source2);

            merged.Subscribe(
                value => Console.WriteLine($"Merged value: {value}"),
                () => Console.WriteLine("Merged completed")
            );

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
