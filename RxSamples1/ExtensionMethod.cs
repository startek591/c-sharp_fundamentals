namespace RxSamples;

static class ExtentsionMethods
{
    public static IDisposable Inspect<T>(this IObservable<T> self, string name)
    {
        return self.Subscribe(
            x => Console.WriteLine($"{name} has generated value {x}"),
            ex => Console.WriteLine($"{name} has generated exception {ex.Message}"),
            () => Console.WriteLine($"{name} has completed")
        );
    }

    public static IObserver<T> OnNext<T>(this IObserver<T> self, params T[] args)
    {
        return self;
    }
}