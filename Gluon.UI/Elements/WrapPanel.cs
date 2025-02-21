
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.WrapPanel WithItemWidth(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ItemWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithItemHeight(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ItemHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithOrientation(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Controls.Orientation> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithBackground(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsItemsHost(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.IsItemsHostProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithStyle(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithOverridesDefaultStyle(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithUseLayoutRounding(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithDataContext(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithBindingGroup(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithLanguage(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithName(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithTag(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithInputScope(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithActualWidth(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithActualHeight(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithLayoutTransform(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithWidth(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithMinWidth(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithMaxWidth(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithHeight(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithMinHeight(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithMaxHeight(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithFlowDirection(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithMargin(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithHorizontalAlignment(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithVerticalAlignment(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithFocusVisualStyle(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithCursor(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithForceCursor(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithToolTip(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithContextMenu(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsMouseDirectlyOver(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsMouseOver(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsStylusOver(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsKeyboardFocusWithin(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsMouseCaptured(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsMouseCaptureWithin(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsStylusDirectlyOver(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsStylusCaptured(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsStylusCaptureWithin(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsKeyboardFocused(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithAreAnyTouchesOver(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithAreAnyTouchesCaptured(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithAllowDrop(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithRenderTransform(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithRenderTransformOrigin(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithOpacity(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithOpacityMask(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithBitmapEffect(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithEffect(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithBitmapEffectInput(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithCacheMode(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithUid(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithVisibility(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithClipToBounds(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithClip(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithSnapsToDevicePixels(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsFocused(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsEnabled(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsHitTestVisible(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsVisible(this System.Windows.Controls.WrapPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.WrapPanel.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithFocusable(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel WithIsManipulationEnabled(this System.Windows.Controls.WrapPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.WrapPanel.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.WrapPanel OnTargetUpdated(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnSourceUpdated(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnDataContextChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnRequestBringIntoView(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnSizeChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnInitialized(this System.Windows.Controls.WrapPanel self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLoaded(this System.Windows.Controls.WrapPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnUnloaded(this System.Windows.Controls.WrapPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnToolTipOpening(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnToolTipClosing(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnContextMenuOpening(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnContextMenuClosing(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseLeftButtonDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseLeftButtonDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseLeftButtonUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseLeftButtonUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseRightButtonDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseRightButtonDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseRightButtonUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseRightButtonUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewMouseWheel(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseWheel(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseEnter(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnMouseLeave(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnGotMouseCapture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLostMouseCapture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnQueryCursor(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusInAirMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusInAirMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusEnter(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusLeave(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusInRange(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusInRange(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusOutOfRange(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusOutOfRange(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusSystemGesture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusSystemGesture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnGotStylusCapture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLostStylusCapture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusButtonDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnStylusButtonUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusButtonDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewStylusButtonUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewKeyDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnKeyDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewKeyUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnKeyUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewGotKeyboardFocus(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnGotKeyboardFocus(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewLostKeyboardFocus(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLostKeyboardFocus(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewTextInput(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnTextInput(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewQueryContinueDrag(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnQueryContinueDrag(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewGiveFeedback(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnGiveFeedback(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewDragEnter(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnDragEnter(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewDragOver(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnDragOver(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewDragLeave(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnDragLeave(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewDrop(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnDrop(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewTouchDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnTouchDown(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewTouchMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnTouchMove(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnPreviewTouchUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnTouchUp(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnGotTouchCapture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLostTouchCapture(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnTouchEnter(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnTouchLeave(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsMouseDirectlyOverChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsMouseCapturedChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsMouseCaptureWithinChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsStylusDirectlyOverChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsStylusCapturedChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsStylusCaptureWithinChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsKeyboardFocusedChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLayoutUpdated(this System.Windows.Controls.WrapPanel self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnGotFocus(this System.Windows.Controls.WrapPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnLostFocus(this System.Windows.Controls.WrapPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsEnabledChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsHitTestVisibleChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnIsVisibleChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnFocusableChanged(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnManipulationStarting(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnManipulationStarted(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnManipulationDelta(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnManipulationInertiaStarting(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnManipulationBoundaryFeedback(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.WrapPanel OnManipulationCompleted(this System.Windows.Controls.WrapPanel self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}