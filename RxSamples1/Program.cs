using System;
using System.Collections.Immutable;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Timers;
using Timer = System.Timers.Timer;

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

        public static IObservable<T> Return<T>(T value)
        {
            return Observable.Create<T>(x =>
            {
                x.OnNext(value);
                x.OnCompleted();
                return Disposable.Empty;
            });
        }
        static void Main(string[] args)
        {
            var obs = Observable.Create<string>(o =>
            {
                var timer = new Timer(1000);
                timer.Elapsed += (sender, e) => o.OnNext($"tick {e.SignalTime}");
                timer.Elapsed += TimerOnElapsed;
                timer.Start();
                return () =>
                {
                    timer.Elapsed -= TimerOnElapsed;
                    timer.Dispose();
                };
            });

            obs.Inspect("timer");
            Console.ReadLine();

            var sub = obs.Inspect("timer");
            Console.ReadLine();

            sub.Dispose();
            Console.ReadLine();
        }

        private static void TimerOnElapsed(object sender1, ElapsedEventArgs args)
        {
            Console.WriteLine($"tock {args.SignalTime}");
        }
    }
}