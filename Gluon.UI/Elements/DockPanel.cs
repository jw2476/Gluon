
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.DockPanel WithLastChildFill(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.LastChildFillProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithDock(this System.Windows.FrameworkElement self, ReadWriteBinding<System.Windows.Controls.Dock> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.DockProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithBackground(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsItemsHost(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.IsItemsHostProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithZIndex(this System.Windows.FrameworkElement self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.ZIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithStyle(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithOverridesDefaultStyle(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithUseLayoutRounding(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithDataContext(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithBindingGroup(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithLanguage(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithName(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithTag(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithInputScope(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithActualWidth(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithActualHeight(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithLayoutTransform(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithWidth(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithMinWidth(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithMaxWidth(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithHeight(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithMinHeight(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithMaxHeight(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithFlowDirection(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithMargin(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithHorizontalAlignment(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithVerticalAlignment(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithFocusVisualStyle(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithCursor(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithForceCursor(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithToolTip(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithContextMenu(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsMouseDirectlyOver(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsMouseOver(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsStylusOver(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsKeyboardFocusWithin(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsMouseCaptured(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsMouseCaptureWithin(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsStylusDirectlyOver(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsStylusCaptured(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsStylusCaptureWithin(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsKeyboardFocused(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithAreAnyTouchesOver(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithAreAnyTouchesCaptured(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithAllowDrop(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithRenderTransform(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithRenderTransformOrigin(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithOpacity(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithOpacityMask(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithBitmapEffect(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithEffect(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithBitmapEffectInput(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithCacheMode(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithUid(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithVisibility(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithClipToBounds(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithClip(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithSnapsToDevicePixels(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsFocused(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsEnabled(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsHitTestVisible(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsVisible(this System.Windows.Controls.DockPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DockPanel.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithFocusable(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DockPanel WithIsManipulationEnabled(this System.Windows.Controls.DockPanel self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DockPanel.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.DockPanel OnTargetUpdated(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnSourceUpdated(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnDataContextChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnRequestBringIntoView(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnSizeChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnInitialized(this System.Windows.Controls.DockPanel self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLoaded(this System.Windows.Controls.DockPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnUnloaded(this System.Windows.Controls.DockPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnToolTipOpening(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnToolTipClosing(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnContextMenuOpening(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnContextMenuClosing(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseLeftButtonDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseLeftButtonDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseLeftButtonUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseLeftButtonUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseRightButtonDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseRightButtonDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseRightButtonUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseRightButtonUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewMouseWheel(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseWheel(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseEnter(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnMouseLeave(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnGotMouseCapture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLostMouseCapture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnQueryCursor(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusInAirMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusInAirMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusEnter(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusLeave(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusInRange(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusInRange(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusOutOfRange(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusOutOfRange(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusSystemGesture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusSystemGesture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnGotStylusCapture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLostStylusCapture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusButtonDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnStylusButtonUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusButtonDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewStylusButtonUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewKeyDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnKeyDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewKeyUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnKeyUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewGotKeyboardFocus(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnGotKeyboardFocus(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewLostKeyboardFocus(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLostKeyboardFocus(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewTextInput(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnTextInput(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewQueryContinueDrag(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnQueryContinueDrag(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewGiveFeedback(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnGiveFeedback(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewDragEnter(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnDragEnter(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewDragOver(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnDragOver(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewDragLeave(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnDragLeave(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewDrop(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnDrop(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewTouchDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnTouchDown(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewTouchMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnTouchMove(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnPreviewTouchUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnTouchUp(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnGotTouchCapture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLostTouchCapture(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnTouchEnter(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnTouchLeave(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsMouseDirectlyOverChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsMouseCapturedChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsMouseCaptureWithinChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsStylusDirectlyOverChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsStylusCapturedChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsStylusCaptureWithinChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsKeyboardFocusedChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLayoutUpdated(this System.Windows.Controls.DockPanel self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnGotFocus(this System.Windows.Controls.DockPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnLostFocus(this System.Windows.Controls.DockPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsEnabledChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsHitTestVisibleChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnIsVisibleChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnFocusableChanged(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnManipulationStarting(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnManipulationStarted(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnManipulationDelta(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnManipulationInertiaStarting(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnManipulationBoundaryFeedback(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DockPanel OnManipulationCompleted(this System.Windows.Controls.DockPanel self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}