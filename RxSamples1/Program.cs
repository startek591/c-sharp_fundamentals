using System;
using System.Reactive;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var customObservable = Observable.Create<int>(observer =>
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        observer.OnNext(i);
                    }
                    observer.OnCompleted();
                }
                catch (Exception ex)
                {
                    observer.OnError(ex);
                }
                return () => Console.WriteLine("Observer has unsubscribed");
            });

            customObservable.Subscribe(
                value => Console.WriteLine($"Received value: {value}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed")
            );
        }
    }
}