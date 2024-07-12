using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    class Program
    {
        public Program()
        {
            var market = new Subject<float>();
            market.Subscribe(
                f => Console.WriteLine($"Price is {f}"),
                () => Console.WriteLine("Sequence is complete")
            );

            market.OnNext(1.24f);
            // market.OnError(new Exception("oops"));
            market.OnCompleted();
        }
        static void Main(string[] args)
        {
            // OnNext* --> (OnError | OnCompleted)?

            new Program();
        }
    }
}