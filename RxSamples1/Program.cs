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

            var concatenated = source1.Concat(source2);

            concatenated.Subscribe(
                value => Console.WriteLine($"Concatenated value: {value}"),
                () => Console.WriteLine("Concatenated completed")
            );
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
