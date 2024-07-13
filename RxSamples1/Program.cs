using System;
using System.Reactive.Subjects;

namespace RxSamples
{
    public class Scada
    {
        private BehaviorSubject<double> sensorValue;
        public IObservable<double> SensorValue => sensorValue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sensorReading = new BehaviorSubject<double>(-1.0);

            sensorReading.Inspect("sensor");

            sensorReading.OnNext(0.99);

            sensorReading.OnCompleted();
        }
    }
}