using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var market = new ReplaySubject<float>();

            market.OnNext(123);
            market.Subscribe(x => Console.WriteLine($"Got the price {x}"));
        }
    }
}