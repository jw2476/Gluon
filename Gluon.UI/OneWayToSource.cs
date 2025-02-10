using System.Windows.Data;
using Gluon.Reactive;

namespace Gluon.UI;
public sealed class OneWayToSource<T> : Binding, IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private T _value;

    public OneWayToSource()
    {
        Mode = BindingMode.OneWayToSource;
        Source = this;
        Path = new(nameof(Value));
    }

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            _observers.ForEach(observer => observer.OnNext(value));
        }
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);

        return new Subscription(() => _observers.Remove(observer));
    }
}
