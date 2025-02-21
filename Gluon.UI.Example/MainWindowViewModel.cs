using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using Gluon.Core;

namespace Gluon.UI.Example;

public sealed record Selector(string Name, Predicate<int> Predicate)
{
    public bool Enabled { get; set; } = true;
};

internal class MainWindowViewModel : INotifyPropertyChanged
{
    private UIElement _content = new ContentControl();

    private StackPanel GetFilters(IEnumerable<int> input, out IObservable<IEnumerable<int>> output)
    {
        var selectors = new List<Selector>([
            new("Is Even", x => x % 2 == 0),
            new("Greater Than 5", x => x > 5)]);

        var (buttons, enabled) = selectors
            .Select(filter =>
            {
                var checkBox = filter.Name
                    .CheckBox()
                    .WithIsChecked(out var isEnabled);

                isEnabled.Value = true;

                return (checkBox, isEnabled.StartWith(true));
            })
            .ToList()
            .Unzip();

        output = enabled
            .CombineLatest()
            .Select(enabled => enabled
                .Zip(selectors)
                .Where(x => x.First ?? false)
                .Select(x => x.Second))
            .Select(filters => input
                .Where(value =>
                    filters.Any(filter => filter.Predicate(value))));

        return buttons
            .StackPanel()
            .WithOrientation(Orientation.Horizontal);
    }

    public MainWindowViewModel()
    {
        //var sendButton =
        //    "Click me!"
        //    .TextBlock()
        //    .Button()
        //    .OnClick(out var onClick);

        //var messageBox =
        //    UI.TextBox()
        //    .WithText(out var message)
        //    .OnKeyUp(out var onKeyUp)
        //    .WithMinWidth(300.0);

        //var onSend =
        //    onKeyUp
        //    .Where(e => e.Key == Key.Enter)
        //    .Select(_ => new Unit())
        //    .Merge(onClick);

        //var messages =
        //    onSend
        //    .ObserveOn(SynchronizationContext.Current!)
        //    .Select(_ =>
        //    message.Value)
        //    .Where(message => !string.IsNullOrWhiteSpace(message))
        //    .Do(_ => message.Value = "")
        //    .Select(UI.TextBlock)
        //    .Scan(
        //        Enumerable.Empty<FrameworkElement>(),
        //        (acc, item) => acc.Append(item))
        //    .Select(UI.StackPanel)
        //    .StartWith(UI.StackPanel([]));

        //var messageBar =
        //    UI.StackPanel([messageBox, sendButton])
        //    .WithOrientation(Orientation.Horizontal);

        //var ui =
        //    messages
        //    .Select(messages =>
        //        UI.StackPanel([
        //            messageBar,
        //            messages]));

        var filters = GetFilters(Enumerable.Range(0, 100), out var filtered);
        var ui = filtered
            .Select(filtered => UI.StackPanel([
                filters,
                .. filtered.Select(value => value
                    .ToString()
                    .TextBlock())]))
            .StartWith(UI.StackPanel([filters]));

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
