namespace Gluon.Reactive;

public static class Extensions
{
    public static IDisposable Subscribe<T>(this IObservable<T> self, Action<T> onNext)
    {
        return self.Subscribe(new Observer<T>(onNext, _ => { }, () => { }));
    }

    public static IObservable<TResult> Select<T, TResult>(this IObservable<T> self, Func<T, TResult> func)
    {
        return new Select<T, TResult>(self, func);
    }

    public static IObservable<T> ObserveOn<T>(
        this IObservable<T> self,
        SynchronizationContext context)
    {
        return new ObserveOn<T>(self, context);
    }

    public static IObservable<TAccum> Aggregate<T, TAccum>(
        this IObservable<T> self,
        TAccum initial,
        Func<TAccum, T, TAccum> accumulate)
    {
        return new Aggregate<T, TAccum>(self, initial, accumulate);
    }

    public static IObservable<T> StartWith<T>(this IObservable<T> self, T initial)
    {
        return new StartWith<T>(self, initial);
    }

    public static Current<T> Current<T>(this IObservable<T> self)
    {
        return new Current<T>(self);
    }

    public static IObservable<T> Do<T>(this IObservable<T> self, Action<T> action)
    {
        return new Do<T>(self, action);
    }

    public static IObservable<T> Where<T>(this IObservable<T> self, Predicate<T> predicate)
    {
        return new Where<T>(self, predicate);
    }

    public static IObservable<T> Merge<T>(this IObservable<T> self, IObservable<T> other)
    {
        return new Merge<T>(self, other);
    }

    public static IObservable<IEnumerable<T?>> CombineLatest<T>(this IEnumerable<IObservable<T>> self)
    {
        return new CombineLatest<T>(self);
    }
}
