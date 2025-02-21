
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.PasswordBox WithPasswordChar(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Char> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.PasswordCharProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithMaxLength(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.MaxLengthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithSelectionBrush(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.SelectionBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithSelectionTextBrush(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.SelectionTextBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithSelectionOpacity(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.SelectionOpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithCaretBrush(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.CaretBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsSelectionActive(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsSelectionActiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsInactiveSelectionHighlightEnabled(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.IsInactiveSelectionHighlightEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithBorderBrush(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithBorderThickness(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithBackground(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithForeground(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFontFamily(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFontSize(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFontStretch(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFontStyle(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFontWeight(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithHorizontalContentAlignment(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithVerticalContentAlignment(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithTabIndex(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsTabStop(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithPadding(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithTemplate(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithStyle(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithOverridesDefaultStyle(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithUseLayoutRounding(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithDataContext(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithBindingGroup(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithLanguage(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithName(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithTag(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithInputScope(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithActualWidth(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithActualHeight(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithLayoutTransform(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithWidth(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithMinWidth(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithMaxWidth(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithHeight(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithMinHeight(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithMaxHeight(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFlowDirection(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithMargin(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithHorizontalAlignment(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithVerticalAlignment(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFocusVisualStyle(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithCursor(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithForceCursor(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithToolTip(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithContextMenu(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsMouseDirectlyOver(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsMouseOver(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsStylusOver(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsKeyboardFocusWithin(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsMouseCaptured(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsMouseCaptureWithin(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsStylusDirectlyOver(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsStylusCaptured(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsStylusCaptureWithin(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsKeyboardFocused(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithAreAnyTouchesOver(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithAreAnyTouchesCaptured(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithAllowDrop(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithRenderTransform(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithRenderTransformOrigin(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithOpacity(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithOpacityMask(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithBitmapEffect(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithEffect(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithBitmapEffectInput(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithCacheMode(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithUid(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithVisibility(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithClipToBounds(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithClip(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithSnapsToDevicePixels(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsFocused(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsEnabled(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsHitTestVisible(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsVisible(this System.Windows.Controls.PasswordBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.PasswordBox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithFocusable(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox WithIsManipulationEnabled(this System.Windows.Controls.PasswordBox self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.PasswordBox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.PasswordBox OnPasswordChanged(this System.Windows.Controls.PasswordBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.PasswordChanged += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseDoubleClick(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseDoubleClick(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTargetUpdated(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnSourceUpdated(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnDataContextChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnRequestBringIntoView(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnSizeChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnInitialized(this System.Windows.Controls.PasswordBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLoaded(this System.Windows.Controls.PasswordBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnUnloaded(this System.Windows.Controls.PasswordBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnToolTipOpening(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnToolTipClosing(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnContextMenuOpening(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnContextMenuClosing(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseLeftButtonDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseLeftButtonUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseRightButtonDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseRightButtonDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseRightButtonUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseRightButtonUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewMouseWheel(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseWheel(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseEnter(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnMouseLeave(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnGotMouseCapture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLostMouseCapture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnQueryCursor(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusInAirMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusInAirMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusEnter(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusLeave(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusInRange(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusInRange(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusOutOfRange(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusOutOfRange(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusSystemGesture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusSystemGesture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnGotStylusCapture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLostStylusCapture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusButtonDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnStylusButtonUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusButtonDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewStylusButtonUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewKeyDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnKeyDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewKeyUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnKeyUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewGotKeyboardFocus(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnGotKeyboardFocus(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewLostKeyboardFocus(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLostKeyboardFocus(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewTextInput(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTextInput(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewQueryContinueDrag(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnQueryContinueDrag(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewGiveFeedback(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnGiveFeedback(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewDragEnter(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnDragEnter(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewDragOver(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnDragOver(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewDragLeave(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnDragLeave(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewDrop(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnDrop(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewTouchDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTouchDown(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewTouchMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTouchMove(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnPreviewTouchUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTouchUp(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnGotTouchCapture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLostTouchCapture(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTouchEnter(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnTouchLeave(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsMouseCapturedChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsStylusCapturedChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsKeyboardFocusedChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLayoutUpdated(this System.Windows.Controls.PasswordBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnGotFocus(this System.Windows.Controls.PasswordBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnLostFocus(this System.Windows.Controls.PasswordBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsEnabledChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsHitTestVisibleChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnIsVisibleChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnFocusableChanged(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnManipulationStarting(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnManipulationStarted(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnManipulationDelta(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnManipulationInertiaStarting(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnManipulationBoundaryFeedback(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.PasswordBox OnManipulationCompleted(this System.Windows.Controls.PasswordBox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}