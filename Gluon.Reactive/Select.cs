namespace Gluon.Reactive;

public sealed class Select<T, TResult>(
    IObservable<T> source,
    Func<T, TResult> func) : IObservable<TResult>
{
    private readonly List<IObserver<TResult>> _observers = [];
    private IDisposable? _subscription;

    public IDisposable Subscribe(IObserver<TResult> observer)
    {
        _observers.Add(observer);

        _subscription ??= source.Subscribe(value =>
                _observers.ForEach(observer =>
                    observer.OnNext(func(value))));

        return new Subscription(() =>
        {
            _observers.Remove(observer);

            if (_observers.Count == 0)
            {
                _subscription.Dispose();
            }
        });
    }
}
