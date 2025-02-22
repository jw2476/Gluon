
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.CheckBox WithIsChecked(this System.Windows.Controls.CheckBox self, out ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        var metadata = System.Windows.Controls.CheckBox.IsCheckedProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.ToggleButton))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Nullable<System.Boolean>)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.CheckBox.IsCheckedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsChecked(this System.Windows.Controls.CheckBox self, out ReadWriteBinding<System.Nullable<System.Boolean>> value, System.Nullable<System.Boolean> initialValue)
    {
        value = new(initialValue);
        self.SetBinding(System.Windows.Controls.CheckBox.IsCheckedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsThreeState(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.IsThreeStateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithCommand(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Input.ICommand> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.CommandProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithCommandParameter(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.CommandParameterProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithCommandTarget(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.IInputElement> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.CommandTargetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsPressed(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsPressedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithClickMode(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Controls.ClickMode> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ClickModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithContent(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithHasContent(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.HasContentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithContentTemplate(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ContentTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithContentTemplateSelector(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ContentTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithContentStringFormat(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ContentStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithBorderBrush(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithBorderThickness(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithBackground(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithForeground(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFontFamily(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFontSize(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFontStretch(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFontStyle(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFontWeight(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithHorizontalContentAlignment(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithVerticalContentAlignment(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithTabIndex(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Int32> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsTabStop(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithPadding(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithTemplate(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithStyle(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithOverridesDefaultStyle(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithUseLayoutRounding(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithDataContext(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithBindingGroup(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithLanguage(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithName(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithTag(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithInputScope(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithActualWidth(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithActualHeight(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithLayoutTransform(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithWidth(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithMinWidth(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithMaxWidth(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithHeight(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithMinHeight(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithMaxHeight(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFlowDirection(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithMargin(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithHorizontalAlignment(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithVerticalAlignment(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFocusVisualStyle(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Style> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithCursor(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithForceCursor(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithToolTip(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Object> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithContextMenu(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsMouseDirectlyOver(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsMouseOver(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsStylusOver(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsKeyboardFocusWithin(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsMouseCaptured(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsMouseCaptureWithin(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsStylusDirectlyOver(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsStylusCaptured(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsStylusCaptureWithin(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsKeyboardFocused(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithAreAnyTouchesOver(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithAreAnyTouchesCaptured(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithAllowDrop(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithRenderTransform(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithRenderTransformOrigin(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Point> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithOpacity(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Double> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithOpacityMask(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithBitmapEffect(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithEffect(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithBitmapEffectInput(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithCacheMode(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithUid(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.String> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithVisibility(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithClipToBounds(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithClip(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithSnapsToDevicePixels(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsFocused(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsEnabled(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsHitTestVisible(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsVisible(this System.Windows.Controls.CheckBox self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.CheckBox.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithFocusable(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.CheckBox WithIsManipulationEnabled(this System.Windows.Controls.CheckBox self, ReadWriteBinding<System.Boolean> value)
    {
        self.SetBinding(System.Windows.Controls.CheckBox.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.CheckBox OnChecked(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Checked += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnUnchecked(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unchecked += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIndeterminate(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Indeterminate += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnClick(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Click += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseDoubleClick(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseDoubleClick(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTargetUpdated(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnSourceUpdated(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnDataContextChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnRequestBringIntoView(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnSizeChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnInitialized(this System.Windows.Controls.CheckBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLoaded(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnUnloaded(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnToolTipOpening(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnToolTipClosing(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnContextMenuOpening(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnContextMenuClosing(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseLeftButtonDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseLeftButtonDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseLeftButtonUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseLeftButtonUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseRightButtonDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseRightButtonDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseRightButtonUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseRightButtonUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewMouseWheel(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseWheel(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseEnter(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnMouseLeave(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnGotMouseCapture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLostMouseCapture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnQueryCursor(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusInAirMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusInAirMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusEnter(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusLeave(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusInRange(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusInRange(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusOutOfRange(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusOutOfRange(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusSystemGesture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusSystemGesture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnGotStylusCapture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLostStylusCapture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusButtonDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnStylusButtonUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusButtonDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewStylusButtonUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewKeyDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnKeyDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewKeyUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnKeyUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewGotKeyboardFocus(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnGotKeyboardFocus(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewLostKeyboardFocus(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLostKeyboardFocus(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewTextInput(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTextInput(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewQueryContinueDrag(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnQueryContinueDrag(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewGiveFeedback(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnGiveFeedback(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewDragEnter(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnDragEnter(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewDragOver(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnDragOver(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewDragLeave(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnDragLeave(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewDrop(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnDrop(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewTouchDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTouchDown(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewTouchMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTouchMove(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnPreviewTouchUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTouchUp(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnGotTouchCapture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLostTouchCapture(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTouchEnter(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnTouchLeave(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsMouseDirectlyOverChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsMouseCapturedChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsMouseCaptureWithinChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsStylusDirectlyOverChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsStylusCapturedChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsStylusCaptureWithinChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsKeyboardFocusedChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLayoutUpdated(this System.Windows.Controls.CheckBox self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnGotFocus(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnLostFocus(this System.Windows.Controls.CheckBox self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsEnabledChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsHitTestVisibleChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnIsVisibleChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnFocusableChanged(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnManipulationStarting(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnManipulationStarted(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnManipulationDelta(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnManipulationInertiaStarting(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnManipulationBoundaryFeedback(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.CheckBox OnManipulationCompleted(this System.Windows.Controls.CheckBox self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}