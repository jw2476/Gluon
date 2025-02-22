
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ListViewItem WithIsSelected(this System.Windows.Controls.ListViewItem self, out ReadWriteBinding<System.Boolean> value)
    {
        var metadata = System.Windows.Controls.ListViewItem.IsSelectedProperty.GetMetadata(typeof(System.Windows.Controls.ListBoxItem))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListViewItem.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsSelected(this System.Windows.Controls.ListViewItem self, out ReadWriteBinding<System.Boolean> value, System.Boolean initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.ListViewItem.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithContent(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithHasContent(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithContentTemplate(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithContentTemplateSelector(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithContentStringFormat(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithBorderBrush(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithBorderThickness(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithBackground(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithForeground(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFontFamily(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFontSize(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFontStretch(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFontStyle(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFontWeight(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithHorizontalContentAlignment(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithVerticalContentAlignment(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithTabIndex(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsTabStop(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithPadding(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithTemplate(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithStyle(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithOverridesDefaultStyle(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithUseLayoutRounding(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithDataContext(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithBindingGroup(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithLanguage(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithName(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithTag(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithInputScope(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithActualWidth(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithActualHeight(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithLayoutTransform(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithWidth(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithMinWidth(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithMaxWidth(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithHeight(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithMinHeight(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithMaxHeight(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFlowDirection(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithMargin(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithHorizontalAlignment(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithVerticalAlignment(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFocusVisualStyle(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithCursor(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithForceCursor(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithToolTip(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithContextMenu(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsMouseDirectlyOver(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsMouseOver(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsStylusOver(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsKeyboardFocusWithin(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsMouseCaptured(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsMouseCaptureWithin(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsStylusDirectlyOver(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsStylusCaptured(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsStylusCaptureWithin(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsKeyboardFocused(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithAreAnyTouchesOver(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithAreAnyTouchesCaptured(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithAllowDrop(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithRenderTransform(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithRenderTransformOrigin(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithOpacity(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithOpacityMask(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithBitmapEffect(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithEffect(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithBitmapEffectInput(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithCacheMode(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithUid(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithVisibility(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithClipToBounds(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithClip(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithSnapsToDevicePixels(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsFocused(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsEnabled(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsHitTestVisible(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsVisible(this System.Windows.Controls.ListViewItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListViewItem.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithFocusable(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem WithIsManipulationEnabled(this System.Windows.Controls.ListViewItem self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.ListViewItem.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ListViewItem OnSelected(this System.Windows.Controls.ListViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Selected += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnUnselected(this System.Windows.Controls.ListViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unselected += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseDoubleClick(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseDoubleClick(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTargetUpdated(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnSourceUpdated(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnDataContextChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnRequestBringIntoView(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnSizeChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnInitialized(this System.Windows.Controls.ListViewItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLoaded(this System.Windows.Controls.ListViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnUnloaded(this System.Windows.Controls.ListViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnToolTipOpening(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnToolTipClosing(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnContextMenuOpening(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnContextMenuClosing(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseLeftButtonDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseLeftButtonUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseRightButtonDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseRightButtonDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseRightButtonUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseRightButtonUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewMouseWheel(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseWheel(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseEnter(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnMouseLeave(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnGotMouseCapture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLostMouseCapture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnQueryCursor(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusInAirMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusInAirMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusEnter(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusLeave(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusInRange(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusInRange(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusOutOfRange(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusOutOfRange(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusSystemGesture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusSystemGesture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnGotStylusCapture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLostStylusCapture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusButtonDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnStylusButtonUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusButtonDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewStylusButtonUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewKeyDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnKeyDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewKeyUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnKeyUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewGotKeyboardFocus(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnGotKeyboardFocus(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewLostKeyboardFocus(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLostKeyboardFocus(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewTextInput(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTextInput(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewQueryContinueDrag(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnQueryContinueDrag(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewGiveFeedback(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnGiveFeedback(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewDragEnter(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnDragEnter(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewDragOver(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnDragOver(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewDragLeave(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnDragLeave(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewDrop(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnDrop(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewTouchDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTouchDown(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewTouchMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTouchMove(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnPreviewTouchUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTouchUp(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnGotTouchCapture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLostTouchCapture(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTouchEnter(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnTouchLeave(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsMouseCapturedChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsStylusCapturedChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsKeyboardFocusedChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLayoutUpdated(this System.Windows.Controls.ListViewItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnGotFocus(this System.Windows.Controls.ListViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnLostFocus(this System.Windows.Controls.ListViewItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsEnabledChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsHitTestVisibleChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnIsVisibleChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnFocusableChanged(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnManipulationStarting(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnManipulationStarted(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnManipulationDelta(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnManipulationInertiaStarting(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnManipulationBoundaryFeedback(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListViewItem OnManipulationCompleted(this System.Windows.Controls.ListViewItem self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}