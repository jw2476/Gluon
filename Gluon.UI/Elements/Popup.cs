
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Primitives.Popup WithChild(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.UIElement> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ChildProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsOpen(this System.Windows.Controls.Primitives.Popup self, out ReadWriteBinding<System.Boolean> value)
    {
        
        var metadata = System.Windows.Controls.Primitives.Popup.IsOpenProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Popup))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithPlacement(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Controls.Primitives.PlacementMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.PlacementProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithCustomPopupPlacementCallback(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Controls.Primitives.CustomPopupPlacementCallback> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithStaysOpen(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.StaysOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithHorizontalOffset(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithVerticalOffset(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithPlacementTarget(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.UIElement> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.PlacementTargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithPlacementRectangle(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Rect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.PlacementRectangleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithPopupAnimation(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Controls.Primitives.PopupAnimation> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.PopupAnimationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithAllowsTransparency(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithHasDropShadow(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.HasDropShadowProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithStyle(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithOverridesDefaultStyle(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithUseLayoutRounding(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithDataContext(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithBindingGroup(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithLanguage(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithName(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithTag(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithInputScope(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithActualWidth(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithActualHeight(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithLayoutTransform(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithWidth(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithMinWidth(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithMaxWidth(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithHeight(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithMinHeight(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithMaxHeight(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithFlowDirection(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithMargin(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithHorizontalAlignment(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithVerticalAlignment(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithFocusVisualStyle(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithCursor(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithForceCursor(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithToolTip(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithContextMenu(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsMouseDirectlyOver(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsMouseOver(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsStylusOver(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsKeyboardFocusWithin(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsMouseCaptured(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsMouseCaptureWithin(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsStylusDirectlyOver(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsStylusCaptured(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsStylusCaptureWithin(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsKeyboardFocused(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithAreAnyTouchesOver(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithAreAnyTouchesCaptured(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithAllowDrop(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithRenderTransform(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithRenderTransformOrigin(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithOpacity(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithOpacityMask(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithBitmapEffect(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithEffect(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithBitmapEffectInput(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithCacheMode(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithUid(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithVisibility(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithClipToBounds(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithClip(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithSnapsToDevicePixels(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsFocused(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsEnabled(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsHitTestVisible(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsVisible(this System.Windows.Controls.Primitives.Popup self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithFocusable(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup WithIsManipulationEnabled(this System.Windows.Controls.Primitives.Popup self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.Popup.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Primitives.Popup OnOpened(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Opened += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnClosed(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Closed += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTargetUpdated(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnSourceUpdated(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnDataContextChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnRequestBringIntoView(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnSizeChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnInitialized(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLoaded(this System.Windows.Controls.Primitives.Popup self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnUnloaded(this System.Windows.Controls.Primitives.Popup self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnToolTipOpening(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnToolTipClosing(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnContextMenuOpening(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnContextMenuClosing(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseLeftButtonDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseLeftButtonUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseRightButtonDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseRightButtonDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseRightButtonUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseRightButtonUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewMouseWheel(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseWheel(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseEnter(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnMouseLeave(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnGotMouseCapture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLostMouseCapture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnQueryCursor(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusInAirMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusInAirMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusEnter(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusLeave(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusInRange(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusInRange(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusOutOfRange(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusOutOfRange(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusSystemGesture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusSystemGesture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnGotStylusCapture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLostStylusCapture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusButtonDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnStylusButtonUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusButtonDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewStylusButtonUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewKeyDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnKeyDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewKeyUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnKeyUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewGotKeyboardFocus(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnGotKeyboardFocus(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewLostKeyboardFocus(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLostKeyboardFocus(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewTextInput(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTextInput(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewQueryContinueDrag(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnQueryContinueDrag(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewGiveFeedback(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnGiveFeedback(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewDragEnter(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnDragEnter(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewDragOver(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnDragOver(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewDragLeave(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnDragLeave(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewDrop(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnDrop(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewTouchDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTouchDown(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewTouchMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTouchMove(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnPreviewTouchUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTouchUp(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnGotTouchCapture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLostTouchCapture(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTouchEnter(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnTouchLeave(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsMouseCapturedChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsStylusCapturedChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsKeyboardFocusedChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLayoutUpdated(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnGotFocus(this System.Windows.Controls.Primitives.Popup self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnLostFocus(this System.Windows.Controls.Primitives.Popup self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsEnabledChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsHitTestVisibleChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnIsVisibleChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnFocusableChanged(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnManipulationStarting(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnManipulationStarted(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnManipulationDelta(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnManipulationInertiaStarting(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnManipulationBoundaryFeedback(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.Popup OnManipulationCompleted(this System.Windows.Controls.Primitives.Popup self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}