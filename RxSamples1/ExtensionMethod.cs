namespace RxSamples;

static class ExtentsionMethods
{
    public static IObserver<T> OnNext<T>(this IObserver<T> self, params T[] args)
    {
        return self;
    }
}