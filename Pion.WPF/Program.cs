using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Pion.Core;

namespace Pion.WPF;

public class Program
{
    [STAThread]
    private static void Main()
    {
        Project.Create()
            .Add<Button>()
            .Add<CheckBox>()
            .Add<ComboBox>()
            .Add<ContentControl>()
            .Add<DataGrid>()
            .Add<DockPanel>()
            .Add<Expander>()
            .Add<Grid>()
            .Add<Image>()
            .Add<Label>()
            .Add<ListBox>()
            .Add<ListBoxItem>()
            .Add<ListView>()
            .Add<ListViewItem>()
            .Add<Menu>()
            .Add<MenuItem>()
            .Add<RadioButton>()
            .Add<PasswordBox>()
            .Add<Popup>()
            .Add<ProgressBar>()
            .Add<RichTextBox>()
            .Add<ScrollBar>()
            .Add<ScrollViewer>()
            .Add<Separator>()
            .Add<Slider>()
            .Add<StackPanel>()
            .Add<StatusBar>()
            .Add<StatusBarItem>()
            .Add<TabControl>()
            .Add<TextBlock>()
            .Add<TextBox>()
            .Add<ToolBar>()
            .Add<ToolBarTray>()
            .Add<ToolTip>()
            .Add<TreeView>()
            .Add<TreeViewItem>()
            .Add<UniformGrid>()
            .Add<WrapPanel>()
            .Add<Viewbox>()
            .Finish();
    }
}
