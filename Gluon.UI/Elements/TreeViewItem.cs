
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.TreeViewItem WithIsExpanded(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsExpandedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsSelected(this System.Windows.Controls.TreeViewItem self, out ReadWriteBinding<System.Boolean> value)
    {
        var metadata = System.Windows.Controls.TreeViewItem.IsSelectedProperty.GetMetadata(typeof(System.Windows.Controls.TreeViewItem))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsSelected(this System.Windows.Controls.TreeViewItem self, out ReadWriteBinding<System.Boolean> value, System.Boolean initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsSelectionActive(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsSelectionActiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHeader(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHasHeader(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.HasHeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHeaderTemplate(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HeaderTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHeaderTemplateSelector(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HeaderTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHeaderStringFormat(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HeaderStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemsSource(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHasItems(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithDisplayMemberPath(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemTemplate(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemTemplateSelector(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemStringFormat(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemBindingGroup(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemContainerStyle(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemContainerStyleSelector(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithItemsPanel(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsGrouping(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithGroupStyleSelector(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithAlternationCount(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsTextSearchEnabled(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsTextSearchCaseSensitive(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithBorderBrush(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithBorderThickness(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithBackground(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithForeground(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFontFamily(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFontSize(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFontStretch(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFontStyle(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFontWeight(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHorizontalContentAlignment(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithVerticalContentAlignment(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithTabIndex(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsTabStop(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithPadding(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithTemplate(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithStyle(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithOverridesDefaultStyle(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithUseLayoutRounding(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithDataContext(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithBindingGroup(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithLanguage(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithName(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithTag(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithInputScope(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithActualWidth(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithActualHeight(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithLayoutTransform(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithWidth(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithMinWidth(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithMaxWidth(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHeight(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithMinHeight(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithMaxHeight(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFlowDirection(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithMargin(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithHorizontalAlignment(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithVerticalAlignment(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFocusVisualStyle(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithCursor(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithForceCursor(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithToolTip(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithContextMenu(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsMouseDirectlyOver(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsMouseOver(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsStylusOver(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsKeyboardFocusWithin(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsMouseCaptured(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsMouseCaptureWithin(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsStylusDirectlyOver(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsStylusCaptured(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsStylusCaptureWithin(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsKeyboardFocused(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithAreAnyTouchesOver(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithAreAnyTouchesCaptured(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithAllowDrop(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithRenderTransform(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithRenderTransformOrigin(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithOpacity(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithOpacityMask(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithBitmapEffect(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithEffect(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithBitmapEffectInput(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithCacheMode(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithUid(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithVisibility(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithClipToBounds(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithClip(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithSnapsToDevicePixels(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsFocused(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsEnabled(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsHitTestVisible(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsVisible(this System.Windows.Controls.TreeViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithFocusable(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem WithIsManipulationEnabled(this System.Windows.Controls.TreeViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.TreeViewItem.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.TreeViewItem OnExpanded(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Expanded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnCollapsed(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Collapsed += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnSelected(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Selected += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnUnselected(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unselected += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseDoubleClick(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseDoubleClick(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTargetUpdated(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnSourceUpdated(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnDataContextChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnRequestBringIntoView(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnSizeChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnInitialized(this System.Windows.Controls.TreeViewItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLoaded(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnUnloaded(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnToolTipOpening(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnToolTipClosing(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnContextMenuOpening(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnContextMenuClosing(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseLeftButtonDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseLeftButtonDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseLeftButtonUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseLeftButtonUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseRightButtonDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseRightButtonDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseRightButtonUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseRightButtonUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewMouseWheel(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseWheel(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseEnter(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnMouseLeave(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnGotMouseCapture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLostMouseCapture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnQueryCursor(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusInAirMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusInAirMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusEnter(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusLeave(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusInRange(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusInRange(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusOutOfRange(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusOutOfRange(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusSystemGesture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusSystemGesture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnGotStylusCapture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLostStylusCapture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusButtonDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnStylusButtonUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusButtonDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewStylusButtonUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewKeyDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnKeyDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewKeyUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnKeyUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewGotKeyboardFocus(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnGotKeyboardFocus(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewLostKeyboardFocus(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLostKeyboardFocus(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewTextInput(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTextInput(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewQueryContinueDrag(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnQueryContinueDrag(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewGiveFeedback(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnGiveFeedback(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewDragEnter(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnDragEnter(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewDragOver(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnDragOver(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewDragLeave(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnDragLeave(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewDrop(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnDrop(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewTouchDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTouchDown(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewTouchMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTouchMove(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnPreviewTouchUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTouchUp(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnGotTouchCapture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLostTouchCapture(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTouchEnter(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnTouchLeave(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsMouseDirectlyOverChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsMouseCapturedChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsMouseCaptureWithinChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsStylusDirectlyOverChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsStylusCapturedChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsStylusCaptureWithinChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsKeyboardFocusedChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLayoutUpdated(this System.Windows.Controls.TreeViewItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnGotFocus(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnLostFocus(this System.Windows.Controls.TreeViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsEnabledChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsHitTestVisibleChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnIsVisibleChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnFocusableChanged(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnManipulationStarting(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnManipulationStarted(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnManipulationDelta(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnManipulationInertiaStarting(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnManipulationBoundaryFeedback(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeViewItem OnManipulationCompleted(this System.Windows.Controls.TreeViewItem self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}