namespace Gluon.Reactive;

public sealed class StartWith<T>(
    IObservable<T> source,
    T initial) : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private IDisposable? _subscription;

    public IDisposable Subscribe(IObserver<T> observer)
    {
        observer.OnNext(initial);

        _observers.Add(observer);

        _subscription ??= source.Subscribe(value =>
                _observers.ForEach(observer =>
                    observer.OnNext(value)));

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

