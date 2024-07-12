using System;

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
            var market = new Market();
            market.Subscribe(this);
        }
        static void Main(string[] args)
        {
            // OnNext* --> (OnError | OnCompleted)?
        }

        public void OnNext(float value)
        {
            Console.WriteLine($"Market gave us {value}");
        }

        public void OnError(Exception error)
        {

        }

        public void OnCompleted()
        {

        }
    }
}