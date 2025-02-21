using System.Windows.Controls;
using Pion.Core;

namespace Pion.WPF;

public class Program
{
    [STAThread]
    private static void Main()
    {
        Console.WriteLine(ElementGenerator<TextBox>.Generate());
        Console.WriteLine("Yay");
    }
}
