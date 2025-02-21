
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ContentControl WithContent(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithHasContent(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithContentTemplate(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithContentTemplateSelector(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithContentStringFormat(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithBorderBrush(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithBorderThickness(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithBackground(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithForeground(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFontFamily(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFontSize(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFontStretch(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFontStyle(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFontWeight(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithHorizontalContentAlignment(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithVerticalContentAlignment(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithTabIndex(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsTabStop(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithPadding(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithTemplate(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithStyle(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithOverridesDefaultStyle(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithUseLayoutRounding(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithDataContext(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithBindingGroup(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithLanguage(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithName(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithTag(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithInputScope(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithActualWidth(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithActualHeight(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithLayoutTransform(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithWidth(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithMinWidth(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithMaxWidth(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithHeight(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithMinHeight(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithMaxHeight(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFlowDirection(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithMargin(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithHorizontalAlignment(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithVerticalAlignment(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFocusVisualStyle(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithCursor(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithForceCursor(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithToolTip(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithContextMenu(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsMouseDirectlyOver(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsMouseOver(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsStylusOver(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsKeyboardFocusWithin(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsMouseCaptured(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsMouseCaptureWithin(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsStylusDirectlyOver(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsStylusCaptured(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsStylusCaptureWithin(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsKeyboardFocused(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithAreAnyTouchesOver(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithAreAnyTouchesCaptured(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithAllowDrop(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithRenderTransform(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithRenderTransformOrigin(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithOpacity(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithOpacityMask(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithBitmapEffect(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithEffect(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithBitmapEffectInput(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithCacheMode(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithUid(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithVisibility(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithClipToBounds(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithClip(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithSnapsToDevicePixels(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsFocused(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsEnabled(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsHitTestVisible(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsVisible(this System.Windows.Controls.ContentControl self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ContentControl.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithFocusable(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ContentControl WithIsManipulationEnabled(this System.Windows.Controls.ContentControl self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ContentControl.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ContentControl OnPreviewMouseDoubleClick(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseDoubleClick(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTargetUpdated(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnSourceUpdated(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnDataContextChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnRequestBringIntoView(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnSizeChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnInitialized(this System.Windows.Controls.ContentControl self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLoaded(this System.Windows.Controls.ContentControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnUnloaded(this System.Windows.Controls.ContentControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnToolTipOpening(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnToolTipClosing(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnContextMenuOpening(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnContextMenuClosing(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseLeftButtonDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseLeftButtonUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseRightButtonDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseRightButtonDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseRightButtonUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseRightButtonUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewMouseWheel(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseWheel(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseEnter(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnMouseLeave(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnGotMouseCapture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLostMouseCapture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnQueryCursor(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusInAirMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusInAirMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusEnter(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusLeave(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusInRange(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusInRange(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusOutOfRange(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusOutOfRange(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusSystemGesture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusSystemGesture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnGotStylusCapture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLostStylusCapture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusButtonDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnStylusButtonUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusButtonDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewStylusButtonUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewKeyDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnKeyDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewKeyUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnKeyUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewGotKeyboardFocus(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnGotKeyboardFocus(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewLostKeyboardFocus(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLostKeyboardFocus(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewTextInput(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTextInput(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewQueryContinueDrag(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnQueryContinueDrag(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewGiveFeedback(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnGiveFeedback(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewDragEnter(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnDragEnter(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewDragOver(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnDragOver(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewDragLeave(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnDragLeave(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewDrop(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnDrop(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewTouchDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTouchDown(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewTouchMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTouchMove(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnPreviewTouchUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTouchUp(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnGotTouchCapture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLostTouchCapture(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTouchEnter(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnTouchLeave(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsMouseCapturedChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsStylusCapturedChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsKeyboardFocusedChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLayoutUpdated(this System.Windows.Controls.ContentControl self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnGotFocus(this System.Windows.Controls.ContentControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnLostFocus(this System.Windows.Controls.ContentControl self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsEnabledChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsHitTestVisibleChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnIsVisibleChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnFocusableChanged(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnManipulationStarting(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnManipulationStarted(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnManipulationDelta(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnManipulationInertiaStarting(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnManipulationBoundaryFeedback(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ContentControl OnManipulationCompleted(this System.Windows.Controls.ContentControl self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}