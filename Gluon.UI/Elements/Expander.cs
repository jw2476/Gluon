
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Expander WithExpandDirection(this System.Windows.Controls.Expander self, out ReadWriteBinding<System.Windows.Controls.ExpandDirection> value)
    {
        var metadata = System.Windows.Controls.Expander.ExpandDirectionProperty.GetMetadata(typeof(System.Windows.Controls.Expander))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Windows.Controls.ExpandDirection)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Expander.ExpandDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithExpandDirection(this System.Windows.Controls.Expander self, out ReadWriteBinding<System.Windows.Controls.ExpandDirection> value, System.Windows.Controls.ExpandDirection initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.Expander.ExpandDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsExpanded(this System.Windows.Controls.Expander self, out ReadWriteBinding<System.Boolean> value)
    {
        var metadata = System.Windows.Controls.Expander.IsExpandedProperty.GetMetadata(typeof(System.Windows.Controls.Expander))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.Expander.IsExpandedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsExpanded(this System.Windows.Controls.Expander self, out ReadWriteBinding<System.Boolean> value, System.Boolean initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.Expander.IsExpandedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHeader(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHasHeader(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.HasHeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHeaderTemplate(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HeaderTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHeaderTemplateSelector(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HeaderTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHeaderStringFormat(this System.Windows.Controls.Expander self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HeaderStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithContent(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHasContent(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithContentTemplate(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithContentTemplateSelector(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithContentStringFormat(this System.Windows.Controls.Expander self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithBorderBrush(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithBorderThickness(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithBackground(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithForeground(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFontFamily(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFontSize(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFontStretch(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFontStyle(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFontWeight(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHorizontalContentAlignment(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithVerticalContentAlignment(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithTabIndex(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsTabStop(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithPadding(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithTemplate(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithStyle(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithOverridesDefaultStyle(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithUseLayoutRounding(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithDataContext(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithBindingGroup(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithLanguage(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithName(this System.Windows.Controls.Expander self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithTag(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithInputScope(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithActualWidth(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithActualHeight(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithLayoutTransform(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithWidth(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithMinWidth(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithMaxWidth(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHeight(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithMinHeight(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithMaxHeight(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFlowDirection(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithMargin(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithHorizontalAlignment(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithVerticalAlignment(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFocusVisualStyle(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithCursor(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithForceCursor(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithToolTip(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithContextMenu(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsMouseDirectlyOver(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsMouseOver(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsStylusOver(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsKeyboardFocusWithin(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsMouseCaptured(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsMouseCaptureWithin(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsStylusDirectlyOver(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsStylusCaptured(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsStylusCaptureWithin(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsKeyboardFocused(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithAreAnyTouchesOver(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithAreAnyTouchesCaptured(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithAllowDrop(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithRenderTransform(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithRenderTransformOrigin(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithOpacity(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithOpacityMask(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithBitmapEffect(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithEffect(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithBitmapEffectInput(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithCacheMode(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithUid(this System.Windows.Controls.Expander self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithVisibility(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithClipToBounds(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithClip(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithSnapsToDevicePixels(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsFocused(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsEnabled(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsHitTestVisible(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsVisible(this System.Windows.Controls.Expander self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Expander.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithFocusable(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Expander WithIsManipulationEnabled(this System.Windows.Controls.Expander self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.Expander.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Expander OnExpanded(this System.Windows.Controls.Expander self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Expanded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnCollapsed(this System.Windows.Controls.Expander self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Collapsed += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseDoubleClick(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseDoubleClick(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTargetUpdated(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnSourceUpdated(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnDataContextChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnRequestBringIntoView(this System.Windows.Controls.Expander self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnSizeChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnInitialized(this System.Windows.Controls.Expander self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLoaded(this System.Windows.Controls.Expander self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnUnloaded(this System.Windows.Controls.Expander self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnToolTipOpening(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnToolTipClosing(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnContextMenuOpening(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnContextMenuClosing(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseLeftButtonDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseLeftButtonUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseRightButtonDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseRightButtonDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseRightButtonUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseRightButtonUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewMouseWheel(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseWheel(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseEnter(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnMouseLeave(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnGotMouseCapture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLostMouseCapture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnQueryCursor(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusInAirMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusInAirMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusEnter(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusLeave(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusInRange(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusInRange(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusOutOfRange(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusOutOfRange(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusSystemGesture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusSystemGesture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnGotStylusCapture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLostStylusCapture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusButtonDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnStylusButtonUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusButtonDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewStylusButtonUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewKeyDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnKeyDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewKeyUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnKeyUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewGotKeyboardFocus(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnGotKeyboardFocus(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewLostKeyboardFocus(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLostKeyboardFocus(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewTextInput(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTextInput(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewQueryContinueDrag(this System.Windows.Controls.Expander self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnQueryContinueDrag(this System.Windows.Controls.Expander self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewGiveFeedback(this System.Windows.Controls.Expander self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnGiveFeedback(this System.Windows.Controls.Expander self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewDragEnter(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnDragEnter(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewDragOver(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnDragOver(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewDragLeave(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnDragLeave(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewDrop(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnDrop(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewTouchDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTouchDown(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewTouchMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTouchMove(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnPreviewTouchUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTouchUp(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnGotTouchCapture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLostTouchCapture(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTouchEnter(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnTouchLeave(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsMouseCapturedChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsStylusCapturedChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsKeyboardFocusedChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLayoutUpdated(this System.Windows.Controls.Expander self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnGotFocus(this System.Windows.Controls.Expander self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnLostFocus(this System.Windows.Controls.Expander self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsEnabledChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsHitTestVisibleChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnIsVisibleChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnFocusableChanged(this System.Windows.Controls.Expander self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnManipulationStarting(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnManipulationStarted(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnManipulationDelta(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnManipulationInertiaStarting(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnManipulationBoundaryFeedback(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Expander OnManipulationCompleted(this System.Windows.Controls.Expander self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}