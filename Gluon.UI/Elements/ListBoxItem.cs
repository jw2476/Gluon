
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ListBoxItem WithIsSelected(this System.Windows.Controls.ListBoxItem self, out ReadWriteBinding<System.Boolean> value)
    {
        
        var metadata = System.Windows.Controls.ListBoxItem.IsSelectedProperty.GetMetadata(typeof(System.Windows.Controls.ListBoxItem))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsSelectedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithContent(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithHasContent(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithContentTemplate(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithContentTemplateSelector(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithContentStringFormat(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithBorderBrush(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithBorderThickness(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithBackground(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithForeground(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFontFamily(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFontSize(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFontStretch(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFontStyle(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFontWeight(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithHorizontalContentAlignment(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithVerticalContentAlignment(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithTabIndex(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsTabStop(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithPadding(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithTemplate(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithStyle(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithOverridesDefaultStyle(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithUseLayoutRounding(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithDataContext(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithBindingGroup(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithLanguage(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithName(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithTag(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithInputScope(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithActualWidth(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithActualHeight(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithLayoutTransform(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithWidth(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithMinWidth(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithMaxWidth(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithHeight(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithMinHeight(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithMaxHeight(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFlowDirection(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithMargin(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithHorizontalAlignment(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithVerticalAlignment(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFocusVisualStyle(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithCursor(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithForceCursor(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithToolTip(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithContextMenu(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsMouseDirectlyOver(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsMouseOver(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsStylusOver(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsKeyboardFocusWithin(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsMouseCaptured(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsMouseCaptureWithin(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsStylusDirectlyOver(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsStylusCaptured(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsStylusCaptureWithin(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsKeyboardFocused(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithAreAnyTouchesOver(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithAreAnyTouchesCaptured(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithAllowDrop(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithRenderTransform(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithRenderTransformOrigin(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithOpacity(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithOpacityMask(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithBitmapEffect(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithEffect(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithBitmapEffectInput(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithCacheMode(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithUid(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithVisibility(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithClipToBounds(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithClip(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithSnapsToDevicePixels(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsFocused(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsEnabled(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsHitTestVisible(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsVisible(this System.Windows.Controls.ListBoxItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithFocusable(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem WithIsManipulationEnabled(this System.Windows.Controls.ListBoxItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListBoxItem.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ListBoxItem OnSelected(this System.Windows.Controls.ListBoxItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Selected += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnUnselected(this System.Windows.Controls.ListBoxItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unselected += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseDoubleClick(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseDoubleClick(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTargetUpdated(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnSourceUpdated(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnDataContextChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnRequestBringIntoView(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnSizeChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnInitialized(this System.Windows.Controls.ListBoxItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLoaded(this System.Windows.Controls.ListBoxItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnUnloaded(this System.Windows.Controls.ListBoxItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnToolTipOpening(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnToolTipClosing(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnContextMenuOpening(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnContextMenuClosing(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseLeftButtonDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseLeftButtonUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseRightButtonDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseRightButtonDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseRightButtonUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseRightButtonUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewMouseWheel(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseWheel(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseEnter(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnMouseLeave(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnGotMouseCapture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLostMouseCapture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnQueryCursor(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusInAirMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusInAirMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusEnter(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusLeave(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusInRange(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusInRange(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusOutOfRange(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusOutOfRange(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusSystemGesture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusSystemGesture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnGotStylusCapture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLostStylusCapture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusButtonDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnStylusButtonUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusButtonDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewStylusButtonUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewKeyDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnKeyDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewKeyUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnKeyUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewGotKeyboardFocus(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnGotKeyboardFocus(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewLostKeyboardFocus(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLostKeyboardFocus(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewTextInput(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTextInput(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewQueryContinueDrag(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnQueryContinueDrag(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewGiveFeedback(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnGiveFeedback(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewDragEnter(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnDragEnter(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewDragOver(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnDragOver(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewDragLeave(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnDragLeave(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewDrop(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnDrop(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewTouchDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTouchDown(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewTouchMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTouchMove(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnPreviewTouchUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTouchUp(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnGotTouchCapture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLostTouchCapture(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTouchEnter(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnTouchLeave(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsMouseCapturedChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsStylusCapturedChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsKeyboardFocusedChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLayoutUpdated(this System.Windows.Controls.ListBoxItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnGotFocus(this System.Windows.Controls.ListBoxItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnLostFocus(this System.Windows.Controls.ListBoxItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsEnabledChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsHitTestVisibleChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnIsVisibleChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnFocusableChanged(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnManipulationStarting(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnManipulationStarted(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnManipulationDelta(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnManipulationInertiaStarting(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnManipulationBoundaryFeedback(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListBoxItem OnManipulationCompleted(this System.Windows.Controls.ListBoxItem self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}