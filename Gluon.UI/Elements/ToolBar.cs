
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ToolBar WithOrientation(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Windows.Controls.Orientation> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.OrientationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBand(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BandProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBandIndex(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BandIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsOverflowOpen(this System.Windows.Controls.ToolBar self, out ReadWriteBinding<System.Boolean> value)
    {
        
        var metadata = System.Windows.Controls.ToolBar.IsOverflowOpenProperty.GetMetadata(typeof(System.Windows.Controls.ToolBar))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ToolBar.IsOverflowOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHasOverflowItems(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.HasOverflowItemsProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithIsOverflowItem(this System.Windows.FrameworkElement self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsOverflowItemProperty, value);
        return self;
    }
    
    public static System.Windows.FrameworkElement WithOverflowMode(this System.Windows.FrameworkElement self, ReadWriteBinding<System.Windows.Controls.OverflowMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.OverflowModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHeader(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHasHeader(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.HasHeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHeaderTemplate(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HeaderTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHeaderTemplateSelector(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HeaderTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHeaderStringFormat(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HeaderStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemsSource(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHasItems(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithDisplayMemberPath(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemTemplate(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemTemplateSelector(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemStringFormat(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemBindingGroup(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemContainerStyle(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemContainerStyleSelector(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithItemsPanel(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsGrouping(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithGroupStyleSelector(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithAlternationCount(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsTextSearchEnabled(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsTextSearchCaseSensitive(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBorderBrush(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBorderThickness(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBackground(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithForeground(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFontFamily(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFontSize(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFontStretch(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFontStyle(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFontWeight(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHorizontalContentAlignment(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithVerticalContentAlignment(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithTabIndex(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsTabStop(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithPadding(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithTemplate(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithStyle(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithOverridesDefaultStyle(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithUseLayoutRounding(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithDataContext(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBindingGroup(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithLanguage(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithName(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithTag(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithInputScope(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithActualWidth(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithActualHeight(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithLayoutTransform(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithWidth(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithMinWidth(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithMaxWidth(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHeight(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithMinHeight(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithMaxHeight(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFlowDirection(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithMargin(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithHorizontalAlignment(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithVerticalAlignment(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFocusVisualStyle(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithCursor(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithForceCursor(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithToolTip(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithContextMenu(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsMouseDirectlyOver(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsMouseOver(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsStylusOver(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsKeyboardFocusWithin(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsMouseCaptured(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsMouseCaptureWithin(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsStylusDirectlyOver(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsStylusCaptured(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsStylusCaptureWithin(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsKeyboardFocused(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithAreAnyTouchesOver(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithAreAnyTouchesCaptured(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithAllowDrop(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithRenderTransform(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithRenderTransformOrigin(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithOpacity(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithOpacityMask(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBitmapEffect(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithEffect(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithBitmapEffectInput(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithCacheMode(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithUid(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithVisibility(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithClipToBounds(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithClip(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithSnapsToDevicePixels(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsFocused(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsEnabled(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsHitTestVisible(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsVisible(this System.Windows.Controls.ToolBar self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ToolBar.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithFocusable(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ToolBar WithIsManipulationEnabled(this System.Windows.Controls.ToolBar self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ToolBar.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ToolBar OnPreviewMouseDoubleClick(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseDoubleClick(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTargetUpdated(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnSourceUpdated(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnDataContextChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnRequestBringIntoView(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnSizeChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnInitialized(this System.Windows.Controls.ToolBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLoaded(this System.Windows.Controls.ToolBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnUnloaded(this System.Windows.Controls.ToolBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnToolTipOpening(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnToolTipClosing(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnContextMenuOpening(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnContextMenuClosing(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseLeftButtonDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseLeftButtonUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseRightButtonDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseRightButtonDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseRightButtonUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseRightButtonUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewMouseWheel(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseWheel(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseEnter(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnMouseLeave(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnGotMouseCapture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLostMouseCapture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnQueryCursor(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusInAirMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusInAirMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusEnter(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusLeave(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusInRange(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusInRange(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusOutOfRange(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusOutOfRange(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusSystemGesture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusSystemGesture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnGotStylusCapture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLostStylusCapture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusButtonDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnStylusButtonUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusButtonDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewStylusButtonUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewKeyDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnKeyDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewKeyUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnKeyUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewGotKeyboardFocus(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnGotKeyboardFocus(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewLostKeyboardFocus(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLostKeyboardFocus(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewTextInput(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTextInput(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewQueryContinueDrag(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnQueryContinueDrag(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewGiveFeedback(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnGiveFeedback(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewDragEnter(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnDragEnter(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewDragOver(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnDragOver(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewDragLeave(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnDragLeave(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewDrop(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnDrop(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewTouchDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTouchDown(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewTouchMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTouchMove(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnPreviewTouchUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTouchUp(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnGotTouchCapture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLostTouchCapture(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTouchEnter(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnTouchLeave(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsMouseCapturedChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsStylusCapturedChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsKeyboardFocusedChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLayoutUpdated(this System.Windows.Controls.ToolBar self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnGotFocus(this System.Windows.Controls.ToolBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnLostFocus(this System.Windows.Controls.ToolBar self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsEnabledChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsHitTestVisibleChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnIsVisibleChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnFocusableChanged(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnManipulationStarting(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnManipulationStarted(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnManipulationDelta(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnManipulationInertiaStarting(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnManipulationBoundaryFeedback(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ToolBar OnManipulationCompleted(this System.Windows.Controls.ToolBar self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}