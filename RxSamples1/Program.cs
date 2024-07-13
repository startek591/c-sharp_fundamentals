using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new AsyncSubject<double>();
            sensor.Inspect("async");

            sensor.OnNext(1.0);
            sensor.OnNext(2.0);
            sensor.OnNext(3.0);
            sensor.OnCompleted();
        }
    }
}