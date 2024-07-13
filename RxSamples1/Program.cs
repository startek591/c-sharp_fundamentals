using System;
using System.Collections.Immutable;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using System.Reactive.Disposables;

namespace RxSamples
{
    class Program
    {
        private static IObservable<string> Blocking()
        {
            var subj = new ReplaySubject<string>();
            subj.OnNext("foo");
            subj.OnNext("bar");
            subj.OnCompleted();
            Thread.Sleep(3000);
            return subj;
        }

        private static IObservable<string> NonBlocking()
        {
            return Observable.Create<string>(obeserver =>
            {
                obeserver.OnNext("foo");
                obeserver.OnNext("bar");
                obeserver.OnCompleted();
                Thread.Sleep(3000);
                return Disposable.Empty;
            });
        }
        static void Main(string[] args)
        {
            Blocking().Inspect("blocking");
            NonBlocking().Inspect("nonblocking");
        }
    }
}