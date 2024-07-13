using System;
using System.Reactive.Linq;

using System.Timers;


namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var numbersObservable = numbers.ToObservable();

            numbersObservable.Subscribe(
                number => Console.WriteLine($"Recieved value: {number}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed")
            );
        }
    }
}