
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ToolBarTray WithBackground(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithOrientation(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Controls.Orientation> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsLocked(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsLockedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithStyle(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithOverridesDefaultStyle(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithUseLayoutRounding(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithDataContext(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithBindingGroup(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithLanguage(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithName(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithTag(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithInputScope(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithActualWidth(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithActualHeight(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithLayoutTransform(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithWidth(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithMinWidth(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithMaxWidth(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithHeight(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithMinHeight(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithMaxHeight(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithFlowDirection(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithMargin(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithHorizontalAlignment(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithVerticalAlignment(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithFocusVisualStyle(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithCursor(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithForceCursor(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithToolTip(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithContextMenu(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsMouseDirectlyOver(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsMouseOver(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsStylusOver(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsKeyboardFocusWithin(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsMouseCaptured(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsMouseCaptureWithin(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsStylusDirectlyOver(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsStylusCaptured(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsStylusCaptureWithin(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsKeyboardFocused(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithAreAnyTouchesOver(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithAreAnyTouchesCaptured(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithAllowDrop(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithRenderTransform(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithRenderTransformOrigin(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithOpacity(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithOpacityMask(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithBitmapEffect(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithEffect(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithBitmapEffectInput(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithCacheMode(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithUid(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithVisibility(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithClipToBounds(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithClip(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithSnapsToDevicePixels(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsFocused(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsEnabled(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsHitTestVisible(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsVisible(this System.Windows.Controls.ToolBarTray self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithFocusable(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray WithIsManipulationEnabled(this System.Windows.Controls.ToolBarTray self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBarTray.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ToolBarTray OnTargetUpdated(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnSourceUpdated(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnDataContextChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnRequestBringIntoView(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnSizeChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnInitialized(this System.Windows.Controls.ToolBarTray self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLoaded(this System.Windows.Controls.ToolBarTray self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnUnloaded(this System.Windows.Controls.ToolBarTray self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnToolTipOpening(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnToolTipClosing(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnContextMenuOpening(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnContextMenuClosing(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseLeftButtonDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseLeftButtonUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseRightButtonDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseRightButtonDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseRightButtonUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseRightButtonUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewMouseWheel(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseWheel(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseEnter(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnMouseLeave(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnGotMouseCapture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLostMouseCapture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnQueryCursor(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusInAirMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusInAirMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusEnter(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusLeave(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusInRange(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusInRange(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusOutOfRange(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusOutOfRange(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusSystemGesture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusSystemGesture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnGotStylusCapture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLostStylusCapture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusButtonDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnStylusButtonUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusButtonDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewStylusButtonUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewKeyDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnKeyDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewKeyUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnKeyUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewGotKeyboardFocus(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnGotKeyboardFocus(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewLostKeyboardFocus(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLostKeyboardFocus(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewTextInput(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnTextInput(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewQueryContinueDrag(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnQueryContinueDrag(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewGiveFeedback(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnGiveFeedback(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewDragEnter(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnDragEnter(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewDragOver(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnDragOver(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewDragLeave(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnDragLeave(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewDrop(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnDrop(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewTouchDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnTouchDown(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewTouchMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnTouchMove(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnPreviewTouchUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnTouchUp(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnGotTouchCapture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLostTouchCapture(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnTouchEnter(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnTouchLeave(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsMouseCapturedChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsStylusCapturedChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsKeyboardFocusedChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLayoutUpdated(this System.Windows.Controls.ToolBarTray self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnGotFocus(this System.Windows.Controls.ToolBarTray self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnLostFocus(this System.Windows.Controls.ToolBarTray self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsEnabledChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsHitTestVisibleChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnIsVisibleChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnFocusableChanged(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnManipulationStarting(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnManipulationStarted(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnManipulationDelta(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnManipulationInertiaStarting(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnManipulationBoundaryFeedback(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBarTray OnManipulationCompleted(this System.Windows.Controls.ToolBarTray self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}