
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Primitives.StatusBarItem WithContent(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithHasContent(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithContentTemplate(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithContentTemplateSelector(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithContentStringFormat(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithBorderBrush(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithBorderThickness(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithBackground(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithForeground(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFontFamily(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFontSize(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFontStretch(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFontStyle(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFontWeight(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithHorizontalContentAlignment(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithVerticalContentAlignment(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithTabIndex(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsTabStop(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithPadding(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithTemplate(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithStyle(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithOverridesDefaultStyle(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithUseLayoutRounding(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithDataContext(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithBindingGroup(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithLanguage(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithName(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithTag(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithInputScope(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithActualWidth(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithActualHeight(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithLayoutTransform(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithWidth(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithMinWidth(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithMaxWidth(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithHeight(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithMinHeight(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithMaxHeight(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFlowDirection(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithMargin(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithHorizontalAlignment(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithVerticalAlignment(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFocusVisualStyle(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithCursor(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithForceCursor(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithToolTip(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithContextMenu(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsMouseDirectlyOver(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsMouseOver(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsStylusOver(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsKeyboardFocusWithin(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsMouseCaptured(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsMouseCaptureWithin(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsStylusDirectlyOver(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsStylusCaptured(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsStylusCaptureWithin(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsKeyboardFocused(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithAreAnyTouchesOver(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithAreAnyTouchesCaptured(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithAllowDrop(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithRenderTransform(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithRenderTransformOrigin(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithOpacity(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithOpacityMask(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithBitmapEffect(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithEffect(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithBitmapEffectInput(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithCacheMode(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithUid(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithVisibility(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithClipToBounds(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithClip(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithSnapsToDevicePixels(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsFocused(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsEnabled(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsHitTestVisible(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsVisible(this System.Windows.Controls.Primitives.StatusBarItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithFocusable(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem WithIsManipulationEnabled(this System.Windows.Controls.Primitives.StatusBarItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Primitives.StatusBarItem.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseDoubleClick(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseDoubleClick(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTargetUpdated(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnSourceUpdated(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnDataContextChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnRequestBringIntoView(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnSizeChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnInitialized(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLoaded(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnUnloaded(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnToolTipOpening(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnToolTipClosing(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnContextMenuOpening(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnContextMenuClosing(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseLeftButtonDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseLeftButtonUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseRightButtonDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseRightButtonDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseRightButtonUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseRightButtonUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewMouseWheel(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseWheel(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseEnter(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnMouseLeave(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnGotMouseCapture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLostMouseCapture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnQueryCursor(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusInAirMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusInAirMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusEnter(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusLeave(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusInRange(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusInRange(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusOutOfRange(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusOutOfRange(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusSystemGesture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusSystemGesture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnGotStylusCapture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLostStylusCapture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusButtonDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnStylusButtonUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusButtonDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewStylusButtonUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewKeyDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnKeyDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewKeyUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnKeyUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewGotKeyboardFocus(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnGotKeyboardFocus(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewLostKeyboardFocus(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLostKeyboardFocus(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewTextInput(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTextInput(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewQueryContinueDrag(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnQueryContinueDrag(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewGiveFeedback(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnGiveFeedback(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewDragEnter(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnDragEnter(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewDragOver(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnDragOver(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewDragLeave(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnDragLeave(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewDrop(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnDrop(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewTouchDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTouchDown(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewTouchMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTouchMove(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnPreviewTouchUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTouchUp(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnGotTouchCapture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLostTouchCapture(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTouchEnter(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnTouchLeave(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsMouseCapturedChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsStylusCapturedChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsKeyboardFocusedChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLayoutUpdated(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnGotFocus(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnLostFocus(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsEnabledChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsHitTestVisibleChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnIsVisibleChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnFocusableChanged(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnManipulationStarting(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnManipulationStarted(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnManipulationDelta(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnManipulationInertiaStarting(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnManipulationBoundaryFeedback(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Primitives.StatusBarItem OnManipulationCompleted(this System.Windows.Controls.Primitives.StatusBarItem self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}