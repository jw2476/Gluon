
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.RadioButton WithGroupName(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.GroupNameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsChecked(this System.Windows.Controls.RadioButton self, out ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        
        var metadata = System.Windows.Controls.RadioButton.IsCheckedProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.ToggleButton))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Nullable<System.Boolean>)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.RadioButton.IsCheckedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsThreeState(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.IsThreeStateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithCommand(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Input.ICommand> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.CommandProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithCommandParameter(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.CommandParameterProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithCommandTarget(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.IInputElement> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.CommandTargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsPressed(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsPressedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithClickMode(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Controls.ClickMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ClickModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithContent(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithHasContent(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithContentTemplate(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithContentTemplateSelector(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithContentStringFormat(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithBorderBrush(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithBorderThickness(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithBackground(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithForeground(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFontFamily(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFontSize(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFontStretch(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFontStyle(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFontWeight(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithHorizontalContentAlignment(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithVerticalContentAlignment(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithTabIndex(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsTabStop(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithPadding(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithTemplate(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithStyle(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithOverridesDefaultStyle(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithUseLayoutRounding(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithDataContext(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithBindingGroup(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithLanguage(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithName(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithTag(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithInputScope(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithActualWidth(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithActualHeight(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithLayoutTransform(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithWidth(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithMinWidth(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithMaxWidth(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithHeight(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithMinHeight(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithMaxHeight(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFlowDirection(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithMargin(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithHorizontalAlignment(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithVerticalAlignment(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFocusVisualStyle(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithCursor(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithForceCursor(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithToolTip(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithContextMenu(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsMouseDirectlyOver(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsMouseOver(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsStylusOver(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsKeyboardFocusWithin(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsMouseCaptured(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsMouseCaptureWithin(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsStylusDirectlyOver(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsStylusCaptured(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsStylusCaptureWithin(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsKeyboardFocused(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithAreAnyTouchesOver(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithAreAnyTouchesCaptured(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithAllowDrop(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithRenderTransform(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithRenderTransformOrigin(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithOpacity(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithOpacityMask(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithBitmapEffect(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithEffect(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithBitmapEffectInput(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithCacheMode(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithUid(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithVisibility(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithClipToBounds(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithClip(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithSnapsToDevicePixels(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsFocused(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsEnabled(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsHitTestVisible(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsVisible(this System.Windows.Controls.RadioButton self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.RadioButton.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithFocusable(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.RadioButton WithIsManipulationEnabled(this System.Windows.Controls.RadioButton self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.RadioButton.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.RadioButton OnChecked(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Checked += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnUnchecked(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unchecked += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIndeterminate(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Indeterminate += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnClick(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Click += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseDoubleClick(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseDoubleClick(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTargetUpdated(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnSourceUpdated(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnDataContextChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnRequestBringIntoView(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnSizeChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnInitialized(this System.Windows.Controls.RadioButton self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLoaded(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnUnloaded(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnToolTipOpening(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnToolTipClosing(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnContextMenuOpening(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnContextMenuClosing(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseLeftButtonDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseLeftButtonDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseLeftButtonUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseLeftButtonUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseRightButtonDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseRightButtonDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseRightButtonUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseRightButtonUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewMouseWheel(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseWheel(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseEnter(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnMouseLeave(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnGotMouseCapture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLostMouseCapture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnQueryCursor(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusInAirMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusInAirMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusEnter(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusLeave(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusInRange(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusInRange(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusOutOfRange(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusOutOfRange(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusSystemGesture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusSystemGesture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnGotStylusCapture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLostStylusCapture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusButtonDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnStylusButtonUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusButtonDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewStylusButtonUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewKeyDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnKeyDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewKeyUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnKeyUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewGotKeyboardFocus(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnGotKeyboardFocus(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewLostKeyboardFocus(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLostKeyboardFocus(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewTextInput(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTextInput(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewQueryContinueDrag(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnQueryContinueDrag(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewGiveFeedback(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnGiveFeedback(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewDragEnter(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnDragEnter(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewDragOver(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnDragOver(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewDragLeave(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnDragLeave(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewDrop(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnDrop(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewTouchDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTouchDown(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewTouchMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTouchMove(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnPreviewTouchUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTouchUp(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnGotTouchCapture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLostTouchCapture(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTouchEnter(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnTouchLeave(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsMouseDirectlyOverChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsMouseCapturedChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsMouseCaptureWithinChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsStylusDirectlyOverChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsStylusCapturedChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsStylusCaptureWithinChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsKeyboardFocusedChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLayoutUpdated(this System.Windows.Controls.RadioButton self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnGotFocus(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnLostFocus(this System.Windows.Controls.RadioButton self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsEnabledChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsHitTestVisibleChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnIsVisibleChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnFocusableChanged(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnManipulationStarting(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnManipulationStarted(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnManipulationDelta(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnManipulationInertiaStarting(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnManipulationBoundaryFeedback(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.RadioButton OnManipulationCompleted(this System.Windows.Controls.RadioButton self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}