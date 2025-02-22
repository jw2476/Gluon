
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Viewbox WithStretch(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Stretch> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.StretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithStretchDirection(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Controls.StretchDirection> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.StretchDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithStyle(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithOverridesDefaultStyle(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithUseLayoutRounding(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithDataContext(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithBindingGroup(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithLanguage(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithName(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithTag(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithInputScope(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithActualWidth(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithActualHeight(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithLayoutTransform(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithWidth(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithMinWidth(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithMaxWidth(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithHeight(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithMinHeight(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithMaxHeight(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithFlowDirection(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithMargin(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithHorizontalAlignment(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithVerticalAlignment(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithFocusVisualStyle(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithCursor(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithForceCursor(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithToolTip(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithContextMenu(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsMouseDirectlyOver(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsMouseOver(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsStylusOver(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsKeyboardFocusWithin(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsMouseCaptured(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsMouseCaptureWithin(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsStylusDirectlyOver(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsStylusCaptured(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsStylusCaptureWithin(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsKeyboardFocused(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithAreAnyTouchesOver(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithAreAnyTouchesCaptured(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithAllowDrop(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithRenderTransform(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithRenderTransformOrigin(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithOpacity(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithOpacityMask(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithBitmapEffect(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithEffect(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithBitmapEffectInput(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithCacheMode(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithUid(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithVisibility(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithClipToBounds(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithClip(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithSnapsToDevicePixels(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsFocused(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsEnabled(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsHitTestVisible(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsVisible(this System.Windows.Controls.Viewbox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Viewbox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithFocusable(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Viewbox WithIsManipulationEnabled(this System.Windows.Controls.Viewbox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Viewbox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Viewbox OnTargetUpdated(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnSourceUpdated(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnDataContextChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnRequestBringIntoView(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnSizeChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnInitialized(this System.Windows.Controls.Viewbox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLoaded(this System.Windows.Controls.Viewbox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnUnloaded(this System.Windows.Controls.Viewbox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnToolTipOpening(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnToolTipClosing(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnContextMenuOpening(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnContextMenuClosing(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseLeftButtonDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseLeftButtonUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseRightButtonDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseRightButtonDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseRightButtonUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseRightButtonUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewMouseWheel(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseWheel(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseEnter(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnMouseLeave(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnGotMouseCapture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLostMouseCapture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnQueryCursor(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusInAirMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusInAirMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusEnter(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusLeave(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusInRange(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusInRange(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusOutOfRange(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusOutOfRange(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusSystemGesture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusSystemGesture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnGotStylusCapture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLostStylusCapture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusButtonDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnStylusButtonUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusButtonDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewStylusButtonUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewKeyDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnKeyDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewKeyUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnKeyUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewGotKeyboardFocus(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnGotKeyboardFocus(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewLostKeyboardFocus(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLostKeyboardFocus(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewTextInput(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnTextInput(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewQueryContinueDrag(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnQueryContinueDrag(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewGiveFeedback(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnGiveFeedback(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewDragEnter(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnDragEnter(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewDragOver(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnDragOver(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewDragLeave(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnDragLeave(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewDrop(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnDrop(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewTouchDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnTouchDown(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewTouchMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnTouchMove(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnPreviewTouchUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnTouchUp(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnGotTouchCapture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLostTouchCapture(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnTouchEnter(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnTouchLeave(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsMouseCapturedChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsStylusCapturedChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsKeyboardFocusedChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLayoutUpdated(this System.Windows.Controls.Viewbox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnGotFocus(this System.Windows.Controls.Viewbox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnLostFocus(this System.Windows.Controls.Viewbox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsEnabledChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsHitTestVisibleChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnIsVisibleChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnFocusableChanged(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnManipulationStarting(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnManipulationStarted(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnManipulationDelta(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnManipulationInertiaStarting(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnManipulationBoundaryFeedback(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Viewbox OnManipulationCompleted(this System.Windows.Controls.Viewbox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}