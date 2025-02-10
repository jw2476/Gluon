namespace Gluon.Reactive;

public sealed class ObserveOn<T>(IObservable<T> source, SynchronizationContext context) : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private IDisposable? _subscription;

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);

        _subscription ??= source
            .Subscribe(value =>
                context.Send(
                    value => _observers.ForEach(observer =>
                        observer.OnNext((T)value!)),
                    value));

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
