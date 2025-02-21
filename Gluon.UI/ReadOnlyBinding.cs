using System.Reactive.Disposables;
using System.Windows.Data;

namespace Gluon.UI;

public sealed class ReadOnlyBinding<T> : Binding, IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private T? _value;

    public ReadOnlyBinding()
    {
        Mode = BindingMode.OneWayToSource;
        Source = this;
        Path = new(nameof(Value));
    }

    public T Value
    {
        get => _value ?? throw new ArgumentException("Tried to read an unset binding.");
        private set
        {
            _value = value;
            _observers.ForEach(observer => observer.OnNext(value));
        }
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);

        return Disposable.Create(() => _observers.Remove(observer));
    }
}
