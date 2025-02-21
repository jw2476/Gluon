
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ProgressBar WithIsIndeterminate(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.IsIndeterminateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithOrientation(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Controls.Orientation> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMinimum(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MinimumProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMaximum(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MaximumProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithValue(this System.Windows.Controls.ProgressBar self, out ReadWriteBinding<System.Double> value)
    {
        
        var metadata = System.Windows.Controls.ProgressBar.ValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.RangeBase))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Double)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ProgressBar.ValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithLargeChange(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.LargeChangeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithSmallChange(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.SmallChangeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithBorderBrush(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithBorderThickness(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithBackground(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithForeground(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFontFamily(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFontSize(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFontStretch(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFontStyle(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFontWeight(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithHorizontalContentAlignment(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithVerticalContentAlignment(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithTabIndex(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsTabStop(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithPadding(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithTemplate(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithStyle(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithOverridesDefaultStyle(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithUseLayoutRounding(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithDataContext(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithBindingGroup(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithLanguage(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithName(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithTag(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithInputScope(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithActualWidth(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithActualHeight(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithLayoutTransform(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithWidth(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMinWidth(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMaxWidth(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithHeight(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMinHeight(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMaxHeight(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFlowDirection(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithMargin(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithHorizontalAlignment(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithVerticalAlignment(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFocusVisualStyle(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithCursor(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithForceCursor(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithToolTip(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithContextMenu(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsMouseDirectlyOver(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsMouseOver(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsStylusOver(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsKeyboardFocusWithin(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsMouseCaptured(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsMouseCaptureWithin(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsStylusDirectlyOver(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsStylusCaptured(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsStylusCaptureWithin(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsKeyboardFocused(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithAreAnyTouchesOver(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithAreAnyTouchesCaptured(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithAllowDrop(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithRenderTransform(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithRenderTransformOrigin(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithOpacity(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithOpacityMask(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithBitmapEffect(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithEffect(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithBitmapEffectInput(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithCacheMode(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithUid(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithVisibility(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithClipToBounds(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithClip(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithSnapsToDevicePixels(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsFocused(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsEnabled(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsHitTestVisible(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsVisible(this System.Windows.Controls.ProgressBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ProgressBar.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithFocusable(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar WithIsManipulationEnabled(this System.Windows.Controls.ProgressBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ProgressBar.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ProgressBar OnValueChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> handler)
    {
        var subject = new Subject<System.Windows.RoutedPropertyChangedEventArgs<System.Double>>();
        self.ValueChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseDoubleClick(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseDoubleClick(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTargetUpdated(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnSourceUpdated(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnDataContextChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnRequestBringIntoView(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnSizeChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnInitialized(this System.Windows.Controls.ProgressBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLoaded(this System.Windows.Controls.ProgressBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnUnloaded(this System.Windows.Controls.ProgressBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnToolTipOpening(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnToolTipClosing(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnContextMenuOpening(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnContextMenuClosing(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseLeftButtonDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseLeftButtonUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseRightButtonDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseRightButtonDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseRightButtonUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseRightButtonUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewMouseWheel(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseWheel(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseEnter(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnMouseLeave(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnGotMouseCapture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLostMouseCapture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnQueryCursor(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusInAirMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusInAirMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusEnter(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusLeave(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusInRange(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusInRange(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusOutOfRange(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusOutOfRange(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusSystemGesture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusSystemGesture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnGotStylusCapture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLostStylusCapture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusButtonDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnStylusButtonUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusButtonDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewStylusButtonUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewKeyDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnKeyDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewKeyUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnKeyUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewGotKeyboardFocus(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnGotKeyboardFocus(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewLostKeyboardFocus(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLostKeyboardFocus(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewTextInput(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTextInput(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewQueryContinueDrag(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnQueryContinueDrag(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewGiveFeedback(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnGiveFeedback(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewDragEnter(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnDragEnter(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewDragOver(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnDragOver(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewDragLeave(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnDragLeave(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewDrop(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnDrop(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewTouchDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTouchDown(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewTouchMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTouchMove(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnPreviewTouchUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTouchUp(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnGotTouchCapture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLostTouchCapture(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTouchEnter(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnTouchLeave(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsMouseCapturedChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsStylusCapturedChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsKeyboardFocusedChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLayoutUpdated(this System.Windows.Controls.ProgressBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnGotFocus(this System.Windows.Controls.ProgressBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnLostFocus(this System.Windows.Controls.ProgressBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsEnabledChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsHitTestVisibleChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnIsVisibleChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnFocusableChanged(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnManipulationStarting(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnManipulationStarted(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnManipulationDelta(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnManipulationInertiaStarting(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnManipulationBoundaryFeedback(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ProgressBar OnManipulationCompleted(this System.Windows.Controls.ProgressBar self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}