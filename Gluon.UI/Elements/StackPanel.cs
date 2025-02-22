
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.StackPanel WithOrientation(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Controls.Orientation> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithBackground(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsItemsHost(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.IsItemsHostProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithStyle(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithOverridesDefaultStyle(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithUseLayoutRounding(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithDataContext(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithBindingGroup(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithLanguage(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithName(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithTag(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithInputScope(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithActualWidth(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithActualHeight(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithLayoutTransform(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithWidth(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithMinWidth(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithMaxWidth(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithHeight(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithMinHeight(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithMaxHeight(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithFlowDirection(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithMargin(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithHorizontalAlignment(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithVerticalAlignment(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithFocusVisualStyle(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithCursor(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithForceCursor(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithToolTip(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithContextMenu(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsMouseDirectlyOver(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsMouseOver(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsStylusOver(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsKeyboardFocusWithin(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsMouseCaptured(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsMouseCaptureWithin(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsStylusDirectlyOver(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsStylusCaptured(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsStylusCaptureWithin(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsKeyboardFocused(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithAreAnyTouchesOver(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithAreAnyTouchesCaptured(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithAllowDrop(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithRenderTransform(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithRenderTransformOrigin(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithOpacity(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithOpacityMask(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithBitmapEffect(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithEffect(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithBitmapEffectInput(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithCacheMode(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithUid(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithVisibility(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithClipToBounds(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithClip(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithSnapsToDevicePixels(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsFocused(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsEnabled(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsHitTestVisible(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsVisible(this System.Windows.Controls.StackPanel self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.StackPanel.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithFocusable(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.StackPanel WithIsManipulationEnabled(this System.Windows.Controls.StackPanel self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.StackPanel.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.StackPanel OnTargetUpdated(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnSourceUpdated(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnDataContextChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnRequestBringIntoView(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnSizeChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnInitialized(this System.Windows.Controls.StackPanel self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLoaded(this System.Windows.Controls.StackPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnUnloaded(this System.Windows.Controls.StackPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnToolTipOpening(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnToolTipClosing(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnContextMenuOpening(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnContextMenuClosing(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseLeftButtonDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseLeftButtonDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseLeftButtonUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseLeftButtonUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseRightButtonDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseRightButtonDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseRightButtonUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseRightButtonUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewMouseWheel(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseWheel(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseEnter(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnMouseLeave(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnGotMouseCapture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLostMouseCapture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnQueryCursor(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusInAirMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusInAirMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusEnter(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusLeave(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusInRange(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusInRange(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusOutOfRange(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusOutOfRange(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusSystemGesture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusSystemGesture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnGotStylusCapture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLostStylusCapture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusButtonDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnStylusButtonUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusButtonDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewStylusButtonUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewKeyDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnKeyDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewKeyUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnKeyUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewGotKeyboardFocus(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnGotKeyboardFocus(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewLostKeyboardFocus(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLostKeyboardFocus(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewTextInput(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnTextInput(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewQueryContinueDrag(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnQueryContinueDrag(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewGiveFeedback(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnGiveFeedback(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewDragEnter(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnDragEnter(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewDragOver(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnDragOver(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewDragLeave(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnDragLeave(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewDrop(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnDrop(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewTouchDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnTouchDown(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewTouchMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnTouchMove(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnPreviewTouchUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnTouchUp(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnGotTouchCapture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLostTouchCapture(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnTouchEnter(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnTouchLeave(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsMouseDirectlyOverChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsMouseCapturedChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsMouseCaptureWithinChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsStylusDirectlyOverChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsStylusCapturedChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsStylusCaptureWithinChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsKeyboardFocusedChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLayoutUpdated(this System.Windows.Controls.StackPanel self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnGotFocus(this System.Windows.Controls.StackPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnLostFocus(this System.Windows.Controls.StackPanel self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsEnabledChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsHitTestVisibleChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnIsVisibleChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnFocusableChanged(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnManipulationStarting(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnManipulationStarted(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnManipulationDelta(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnManipulationInertiaStarting(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnManipulationBoundaryFeedback(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.StackPanel OnManipulationCompleted(this System.Windows.Controls.StackPanel self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}