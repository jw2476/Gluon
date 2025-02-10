namespace Gluon.Reactive;

public sealed class Aggregate<T, TAccum> : IObservable<TAccum>
{
    private readonly List<IObserver<TAccum>> _observers = [];
    private TAccum _accumulator;

    public Aggregate(
        IObservable<T> source,
        TAccum initial,
        Func<TAccum, T, TAccum> accumulate)
    {
        _accumulator = initial;
        _ = source
            .Subscribe(value =>
            {
                _accumulator = accumulate(_accumulator, value);
                _observers.ForEach(observer => observer.OnNext(_accumulator));
            });
    }

    public IDisposable Subscribe(IObserver<TAccum> observer)
    {
        _observers.Add(observer);

        return new Subscription(() => _observers.Remove(observer));
    }
}
