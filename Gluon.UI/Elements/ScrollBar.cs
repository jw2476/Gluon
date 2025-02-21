
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Primitives.ScrollBar WithOrientation(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Controls.Orientation> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithViewportSize(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ViewportSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMinimum(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MinimumProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMaximum(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MaximumProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithValue(this System.Windows.Controls.Primitives.ScrollBar self, out ReadWriteBinding<System.Double> value)
    {
        
        var metadata = System.Windows.Controls.Primitives.ScrollBar.ValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.RangeBase))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Double)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithLargeChange(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.LargeChangeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithSmallChange(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.SmallChangeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithBorderBrush(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithBorderThickness(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithBackground(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithForeground(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFontFamily(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFontSize(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFontStretch(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFontStyle(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFontWeight(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithHorizontalContentAlignment(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithVerticalContentAlignment(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithTabIndex(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsTabStop(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithPadding(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithTemplate(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithStyle(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithOverridesDefaultStyle(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithUseLayoutRounding(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithDataContext(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithBindingGroup(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithLanguage(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithName(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithTag(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithInputScope(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithActualWidth(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithActualHeight(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithLayoutTransform(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithWidth(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMinWidth(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMaxWidth(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithHeight(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMinHeight(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMaxHeight(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFlowDirection(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithMargin(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithHorizontalAlignment(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithVerticalAlignment(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFocusVisualStyle(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithCursor(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithForceCursor(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithToolTip(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithContextMenu(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsMouseDirectlyOver(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsMouseOver(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsStylusOver(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsKeyboardFocusWithin(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsMouseCaptured(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsMouseCaptureWithin(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsStylusDirectlyOver(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsStylusCaptured(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsStylusCaptureWithin(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsKeyboardFocused(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithAreAnyTouchesOver(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithAreAnyTouchesCaptured(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithAllowDrop(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithRenderTransform(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithRenderTransformOrigin(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithOpacity(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithOpacityMask(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithBitmapEffect(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithEffect(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithBitmapEffectInput(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithCacheMode(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithUid(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithVisibility(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithClipToBounds(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithClip(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithSnapsToDevicePixels(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsFocused(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsEnabled(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsHitTestVisible(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsVisible(this System.Windows.Controls.Primitives.ScrollBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithFocusable(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar WithIsManipulationEnabled(this System.Windows.Controls.Primitives.ScrollBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.ScrollBar.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Primitives.ScrollBar OnScroll(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Controls.Primitives.ScrollEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.Primitives.ScrollEventArgs>();
        self.Scroll += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnValueChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> handler)
    {
        var subject = new Subject<System.Windows.RoutedPropertyChangedEventArgs<System.Double>>();
        self.ValueChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseDoubleClick(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseDoubleClick(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTargetUpdated(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnSourceUpdated(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnDataContextChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnRequestBringIntoView(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnSizeChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnInitialized(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLoaded(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnUnloaded(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnToolTipOpening(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnToolTipClosing(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnContextMenuOpening(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnContextMenuClosing(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseLeftButtonDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseLeftButtonUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseRightButtonDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseRightButtonDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseRightButtonUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseRightButtonUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewMouseWheel(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseWheel(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseEnter(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnMouseLeave(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnGotMouseCapture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLostMouseCapture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnQueryCursor(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusInAirMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusInAirMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusEnter(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusLeave(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusInRange(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusInRange(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusOutOfRange(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusOutOfRange(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusSystemGesture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusSystemGesture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnGotStylusCapture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLostStylusCapture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusButtonDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnStylusButtonUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusButtonDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewStylusButtonUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewKeyDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnKeyDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewKeyUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnKeyUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewGotKeyboardFocus(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnGotKeyboardFocus(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewLostKeyboardFocus(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLostKeyboardFocus(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewTextInput(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTextInput(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewQueryContinueDrag(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnQueryContinueDrag(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewGiveFeedback(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnGiveFeedback(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewDragEnter(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnDragEnter(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewDragOver(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnDragOver(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewDragLeave(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnDragLeave(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewDrop(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnDrop(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewTouchDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTouchDown(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewTouchMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTouchMove(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnPreviewTouchUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTouchUp(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnGotTouchCapture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLostTouchCapture(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTouchEnter(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnTouchLeave(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsMouseCapturedChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsStylusCapturedChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsKeyboardFocusedChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLayoutUpdated(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnGotFocus(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnLostFocus(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsEnabledChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsHitTestVisibleChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnIsVisibleChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnFocusableChanged(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnManipulationStarting(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnManipulationStarted(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnManipulationDelta(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnManipulationInertiaStarting(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnManipulationBoundaryFeedback(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.ScrollBar OnManipulationCompleted(this System.Windows.Controls.Primitives.ScrollBar self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}