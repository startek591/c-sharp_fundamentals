using System;
using System.Reactive.Subjects;

public class EventBroker
{
    private readonly Subject<string> eventStream = new Subject<string>();

    public IObservable<string> Events => eventStream;

    public void Publish(string eventData)
    {
        eventStream.OnNext(eventData);
    }
}

public class EventConsumer
{
    public EventConsumer(EventBroker eventBroker)
    {
        eventBroker.Events.Subscribe(data =>
        {
            Console.WriteLine($"Event received: {data}");
        });
    }
}

namespace RxSamples
{
    public class Program
    {
        public static void Main()
        {
            var broker = new EventBroker();
            var consumer = new EventConsumer(broker);

            broker.Publish("Event 1");
            broker.Publish("Event 2");
            broker.Publish("Event 3");

            Console.ReadLine();
        }
    }
}
