
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Label WithTarget(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.UIElement> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.TargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithContent(this System.Windows.Controls.Label self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithHasContent(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithContentTemplate(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithContentTemplateSelector(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithContentStringFormat(this System.Windows.Controls.Label self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithBorderBrush(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithBorderThickness(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithBackground(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithForeground(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFontFamily(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFontSize(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFontStretch(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFontStyle(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFontWeight(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithHorizontalContentAlignment(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithVerticalContentAlignment(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithTabIndex(this System.Windows.Controls.Label self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsTabStop(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithPadding(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithTemplate(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithStyle(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithOverridesDefaultStyle(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithUseLayoutRounding(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithDataContext(this System.Windows.Controls.Label self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithBindingGroup(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithLanguage(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithName(this System.Windows.Controls.Label self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithTag(this System.Windows.Controls.Label self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithInputScope(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithActualWidth(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithActualHeight(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithLayoutTransform(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithWidth(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithMinWidth(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithMaxWidth(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithHeight(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithMinHeight(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithMaxHeight(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFlowDirection(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithMargin(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithHorizontalAlignment(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithVerticalAlignment(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFocusVisualStyle(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithCursor(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithForceCursor(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithToolTip(this System.Windows.Controls.Label self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithContextMenu(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsMouseDirectlyOver(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsMouseOver(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsStylusOver(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsKeyboardFocusWithin(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsMouseCaptured(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsMouseCaptureWithin(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsStylusDirectlyOver(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsStylusCaptured(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsStylusCaptureWithin(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsKeyboardFocused(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithAreAnyTouchesOver(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithAreAnyTouchesCaptured(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithAllowDrop(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithRenderTransform(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithRenderTransformOrigin(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithOpacity(this System.Windows.Controls.Label self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithOpacityMask(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithBitmapEffect(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithEffect(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithBitmapEffectInput(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithCacheMode(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithUid(this System.Windows.Controls.Label self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithVisibility(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithClipToBounds(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithClip(this System.Windows.Controls.Label self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithSnapsToDevicePixels(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsFocused(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsEnabled(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsHitTestVisible(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsVisible(this System.Windows.Controls.Label self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Label.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithFocusable(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Label WithIsManipulationEnabled(this System.Windows.Controls.Label self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Label.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Label OnPreviewMouseDoubleClick(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseDoubleClick(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTargetUpdated(this System.Windows.Controls.Label self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnSourceUpdated(this System.Windows.Controls.Label self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnDataContextChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnRequestBringIntoView(this System.Windows.Controls.Label self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnSizeChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnInitialized(this System.Windows.Controls.Label self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLoaded(this System.Windows.Controls.Label self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnUnloaded(this System.Windows.Controls.Label self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnToolTipOpening(this System.Windows.Controls.Label self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnToolTipClosing(this System.Windows.Controls.Label self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnContextMenuOpening(this System.Windows.Controls.Label self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnContextMenuClosing(this System.Windows.Controls.Label self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseLeftButtonDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseLeftButtonUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseRightButtonDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseRightButtonDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseRightButtonUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseRightButtonUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewMouseWheel(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseWheel(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseEnter(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnMouseLeave(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnGotMouseCapture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLostMouseCapture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnQueryCursor(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusInAirMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusInAirMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusEnter(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusLeave(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusInRange(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusInRange(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusOutOfRange(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusOutOfRange(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusSystemGesture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusSystemGesture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnGotStylusCapture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLostStylusCapture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusButtonDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnStylusButtonUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusButtonDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewStylusButtonUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewKeyDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnKeyDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewKeyUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnKeyUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewGotKeyboardFocus(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnGotKeyboardFocus(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewLostKeyboardFocus(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLostKeyboardFocus(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewTextInput(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTextInput(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewQueryContinueDrag(this System.Windows.Controls.Label self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnQueryContinueDrag(this System.Windows.Controls.Label self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewGiveFeedback(this System.Windows.Controls.Label self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnGiveFeedback(this System.Windows.Controls.Label self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewDragEnter(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnDragEnter(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewDragOver(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnDragOver(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewDragLeave(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnDragLeave(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewDrop(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnDrop(this System.Windows.Controls.Label self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewTouchDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTouchDown(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewTouchMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTouchMove(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnPreviewTouchUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTouchUp(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnGotTouchCapture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLostTouchCapture(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTouchEnter(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnTouchLeave(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsMouseCapturedChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsStylusCapturedChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsKeyboardFocusedChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLayoutUpdated(this System.Windows.Controls.Label self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnGotFocus(this System.Windows.Controls.Label self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnLostFocus(this System.Windows.Controls.Label self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsEnabledChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsHitTestVisibleChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnIsVisibleChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnFocusableChanged(this System.Windows.Controls.Label self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnManipulationStarting(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnManipulationStarted(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnManipulationDelta(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnManipulationInertiaStarting(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnManipulationBoundaryFeedback(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Label OnManipulationCompleted(this System.Windows.Controls.Label self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}