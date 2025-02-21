
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Primitives.StatusBar WithItemContainerTemplateSelector(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.ItemContainerTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemContainerTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithUsesItemContainerTemplate(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.UsesItemContainerTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemsSource(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithHasItems(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithDisplayMemberPath(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemTemplate(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemTemplateSelector(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemStringFormat(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemBindingGroup(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemContainerStyle(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemContainerStyleSelector(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithItemsPanel(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsGrouping(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithGroupStyleSelector(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithAlternationCount(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsTextSearchEnabled(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsTextSearchCaseSensitive(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithBorderBrush(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithBorderThickness(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithBackground(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithForeground(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFontFamily(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFontSize(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFontStretch(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFontStyle(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFontWeight(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithHorizontalContentAlignment(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithVerticalContentAlignment(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithTabIndex(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsTabStop(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithPadding(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithTemplate(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithStyle(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithOverridesDefaultStyle(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithUseLayoutRounding(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithDataContext(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithBindingGroup(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithLanguage(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithName(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithTag(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithInputScope(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithActualWidth(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithActualHeight(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithLayoutTransform(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithWidth(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithMinWidth(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithMaxWidth(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithHeight(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithMinHeight(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithMaxHeight(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFlowDirection(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithMargin(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithHorizontalAlignment(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithVerticalAlignment(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFocusVisualStyle(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithCursor(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithForceCursor(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithToolTip(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithContextMenu(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsMouseDirectlyOver(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsMouseOver(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsStylusOver(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsKeyboardFocusWithin(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsMouseCaptured(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsMouseCaptureWithin(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsStylusDirectlyOver(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsStylusCaptured(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsStylusCaptureWithin(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsKeyboardFocused(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithAreAnyTouchesOver(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithAreAnyTouchesCaptured(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithAllowDrop(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithRenderTransform(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithRenderTransformOrigin(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithOpacity(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithOpacityMask(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithBitmapEffect(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithEffect(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithBitmapEffectInput(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithCacheMode(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithUid(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithVisibility(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithClipToBounds(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithClip(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithSnapsToDevicePixels(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsFocused(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsEnabled(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsHitTestVisible(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsVisible(this System.Windows.Controls.Primitives.StatusBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithFocusable(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar WithIsManipulationEnabled(this System.Windows.Controls.Primitives.StatusBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBar.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseDoubleClick(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseDoubleClick(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTargetUpdated(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnSourceUpdated(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnDataContextChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnRequestBringIntoView(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnSizeChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnInitialized(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLoaded(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnUnloaded(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnToolTipOpening(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnToolTipClosing(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnContextMenuOpening(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnContextMenuClosing(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseLeftButtonDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseLeftButtonUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseRightButtonDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseRightButtonDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseRightButtonUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseRightButtonUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewMouseWheel(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseWheel(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseEnter(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnMouseLeave(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnGotMouseCapture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLostMouseCapture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnQueryCursor(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusInAirMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusInAirMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusEnter(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusLeave(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusInRange(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusInRange(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusOutOfRange(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusOutOfRange(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusSystemGesture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusSystemGesture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnGotStylusCapture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLostStylusCapture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusButtonDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnStylusButtonUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusButtonDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewStylusButtonUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewKeyDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnKeyDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewKeyUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnKeyUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewGotKeyboardFocus(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnGotKeyboardFocus(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewLostKeyboardFocus(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLostKeyboardFocus(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewTextInput(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTextInput(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewQueryContinueDrag(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnQueryContinueDrag(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewGiveFeedback(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnGiveFeedback(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewDragEnter(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnDragEnter(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewDragOver(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnDragOver(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewDragLeave(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnDragLeave(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewDrop(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnDrop(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewTouchDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTouchDown(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewTouchMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTouchMove(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnPreviewTouchUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTouchUp(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnGotTouchCapture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLostTouchCapture(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTouchEnter(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnTouchLeave(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsMouseCapturedChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsStylusCapturedChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsKeyboardFocusedChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLayoutUpdated(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnGotFocus(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnLostFocus(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsEnabledChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsHitTestVisibleChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnIsVisibleChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnFocusableChanged(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnManipulationStarting(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnManipulationStarted(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnManipulationDelta(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnManipulationInertiaStarting(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnManipulationBoundaryFeedback(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBar OnManipulationCompleted(this System.Windows.Controls.Primitives.StatusBar self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}