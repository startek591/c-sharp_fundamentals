using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new Subject<float>();
            using (sensor.Subscribe(Console.WriteLine))
            {
                // Anything outside of this block is unsubscribe
                // automatically
                sensor.OnNext(1);
                sensor.OnNext(2);
                sensor.OnNext(3);
            }
            // This value will not print
            sensor.OnNext(4);
            // Unsubscribing
            sensor.Dispose();
        }
    }
}