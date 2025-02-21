
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ToolTip WithHorizontalOffset(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.HorizontalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithVerticalOffset(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.VerticalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsOpen(this System.Windows.Controls.ToolTip self, out ReadWriteBinding<System.Boolean> value)
    {
        
        var metadata = System.Windows.Controls.ToolTip.IsOpenProperty.GetMetadata(typeof(System.Windows.Controls.ToolTip))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ToolTip.IsOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithHasDropShadow(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.HasDropShadowProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithPlacementTarget(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.UIElement> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.PlacementTargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithPlacementRectangle(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Rect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.PlacementRectangleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithPlacement(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Controls.Primitives.PlacementMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.PlacementProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithCustomPopupPlacementCallback(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Controls.Primitives.CustomPopupPlacementCallback> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.CustomPopupPlacementCallbackProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithStaysOpen(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.StaysOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithShowsToolTipOnKeyboardFocus(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ShowsToolTipOnKeyboardFocusProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithContent(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithHasContent(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithContentTemplate(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithContentTemplateSelector(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithContentStringFormat(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithBorderBrush(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithBorderThickness(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithBackground(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithForeground(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFontFamily(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFontSize(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFontStretch(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFontStyle(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFontWeight(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithHorizontalContentAlignment(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithVerticalContentAlignment(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithTabIndex(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsTabStop(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithPadding(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithTemplate(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithStyle(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithOverridesDefaultStyle(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithUseLayoutRounding(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithDataContext(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithBindingGroup(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithLanguage(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithName(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithTag(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithInputScope(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithActualWidth(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithActualHeight(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithLayoutTransform(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithWidth(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithMinWidth(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithMaxWidth(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithHeight(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithMinHeight(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithMaxHeight(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFlowDirection(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithMargin(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithHorizontalAlignment(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithVerticalAlignment(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFocusVisualStyle(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithCursor(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithForceCursor(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithToolTip(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithContextMenu(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsMouseDirectlyOver(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsMouseOver(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsStylusOver(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsKeyboardFocusWithin(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsMouseCaptured(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsMouseCaptureWithin(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsStylusDirectlyOver(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsStylusCaptured(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsStylusCaptureWithin(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsKeyboardFocused(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithAreAnyTouchesOver(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithAreAnyTouchesCaptured(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithAllowDrop(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithRenderTransform(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithRenderTransformOrigin(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithOpacity(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithOpacityMask(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithBitmapEffect(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithEffect(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithBitmapEffectInput(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithCacheMode(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithUid(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithVisibility(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithClipToBounds(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithClip(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithSnapsToDevicePixels(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsFocused(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsEnabled(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsHitTestVisible(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsVisible(this System.Windows.Controls.ToolTip self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolTip.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithFocusable(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolTip WithIsManipulationEnabled(this System.Windows.Controls.ToolTip self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolTip.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ToolTip OnOpened(this System.Windows.Controls.ToolTip self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Opened += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnClosed(this System.Windows.Controls.ToolTip self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Closed += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseDoubleClick(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseDoubleClick(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTargetUpdated(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnSourceUpdated(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnDataContextChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnRequestBringIntoView(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnSizeChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnInitialized(this System.Windows.Controls.ToolTip self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLoaded(this System.Windows.Controls.ToolTip self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnUnloaded(this System.Windows.Controls.ToolTip self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnToolTipOpening(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnToolTipClosing(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnContextMenuOpening(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnContextMenuClosing(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseLeftButtonDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseLeftButtonUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseRightButtonDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseRightButtonDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseRightButtonUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseRightButtonUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewMouseWheel(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseWheel(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseEnter(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnMouseLeave(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnGotMouseCapture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLostMouseCapture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnQueryCursor(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusInAirMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusInAirMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusEnter(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusLeave(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusInRange(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusInRange(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusOutOfRange(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusOutOfRange(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusSystemGesture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusSystemGesture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnGotStylusCapture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLostStylusCapture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusButtonDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnStylusButtonUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusButtonDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewStylusButtonUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewKeyDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnKeyDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewKeyUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnKeyUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewGotKeyboardFocus(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnGotKeyboardFocus(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewLostKeyboardFocus(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLostKeyboardFocus(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewTextInput(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTextInput(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewQueryContinueDrag(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnQueryContinueDrag(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewGiveFeedback(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnGiveFeedback(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewDragEnter(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnDragEnter(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewDragOver(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnDragOver(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewDragLeave(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnDragLeave(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewDrop(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnDrop(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewTouchDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTouchDown(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewTouchMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTouchMove(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnPreviewTouchUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTouchUp(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnGotTouchCapture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLostTouchCapture(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTouchEnter(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnTouchLeave(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsMouseCapturedChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsStylusCapturedChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsKeyboardFocusedChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLayoutUpdated(this System.Windows.Controls.ToolTip self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnGotFocus(this System.Windows.Controls.ToolTip self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnLostFocus(this System.Windows.Controls.ToolTip self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsEnabledChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsHitTestVisibleChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnIsVisibleChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnFocusableChanged(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnManipulationStarting(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnManipulationStarted(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnManipulationDelta(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnManipulationInertiaStarting(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnManipulationBoundaryFeedback(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolTip OnManipulationCompleted(this System.Windows.Controls.ToolTip self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}