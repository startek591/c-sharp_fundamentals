using System;
using System.Collections.Immutable;
using System.Reactive.Subjects;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var obs = Observable.Return(42); // ReplaySubject
            obs.Inspect("obs");
        }
    }
}