using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Gluon.Core;

namespace Gluon.UI.Example;

internal class MainWindowViewModel : INotifyPropertyChanged
{
    private UIElement _content = new ContentControl();

    public MainWindowViewModel()
    {
        var sendButton =
            "Click me!"
            .TextBlock()
            .Button()
            .OnClick(out var onClick);

        var messageBox =
            UI.TextBox()
            .WithText(out var message)
            .OnKeyUp(out var onKeyUp)
            .WithMinWidth(300.0);

        var onSend =
            onKeyUp
            .Where(e => e.Key == Key.Enter)
            .Select(_ => new Unit())
            .Merge(onClick);

        var messages =
            onSend
            .ObserveOn(SynchronizationContext.Current!)
            .Select(_ =>
            message.Value)
            .Where(message => !string.IsNullOrWhiteSpace(message))
            .Do(_ => message.Value = "")
            .Select(UI.TextBlock)
            .Scan(
                Enumerable.Empty<FrameworkElement>(),
                (acc, item) => acc.Append(item))
            .Select(UI.StackPanel)
            .StartWith(UI.StackPanel([]));

        var messageBar =
            UI.StackPanel([messageBox, sendButton])
            .WithOrientation(Orientation.Horizontal);

        var ui =
            messages
            .Select(messages =>
                UI.StackPanel([
                    messageBar,
                    messages]));

        ui.Subscribe(x => Content = x.ContentControl());
    }

    public UIElement Content
    {
        get => _content;
        private set
        {
            _content = value;
            PropertyChanged?.Invoke(this, new(nameof(Content)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
