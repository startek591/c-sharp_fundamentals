using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var market = new Subject<float>(); // observable
            var marketConsumer = new Subject<float>(); // observer of 'market'
                                                       // observable

            market.Subscribe(marketConsumer);
            market
                .Inspect("market Consumer");

            market.OnNext(1, 2, 3, 4);
            market.OnCompleted();
        }
    }
}