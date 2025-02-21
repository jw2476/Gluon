
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Slider WithOrientation(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Controls.Orientation> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsDirectionReversed(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsDirectionReversedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithDelay(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.DelayProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithInterval(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IntervalProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAutoToolTipPlacement(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Controls.Primitives.AutoToolTipPlacement> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.AutoToolTipPlacementProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAutoToolTipPrecision(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.AutoToolTipPrecisionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsSnapToTickEnabled(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsSnapToTickEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithTickPlacement(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Controls.Primitives.TickPlacement> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.TickPlacementProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithTickFrequency(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.TickFrequencyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithTicks(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.DoubleCollection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.TicksProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsSelectionRangeEnabled(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsSelectionRangeEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithSelectionStart(this System.Windows.Controls.Slider self, out ReadWriteBinding<System.Double> value)
    {
        
        var metadata = System.Windows.Controls.Slider.SelectionStartProperty.GetMetadata(typeof(System.Windows.Controls.Slider))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Double)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Slider.SelectionStartProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithSelectionEnd(this System.Windows.Controls.Slider self, out ReadWriteBinding<System.Double> value)
    {
        
        var metadata = System.Windows.Controls.Slider.SelectionEndProperty.GetMetadata(typeof(System.Windows.Controls.Slider))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Double)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Slider.SelectionEndProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsMoveToPointEnabled(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsMoveToPointEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMinimum(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MinimumProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMaximum(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MaximumProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithValue(this System.Windows.Controls.Slider self, out ReadWriteBinding<System.Double> value)
    {
        
        var metadata = System.Windows.Controls.Slider.ValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.RangeBase))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Double)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Slider.ValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithLargeChange(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.LargeChangeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithSmallChange(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.SmallChangeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithBorderBrush(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithBorderThickness(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithBackground(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithForeground(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFontFamily(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFontSize(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFontStretch(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFontStyle(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFontWeight(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithHorizontalContentAlignment(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithVerticalContentAlignment(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithTabIndex(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsTabStop(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithPadding(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithTemplate(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithStyle(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithOverridesDefaultStyle(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithUseLayoutRounding(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithDataContext(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithBindingGroup(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithLanguage(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithName(this System.Windows.Controls.Slider self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithTag(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithInputScope(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithActualWidth(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithActualHeight(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithLayoutTransform(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithWidth(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMinWidth(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMaxWidth(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithHeight(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMinHeight(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMaxHeight(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFlowDirection(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithMargin(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithHorizontalAlignment(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithVerticalAlignment(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFocusVisualStyle(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithCursor(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithForceCursor(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithToolTip(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithContextMenu(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsMouseDirectlyOver(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsMouseOver(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsStylusOver(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsKeyboardFocusWithin(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsMouseCaptured(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsMouseCaptureWithin(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsStylusDirectlyOver(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsStylusCaptured(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsStylusCaptureWithin(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsKeyboardFocused(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAreAnyTouchesOver(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAreAnyTouchesCaptured(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithAllowDrop(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithRenderTransform(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithRenderTransformOrigin(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithOpacity(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithOpacityMask(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithBitmapEffect(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithEffect(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithBitmapEffectInput(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithCacheMode(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithUid(this System.Windows.Controls.Slider self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithVisibility(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithClipToBounds(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithClip(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithSnapsToDevicePixels(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsFocused(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsEnabled(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsHitTestVisible(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsVisible(this System.Windows.Controls.Slider self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Slider.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithFocusable(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Slider WithIsManipulationEnabled(this System.Windows.Controls.Slider self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Slider.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Slider OnValueChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> handler)
    {
        var subject = new Subject<System.Windows.RoutedPropertyChangedEventArgs<System.Double>>();
        self.ValueChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseDoubleClick(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseDoubleClick(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTargetUpdated(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnSourceUpdated(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnDataContextChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnRequestBringIntoView(this System.Windows.Controls.Slider self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnSizeChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnInitialized(this System.Windows.Controls.Slider self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLoaded(this System.Windows.Controls.Slider self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnUnloaded(this System.Windows.Controls.Slider self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnToolTipOpening(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnToolTipClosing(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnContextMenuOpening(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnContextMenuClosing(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseLeftButtonDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseLeftButtonUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseRightButtonDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseRightButtonDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseRightButtonUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseRightButtonUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewMouseWheel(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseWheel(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseEnter(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnMouseLeave(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnGotMouseCapture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLostMouseCapture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnQueryCursor(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusInAirMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusInAirMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusEnter(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusLeave(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusInRange(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusInRange(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusOutOfRange(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusOutOfRange(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusSystemGesture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusSystemGesture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnGotStylusCapture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLostStylusCapture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusButtonDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnStylusButtonUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusButtonDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewStylusButtonUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewKeyDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnKeyDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewKeyUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnKeyUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewGotKeyboardFocus(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnGotKeyboardFocus(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewLostKeyboardFocus(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLostKeyboardFocus(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewTextInput(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTextInput(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewQueryContinueDrag(this System.Windows.Controls.Slider self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnQueryContinueDrag(this System.Windows.Controls.Slider self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewGiveFeedback(this System.Windows.Controls.Slider self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnGiveFeedback(this System.Windows.Controls.Slider self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewDragEnter(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnDragEnter(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewDragOver(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnDragOver(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewDragLeave(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnDragLeave(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewDrop(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnDrop(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewTouchDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTouchDown(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewTouchMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTouchMove(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnPreviewTouchUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTouchUp(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnGotTouchCapture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLostTouchCapture(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTouchEnter(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnTouchLeave(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsMouseCapturedChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsStylusCapturedChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsKeyboardFocusedChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLayoutUpdated(this System.Windows.Controls.Slider self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnGotFocus(this System.Windows.Controls.Slider self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnLostFocus(this System.Windows.Controls.Slider self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsEnabledChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsHitTestVisibleChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnIsVisibleChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnFocusableChanged(this System.Windows.Controls.Slider self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnManipulationStarting(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnManipulationStarted(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnManipulationDelta(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnManipulationInertiaStarting(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnManipulationBoundaryFeedback(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Slider OnManipulationCompleted(this System.Windows.Controls.Slider self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}