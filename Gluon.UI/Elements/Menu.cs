
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.Menu WithIsMainMenu(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsMainMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemContainerTemplateSelector(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.ItemContainerTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemContainerTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithUsesItemContainerTemplate(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.UsesItemContainerTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemsSource(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithHasItems(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithDisplayMemberPath(this System.Windows.Controls.Menu self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemTemplate(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemTemplateSelector(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemStringFormat(this System.Windows.Controls.Menu self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemBindingGroup(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemContainerStyle(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemContainerStyleSelector(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithItemsPanel(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsGrouping(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithGroupStyleSelector(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithAlternationCount(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsTextSearchEnabled(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsTextSearchCaseSensitive(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithBorderBrush(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithBorderThickness(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithBackground(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithForeground(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFontFamily(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFontSize(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFontStretch(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFontStyle(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFontWeight(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithHorizontalContentAlignment(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithVerticalContentAlignment(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithTabIndex(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsTabStop(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithPadding(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithTemplate(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithStyle(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithOverridesDefaultStyle(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithUseLayoutRounding(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithDataContext(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithBindingGroup(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithLanguage(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithName(this System.Windows.Controls.Menu self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithTag(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithInputScope(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithActualWidth(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithActualHeight(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithLayoutTransform(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithWidth(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithMinWidth(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithMaxWidth(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithHeight(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithMinHeight(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithMaxHeight(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFlowDirection(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithMargin(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithHorizontalAlignment(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithVerticalAlignment(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFocusVisualStyle(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithCursor(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithForceCursor(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithToolTip(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithContextMenu(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsMouseDirectlyOver(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsMouseOver(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsStylusOver(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsKeyboardFocusWithin(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsMouseCaptured(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsMouseCaptureWithin(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsStylusDirectlyOver(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsStylusCaptured(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsStylusCaptureWithin(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsKeyboardFocused(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithAreAnyTouchesOver(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithAreAnyTouchesCaptured(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithAllowDrop(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithRenderTransform(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithRenderTransformOrigin(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithOpacity(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithOpacityMask(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithBitmapEffect(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithEffect(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithBitmapEffectInput(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithCacheMode(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithUid(this System.Windows.Controls.Menu self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithVisibility(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithClipToBounds(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithClip(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithSnapsToDevicePixels(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsFocused(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsEnabled(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsHitTestVisible(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsVisible(this System.Windows.Controls.Menu self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.Menu.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithFocusable(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.Menu WithIsManipulationEnabled(this System.Windows.Controls.Menu self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.Menu.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.Menu OnPreviewMouseDoubleClick(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseDoubleClick(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTargetUpdated(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnSourceUpdated(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnDataContextChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnRequestBringIntoView(this System.Windows.Controls.Menu self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnSizeChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnInitialized(this System.Windows.Controls.Menu self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLoaded(this System.Windows.Controls.Menu self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnUnloaded(this System.Windows.Controls.Menu self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnToolTipOpening(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnToolTipClosing(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnContextMenuOpening(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnContextMenuClosing(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseLeftButtonDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseLeftButtonDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseLeftButtonUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseLeftButtonUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseRightButtonDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseRightButtonDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseRightButtonUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseRightButtonUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewMouseWheel(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseWheel(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseEnter(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnMouseLeave(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnGotMouseCapture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLostMouseCapture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnQueryCursor(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusInAirMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusInAirMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusEnter(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusLeave(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusInRange(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusInRange(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusOutOfRange(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusOutOfRange(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusSystemGesture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusSystemGesture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnGotStylusCapture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLostStylusCapture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusButtonDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnStylusButtonUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusButtonDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewStylusButtonUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewKeyDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnKeyDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewKeyUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnKeyUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewGotKeyboardFocus(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnGotKeyboardFocus(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewLostKeyboardFocus(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLostKeyboardFocus(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewTextInput(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTextInput(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewQueryContinueDrag(this System.Windows.Controls.Menu self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnQueryContinueDrag(this System.Windows.Controls.Menu self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewGiveFeedback(this System.Windows.Controls.Menu self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnGiveFeedback(this System.Windows.Controls.Menu self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewDragEnter(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnDragEnter(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewDragOver(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnDragOver(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewDragLeave(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnDragLeave(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewDrop(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnDrop(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewTouchDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTouchDown(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewTouchMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTouchMove(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnPreviewTouchUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTouchUp(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnGotTouchCapture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLostTouchCapture(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTouchEnter(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnTouchLeave(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsMouseDirectlyOverChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsMouseCapturedChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsMouseCaptureWithinChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsStylusDirectlyOverChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsStylusCapturedChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsStylusCaptureWithinChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsKeyboardFocusedChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLayoutUpdated(this System.Windows.Controls.Menu self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnGotFocus(this System.Windows.Controls.Menu self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnLostFocus(this System.Windows.Controls.Menu self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsEnabledChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsHitTestVisibleChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnIsVisibleChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnFocusableChanged(this System.Windows.Controls.Menu self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnManipulationStarting(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnManipulationStarted(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnManipulationDelta(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnManipulationInertiaStarting(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnManipulationBoundaryFeedback(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.Menu OnManipulationCompleted(this System.Windows.Controls.Menu self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}