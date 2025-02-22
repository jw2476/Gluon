
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ComboBox WithMaxDropDownHeight(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.MaxDropDownHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsDropDownOpen(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Boolean> value)
    {
        var metadata = System.Windows.Controls.ComboBox.IsDropDownOpenProperty.GetMetadata(typeof(System.Windows.Controls.ComboBox))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ComboBox.IsDropDownOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsDropDownOpen(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Boolean> value, System.Boolean initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ComboBox.IsDropDownOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithShouldPreserveUserEnteredPrefix(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ShouldPreserveUserEnteredPrefixProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsEditable(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsEditableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithText(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.String> value)
    {
        var metadata = System.Windows.Controls.ComboBox.TextProperty.GetMetadata(typeof(System.Windows.Controls.ComboBox))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.String)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ComboBox.TextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithText(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.String> value, System.String initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ComboBox.TextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsReadOnly(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsReadOnlyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectionBoxItem(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Object> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.SelectionBoxItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectionBoxItemTemplate(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Windows.DataTemplate> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.SelectionBoxItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectionBoxItemStringFormat(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.String> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.SelectionBoxItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithStaysOpenOnEdit(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.StaysOpenOnEditProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithIsSelectionActive(this System.Windows.FrameworkElement self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsSelectionActiveProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithIsSelected(this System.Windows.FrameworkElement self, out ReadWriteBinding<System.Boolean> value)
    {
        var metadata = System.Windows.Controls.ComboBox.IsSelectedProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ComboBox.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithIsSelected(this System.Windows.FrameworkElement self, out ReadWriteBinding<System.Boolean> value, System.Boolean initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ComboBox.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsSynchronizedWithCurrentItem(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsSynchronizedWithCurrentItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedIndex(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Int32> value)
    {
        var metadata = System.Windows.Controls.ComboBox.SelectedIndexProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Int32)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedIndex(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Int32> value, System.Int32 initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedItem(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Object> value)
    {
        var metadata = System.Windows.Controls.ComboBox.SelectedItemProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedItem(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Object> value, System.Object initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedValue(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Object> value)
    {
        var metadata = System.Windows.Controls.ComboBox.SelectedValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedValue(this System.Windows.Controls.ComboBox self, out ReadWriteBinding<System.Object> value, System.Object initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSelectedValuePath(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.SelectedValuePathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemsSource(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithHasItems(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithDisplayMemberPath(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemTemplate(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemTemplateSelector(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemStringFormat(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemBindingGroup(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemContainerStyle(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemContainerStyleSelector(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithItemsPanel(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsGrouping(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithGroupStyleSelector(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithAlternationCount(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithAlternationIndex(this System.Windows.FrameworkElement self, out ReadOnlyBinding<System.Int32> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.AlternationIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsTextSearchEnabled(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsTextSearchCaseSensitive(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithBorderBrush(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithBorderThickness(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithBackground(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithForeground(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFontFamily(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFontSize(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFontStretch(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFontStyle(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFontWeight(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithHorizontalContentAlignment(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithVerticalContentAlignment(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithTabIndex(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsTabStop(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithPadding(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithTemplate(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithStyle(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithOverridesDefaultStyle(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithUseLayoutRounding(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithDataContext(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithBindingGroup(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithLanguage(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithName(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithTag(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithInputScope(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithActualWidth(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithActualHeight(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithLayoutTransform(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithWidth(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithMinWidth(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithMaxWidth(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithHeight(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithMinHeight(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithMaxHeight(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFlowDirection(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithMargin(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithHorizontalAlignment(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithVerticalAlignment(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFocusVisualStyle(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithCursor(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithForceCursor(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithToolTip(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithContextMenu(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsMouseDirectlyOver(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsMouseOver(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsStylusOver(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsKeyboardFocusWithin(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsMouseCaptured(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsMouseCaptureWithin(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsStylusDirectlyOver(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsStylusCaptured(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsStylusCaptureWithin(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsKeyboardFocused(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithAreAnyTouchesOver(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithAreAnyTouchesCaptured(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithAllowDrop(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithRenderTransform(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithRenderTransformOrigin(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithOpacity(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithOpacityMask(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithBitmapEffect(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithEffect(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithBitmapEffectInput(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithCacheMode(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithUid(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithVisibility(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithClipToBounds(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithClip(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithSnapsToDevicePixels(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsFocused(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsEnabled(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsHitTestVisible(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsVisible(this System.Windows.Controls.ComboBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ComboBox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithFocusable(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ComboBox WithIsManipulationEnabled(this System.Windows.Controls.ComboBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ComboBox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ComboBox OnDropDownOpened(this System.Windows.Controls.ComboBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.DropDownOpened += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnDropDownClosed(this System.Windows.Controls.ComboBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.DropDownClosed += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnSelectionChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Controls.SelectionChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.SelectionChangedEventArgs>();
        self.SelectionChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseDoubleClick(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseDoubleClick(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTargetUpdated(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnSourceUpdated(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnDataContextChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnRequestBringIntoView(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnSizeChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnInitialized(this System.Windows.Controls.ComboBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLoaded(this System.Windows.Controls.ComboBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnUnloaded(this System.Windows.Controls.ComboBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnToolTipOpening(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnToolTipClosing(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnContextMenuOpening(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnContextMenuClosing(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseLeftButtonDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseLeftButtonUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseRightButtonDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseRightButtonDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseRightButtonUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseRightButtonUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewMouseWheel(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseWheel(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseEnter(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnMouseLeave(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnGotMouseCapture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLostMouseCapture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnQueryCursor(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusInAirMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusInAirMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusEnter(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusLeave(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusInRange(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusInRange(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusOutOfRange(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusOutOfRange(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusSystemGesture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusSystemGesture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnGotStylusCapture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLostStylusCapture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusButtonDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnStylusButtonUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusButtonDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewStylusButtonUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewKeyDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnKeyDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewKeyUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnKeyUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewGotKeyboardFocus(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnGotKeyboardFocus(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewLostKeyboardFocus(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLostKeyboardFocus(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewTextInput(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTextInput(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewQueryContinueDrag(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnQueryContinueDrag(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewGiveFeedback(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnGiveFeedback(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewDragEnter(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnDragEnter(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewDragOver(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnDragOver(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewDragLeave(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnDragLeave(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewDrop(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnDrop(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewTouchDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTouchDown(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewTouchMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTouchMove(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnPreviewTouchUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTouchUp(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnGotTouchCapture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLostTouchCapture(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTouchEnter(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnTouchLeave(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsMouseCapturedChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsStylusCapturedChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsKeyboardFocusedChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLayoutUpdated(this System.Windows.Controls.ComboBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnGotFocus(this System.Windows.Controls.ComboBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnLostFocus(this System.Windows.Controls.ComboBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsEnabledChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsHitTestVisibleChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnIsVisibleChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnFocusableChanged(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnManipulationStarting(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnManipulationStarted(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnManipulationDelta(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnManipulationInertiaStarting(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnManipulationBoundaryFeedback(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ComboBox OnManipulationCompleted(this System.Windows.Controls.ComboBox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}