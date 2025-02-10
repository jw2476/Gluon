namespace Gluon.Reactive;

public class ObservableValue<T>(T initial) : IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private T _value = initial;

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            _observers.ForEach(x => x.OnNext(value));
        }
    }

    public static implicit operator T(ObservableValue<T> self)
    {
        return self.Value;
    }

    public static implicit operator ObservableValue<T>(T initial)
    {
        return new(initial);
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);
        return new Subscription(() => _observers.Remove(observer));
    }
}
