using System;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;

namespace RxSamples
{
    class Program
    {
        static async Task Main()
        {
            var task = Task.Run(() => 42);
            var taskObservable = task.ToObservable();

            taskObservable.Subscribe(
                value => Console.WriteLine($"Received value: {value}"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed")
            );

            await task; // Wait for task completion to keep the console open
        }
    }
}