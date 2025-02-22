
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Button WithIsDefault(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.IsDefaultProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsCancel(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.IsCancelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsDefaulted(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsDefaultedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithCommand(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Input.ICommand> value)
    {
        self.SetBinding(System.Windows.Controls.Button.CommandProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithCommandParameter(this System.Windows.Controls.Button self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Button.CommandParameterProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithCommandTarget(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.IInputElement> value)
    {
        self.SetBinding(System.Windows.Controls.Button.CommandTargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsPressed(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsPressedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithClickMode(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Controls.ClickMode> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ClickModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithContent(this System.Windows.Controls.Button self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithHasContent(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithContentTemplate(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithContentTemplateSelector(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithContentStringFormat(this System.Windows.Controls.Button self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithBorderBrush(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Button.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithBorderThickness(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Button.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithBackground(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Button.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithForeground(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFontFamily(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFontSize(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFontStretch(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFontStyle(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFontWeight(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithHorizontalContentAlignment(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Button.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithVerticalContentAlignment(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Button.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithTabIndex(this System.Windows.Controls.Button self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.Button.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsTabStop(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithPadding(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Button.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithTemplate(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.Button.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithStyle(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.Button.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithOverridesDefaultStyle(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithUseLayoutRounding(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithDataContext(this System.Windows.Controls.Button self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Button.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithBindingGroup(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.Button.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithLanguage(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.Button.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithName(this System.Windows.Controls.Button self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Button.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithTag(this System.Windows.Controls.Button self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Button.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithInputScope(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.Button.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithActualWidth(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithActualHeight(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithLayoutTransform(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.Button.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithWidth(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithMinWidth(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithMaxWidth(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithHeight(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithMinHeight(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithMaxHeight(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFlowDirection(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithMargin(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Button.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithHorizontalAlignment(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Button.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithVerticalAlignment(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Button.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFocusVisualStyle(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithCursor(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.Button.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithForceCursor(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithToolTip(this System.Windows.Controls.Button self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithContextMenu(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsMouseDirectlyOver(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsMouseOver(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsStylusOver(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsKeyboardFocusWithin(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsMouseCaptured(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsMouseCaptureWithin(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsStylusDirectlyOver(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsStylusCaptured(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsStylusCaptureWithin(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsKeyboardFocused(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithAreAnyTouchesOver(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithAreAnyTouchesCaptured(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithAllowDrop(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithRenderTransform(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.Button.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithRenderTransformOrigin(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.Button.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithOpacity(this System.Windows.Controls.Button self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Button.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithOpacityMask(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Button.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithBitmapEffect(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.Button.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithEffect(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.Button.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithBitmapEffectInput(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.Button.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithCacheMode(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.Button.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithUid(this System.Windows.Controls.Button self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Button.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithVisibility(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.Button.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithClipToBounds(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithClip(this System.Windows.Controls.Button self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.Button.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithSnapsToDevicePixels(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsFocused(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsEnabled(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsHitTestVisible(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsVisible(this System.Windows.Controls.Button self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Button.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithFocusable(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Button WithIsManipulationEnabled(this System.Windows.Controls.Button self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Button.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Button OnClick(this System.Windows.Controls.Button self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Click += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseDoubleClick(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseDoubleClick(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTargetUpdated(this System.Windows.Controls.Button self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnSourceUpdated(this System.Windows.Controls.Button self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnDataContextChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnRequestBringIntoView(this System.Windows.Controls.Button self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnSizeChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnInitialized(this System.Windows.Controls.Button self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLoaded(this System.Windows.Controls.Button self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnUnloaded(this System.Windows.Controls.Button self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnToolTipOpening(this System.Windows.Controls.Button self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnToolTipClosing(this System.Windows.Controls.Button self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnContextMenuOpening(this System.Windows.Controls.Button self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnContextMenuClosing(this System.Windows.Controls.Button self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseLeftButtonDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseLeftButtonUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseRightButtonDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseRightButtonDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseRightButtonUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseRightButtonUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewMouseWheel(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseWheel(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseEnter(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnMouseLeave(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnGotMouseCapture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLostMouseCapture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnQueryCursor(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusInAirMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusInAirMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusEnter(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusLeave(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusInRange(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusInRange(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusOutOfRange(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusOutOfRange(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusSystemGesture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusSystemGesture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnGotStylusCapture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLostStylusCapture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusButtonDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnStylusButtonUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusButtonDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewStylusButtonUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewKeyDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnKeyDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewKeyUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnKeyUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewGotKeyboardFocus(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnGotKeyboardFocus(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewLostKeyboardFocus(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLostKeyboardFocus(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewTextInput(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTextInput(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewQueryContinueDrag(this System.Windows.Controls.Button self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnQueryContinueDrag(this System.Windows.Controls.Button self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewGiveFeedback(this System.Windows.Controls.Button self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnGiveFeedback(this System.Windows.Controls.Button self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewDragEnter(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnDragEnter(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewDragOver(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnDragOver(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewDragLeave(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnDragLeave(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewDrop(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnDrop(this System.Windows.Controls.Button self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewTouchDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTouchDown(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewTouchMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTouchMove(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnPreviewTouchUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTouchUp(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnGotTouchCapture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLostTouchCapture(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTouchEnter(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnTouchLeave(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsMouseCapturedChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsStylusCapturedChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsKeyboardFocusedChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLayoutUpdated(this System.Windows.Controls.Button self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnGotFocus(this System.Windows.Controls.Button self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnLostFocus(this System.Windows.Controls.Button self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsEnabledChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsHitTestVisibleChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnIsVisibleChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnFocusableChanged(this System.Windows.Controls.Button self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnManipulationStarting(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnManipulationStarted(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnManipulationDelta(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnManipulationInertiaStarting(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnManipulationBoundaryFeedback(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Button OnManipulationCompleted(this System.Windows.Controls.Button self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}