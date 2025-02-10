using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    private static T Disconnect<T>(this T self)
        where T : FrameworkElement
    {
        var parent = self.Parent;

        if (parent is Panel panel)
        {
            panel.Children.Remove(self);
        }
        else if (parent is ContentControl control)
        {
            control.Content = null;
        }

        return self;
    }

    public static TextBlock TextBlock(this string self)
    {
        return new TextBlock()
        {
            Text = self,
        };
    }

    public static StackPanel StackPanel(this IEnumerable<FrameworkElement> self)
    {
        var element = new StackPanel();
        self.ForEach(child => element.Children.Add(child.Disconnect()));
        return element;
    }

    public static Button Button(this FrameworkElement self)
    {
        return new Button()
        {
            Content = self.Disconnect(),
        };
    }

    public static TextBox TextBox()
    {
        return new TextBox();
    }

    public static ContentControl ContentControl(this FrameworkElement self)
    {
        return new ContentControl()
        {
            Content = self.Disconnect(),
        };
    }

    public static T OnClick<T>(this T self, out IObservable<Unit> handler)
        where T : ButtonBase
    {
        var subject = new Subject<Unit>();
        self.Click += (_, _) => subject.OnNext(new());
        handler = subject;

        return self;
    }

    public static T WithText<T>(this T self, out TwoWay<string> value)
        where T : TextBox
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.TextProperty, value);
        return self;
    }

    public static T WithOrientation<T>(this T self, OneWay<Orientation> value)
        where T : StackPanel
    {
        self.SetBinding(System.Windows.Controls.StackPanel.OrientationProperty, value);
        return self;
    }

    public static T WithMinWidth<T>(this T self, OneWay<double> value)
        where T : FrameworkElement
    {
        self.SetBinding(FrameworkElement.WidthProperty, value);
        return self;
    }
}

