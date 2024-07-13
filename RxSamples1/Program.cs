using System;
using System.Reactive;
using System.Reactive.Linq;

namespace RxSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();
            var clickObservable = Observable.FromEventPattern<EventHandler, EventArgs>(
             handler => button.Click += handler,
             handler => button.Click -= handler
            );

            clickObservable.Subscribe(
                evt => Console.WriteLine("Button clicked"),
                ex => Console.WriteLine($"Error: {ex.Message}"),
                () => Console.WriteLine("Completed")
            );

            // Simulate button click
            button.OnClick();
        }
    }

    class Button
    {
        public event EventHandler Click;

        public void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}