
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ScrollViewer WithCanContentScroll(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.CanContentScrollProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithHorizontalScrollBarVisibility(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithVerticalScrollBarVisibility(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithComputedHorizontalScrollBarVisibility(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Windows.Visibility> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ComputedHorizontalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithComputedVerticalScrollBarVisibility(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Windows.Visibility> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ComputedVerticalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithVerticalOffset(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.VerticalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithHorizontalOffset(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.HorizontalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContentVerticalOffset(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContentVerticalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContentHorizontalOffset(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContentHorizontalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithExtentWidth(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ExtentWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithExtentHeight(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ExtentHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithScrollableWidth(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ScrollableWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithScrollableHeight(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ScrollableHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithViewportWidth(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ViewportWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithViewportHeight(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ViewportHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsDeferredScrollingEnabled(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithPanningMode(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Controls.PanningMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.PanningModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithPanningDeceleration(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.PanningDecelerationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithPanningRatio(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.PanningRatioProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContent(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithHasContent(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContentTemplate(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContentTemplateSelector(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContentStringFormat(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithBorderBrush(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithBorderThickness(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithBackground(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithForeground(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFontFamily(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFontSize(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFontStretch(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFontStyle(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFontWeight(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithHorizontalContentAlignment(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithVerticalContentAlignment(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithTabIndex(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsTabStop(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithPadding(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithTemplate(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithStyle(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithOverridesDefaultStyle(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithUseLayoutRounding(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithDataContext(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithBindingGroup(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithLanguage(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithName(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithTag(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithInputScope(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithActualWidth(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithActualHeight(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithLayoutTransform(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithWidth(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithMinWidth(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithMaxWidth(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithHeight(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithMinHeight(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithMaxHeight(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFlowDirection(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithMargin(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithHorizontalAlignment(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithVerticalAlignment(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFocusVisualStyle(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithCursor(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithForceCursor(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithToolTip(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithContextMenu(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsMouseDirectlyOver(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsMouseOver(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsStylusOver(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsKeyboardFocusWithin(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsMouseCaptured(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsMouseCaptureWithin(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsStylusDirectlyOver(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsStylusCaptured(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsStylusCaptureWithin(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsKeyboardFocused(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithAreAnyTouchesOver(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithAreAnyTouchesCaptured(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithAllowDrop(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithRenderTransform(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithRenderTransformOrigin(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithOpacity(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithOpacityMask(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithBitmapEffect(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithEffect(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithBitmapEffectInput(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithCacheMode(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithUid(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithVisibility(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithClipToBounds(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithClip(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithSnapsToDevicePixels(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsFocused(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsEnabled(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsHitTestVisible(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsVisible(this System.Windows.Controls.ScrollViewer self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithFocusable(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer WithIsManipulationEnabled(this System.Windows.Controls.ScrollViewer self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ScrollViewer.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ScrollViewer OnScrollChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Controls.ScrollChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ScrollChangedEventArgs>();
        self.ScrollChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseDoubleClick(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseDoubleClick(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTargetUpdated(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnSourceUpdated(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnDataContextChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnRequestBringIntoView(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnSizeChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnInitialized(this System.Windows.Controls.ScrollViewer self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLoaded(this System.Windows.Controls.ScrollViewer self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnUnloaded(this System.Windows.Controls.ScrollViewer self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnToolTipOpening(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnToolTipClosing(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnContextMenuOpening(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnContextMenuClosing(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseLeftButtonDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseLeftButtonUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseRightButtonDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseRightButtonDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseRightButtonUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseRightButtonUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewMouseWheel(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseWheel(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseEnter(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnMouseLeave(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnGotMouseCapture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLostMouseCapture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnQueryCursor(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusInAirMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusInAirMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusEnter(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusLeave(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusInRange(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusInRange(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusOutOfRange(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusOutOfRange(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusSystemGesture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusSystemGesture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnGotStylusCapture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLostStylusCapture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusButtonDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnStylusButtonUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusButtonDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewStylusButtonUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewKeyDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnKeyDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewKeyUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnKeyUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewGotKeyboardFocus(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnGotKeyboardFocus(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewLostKeyboardFocus(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLostKeyboardFocus(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewTextInput(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTextInput(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewQueryContinueDrag(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnQueryContinueDrag(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewGiveFeedback(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnGiveFeedback(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewDragEnter(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnDragEnter(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewDragOver(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnDragOver(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewDragLeave(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnDragLeave(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewDrop(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnDrop(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewTouchDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTouchDown(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewTouchMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTouchMove(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnPreviewTouchUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTouchUp(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnGotTouchCapture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLostTouchCapture(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTouchEnter(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnTouchLeave(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsMouseCapturedChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsStylusCapturedChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsKeyboardFocusedChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLayoutUpdated(this System.Windows.Controls.ScrollViewer self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnGotFocus(this System.Windows.Controls.ScrollViewer self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnLostFocus(this System.Windows.Controls.ScrollViewer self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsEnabledChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsHitTestVisibleChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnIsVisibleChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnFocusableChanged(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnManipulationStarting(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnManipulationStarted(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnManipulationDelta(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnManipulationInertiaStarting(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnManipulationBoundaryFeedback(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ScrollViewer OnManipulationCompleted(this System.Windows.Controls.ScrollViewer self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}