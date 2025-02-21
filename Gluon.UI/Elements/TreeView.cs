
using Gluon.Core;
using Gluon.Reactive;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.TreeView WithSelectedItem(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Object> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithSelectedValue(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Object> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithSelectedValuePath(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.SelectedValuePathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemsSource(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithHasItems(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithDisplayMemberPath(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemTemplate(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemTemplateSelector(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemStringFormat(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemBindingGroup(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemContainerStyle(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemContainerStyleSelector(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithItemsPanel(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsGrouping(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithGroupStyleSelector(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithAlternationCount(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsTextSearchEnabled(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsTextSearchCaseSensitive(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithBorderBrush(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithBorderThickness(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithBackground(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithForeground(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFontFamily(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFontSize(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFontStretch(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFontStyle(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFontWeight(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithHorizontalContentAlignment(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithVerticalContentAlignment(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithTabIndex(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsTabStop(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithPadding(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithTemplate(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithStyle(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithOverridesDefaultStyle(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithUseLayoutRounding(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithDataContext(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithBindingGroup(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithLanguage(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithName(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithTag(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithInputScope(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithActualWidth(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithActualHeight(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithLayoutTransform(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithWidth(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithMinWidth(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithMaxWidth(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithHeight(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithMinHeight(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithMaxHeight(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFlowDirection(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithMargin(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithHorizontalAlignment(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithVerticalAlignment(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFocusVisualStyle(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithCursor(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithForceCursor(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithToolTip(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithContextMenu(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsMouseDirectlyOver(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsMouseOver(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsStylusOver(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsKeyboardFocusWithin(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsMouseCaptured(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsMouseCaptureWithin(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsStylusDirectlyOver(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsStylusCaptured(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsStylusCaptureWithin(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsKeyboardFocused(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithAreAnyTouchesOver(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithAreAnyTouchesCaptured(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithAllowDrop(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithRenderTransform(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithRenderTransformOrigin(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithOpacity(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithOpacityMask(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithBitmapEffect(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithEffect(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithBitmapEffectInput(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithCacheMode(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithUid(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithVisibility(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithClipToBounds(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithClip(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithSnapsToDevicePixels(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsFocused(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsEnabled(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsHitTestVisible(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsVisible(this System.Windows.Controls.TreeView self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.TreeView.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithFocusable(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.TreeView WithIsManipulationEnabled(this System.Windows.Controls.TreeView self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.TreeView.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.TreeView OnSelectedItemChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Object>> handler)
    {
        var subject = new Subject<System.Windows.RoutedPropertyChangedEventArgs<System.Object>>();
        self.SelectedItemChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseDoubleClick(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseDoubleClick(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTargetUpdated(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnSourceUpdated(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnDataContextChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnRequestBringIntoView(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnSizeChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnInitialized(this System.Windows.Controls.TreeView self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLoaded(this System.Windows.Controls.TreeView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnUnloaded(this System.Windows.Controls.TreeView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnToolTipOpening(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnToolTipClosing(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnContextMenuOpening(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnContextMenuClosing(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseLeftButtonDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseLeftButtonDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseLeftButtonUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseLeftButtonUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseRightButtonDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseRightButtonDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseRightButtonUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseRightButtonUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewMouseWheel(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseWheel(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseEnter(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnMouseLeave(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnGotMouseCapture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLostMouseCapture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnQueryCursor(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusInAirMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusInAirMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusEnter(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusLeave(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusInRange(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusInRange(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusOutOfRange(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusOutOfRange(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusSystemGesture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusSystemGesture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnGotStylusCapture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLostStylusCapture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusButtonDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnStylusButtonUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusButtonDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewStylusButtonUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewKeyDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnKeyDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewKeyUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnKeyUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewGotKeyboardFocus(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnGotKeyboardFocus(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewLostKeyboardFocus(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLostKeyboardFocus(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewTextInput(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTextInput(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewQueryContinueDrag(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnQueryContinueDrag(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewGiveFeedback(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnGiveFeedback(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewDragEnter(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnDragEnter(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewDragOver(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnDragOver(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewDragLeave(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnDragLeave(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewDrop(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnDrop(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewTouchDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTouchDown(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewTouchMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTouchMove(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnPreviewTouchUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTouchUp(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnGotTouchCapture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLostTouchCapture(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTouchEnter(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnTouchLeave(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsMouseDirectlyOverChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsMouseCapturedChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsMouseCaptureWithinChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsStylusDirectlyOverChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsStylusCapturedChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsStylusCaptureWithinChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsKeyboardFocusedChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLayoutUpdated(this System.Windows.Controls.TreeView self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnGotFocus(this System.Windows.Controls.TreeView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnLostFocus(this System.Windows.Controls.TreeView self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsEnabledChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsHitTestVisibleChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnIsVisibleChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnFocusableChanged(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnManipulationStarting(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnManipulationStarted(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnManipulationDelta(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnManipulationInertiaStarting(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnManipulationBoundaryFeedback(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.TreeView OnManipulationCompleted(this System.Windows.Controls.TreeView self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}