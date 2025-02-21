
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.TextBox WithTextWrapping(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.TextWrapping> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.TextWrappingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMinLines(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MinLinesProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMaxLines(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MaxLinesProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithText(this System.Windows.Controls.TextBox self, out ReadWriteBinding<System.String> value)
    {
        
        var metadata = System.Windows.Controls.TextBox.TextProperty.GetMetadata(typeof(System.Windows.Controls.TextBox))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.String)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.TextBox.TextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithCharacterCasing(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Controls.CharacterCasing> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.CharacterCasingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMaxLength(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MaxLengthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithTextAlignment(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.TextAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.TextAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithTextDecorations(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.TextDecorationCollection> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.TextDecorationsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsReadOnly(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsReadOnlyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsReadOnlyCaretVisible(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsReadOnlyCaretVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAcceptsReturn(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.AcceptsReturnProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAcceptsTab(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.AcceptsTabProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithHorizontalScrollBarVisibility(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.HorizontalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithVerticalScrollBarVisibility(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.VerticalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsUndoEnabled(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsUndoEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithUndoLimit(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.UndoLimitProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAutoWordSelection(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.AutoWordSelectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithSelectionBrush(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.SelectionBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithSelectionTextBrush(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.SelectionTextBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithSelectionOpacity(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.SelectionOpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithCaretBrush(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.CaretBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsSelectionActive(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsSelectionActiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsInactiveSelectionHighlightEnabled(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsInactiveSelectionHighlightEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithBorderBrush(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithBorderThickness(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithBackground(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithForeground(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFontFamily(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFontSize(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFontStretch(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFontStyle(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFontWeight(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithHorizontalContentAlignment(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithVerticalContentAlignment(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithTabIndex(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsTabStop(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithPadding(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithTemplate(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithStyle(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithOverridesDefaultStyle(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithUseLayoutRounding(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithDataContext(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithBindingGroup(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithLanguage(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithName(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithTag(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithInputScope(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithActualWidth(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithActualHeight(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithLayoutTransform(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithWidth(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMinWidth(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMaxWidth(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithHeight(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMinHeight(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMaxHeight(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFlowDirection(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithMargin(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithHorizontalAlignment(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithVerticalAlignment(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFocusVisualStyle(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithCursor(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithForceCursor(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithToolTip(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithContextMenu(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsMouseDirectlyOver(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsMouseOver(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsStylusOver(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsKeyboardFocusWithin(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsMouseCaptured(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsMouseCaptureWithin(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsStylusDirectlyOver(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsStylusCaptured(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsStylusCaptureWithin(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsKeyboardFocused(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAreAnyTouchesOver(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAreAnyTouchesCaptured(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithAllowDrop(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithRenderTransform(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithRenderTransformOrigin(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithOpacity(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithOpacityMask(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithBitmapEffect(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithEffect(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithBitmapEffectInput(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithCacheMode(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithUid(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithVisibility(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithClipToBounds(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithClip(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithSnapsToDevicePixels(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsFocused(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsEnabled(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsHitTestVisible(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsVisible(this System.Windows.Controls.TextBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TextBox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithFocusable(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TextBox WithIsManipulationEnabled(this System.Windows.Controls.TextBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TextBox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.TextBox OnTextChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Controls.TextChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.TextChangedEventArgs>();
        self.TextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnSelectionChanged(this System.Windows.Controls.TextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.SelectionChanged += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseDoubleClick(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseDoubleClick(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTargetUpdated(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnSourceUpdated(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnDataContextChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnRequestBringIntoView(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnSizeChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnInitialized(this System.Windows.Controls.TextBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLoaded(this System.Windows.Controls.TextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnUnloaded(this System.Windows.Controls.TextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnToolTipOpening(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnToolTipClosing(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnContextMenuOpening(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnContextMenuClosing(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseLeftButtonDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseLeftButtonUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseRightButtonDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseRightButtonDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseRightButtonUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseRightButtonUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewMouseWheel(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseWheel(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseEnter(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnMouseLeave(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnGotMouseCapture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLostMouseCapture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnQueryCursor(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusInAirMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusInAirMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusEnter(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusLeave(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusInRange(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusInRange(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusOutOfRange(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusOutOfRange(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusSystemGesture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusSystemGesture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnGotStylusCapture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLostStylusCapture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusButtonDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnStylusButtonUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusButtonDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewStylusButtonUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewKeyDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnKeyDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewKeyUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnKeyUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewGotKeyboardFocus(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnGotKeyboardFocus(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewLostKeyboardFocus(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLostKeyboardFocus(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewTextInput(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTextInput(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewQueryContinueDrag(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnQueryContinueDrag(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewGiveFeedback(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnGiveFeedback(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewDragEnter(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnDragEnter(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewDragOver(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnDragOver(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewDragLeave(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnDragLeave(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewDrop(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnDrop(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewTouchDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTouchDown(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewTouchMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTouchMove(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnPreviewTouchUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTouchUp(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnGotTouchCapture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLostTouchCapture(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTouchEnter(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnTouchLeave(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsMouseCapturedChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsStylusCapturedChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsKeyboardFocusedChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLayoutUpdated(this System.Windows.Controls.TextBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnGotFocus(this System.Windows.Controls.TextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnLostFocus(this System.Windows.Controls.TextBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsEnabledChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsHitTestVisibleChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnIsVisibleChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnFocusableChanged(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnManipulationStarting(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnManipulationStarted(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnManipulationDelta(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnManipulationInertiaStarting(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnManipulationBoundaryFeedback(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TextBox OnManipulationCompleted(this System.Windows.Controls.TextBox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}