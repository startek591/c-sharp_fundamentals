using System;
using System.Collections.Immutable;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Timers;
using Timer = System.Timers.Timer;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var observable = Observable.Generate(
              0,
              x => x < 10,
              x => x + 1,
              x => x,
              x => TimeSpan.FromSeconds(x)
            );

            var subscription = observable.Subscribe(
              onNext: x => Console.WriteLine($"Received {x}"),
              onError: ex => Console.WriteLine($"Error: {ex}"),
              onCompleted: () => Console.WriteLine("Completed")
            );

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            subscription.Dispose();

        }
    }
}