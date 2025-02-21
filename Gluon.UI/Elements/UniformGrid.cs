
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Primitives.UniformGrid WithFirstColumn(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.FirstColumnProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithColumns(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ColumnsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithRows(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.RowsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithBackground(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsItemsHost(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsItemsHostProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithStyle(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithOverridesDefaultStyle(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithUseLayoutRounding(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithDataContext(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithBindingGroup(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithLanguage(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithName(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithTag(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithInputScope(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithActualWidth(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithActualHeight(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithLayoutTransform(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithWidth(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithMinWidth(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithMaxWidth(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithHeight(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithMinHeight(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithMaxHeight(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithFlowDirection(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithMargin(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithHorizontalAlignment(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithVerticalAlignment(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithFocusVisualStyle(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithCursor(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithForceCursor(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithToolTip(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithContextMenu(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsMouseDirectlyOver(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsMouseOver(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsStylusOver(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsKeyboardFocusWithin(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsMouseCaptured(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsMouseCaptureWithin(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsStylusDirectlyOver(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsStylusCaptured(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsStylusCaptureWithin(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsKeyboardFocused(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithAreAnyTouchesOver(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithAreAnyTouchesCaptured(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithAllowDrop(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithRenderTransform(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithRenderTransformOrigin(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithOpacity(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithOpacityMask(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithBitmapEffect(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithEffect(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithBitmapEffectInput(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithCacheMode(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithUid(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithVisibility(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithClipToBounds(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithClip(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithSnapsToDevicePixels(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsFocused(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsEnabled(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsHitTestVisible(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsVisible(this System.Windows.Controls.Primitives.UniformGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithFocusable(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid WithIsManipulationEnabled(this System.Windows.Controls.Primitives.UniformGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.UniformGrid.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Primitives.UniformGrid OnTargetUpdated(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnSourceUpdated(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnDataContextChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnRequestBringIntoView(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnSizeChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnInitialized(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLoaded(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnUnloaded(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnToolTipOpening(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnToolTipClosing(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnContextMenuOpening(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnContextMenuClosing(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseLeftButtonDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseLeftButtonUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseRightButtonDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseRightButtonDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseRightButtonUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseRightButtonUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewMouseWheel(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseWheel(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseEnter(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnMouseLeave(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnGotMouseCapture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLostMouseCapture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnQueryCursor(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusInAirMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusInAirMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusEnter(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusLeave(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusInRange(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusInRange(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusOutOfRange(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusOutOfRange(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusSystemGesture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusSystemGesture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnGotStylusCapture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLostStylusCapture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusButtonDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnStylusButtonUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusButtonDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewStylusButtonUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewKeyDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnKeyDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewKeyUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnKeyUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewGotKeyboardFocus(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnGotKeyboardFocus(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewLostKeyboardFocus(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLostKeyboardFocus(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewTextInput(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnTextInput(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewQueryContinueDrag(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnQueryContinueDrag(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewGiveFeedback(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnGiveFeedback(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewDragEnter(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnDragEnter(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewDragOver(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnDragOver(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewDragLeave(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnDragLeave(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewDrop(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnDrop(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewTouchDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnTouchDown(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewTouchMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnTouchMove(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnPreviewTouchUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnTouchUp(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnGotTouchCapture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLostTouchCapture(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnTouchEnter(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnTouchLeave(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsMouseCapturedChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsStylusCapturedChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsKeyboardFocusedChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLayoutUpdated(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnGotFocus(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnLostFocus(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsEnabledChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsHitTestVisibleChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnIsVisibleChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnFocusableChanged(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnManipulationStarting(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnManipulationStarted(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnManipulationDelta(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnManipulationInertiaStarting(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnManipulationBoundaryFeedback(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.UniformGrid OnManipulationCompleted(this System.Windows.Controls.Primitives.UniformGrid self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}