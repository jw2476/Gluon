using System.ComponentModel;
using System.Windows.Data;
using Gluon.Reactive;

namespace Gluon.UI;

public class TwoWay<T> : Binding, INotifyPropertyChanged, IObservable<T>
{
    private readonly List<IObserver<T>> _observers = [];
    private T _value;

    public TwoWay(IObservable<T> observable)
    {
        _ = observable.Subscribe(value =>
        {
            _value = value;
            PropertyChanged?.Invoke(this, new(nameof(Value)));
        });

        Mode = BindingMode.TwoWay;
        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
        Source = this;
        Path = new(nameof(Value));
    }

    public TwoWay()
    {
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
            _observers.ForEach(observer => observer.OnNext(value!));
            PropertyChanged?.Invoke(this, new(nameof(Value)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observers.Add(observer);

        return new Subscription(() => _observers.Remove(observer));
    }

    public static implicit operator TwoWay<T>(T self)
    {
        return new(new ObservableValue<T>(self));
    }
}
