
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Image WithSource(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.ImageSource> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.SourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithStretch(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Stretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.StretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithStretchDirection(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Controls.StretchDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.StretchDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithStyle(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithOverridesDefaultStyle(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithUseLayoutRounding(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithDataContext(this System.Windows.Controls.Image self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithBindingGroup(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithLanguage(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithName(this System.Windows.Controls.Image self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithTag(this System.Windows.Controls.Image self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithInputScope(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithActualWidth(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithActualHeight(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithLayoutTransform(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithWidth(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithMinWidth(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithMaxWidth(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithHeight(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithMinHeight(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithMaxHeight(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithFlowDirection(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithMargin(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithHorizontalAlignment(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithVerticalAlignment(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithFocusVisualStyle(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithCursor(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithForceCursor(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithToolTip(this System.Windows.Controls.Image self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithContextMenu(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsMouseDirectlyOver(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsMouseOver(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsStylusOver(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsKeyboardFocusWithin(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsMouseCaptured(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsMouseCaptureWithin(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsStylusDirectlyOver(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsStylusCaptured(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsStylusCaptureWithin(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsKeyboardFocused(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithAreAnyTouchesOver(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithAreAnyTouchesCaptured(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithAllowDrop(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithRenderTransform(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithRenderTransformOrigin(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithOpacity(this System.Windows.Controls.Image self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithOpacityMask(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithBitmapEffect(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithEffect(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithBitmapEffectInput(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithCacheMode(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithUid(this System.Windows.Controls.Image self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithVisibility(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithClipToBounds(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithClip(this System.Windows.Controls.Image self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithSnapsToDevicePixels(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsFocused(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsEnabled(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsHitTestVisible(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsVisible(this System.Windows.Controls.Image self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Image.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithFocusable(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Image WithIsManipulationEnabled(this System.Windows.Controls.Image self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Image.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Image OnImageFailed(this System.Windows.Controls.Image self, out IObservable<System.Windows.ExceptionRoutedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.ExceptionRoutedEventArgs>();
        self.ImageFailed += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnDpiChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DpiChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DpiChangedEventArgs>();
        self.DpiChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTargetUpdated(this System.Windows.Controls.Image self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnSourceUpdated(this System.Windows.Controls.Image self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnDataContextChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnRequestBringIntoView(this System.Windows.Controls.Image self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnSizeChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnInitialized(this System.Windows.Controls.Image self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLoaded(this System.Windows.Controls.Image self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnUnloaded(this System.Windows.Controls.Image self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnToolTipOpening(this System.Windows.Controls.Image self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnToolTipClosing(this System.Windows.Controls.Image self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnContextMenuOpening(this System.Windows.Controls.Image self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnContextMenuClosing(this System.Windows.Controls.Image self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseLeftButtonDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseLeftButtonUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseRightButtonDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseRightButtonDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseRightButtonUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseRightButtonUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewMouseWheel(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseWheel(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseEnter(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnMouseLeave(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnGotMouseCapture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLostMouseCapture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnQueryCursor(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusInAirMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusInAirMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusEnter(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusLeave(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusInRange(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusInRange(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusOutOfRange(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusOutOfRange(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusSystemGesture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusSystemGesture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnGotStylusCapture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLostStylusCapture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusButtonDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnStylusButtonUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusButtonDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewStylusButtonUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewKeyDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnKeyDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewKeyUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnKeyUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewGotKeyboardFocus(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnGotKeyboardFocus(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewLostKeyboardFocus(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLostKeyboardFocus(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewTextInput(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTextInput(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewQueryContinueDrag(this System.Windows.Controls.Image self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnQueryContinueDrag(this System.Windows.Controls.Image self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewGiveFeedback(this System.Windows.Controls.Image self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnGiveFeedback(this System.Windows.Controls.Image self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewDragEnter(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnDragEnter(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewDragOver(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnDragOver(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewDragLeave(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnDragLeave(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewDrop(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnDrop(this System.Windows.Controls.Image self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewTouchDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTouchDown(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewTouchMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTouchMove(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnPreviewTouchUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTouchUp(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnGotTouchCapture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLostTouchCapture(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTouchEnter(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnTouchLeave(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsMouseCapturedChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsStylusCapturedChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsKeyboardFocusedChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLayoutUpdated(this System.Windows.Controls.Image self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnGotFocus(this System.Windows.Controls.Image self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnLostFocus(this System.Windows.Controls.Image self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsEnabledChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsHitTestVisibleChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnIsVisibleChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnFocusableChanged(this System.Windows.Controls.Image self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnManipulationStarting(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnManipulationStarted(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnManipulationDelta(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnManipulationInertiaStarting(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnManipulationBoundaryFeedback(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Image OnManipulationCompleted(this System.Windows.Controls.Image self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}