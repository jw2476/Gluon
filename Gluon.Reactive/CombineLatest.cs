namespace Gluon.Reactive;

public sealed class CombineLatest<T> : IObservable<IEnumerable<T?>>
{
    private readonly List<IObserver<IEnumerable<T?>>> _observers = [];
    private readonly List<T?> _values;

    public CombineLatest(IEnumerable<IObservable<T>> observables)
    {
        _values = [.. Enumerable.Repeat<T?>(default, observables.Count())];

        _ = observables.Select((observable, i) =>
            observable.Subscribe(value =>
            {
                _values[i] = value;
                _observers.ForEach(observer => observer.OnNext(_values));
            }))
            .ToList();
    }

    public IDisposable Subscribe(IObserver<IEnumerable<T?>> observer)
    {
        _observers.Add(observer);

        return new Subscription(() => _observers.Remove(observer));
    }
}
