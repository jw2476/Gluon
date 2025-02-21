
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.MenuItem WithCommand(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Input.ICommand> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.CommandProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithCommandParameter(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.CommandParameterProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithCommandTarget(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.IInputElement> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.CommandTargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsSubmenuOpen(this System.Windows.Controls.MenuItem self, out ReadWriteBinding<System.Boolean> value)
    {
        
        var metadata = System.Windows.Controls.MenuItem.IsSubmenuOpenProperty.GetMetadata(typeof(System.Windows.Controls.MenuItem))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.MenuItem.IsSubmenuOpenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithRole(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Windows.Controls.MenuItemRole> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.RoleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsCheckable(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsCheckableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsPressed(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsPressedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsHighlighted(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsHighlightedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsChecked(this System.Windows.Controls.MenuItem self, out ReadWriteBinding<System.Boolean> value)
    {
        
        var metadata = System.Windows.Controls.MenuItem.IsCheckedProperty.GetMetadata(typeof(System.Windows.Controls.MenuItem))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Boolean)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.MenuItem.IsCheckedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithStaysOpenOnClick(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.StaysOpenOnClickProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithInputGestureText(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.InputGestureTextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIcon(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IconProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsSuspendingPopupAnimation(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsSuspendingPopupAnimationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemContainerTemplateSelector(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.ItemContainerTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemContainerTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithUsesItemContainerTemplate(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.UsesItemContainerTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHeader(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHasHeader(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.HasHeaderProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHeaderTemplate(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HeaderTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHeaderTemplateSelector(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HeaderTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHeaderStringFormat(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HeaderStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemsSource(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHasItems(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithDisplayMemberPath(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemTemplate(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemTemplateSelector(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemStringFormat(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemBindingGroup(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemContainerStyle(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemContainerStyleSelector(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithItemsPanel(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsGrouping(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithGroupStyleSelector(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithAlternationCount(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsTextSearchEnabled(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsTextSearchCaseSensitive(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithBorderBrush(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithBorderThickness(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithBackground(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithForeground(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFontFamily(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFontSize(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFontStretch(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFontStyle(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFontWeight(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHorizontalContentAlignment(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithVerticalContentAlignment(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithTabIndex(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsTabStop(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithPadding(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithTemplate(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithStyle(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithOverridesDefaultStyle(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithUseLayoutRounding(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithDataContext(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithBindingGroup(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithLanguage(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithName(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithTag(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithInputScope(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithActualWidth(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithActualHeight(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithLayoutTransform(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithWidth(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithMinWidth(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithMaxWidth(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHeight(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithMinHeight(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithMaxHeight(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFlowDirection(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithMargin(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithHorizontalAlignment(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithVerticalAlignment(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFocusVisualStyle(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithCursor(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithForceCursor(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithToolTip(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithContextMenu(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsMouseDirectlyOver(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsMouseOver(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsStylusOver(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsKeyboardFocusWithin(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsMouseCaptured(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsMouseCaptureWithin(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsStylusDirectlyOver(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsStylusCaptured(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsStylusCaptureWithin(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsKeyboardFocused(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithAreAnyTouchesOver(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithAreAnyTouchesCaptured(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithAllowDrop(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithRenderTransform(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithRenderTransformOrigin(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithOpacity(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithOpacityMask(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithBitmapEffect(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithEffect(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithBitmapEffectInput(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithCacheMode(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithUid(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithVisibility(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithClipToBounds(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithClip(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithSnapsToDevicePixels(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsFocused(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsEnabled(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsHitTestVisible(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsVisible(this System.Windows.Controls.MenuItem self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.MenuItem.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithFocusable(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.MenuItem WithIsManipulationEnabled(this System.Windows.Controls.MenuItem self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.MenuItem.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.MenuItem OnClick(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Click += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnChecked(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Checked += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnUnchecked(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unchecked += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnSubmenuOpened(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.SubmenuOpened += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnSubmenuClosed(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.SubmenuClosed += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseDoubleClick(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseDoubleClick(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTargetUpdated(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnSourceUpdated(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnDataContextChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnRequestBringIntoView(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnSizeChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnInitialized(this System.Windows.Controls.MenuItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLoaded(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnUnloaded(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnToolTipOpening(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnToolTipClosing(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnContextMenuOpening(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnContextMenuClosing(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseLeftButtonDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseLeftButtonDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseLeftButtonUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseLeftButtonUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseRightButtonDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseRightButtonDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseRightButtonUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseRightButtonUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewMouseWheel(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseWheel(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseEnter(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnMouseLeave(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnGotMouseCapture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLostMouseCapture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnQueryCursor(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusInAirMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusInAirMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusEnter(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusLeave(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusInRange(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusInRange(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusOutOfRange(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusOutOfRange(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusSystemGesture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusSystemGesture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnGotStylusCapture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLostStylusCapture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusButtonDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnStylusButtonUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusButtonDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewStylusButtonUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewKeyDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnKeyDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewKeyUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnKeyUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewGotKeyboardFocus(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnGotKeyboardFocus(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewLostKeyboardFocus(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLostKeyboardFocus(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewTextInput(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTextInput(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewQueryContinueDrag(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnQueryContinueDrag(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewGiveFeedback(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnGiveFeedback(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewDragEnter(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnDragEnter(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewDragOver(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnDragOver(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewDragLeave(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnDragLeave(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewDrop(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnDrop(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewTouchDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTouchDown(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewTouchMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTouchMove(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnPreviewTouchUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTouchUp(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnGotTouchCapture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLostTouchCapture(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTouchEnter(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnTouchLeave(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsMouseDirectlyOverChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsMouseCapturedChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsMouseCaptureWithinChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsStylusDirectlyOverChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsStylusCapturedChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsStylusCaptureWithinChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsKeyboardFocusedChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLayoutUpdated(this System.Windows.Controls.MenuItem self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnGotFocus(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnLostFocus(this System.Windows.Controls.MenuItem self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsEnabledChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsHitTestVisibleChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnIsVisibleChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnFocusableChanged(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnManipulationStarting(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnManipulationStarted(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnManipulationDelta(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnManipulationInertiaStarting(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnManipulationBoundaryFeedback(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.MenuItem OnManipulationCompleted(this System.Windows.Controls.MenuItem self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}