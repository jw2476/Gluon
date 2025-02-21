using System.Windows;
using System.Windows.Controls;
using Gluon.Core;

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
}

