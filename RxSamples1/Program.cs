using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeWindow = TimeSpan.FromMilliseconds(500);
            var market = new ReplaySubject<float>(timeWindow);

            market.OnNext(123);
            market.OnNext(234);
            market.OnNext(456);

            market.Subscribe(x => Console.WriteLine($"Got the price {x}"));
        }
    }
}