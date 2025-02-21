
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.TextBlock WithBaselineOffset(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.BaselineOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithText(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFontFamily(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFontStyle(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFontWeight(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFontStretch(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFontSize(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithForeground(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithBackground(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithTextDecorations(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.TextDecorationCollection> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TextDecorationsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithTextEffects(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.TextEffectCollection> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TextEffectsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithLineHeight(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.LineHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithLineStackingStrategy(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.LineStackingStrategy> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.LineStackingStrategyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithPadding(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithTextAlignment(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.TextAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TextAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithTextTrimming(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.TextTrimming> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TextTrimmingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithTextWrapping(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.TextWrapping> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TextWrappingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsHyphenationEnabled(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.IsHyphenationEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithStyle(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithOverridesDefaultStyle(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithUseLayoutRounding(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithDataContext(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithBindingGroup(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithLanguage(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithName(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithTag(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithInputScope(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithActualWidth(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithActualHeight(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithLayoutTransform(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithWidth(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithMinWidth(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithMaxWidth(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithHeight(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithMinHeight(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithMaxHeight(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFlowDirection(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithMargin(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithHorizontalAlignment(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithVerticalAlignment(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFocusVisualStyle(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithCursor(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithForceCursor(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithToolTip(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithContextMenu(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsMouseDirectlyOver(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsMouseOver(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsStylusOver(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsKeyboardFocusWithin(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsMouseCaptured(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsMouseCaptureWithin(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsStylusDirectlyOver(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsStylusCaptured(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsStylusCaptureWithin(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsKeyboardFocused(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithAreAnyTouchesOver(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithAreAnyTouchesCaptured(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithAllowDrop(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithRenderTransform(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithRenderTransformOrigin(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithOpacity(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithOpacityMask(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithBitmapEffect(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithEffect(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithBitmapEffectInput(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithCacheMode(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithUid(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithVisibility(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithClipToBounds(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithClip(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithSnapsToDevicePixels(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsFocused(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsEnabled(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsHitTestVisible(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsVisible(this System.Windows.Controls.TextBlock self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBlock.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithFocusable(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBlock WithIsManipulationEnabled(this System.Windows.Controls.TextBlock self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBlock.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.TextBlock OnTargetUpdated(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnSourceUpdated(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnDataContextChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnRequestBringIntoView(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnSizeChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnInitialized(this System.Windows.Controls.TextBlock self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLoaded(this System.Windows.Controls.TextBlock self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnUnloaded(this System.Windows.Controls.TextBlock self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnToolTipOpening(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnToolTipClosing(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnContextMenuOpening(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnContextMenuClosing(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseLeftButtonDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseLeftButtonDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseLeftButtonUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseLeftButtonUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseRightButtonDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseRightButtonDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseRightButtonUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseRightButtonUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewMouseWheel(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseWheel(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseEnter(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnMouseLeave(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnGotMouseCapture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLostMouseCapture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnQueryCursor(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusInAirMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusInAirMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusEnter(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusLeave(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusInRange(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusInRange(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusOutOfRange(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusOutOfRange(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusSystemGesture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusSystemGesture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnGotStylusCapture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLostStylusCapture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusButtonDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnStylusButtonUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusButtonDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewStylusButtonUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewKeyDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnKeyDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewKeyUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnKeyUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewGotKeyboardFocus(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnGotKeyboardFocus(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewLostKeyboardFocus(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLostKeyboardFocus(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewTextInput(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnTextInput(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewQueryContinueDrag(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnQueryContinueDrag(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewGiveFeedback(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnGiveFeedback(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewDragEnter(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnDragEnter(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewDragOver(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnDragOver(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewDragLeave(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnDragLeave(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewDrop(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnDrop(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewTouchDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnTouchDown(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewTouchMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnTouchMove(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnPreviewTouchUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnTouchUp(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnGotTouchCapture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLostTouchCapture(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnTouchEnter(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnTouchLeave(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsMouseDirectlyOverChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsMouseCapturedChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsMouseCaptureWithinChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsStylusDirectlyOverChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsStylusCapturedChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsStylusCaptureWithinChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsKeyboardFocusedChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLayoutUpdated(this System.Windows.Controls.TextBlock self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnGotFocus(this System.Windows.Controls.TextBlock self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnLostFocus(this System.Windows.Controls.TextBlock self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsEnabledChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsHitTestVisibleChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnIsVisibleChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnFocusableChanged(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnManipulationStarting(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnManipulationStarted(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnManipulationDelta(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnManipulationInertiaStarting(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnManipulationBoundaryFeedback(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBlock OnManipulationCompleted(this System.Windows.Controls.TextBlock self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}