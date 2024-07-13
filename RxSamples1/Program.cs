using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var numbers1 = Observable.Range(1, 3);
            var numbers2 = Observable.Range(4, 3);

            numbers1
                .Zip(numbers2, (x, y) => $"Combined: {x} + {y} = {x + y}") // Combine with addition
                .Subscribe(result => Console.WriteLine(result));
        }
    }
}
