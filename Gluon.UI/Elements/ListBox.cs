
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ListBox WithSelectionMode(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.SelectionMode> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.SelectionModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedItems(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Collections.IList> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.SelectedItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsSynchronizedWithCurrentItem(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsSynchronizedWithCurrentItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedIndex(this System.Windows.Controls.ListBox self, out ReadWriteBinding<System.Int32> value)
    {
        var metadata = System.Windows.Controls.ListBox.SelectedIndexProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Int32)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListBox.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedIndex(this System.Windows.Controls.ListBox self, out ReadWriteBinding<System.Int32> value, System.Int32 initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ListBox.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedItem(this System.Windows.Controls.ListBox self, out ReadWriteBinding<System.Object> value)
    {
        var metadata = System.Windows.Controls.ListBox.SelectedItemProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListBox.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedItem(this System.Windows.Controls.ListBox self, out ReadWriteBinding<System.Object> value, System.Object initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ListBox.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedValue(this System.Windows.Controls.ListBox self, out ReadWriteBinding<System.Object> value)
    {
        var metadata = System.Windows.Controls.ListBox.SelectedValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListBox.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedValue(this System.Windows.Controls.ListBox self, out ReadWriteBinding<System.Object> value, System.Object initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ListBox.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSelectedValuePath(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.SelectedValuePathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemsSource(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithHasItems(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithDisplayMemberPath(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemTemplate(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemTemplateSelector(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemStringFormat(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemBindingGroup(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemContainerStyle(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemContainerStyleSelector(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithItemsPanel(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsGrouping(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithGroupStyleSelector(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithAlternationCount(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsTextSearchEnabled(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsTextSearchCaseSensitive(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithBorderBrush(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithBorderThickness(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithBackground(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithForeground(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFontFamily(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFontSize(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFontStretch(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFontStyle(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFontWeight(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithHorizontalContentAlignment(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithVerticalContentAlignment(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithTabIndex(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsTabStop(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithPadding(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithTemplate(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithStyle(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithOverridesDefaultStyle(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithUseLayoutRounding(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithDataContext(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithBindingGroup(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithLanguage(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithName(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithTag(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithInputScope(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithActualWidth(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithActualHeight(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithLayoutTransform(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithWidth(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithMinWidth(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithMaxWidth(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithHeight(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithMinHeight(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithMaxHeight(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFlowDirection(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithMargin(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithHorizontalAlignment(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithVerticalAlignment(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFocusVisualStyle(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithCursor(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithForceCursor(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithToolTip(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithContextMenu(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsMouseDirectlyOver(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsMouseOver(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsStylusOver(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsKeyboardFocusWithin(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsMouseCaptured(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsMouseCaptureWithin(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsStylusDirectlyOver(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsStylusCaptured(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsStylusCaptureWithin(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsKeyboardFocused(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithAreAnyTouchesOver(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithAreAnyTouchesCaptured(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithAllowDrop(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithRenderTransform(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithRenderTransformOrigin(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithOpacity(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithOpacityMask(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithBitmapEffect(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithEffect(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithBitmapEffectInput(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithCacheMode(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithUid(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithVisibility(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithClipToBounds(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithClip(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithSnapsToDevicePixels(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsFocused(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsEnabled(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsHitTestVisible(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsVisible(this System.Windows.Controls.ListBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithFocusable(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBox WithIsManipulationEnabled(this System.Windows.Controls.ListBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListBox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ListBox OnSelectionChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Controls.SelectionChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.SelectionChangedEventArgs>();
        self.SelectionChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseDoubleClick(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseDoubleClick(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTargetUpdated(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnSourceUpdated(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnDataContextChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnRequestBringIntoView(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnSizeChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnInitialized(this System.Windows.Controls.ListBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLoaded(this System.Windows.Controls.ListBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnUnloaded(this System.Windows.Controls.ListBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnToolTipOpening(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnToolTipClosing(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnContextMenuOpening(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnContextMenuClosing(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseLeftButtonDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseLeftButtonUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseRightButtonDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseRightButtonDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseRightButtonUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseRightButtonUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewMouseWheel(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseWheel(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseEnter(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnMouseLeave(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnGotMouseCapture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLostMouseCapture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnQueryCursor(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusInAirMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusInAirMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusEnter(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusLeave(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusInRange(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusInRange(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusOutOfRange(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusOutOfRange(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusSystemGesture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusSystemGesture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnGotStylusCapture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLostStylusCapture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusButtonDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnStylusButtonUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusButtonDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewStylusButtonUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewKeyDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnKeyDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewKeyUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnKeyUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewGotKeyboardFocus(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnGotKeyboardFocus(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewLostKeyboardFocus(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLostKeyboardFocus(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewTextInput(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTextInput(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewQueryContinueDrag(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnQueryContinueDrag(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewGiveFeedback(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnGiveFeedback(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewDragEnter(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnDragEnter(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewDragOver(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnDragOver(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewDragLeave(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnDragLeave(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewDrop(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnDrop(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewTouchDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTouchDown(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewTouchMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTouchMove(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnPreviewTouchUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTouchUp(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnGotTouchCapture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLostTouchCapture(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTouchEnter(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnTouchLeave(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsMouseCapturedChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsStylusCapturedChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsKeyboardFocusedChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLayoutUpdated(this System.Windows.Controls.ListBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnGotFocus(this System.Windows.Controls.ListBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnLostFocus(this System.Windows.Controls.ListBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsEnabledChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsHitTestVisibleChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnIsVisibleChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnFocusableChanged(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnManipulationStarting(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnManipulationStarted(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnManipulationDelta(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnManipulationInertiaStarting(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnManipulationBoundaryFeedback(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBox OnManipulationCompleted(this System.Windows.Controls.ListBox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}