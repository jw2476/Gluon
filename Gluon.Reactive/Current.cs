namespace Gluon.Reactive;

public sealed class Current<T>
{
    public Current(IObservable<T> source)
    {
        _ = source.Subscribe(value => Value = value);
    }

    public T? Value { get; private set; }

    public static implicit operator T?(Current<T> self)
    {
        return self.Value;
    }
}
