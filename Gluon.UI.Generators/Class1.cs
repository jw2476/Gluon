
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Gluon.UI.Generators;

[Generator]
public class ElementGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(static context =>
        {
            context.AddSource("UI.StackPanel.g.cs",
                SourceText.From("""
                    using System.Windows;
                    using Gluon.Core;
                    using Gluon.Reactive;

                    namespace Gluon.UI;

                    public static partial class UI {
                        public static System.Windows.Controls.StackPanel StackPanel(this IEnumerable<FrameworkElement> self)
                        {
                            var element = new System.Windows.Controls.StackPanel();
                            self.ForEach(child => element.Children.Add(child.Disconnect()));
                            return element;
                        }
                    }  
                    """, Encoding.UTF8));
        });
    }
}

