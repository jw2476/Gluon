﻿namespace Gluon.Reactive;

public sealed class Do<T>(
    IObservable<T> source,
    Action<T> action) : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private IDisposable? _subscription;

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);

        _subscription ??= source.Subscribe(value =>
        {
            action(value);
            _observers.ForEach(observer => observer.OnNext(value));
        });

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

