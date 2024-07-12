using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    public class Market : IObservable<float>
    {
        public IDisposable Subscribe(IObserver<float> observer)
        {
            throw new NotImplementedException();
        }
    }
    class Program : IObserver<float>
    {
        public Program()
        {
            var market = new Subject<float>();
            market.Subscribe(this);

            market.OnNext(1.24f);
            market.OnError(new Exception("opps"));
            // market.OnCompleted();
        }
        static void Main(string[] args)
        {
            // OnNext* --> (OnError | OnCompleted)?

            new Program();
        }

        public void OnNext(float value)
        {
            Console.WriteLine($"Market gave us {value}");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"We got an error {error.Message}");
        }

        public void OnCompleted()
        {
            Console.WriteLine("Sequence is complete");
        }
    }
}