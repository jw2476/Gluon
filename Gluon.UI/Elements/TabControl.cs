
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.TabControl WithTabStripPlacement(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.Dock> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.TabStripPlacementProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedContent(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Object> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.SelectedContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedContentTemplate(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Windows.DataTemplate> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.SelectedContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedContentTemplateSelector(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.SelectedContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedContentStringFormat(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.String> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.SelectedContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithContentTemplate(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithContentTemplateSelector(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithContentStringFormat(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsSynchronizedWithCurrentItem(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsSynchronizedWithCurrentItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedIndex(this System.Windows.Controls.TabControl self, out ReadWriteBinding<System.Int32> value)
    {
        var metadata = System.Windows.Controls.TabControl.SelectedIndexProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Int32)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.TabControl.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedIndex(this System.Windows.Controls.TabControl self, out ReadWriteBinding<System.Int32> value, System.Int32 initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.TabControl.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedItem(this System.Windows.Controls.TabControl self, out ReadWriteBinding<System.Object> value)
    {
        var metadata = System.Windows.Controls.TabControl.SelectedItemProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.TabControl.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedItem(this System.Windows.Controls.TabControl self, out ReadWriteBinding<System.Object> value, System.Object initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.TabControl.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedValue(this System.Windows.Controls.TabControl self, out ReadWriteBinding<System.Object> value)
    {
        var metadata = System.Windows.Controls.TabControl.SelectedValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.TabControl.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedValue(this System.Windows.Controls.TabControl self, out ReadWriteBinding<System.Object> value, System.Object initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.TabControl.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSelectedValuePath(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.SelectedValuePathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemsSource(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithHasItems(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithDisplayMemberPath(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemTemplate(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemTemplateSelector(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemStringFormat(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemBindingGroup(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemContainerStyle(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemContainerStyleSelector(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithItemsPanel(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsGrouping(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithGroupStyleSelector(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithAlternationCount(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsTextSearchEnabled(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsTextSearchCaseSensitive(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithBorderBrush(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithBorderThickness(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithBackground(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithForeground(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFontFamily(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFontSize(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFontStretch(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFontStyle(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFontWeight(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithHorizontalContentAlignment(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithVerticalContentAlignment(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithTabIndex(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsTabStop(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithPadding(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithTemplate(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithStyle(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithOverridesDefaultStyle(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithUseLayoutRounding(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithDataContext(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithBindingGroup(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithLanguage(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithName(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithTag(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithInputScope(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithActualWidth(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithActualHeight(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithLayoutTransform(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithWidth(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithMinWidth(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithMaxWidth(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithHeight(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithMinHeight(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithMaxHeight(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFlowDirection(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithMargin(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithHorizontalAlignment(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithVerticalAlignment(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFocusVisualStyle(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithCursor(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithForceCursor(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithToolTip(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithContextMenu(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsMouseDirectlyOver(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsMouseOver(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsStylusOver(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsKeyboardFocusWithin(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsMouseCaptured(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsMouseCaptureWithin(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsStylusDirectlyOver(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsStylusCaptured(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsStylusCaptureWithin(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsKeyboardFocused(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithAreAnyTouchesOver(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithAreAnyTouchesCaptured(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithAllowDrop(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithRenderTransform(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithRenderTransformOrigin(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithOpacity(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithOpacityMask(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithBitmapEffect(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithEffect(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithBitmapEffectInput(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithCacheMode(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithUid(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithVisibility(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithClipToBounds(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithClip(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithSnapsToDevicePixels(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsFocused(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsEnabled(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsHitTestVisible(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsVisible(this System.Windows.Controls.TabControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TabControl.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithFocusable(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TabControl WithIsManipulationEnabled(this System.Windows.Controls.TabControl self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TabControl.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.TabControl OnSelectionChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Controls.SelectionChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.SelectionChangedEventArgs>();
        self.SelectionChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseDoubleClick(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseDoubleClick(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTargetUpdated(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnSourceUpdated(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnDataContextChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnRequestBringIntoView(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnSizeChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnInitialized(this System.Windows.Controls.TabControl self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLoaded(this System.Windows.Controls.TabControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnUnloaded(this System.Windows.Controls.TabControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnToolTipOpening(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnToolTipClosing(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnContextMenuOpening(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnContextMenuClosing(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseLeftButtonDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseLeftButtonDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseLeftButtonUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseLeftButtonUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseRightButtonDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseRightButtonDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseRightButtonUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseRightButtonUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewMouseWheel(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseWheel(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseEnter(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnMouseLeave(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnGotMouseCapture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLostMouseCapture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnQueryCursor(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusInAirMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusInAirMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusEnter(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusLeave(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusInRange(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusInRange(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusOutOfRange(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusOutOfRange(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusSystemGesture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusSystemGesture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnGotStylusCapture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLostStylusCapture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusButtonDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnStylusButtonUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusButtonDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewStylusButtonUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewKeyDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnKeyDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewKeyUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnKeyUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewGotKeyboardFocus(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnGotKeyboardFocus(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewLostKeyboardFocus(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLostKeyboardFocus(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewTextInput(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTextInput(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewQueryContinueDrag(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnQueryContinueDrag(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewGiveFeedback(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnGiveFeedback(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewDragEnter(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnDragEnter(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewDragOver(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnDragOver(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewDragLeave(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnDragLeave(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewDrop(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnDrop(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewTouchDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTouchDown(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewTouchMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTouchMove(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnPreviewTouchUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTouchUp(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnGotTouchCapture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLostTouchCapture(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTouchEnter(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnTouchLeave(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsMouseDirectlyOverChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsMouseCapturedChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsMouseCaptureWithinChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsStylusDirectlyOverChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsStylusCapturedChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsStylusCaptureWithinChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsKeyboardFocusedChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLayoutUpdated(this System.Windows.Controls.TabControl self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnGotFocus(this System.Windows.Controls.TabControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnLostFocus(this System.Windows.Controls.TabControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsEnabledChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsHitTestVisibleChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnIsVisibleChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnFocusableChanged(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnManipulationStarting(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnManipulationStarted(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnManipulationDelta(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnManipulationInertiaStarting(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnManipulationBoundaryFeedback(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TabControl OnManipulationCompleted(this System.Windows.Controls.TabControl self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}