using System;
using System.Collections.Immutable;
using System.Reactive.Subjects;
using System.Reactive.Disposables;

namespace RxSamples
{
    public class Market : IObservable<float>
    {
        private ImmutableHashSet<IObserver<float>> observers = ImmutableHashSet<IObserver<float>>.Empty;
        public IDisposable Subscribe(IObserver<float> observer)
        {
            observers = observers.Add(observer);
            return Disposable.Create(() =>
            {
                observers = observers.Remove(observer);
            });
        }

        public void Publish(float price)
        {
            foreach (var o in observers)
                o.OnNext(price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();
            var sub = market.Inspect("market");
            market.Publish(123.4f);

            sub.Dispose();

            market.Publish(321.0f);
        }
    }
}