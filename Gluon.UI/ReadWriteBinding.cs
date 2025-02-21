using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Data;

namespace Gluon.UI;

public sealed class ReadWriteBinding<T> : Binding, IObservable<T>, INotifyPropertyChanged
{
    private readonly List<IObserver<T>> _observers = [];
    private T _value;

    public ReadWriteBinding(T initial)
    {
        _value = initial;
        Mode = BindingMode.TwoWay;
        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
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
            PropertyChanged?.Invoke(this, new(nameof(Value)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);

        return Disposable.Create(() => _observers.Remove(observer));
    }

    public static implicit operator ReadWriteBinding<T>(T self)
    {
        return new ReadWriteBinding<T>(self);
    }
}
