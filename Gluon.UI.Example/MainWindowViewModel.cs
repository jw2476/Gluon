using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using Gluon.Core;

namespace Gluon.UI.Example;


internal class MainWindowViewModel : INotifyPropertyChanged
{
    private UIElement _content = new ContentControl();

    private StackPanel GetSelectors(IEnumerable<int> input, out IObservable<IEnumerable<int>> output)
    {
        (CheckBox Element, IObservable<IEnumerable<int>> Output) GetSelector(string name, IEnumerable<int> items)
        {
            return (
                name.CheckBox().WithIsChecked(out var on, true),
                on.StartWith(true).Select(on => on == true ? items : []));
        }

        var selectors = new List<(string, IEnumerable<int>)>([
            ("Greater Than 5", input.Where(x => x > 5)),
            ("Is Even", input.Where(x => x % 2 == 0))]);

        var (checkBoxes, outputs) = selectors
            .Select(selector => GetSelector(selector.Item1, selector.Item2))
            .Unzip();

        output = outputs
            .CombineLatest()
            .Select(outputs => outputs.SelectMany().Distinct().Order());

        return checkBoxes
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

        var filters = GetSelectors(Enumerable.Range(0, 100), out var filtered);
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
