
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.RichTextBox WithIsDocumentEnabled(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsDocumentEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsReadOnly(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsReadOnlyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsReadOnlyCaretVisible(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsReadOnlyCaretVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAcceptsReturn(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.AcceptsReturnProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAcceptsTab(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.AcceptsTabProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithHorizontalScrollBarVisibility(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.HorizontalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithVerticalScrollBarVisibility(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.VerticalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsUndoEnabled(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsUndoEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithUndoLimit(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.UndoLimitProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAutoWordSelection(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.AutoWordSelectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithSelectionBrush(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.SelectionBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithSelectionTextBrush(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.SelectionTextBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithSelectionOpacity(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.SelectionOpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithCaretBrush(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.CaretBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsSelectionActive(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsSelectionActiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsInactiveSelectionHighlightEnabled(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsInactiveSelectionHighlightEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithBorderBrush(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithBorderThickness(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithBackground(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithForeground(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFontFamily(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFontSize(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFontStretch(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFontStyle(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFontWeight(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithHorizontalContentAlignment(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithVerticalContentAlignment(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithTabIndex(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsTabStop(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithPadding(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithTemplate(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithStyle(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithOverridesDefaultStyle(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithUseLayoutRounding(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithDataContext(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithBindingGroup(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithLanguage(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithName(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithTag(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithInputScope(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithActualWidth(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithActualHeight(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithLayoutTransform(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithWidth(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithMinWidth(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithMaxWidth(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithHeight(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithMinHeight(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithMaxHeight(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFlowDirection(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithMargin(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithHorizontalAlignment(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithVerticalAlignment(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFocusVisualStyle(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithCursor(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithForceCursor(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithToolTip(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithContextMenu(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsMouseDirectlyOver(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsMouseOver(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsStylusOver(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsKeyboardFocusWithin(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsMouseCaptured(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsMouseCaptureWithin(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsStylusDirectlyOver(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsStylusCaptured(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsStylusCaptureWithin(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsKeyboardFocused(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAreAnyTouchesOver(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAreAnyTouchesCaptured(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithAllowDrop(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithRenderTransform(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithRenderTransformOrigin(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithOpacity(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithOpacityMask(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithBitmapEffect(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithEffect(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithBitmapEffectInput(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithCacheMode(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithUid(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithVisibility(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithClipToBounds(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithClip(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithSnapsToDevicePixels(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsFocused(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsEnabled(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsHitTestVisible(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsVisible(this System.Windows.Controls.RichTextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RichTextBox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithFocusable(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox WithIsManipulationEnabled(this System.Windows.Controls.RichTextBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.RichTextBox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.RichTextBox OnTextChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Controls.TextChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.TextChangedEventArgs>();
        self.TextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnSelectionChanged(this System.Windows.Controls.RichTextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.SelectionChanged += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseDoubleClick(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseDoubleClick(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTargetUpdated(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnSourceUpdated(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnDataContextChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnRequestBringIntoView(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnSizeChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnInitialized(this System.Windows.Controls.RichTextBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLoaded(this System.Windows.Controls.RichTextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnUnloaded(this System.Windows.Controls.RichTextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnToolTipOpening(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnToolTipClosing(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnContextMenuOpening(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnContextMenuClosing(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseLeftButtonDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseLeftButtonUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseRightButtonDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseRightButtonDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseRightButtonUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseRightButtonUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewMouseWheel(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseWheel(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseEnter(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnMouseLeave(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnGotMouseCapture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLostMouseCapture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnQueryCursor(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusInAirMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusInAirMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusEnter(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusLeave(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusInRange(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusInRange(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusOutOfRange(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusOutOfRange(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusSystemGesture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusSystemGesture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnGotStylusCapture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLostStylusCapture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusButtonDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnStylusButtonUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusButtonDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewStylusButtonUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewKeyDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnKeyDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewKeyUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnKeyUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewGotKeyboardFocus(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnGotKeyboardFocus(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewLostKeyboardFocus(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLostKeyboardFocus(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewTextInput(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTextInput(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewQueryContinueDrag(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnQueryContinueDrag(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewGiveFeedback(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnGiveFeedback(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewDragEnter(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnDragEnter(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewDragOver(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnDragOver(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewDragLeave(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnDragLeave(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewDrop(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnDrop(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewTouchDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTouchDown(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewTouchMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTouchMove(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnPreviewTouchUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTouchUp(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnGotTouchCapture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLostTouchCapture(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTouchEnter(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnTouchLeave(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsMouseCapturedChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsStylusCapturedChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsKeyboardFocusedChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLayoutUpdated(this System.Windows.Controls.RichTextBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnGotFocus(this System.Windows.Controls.RichTextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnLostFocus(this System.Windows.Controls.RichTextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsEnabledChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsHitTestVisibleChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnIsVisibleChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnFocusableChanged(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnManipulationStarting(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnManipulationStarted(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnManipulationDelta(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnManipulationInertiaStarting(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnManipulationBoundaryFeedback(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RichTextBox OnManipulationCompleted(this System.Windows.Controls.RichTextBox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}