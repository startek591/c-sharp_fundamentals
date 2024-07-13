using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var words = new[] { "apple", "banana", "cherry", "date", "fig", "grape" };
            var observableWords = words.ToObservable();
            var longWords = observableWords.Where(word => word.Length > 4);

            longWords.Subscribe(
                onNext: word => Console.WriteLine($"Long word: {word}"),
                onCompleted: () => Console.WriteLine("Sequence completed.")
            );

            Console.ReadLine();
        }
    }
}