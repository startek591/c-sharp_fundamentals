using System;
using System.Reactive.Linq;

using System.Timers;


namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleValue = 42;
            var singleValueObservable = Observable.Return(singleValue);

            singleValueObservable.Subscribe(
                value => Console.WriteLine($"Recieved value: {value}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed")
            );
        }
    }
}