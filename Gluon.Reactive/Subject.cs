namespace Gluon.Reactive;

public sealed class Subject<T> : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];

    public void OnNext(T value)
    {
        _observers.ForEach(observer => observer.OnNext(value));
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);
        return new Subscription(() => _observers.Remove(observer));
    }
}
