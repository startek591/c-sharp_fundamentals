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
            var obs = Observable.Never<int>(); // ReplaySubject
            obs.Inspect("obs");
        }
    }
}