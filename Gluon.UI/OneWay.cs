using System.ComponentModel;
using System.Windows.Data;
using Gluon.Reactive;

namespace Gluon.UI;

public class OneWay<T> : Binding, INotifyPropertyChanged
{
    public OneWay(IObservable<T> observable)
    {
        _ = observable.Subscribe(value =>
        {
            Value = value;
            PropertyChanged?.Invoke(this, new(nameof(Value)));
        });

        Mode = BindingMode.OneWay;
        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
        Source = this;
        Path = new(nameof(Value));
    }

    public T? Value { get; private set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    public static implicit operator OneWay<T>(T self)
    {
        return new(new Subject<T>().StartWith(self));
    }
}
