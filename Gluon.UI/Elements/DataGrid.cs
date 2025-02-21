
using Gluon.Core;
using System.Reactive.Subjects;

namespace Gluon.UI;

public static partial class UI
{
    public static System.Windows.Controls.DataGrid WithCanUserResizeColumns(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CanUserResizeColumnsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithColumnWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridLength> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ColumnWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMinColumnWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MinColumnWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMaxColumnWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MaxColumnWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithGridLinesVisibility(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridGridLinesVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.GridLinesVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHorizontalGridLinesBrush(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.HorizontalGridLinesBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithVerticalGridLinesBrush(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.VerticalGridLinesBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowValidationErrorTemplate(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowStyleSelector(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowBackground(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowBackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAlternatingRowBackground(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowHeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMinRowHeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MinRowHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowHeaderWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowHeaderWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowHeaderActualWidth(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.RowHeaderActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithColumnHeaderHeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ColumnHeaderHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHeadersVisibility(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridHeadersVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.HeadersVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCellStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CellStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithColumnHeaderStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ColumnHeaderStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowHeaderStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowHeaderStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowHeaderTemplate(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowHeaderTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowHeaderTemplateSelector(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHorizontalScrollBarVisibility(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.HorizontalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithVerticalScrollBarVisibility(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.ScrollBarVisibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.VerticalScrollBarVisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsReadOnly(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsReadOnlyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCurrentItem(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CurrentItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCurrentColumn(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridColumn> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CurrentColumnProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCurrentCell(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridCellInfo> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CurrentCellProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCanUserAddRows(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CanUserAddRowsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCanUserDeleteRows(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CanUserDeleteRowsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowDetailsVisibilityMode(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridRowDetailsVisibilityMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAreRowDetailsFrozen(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.AreRowDetailsFrozenProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowDetailsTemplate(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowDetailsTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRowDetailsTemplateSelector(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCanUserResizeRows(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CanUserResizeRowsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithNewItemMargin(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Windows.Thickness> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.NewItemMarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSelectionMode(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridSelectionMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.SelectionModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSelectionUnit(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridSelectionUnit> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.SelectionUnitProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCanUserSortColumns(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CanUserSortColumnsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAutoGenerateColumns(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.AutoGenerateColumnsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFrozenColumnCount(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FrozenColumnCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithNonFrozenColumnsViewportHorizontalOffset(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.NonFrozenColumnsViewportHorizontalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithEnableRowVirtualization(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.EnableRowVirtualizationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithEnableColumnVirtualization(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCanUserReorderColumns(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CanUserReorderColumnsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithDragIndicatorStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.DragIndicatorStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithDropLocationIndicatorStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.DropLocationIndicatorStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithClipboardCopyMode(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataGridClipboardCopyMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ClipboardCopyModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCellsPanelHorizontalOffset(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsSynchronizedWithCurrentItem(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Nullable<System.Boolean>> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsSynchronizedWithCurrentItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSelectedIndex(this System.Windows.Controls.DataGrid self, out ReadWriteBinding<System.Int32> value)
    {
        
        var metadata = System.Windows.Controls.DataGrid.SelectedIndexProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Int32)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.DataGrid.SelectedIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSelectedItem(this System.Windows.Controls.DataGrid self, out ReadWriteBinding<System.Object> value)
    {
        
        var metadata = System.Windows.Controls.DataGrid.SelectedItemProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.DataGrid.SelectedItemProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSelectedValue(this System.Windows.Controls.DataGrid self, out ReadWriteBinding<System.Object> value)
    {
        
        var metadata = System.Windows.Controls.DataGrid.SelectedValueProperty.GetMetadata(typeof(System.Windows.Controls.Primitives.Selector))
            ?? throw new ArgumentException("Can't get metadata.");
        value = new((System.Object)metadata.DefaultValue);
        self.SetBinding(System.Windows.Controls.DataGrid.SelectedValueProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSelectedValuePath(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.SelectedValuePathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemsSource(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Collections.IEnumerable> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemsSourceProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHasItems(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.HasItemsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithDisplayMemberPath(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.DisplayMemberPathProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemTemplate(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.DataTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemTemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemTemplateSelector(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.DataTemplateSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemTemplateSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemStringFormat(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemStringFormatProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemBindingGroup(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemBindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemContainerStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemContainerStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemContainerStyleSelector(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.StyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemContainerStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithItemsPanel(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.ItemsPanelTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ItemsPanelProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsGrouping(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsGroupingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithGroupStyleSelector(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.GroupStyleSelector> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.GroupStyleSelectorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAlternationCount(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.AlternationCountProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsTextSearchEnabled(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsTextSearchEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsTextSearchCaseSensitive(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsTextSearchCaseSensitiveProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithBorderBrush(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.BorderBrushProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithBorderThickness(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.BorderThicknessProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithBackground(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.BackgroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithForeground(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ForegroundProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFontFamily(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.FontFamily> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FontFamilyProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFontSize(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FontSizeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFontStretch(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.FontStretch> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FontStretchProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFontStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.FontStyle> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FontStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFontWeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.FontWeight> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FontWeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHorizontalContentAlignment(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.HorizontalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithVerticalContentAlignment(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.VerticalContentAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithTabIndex(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Int32> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.TabIndexProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsTabStop(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsTabStopProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithPadding(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.PaddingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithTemplate(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.ControlTemplate> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.TemplateProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.StyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithOverridesDefaultStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.OverridesDefaultStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithUseLayoutRounding(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.UseLayoutRoundingProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithDataContext(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.DataContextProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithBindingGroup(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Data.BindingGroup> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.BindingGroupProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithLanguage(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Markup.XmlLanguage> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.LanguageProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithName(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.NameProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithTag(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.TagProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithInputScope(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Input.InputScope> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.InputScopeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithActualWidth(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.ActualWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithActualHeight(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Double> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.ActualHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithLayoutTransform(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.LayoutTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.WidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMinWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MinWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMaxWidth(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MaxWidthProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.HeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMinHeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MinHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMaxHeight(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MaxHeightProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFlowDirection(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.FlowDirection> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FlowDirectionProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithMargin(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Thickness> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.MarginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithHorizontalAlignment(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.HorizontalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.HorizontalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithVerticalAlignment(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.VerticalAlignment> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.VerticalAlignmentProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFocusVisualStyle(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Style> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FocusVisualStyleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCursor(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Input.Cursor> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithForceCursor(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ForceCursorProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithToolTip(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Object> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ToolTipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithContextMenu(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Controls.ContextMenu> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ContextMenuProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsMouseDirectlyOver(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsMouseDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsMouseOver(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsMouseOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsStylusOver(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsStylusOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsKeyboardFocusWithin(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsKeyboardFocusWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsMouseCaptured(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsMouseCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsMouseCaptureWithin(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsMouseCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsStylusDirectlyOver(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsStylusDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsStylusCaptured(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsStylusCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsStylusCaptureWithin(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsStylusCaptureWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsKeyboardFocused(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsKeyboardFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAreAnyTouchesDirectlyOver(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.AreAnyTouchesDirectlyOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAreAnyTouchesOver(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.AreAnyTouchesOverProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAreAnyTouchesCaptured(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.AreAnyTouchesCapturedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAreAnyTouchesCapturedWithin(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.AreAnyTouchesCapturedWithinProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithAllowDrop(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.AllowDropProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRenderTransform(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Transform> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RenderTransformProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithRenderTransformOrigin(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Point> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.RenderTransformOriginProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithOpacity(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Double> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.OpacityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithOpacityMask(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Brush> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.OpacityMaskProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithBitmapEffect(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffect> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.BitmapEffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithEffect(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Effects.Effect> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.EffectProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithBitmapEffectInput(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Effects.BitmapEffectInput> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.BitmapEffectInputProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithCacheMode(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.CacheMode> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.CacheModeProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithUid(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.String> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.UidProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithVisibility(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Visibility> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.VisibilityProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithClipToBounds(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ClipToBoundsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithClip(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Windows.Media.Geometry> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.ClipProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithSnapsToDevicePixels(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.SnapsToDevicePixelsProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsFocused(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsFocusedProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsEnabled(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsEnabledProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsHitTestVisible(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsHitTestVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsVisible(this System.Windows.Controls.DataGrid self, out ReadOnlyBinding<System.Boolean> value)
    {
        value = new();
        self.SetBinding(System.Windows.Controls.DataGrid.IsVisibleProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithFocusable(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.FocusableProperty, value);
        return self;
    }
    
    public static System.Windows.Controls.DataGrid WithIsManipulationEnabled(this System.Windows.Controls.DataGrid self, ReadWriteBinding<System.Boolean> value)
    {
        
        self.SetBinding(System.Windows.Controls.DataGrid.IsManipulationEnabledProperty, value);
        return self;
    }

    public static System.Windows.Controls.DataGrid OnColumnDisplayIndexChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridColumnEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridColumnEventArgs>();
        self.ColumnDisplayIndexChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLoadingRow(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowEventArgs>();
        self.LoadingRow += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnUnloadingRow(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowEventArgs>();
        self.UnloadingRow += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnRowEditEnding(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowEditEndingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowEditEndingEventArgs>();
        self.RowEditEnding += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnCellEditEnding(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridCellEditEndingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridCellEditEndingEventArgs>();
        self.CellEditEnding += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnCurrentCellChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.CurrentCellChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnBeginningEdit(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridBeginningEditEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridBeginningEditEventArgs>();
        self.BeginningEdit += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreparingCellForEdit(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>();
        self.PreparingCellForEdit += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnAddingNewItem(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.AddingNewItemEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.AddingNewItemEventArgs>();
        self.AddingNewItem += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnInitializingNewItem(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.InitializingNewItemEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.InitializingNewItemEventArgs>();
        self.InitializingNewItem += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLoadingRowDetails(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowDetailsEventArgs>();
        self.LoadingRowDetails += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnUnloadingRowDetails(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowDetailsEventArgs>();
        self.UnloadingRowDetails += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnRowDetailsVisibilityChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowDetailsEventArgs>();
        self.RowDetailsVisibilityChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnSelectedCellsChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.SelectedCellsChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.SelectedCellsChangedEventArgs>();
        self.SelectedCellsChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnSorting(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridSortingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridSortingEventArgs>();
        self.Sorting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnAutoGeneratedColumns(this System.Windows.Controls.DataGrid self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.AutoGeneratedColumns += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnAutoGeneratingColumn(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>();
        self.AutoGeneratingColumn += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnColumnReordering(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridColumnReorderingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridColumnReorderingEventArgs>();
        self.ColumnReordering += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnColumnHeaderDragStarted(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.Primitives.DragStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.Primitives.DragStartedEventArgs>();
        self.ColumnHeaderDragStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnColumnHeaderDragDelta(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.Primitives.DragDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.Primitives.DragDeltaEventArgs>();
        self.ColumnHeaderDragDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnColumnHeaderDragCompleted(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.Primitives.DragCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.Primitives.DragCompletedEventArgs>();
        self.ColumnHeaderDragCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnColumnReordered(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridColumnEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridColumnEventArgs>();
        self.ColumnReordered += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnCopyingRowClipboardContent(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.DataGridRowClipboardEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.DataGridRowClipboardEventArgs>();
        self.CopyingRowClipboardContent += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnSelectionChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.SelectionChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.SelectionChangedEventArgs>();
        self.SelectionChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseDoubleClick(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseDoubleClick(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDoubleClick += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTargetUpdated(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.TargetUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnSourceUpdated(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Data.DataTransferEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Data.DataTransferEventArgs>();
        self.SourceUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnDataContextChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.DataContextChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnRequestBringIntoView(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.RequestBringIntoViewEventArgs> handler)
    {
        var subject = new Subject<System.Windows.RequestBringIntoViewEventArgs>();
        self.RequestBringIntoView += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnSizeChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.SizeChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.SizeChangedEventArgs>();
        self.SizeChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnInitialized(this System.Windows.Controls.DataGrid self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.Initialized += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLoaded(this System.Windows.Controls.DataGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Loaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnUnloaded(this System.Windows.Controls.DataGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.Unloaded += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnToolTipOpening(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnToolTipClosing(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.ToolTipEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ToolTipEventArgs>();
        self.ToolTipClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnContextMenuOpening(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuOpening += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnContextMenuClosing(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Controls.ContextMenuEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Controls.ContextMenuEventArgs>();
        self.ContextMenuClosing += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseLeftButtonDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseLeftButtonDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseLeftButtonUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseLeftButtonUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseLeftButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseRightButtonDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseRightButtonDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseRightButtonUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.PreviewMouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseRightButtonUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseButtonEventArgs>();
        self.MouseRightButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.PreviewMouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewMouseWheel(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.PreviewMouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseWheel(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseWheelEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseWheelEventArgs>();
        self.MouseWheel += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseEnter(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnMouseLeave(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.MouseLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnGotMouseCapture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.GotMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLostMouseCapture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.MouseEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.MouseEventArgs>();
        self.LostMouseCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnQueryCursor(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.QueryCursorEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.QueryCursorEventArgs>();
        self.QueryCursor += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.PreviewStylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusDownEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusDownEventArgs>();
        self.StylusDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusInAirMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusInAirMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInAirMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusEnter(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusLeave(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusInRange(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusInRange(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusInRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusOutOfRange(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.PreviewStylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusOutOfRange(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.StylusOutOfRange += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusSystemGesture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.PreviewStylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusSystemGesture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusSystemGestureEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusSystemGestureEventArgs>();
        self.StylusSystemGesture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnGotStylusCapture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.GotStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLostStylusCapture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusEventArgs>();
        self.LostStylusCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusButtonDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnStylusButtonUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.StylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusButtonDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewStylusButtonUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.StylusButtonEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.StylusButtonEventArgs>();
        self.PreviewStylusButtonUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewKeyDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnKeyDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewKeyUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.PreviewKeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnKeyUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyEventArgs>();
        self.KeyUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewGotKeyboardFocus(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewGotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnGotKeyboardFocus(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.GotKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewLostKeyboardFocus(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.PreviewLostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLostKeyboardFocus(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.KeyboardFocusChangedEventArgs>();
        self.LostKeyboardFocus += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewTextInput(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.PreviewTextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTextInput(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TextCompositionEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TextCompositionEventArgs>();
        self.TextInput += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewQueryContinueDrag(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.PreviewQueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnQueryContinueDrag(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.QueryContinueDragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.QueryContinueDragEventArgs>();
        self.QueryContinueDrag += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewGiveFeedback(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.PreviewGiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnGiveFeedback(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.GiveFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.GiveFeedbackEventArgs>();
        self.GiveFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewDragEnter(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnDragEnter(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewDragOver(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnDragOver(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragOver += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewDragLeave(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnDragLeave(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.DragLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewDrop(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.PreviewDrop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnDrop(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DragEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DragEventArgs>();
        self.Drop += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewTouchDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTouchDown(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchDown += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewTouchMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTouchMove(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchMove += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnPreviewTouchUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.PreviewTouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTouchUp(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchUp += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnGotTouchCapture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.GotTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLostTouchCapture(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.LostTouchCapture += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTouchEnter(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchEnter += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnTouchLeave(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.TouchEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.TouchEventArgs>();
        self.TouchLeave += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsMouseDirectlyOverChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsKeyboardFocusWithinChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsMouseCapturedChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsMouseCaptureWithinChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsMouseCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsStylusDirectlyOverChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusDirectlyOverChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsStylusCapturedChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCapturedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsStylusCaptureWithinChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsStylusCaptureWithinChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsKeyboardFocusedChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsKeyboardFocusedChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLayoutUpdated(this System.Windows.Controls.DataGrid self, out IObservable<System.EventArgs> handler)
    {
        var subject = new Subject<System.EventArgs>();
        self.LayoutUpdated += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnGotFocus(this System.Windows.Controls.DataGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.GotFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnLostFocus(this System.Windows.Controls.DataGrid self, out IObservable<Gluon.Core.Unit> handler)
    {
        var subject = new Subject<Gluon.Core.Unit>();
        self.LostFocus += (_, _) => subject.OnNext(new());
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsEnabledChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsEnabledChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsHitTestVisibleChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsHitTestVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnIsVisibleChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.IsVisibleChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnFocusableChanged(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.DependencyPropertyChangedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.DependencyPropertyChangedEventArgs>();
        self.FocusableChanged += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnManipulationStarting(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.ManipulationStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartingEventArgs>();
        self.ManipulationStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnManipulationStarted(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.ManipulationStartedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationStartedEventArgs>();
        self.ManipulationStarted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnManipulationDelta(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.ManipulationDeltaEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationDeltaEventArgs>();
        self.ManipulationDelta += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnManipulationInertiaStarting(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationInertiaStartingEventArgs>();
        self.ManipulationInertiaStarting += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnManipulationBoundaryFeedback(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>();
        self.ManipulationBoundaryFeedback += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
    
    public static System.Windows.Controls.DataGrid OnManipulationCompleted(this System.Windows.Controls.DataGrid self, out IObservable<System.Windows.Input.ManipulationCompletedEventArgs> handler)
    {
        var subject = new Subject<System.Windows.Input.ManipulationCompletedEventArgs>();
        self.ManipulationCompleted += (_, e) => subject.OnNext(e);
        handler = subject;
    
        return self;
    }
}