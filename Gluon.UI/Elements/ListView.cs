
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.ListView WithView(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.ViewBase> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ViewProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSelectionMode(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.SelectionMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.SelectionModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSelectedItems(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Collections.IList> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.SelectedItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsSynchronizedWithCurrentItem(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsSynchronizedWithCurrentItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSelectedIndex(this System.Windows.Controls.ListView self, out ReadWriteBinding<System.Int32> value)
    {
        
        var metadata = System.Windows.Controls.ListView.SelectedIndexProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Int32)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListView.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSelectedItem(this System.Windows.Controls.ListView self, out ReadWriteBinding<System.Object> value)
    {
        
        var metadata = System.Windows.Controls.ListView.SelectedItemProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListView.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSelectedValue(this System.Windows.Controls.ListView self, out ReadWriteBinding<System.Object> value)
    {
        
        var metadata = System.Windows.Controls.ListView.SelectedValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.ListView.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSelectedValuePath(this System.Windows.Controls.ListView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.SelectedValuePathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemsSource(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithHasItems(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithDisplayMemberPath(this System.Windows.Controls.ListView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemTemplate(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemTemplateSelector(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemStringFormat(this System.Windows.Controls.ListView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemBindingGroup(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemContainerStyle(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemContainerStyleSelector(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithItemsPanel(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsGrouping(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithGroupStyleSelector(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithAlternationCount(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsTextSearchEnabled(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsTextSearchCaseSensitive(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithBorderBrush(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithBorderThickness(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithBackground(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithForeground(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFontFamily(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFontSize(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFontStretch(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFontStyle(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFontWeight(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithHorizontalContentAlignment(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithVerticalContentAlignment(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithTabIndex(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsTabStop(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithPadding(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithTemplate(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithStyle(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithOverridesDefaultStyle(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithUseLayoutRounding(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithDataContext(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithBindingGroup(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithLanguage(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithName(this System.Windows.Controls.ListView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithTag(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithInputScope(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithActualWidth(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithActualHeight(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithLayoutTransform(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithWidth(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithMinWidth(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithMaxWidth(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithHeight(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithMinHeight(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithMaxHeight(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFlowDirection(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithMargin(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithHorizontalAlignment(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithVerticalAlignment(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFocusVisualStyle(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithCursor(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithForceCursor(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithToolTip(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithContextMenu(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsMouseDirectlyOver(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsMouseOver(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsStylusOver(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsKeyboardFocusWithin(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsMouseCaptured(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsMouseCaptureWithin(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsStylusDirectlyOver(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsStylusCaptured(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsStylusCaptureWithin(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsKeyboardFocused(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithAreAnyTouchesOver(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithAreAnyTouchesCaptured(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithAllowDrop(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithRenderTransform(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithRenderTransformOrigin(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithOpacity(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithOpacityMask(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithBitmapEffect(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithEffect(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithBitmapEffectInput(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithCacheMode(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithUid(this System.Windows.Controls.ListView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithVisibility(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithClipToBounds(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithClip(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithSnapsToDevicePixels(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsFocused(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsEnabled(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsHitTestVisible(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsVisible(this System.Windows.Controls.ListView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.ListView.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithFocusable(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.ListView WithIsManipulationEnabled(this System.Windows.Controls.ListView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.ListView.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.ListView OnSelectionChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Controls.SelectionChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.SelectionChangedEventArgs>();
        self.SelectionChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseDoubleClick(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseDoubleClick(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTargetUpdated(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnSourceUpdated(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnDataContextChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnRequestBringIntoView(this System.Windows.Controls.ListView self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnSizeChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnInitialized(this System.Windows.Controls.ListView self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLoaded(this System.Windows.Controls.ListView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnUnloaded(this System.Windows.Controls.ListView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnToolTipOpening(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnToolTipClosing(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnContextMenuOpening(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnContextMenuClosing(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseLeftButtonDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseLeftButtonDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseLeftButtonUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseLeftButtonUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseRightButtonDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseRightButtonDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseRightButtonUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseRightButtonUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewMouseWheel(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseWheel(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseEnter(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnMouseLeave(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnGotMouseCapture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLostMouseCapture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnQueryCursor(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusInAirMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusInAirMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusEnter(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusLeave(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusInRange(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusInRange(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusOutOfRange(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusOutOfRange(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusSystemGesture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusSystemGesture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnGotStylusCapture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLostStylusCapture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusButtonDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnStylusButtonUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusButtonDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewStylusButtonUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewKeyDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnKeyDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewKeyUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnKeyUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewGotKeyboardFocus(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnGotKeyboardFocus(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewLostKeyboardFocus(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLostKeyboardFocus(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewTextInput(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTextInput(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewQueryContinueDrag(this System.Windows.Controls.ListView self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnQueryContinueDrag(this System.Windows.Controls.ListView self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewGiveFeedback(this System.Windows.Controls.ListView self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnGiveFeedback(this System.Windows.Controls.ListView self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewDragEnter(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnDragEnter(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewDragOver(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnDragOver(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewDragLeave(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnDragLeave(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewDrop(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnDrop(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewTouchDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTouchDown(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewTouchMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTouchMove(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnPreviewTouchUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTouchUp(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnGotTouchCapture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLostTouchCapture(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTouchEnter(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnTouchLeave(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsMouseDirectlyOverChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsMouseCapturedChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsMouseCaptureWithinChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsStylusDirectlyOverChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsStylusCapturedChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsStylusCaptureWithinChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsKeyboardFocusedChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLayoutUpdated(this System.Windows.Controls.ListView self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnGotFocus(this System.Windows.Controls.ListView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnLostFocus(this System.Windows.Controls.ListView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsEnabledChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsHitTestVisibleChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnIsVisibleChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnFocusableChanged(this System.Windows.Controls.ListView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnManipulationStarting(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnManipulationStarted(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnManipulationDelta(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnManipulationInertiaStarting(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnManipulationBoundaryFeedback(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.ListView OnManipulationCompleted(this System.Windows.Controls.ListView self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}