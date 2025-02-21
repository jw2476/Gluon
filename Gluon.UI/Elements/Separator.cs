
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Separator WithBorderBrush(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithBorderThickness(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithBackground(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithForeground(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFontFamily(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFontSize(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFontStretch(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFontStyle(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFontWeight(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithHorizontalContentAlignment(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithVerticalContentAlignment(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithTabIndex(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsTabStop(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithPadding(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithTemplate(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithStyle(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithOverridesDefaultStyle(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithUseLayoutRounding(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithDataContext(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithBindingGroup(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithLanguage(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithName(this System.Windows.Controls.Separator self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithTag(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithInputScope(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithActualWidth(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithActualHeight(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithLayoutTransform(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithWidth(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithMinWidth(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithMaxWidth(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithHeight(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithMinHeight(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithMaxHeight(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFlowDirection(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithMargin(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithHorizontalAlignment(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithVerticalAlignment(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFocusVisualStyle(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithCursor(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithForceCursor(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithToolTip(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithContextMenu(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsMouseDirectlyOver(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsMouseOver(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsStylusOver(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsKeyboardFocusWithin(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsMouseCaptured(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsMouseCaptureWithin(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsStylusDirectlyOver(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsStylusCaptured(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsStylusCaptureWithin(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsKeyboardFocused(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithAreAnyTouchesOver(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithAreAnyTouchesCaptured(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithAllowDrop(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithRenderTransform(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithRenderTransformOrigin(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithOpacity(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithOpacityMask(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithBitmapEffect(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithEffect(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithBitmapEffectInput(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithCacheMode(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithUid(this System.Windows.Controls.Separator self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithVisibility(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithClipToBounds(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithClip(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithSnapsToDevicePixels(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsFocused(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsEnabled(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsHitTestVisible(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsVisible(this System.Windows.Controls.Separator self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Separator.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithFocusable(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Separator WithIsManipulationEnabled(this System.Windows.Controls.Separator self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Separator.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Separator OnPreviewMouseDoubleClick(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseDoubleClick(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTargetUpdated(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnSourceUpdated(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnDataContextChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnRequestBringIntoView(this System.Windows.Controls.Separator self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnSizeChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnInitialized(this System.Windows.Controls.Separator self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLoaded(this System.Windows.Controls.Separator self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnUnloaded(this System.Windows.Controls.Separator self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnToolTipOpening(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnToolTipClosing(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnContextMenuOpening(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnContextMenuClosing(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseLeftButtonDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseLeftButtonUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseRightButtonDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseRightButtonDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseRightButtonUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseRightButtonUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewMouseWheel(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseWheel(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseEnter(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnMouseLeave(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnGotMouseCapture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLostMouseCapture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnQueryCursor(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusInAirMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusInAirMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusEnter(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusLeave(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusInRange(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusInRange(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusOutOfRange(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusOutOfRange(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusSystemGesture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusSystemGesture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnGotStylusCapture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLostStylusCapture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusButtonDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnStylusButtonUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusButtonDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewStylusButtonUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewKeyDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnKeyDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewKeyUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnKeyUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewGotKeyboardFocus(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnGotKeyboardFocus(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewLostKeyboardFocus(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLostKeyboardFocus(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewTextInput(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTextInput(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewQueryContinueDrag(this System.Windows.Controls.Separator self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnQueryContinueDrag(this System.Windows.Controls.Separator self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewGiveFeedback(this System.Windows.Controls.Separator self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnGiveFeedback(this System.Windows.Controls.Separator self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewDragEnter(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnDragEnter(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewDragOver(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnDragOver(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewDragLeave(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnDragLeave(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewDrop(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnDrop(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewTouchDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTouchDown(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewTouchMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTouchMove(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnPreviewTouchUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTouchUp(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnGotTouchCapture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLostTouchCapture(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTouchEnter(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnTouchLeave(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsMouseCapturedChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsStylusCapturedChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsKeyboardFocusedChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLayoutUpdated(this System.Windows.Controls.Separator self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnGotFocus(this System.Windows.Controls.Separator self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnLostFocus(this System.Windows.Controls.Separator self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsEnabledChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsHitTestVisibleChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnIsVisibleChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnFocusableChanged(this System.Windows.Controls.Separator self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnManipulationStarting(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnManipulationStarted(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnManipulationDelta(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnManipulationInertiaStarting(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnManipulationBoundaryFeedback(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Separator OnManipulationCompleted(this System.Windows.Controls.Separator self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}