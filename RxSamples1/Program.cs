using System;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main()
        {
            var source = Observable.Defer(() =>
        {
            Console.WriteLine("Executing...");
            if (DateTime.Now.Second % 3 != 0)
                throw new Exception("Failed");
            return Observable.Return(DateTime.Now);
        });

            var query = source.Retry(3); // Retry 3 times

            query.Subscribe(
                result => Console.WriteLine($"Received: {result}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed")
            );

            Console.ReadKey();
        }
    }
}
