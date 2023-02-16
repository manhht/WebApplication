using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web;
using System.Web.UI.WebControls;
using DevExpress.Web.Mvc;
using DevExpress.Web.Mvc.UI;
using System.Web.Mvc;
using DevExpress.Utils;

namespace WebApplication.Code
{
    public static class LayoutHelper
    {
        public static string[] theme_name
        {
            get
            {
                return new string[] {
                    "Default",
        "DevEx",
        "Metropolis",
        "MetropolisBlue",
        "Material",
        "MaterialCompact",
        "Office365",
        "Aqua",
        "Glass",
        "Mulberry",
        "PlasticBlue",
        "Office2010",
        "Office2010Blue",
                };
            }
        }

        public static string[] CustomBaseColors
        {
            get
            {
                return new string[] {
                    "#4796CE",
                    "#35B86B",
                    "#CE5B47",
                    "#9F47CE",
                    "#5C57C9",
                    "#CE4776",
                };
            }
        }

        public static void PageToolbarSetting(MenuSettings menuSettings, string name_menu)
        {
            menuSettings.Name = name_menu;

            menuSettings.ItemAutoWidth = false;
            menuSettings.AllowSelectItem = false;
            menuSettings.ApplyItemStyleToTemplates = true;

            menuSettings.SettingsAdaptivity.Enabled = true;
            menuSettings.SettingsAdaptivity.EnableAutoHideRootItems = true;
            menuSettings.SettingsAdaptivity.EnableCollapseRootItemsToIcons = true;
            menuSettings.SettingsAdaptivity.CollapseRootItemsToIconsAtWindowInnerWidth = 600;

            menuSettings.Width = Unit.Percentage(100);
            menuSettings.ControlStyle.SeparatorWidth = Unit.Pixel(0);
            menuSettings.ControlStyle.CssClass = "page-toolbar";

            menuSettings.Styles.Item.CssClass = "item";
            menuSettings.Styles.Item.VerticalAlign = VerticalAlign.Middle;

            menuSettings.Images.Item.Width = Unit.Pixel(16);
            menuSettings.Images.Item.Height = Unit.Pixel(16);
            menuSettings.ClientSideEvents.ItemClick = "onPageToolbarItemClick";
        }

        public static void panelsearch(PanelSettings panelSettings)
        {
            panelSettings.Name = "filterPanel";
            panelSettings.Collapsible = true;
            panelSettings.ControlStyle.CssClass = "filter-panel";

            panelSettings.SettingsCollapsing.ExpandEffect = PanelExpandEffect.Slide;
            panelSettings.SettingsCollapsing.AnimationType = AnimationType.None;
            panelSettings.SettingsCollapsing.ExpandButton.Visible = false;
            panelSettings.ClientSideEvents.Expanded = "onFilterPanelExpanded";
            panelSettings.ClientSideEvents.Collapsed = "adjustPageControls";
        }
    }

    public static class GridViewSettingHelper
    {
        public static void SettingGridView(GridViewSettings gridViewSettings)
        {
            gridViewSettings.EnablePagingGestures = AutoBoolean.False;

            gridViewSettings.ControlStyle.CssClass = "grid-view";
            gridViewSettings.Width = Unit.Percentage(100);
            gridViewSettings.SettingsLoadingPanel.Mode = GridViewLoadingPanelMode.Default;

            gridViewSettings.Styles.Cell.Wrap = DefaultBoolean.False;
            gridViewSettings.Styles.PagerBottomPanel.CssClass = "pager";
            gridViewSettings.Styles.FocusedRow.CssClass = "focused";
            gridViewSettings.SettingsFilterControl.ViewMode = FilterControlViewMode.VisualAndText;
            gridViewSettings.Settings.AutoFilterCondition = AutoFilterCondition.Contains;
            gridViewSettings.SettingsBehavior.AllowFocusedRow = true;
            gridViewSettings.SettingsBehavior.AllowSelectByRowClick = true;
            gridViewSettings.SettingsBehavior.AllowEllipsisInText = false;
            gridViewSettings.Settings.ShowGroupPanel = true;
            gridViewSettings.SettingsBehavior.AllowDragDrop = true;
            gridViewSettings.SettingsSearchPanel.CustomEditorName = "searchButtonEdit";
            gridViewSettings.SettingsSearchPanel.CustomEditorName = "searchButtonEdit";
            gridViewSettings.Settings.VerticalScrollBarMode = ScrollBarMode.Hidden;
            gridViewSettings.Settings.ShowHeaderFilterButton = true;
            gridViewSettings.Settings.GridLines = GridLines.Both;
            gridViewSettings.SettingsPager.PageSize = 50;
            gridViewSettings.SettingsPager.PageSizeItemSettings.ShowAllItem = true;
            gridViewSettings.SettingsPager.PageSizeItemSettings.Items = new string[] { "5", "10", "20", "50", "100", "200", "500", "1000" };
            gridViewSettings.SettingsPager.Position = PagerPosition.TopAndBottom;
            gridViewSettings.SettingsPager.PageSizeItemSettings.ShowAllItem = true;
            gridViewSettings.SettingsPager.EnableAdaptivity = true;
            gridViewSettings.SettingsPager.PageSizeItemSettings.Visible = true;
            gridViewSettings.SettingsPager.PageSizeItemSettings.AllItemText = "Tất cả";
            gridViewSettings.SettingsPager.Summary.Text = "Đang xem {0} đến {1} trong tổng số {2} mục";
            gridViewSettings.SettingsPager.FirstPageButton.Visible = true;
            gridViewSettings.SettingsPager.LastPageButton.Visible = true;
            gridViewSettings.SettingsPager.PrevPageButton.Visible = true;
            gridViewSettings.SettingsPager.NextPageButton.Visible = true;
            gridViewSettings.SettingsExport.EnableClientSideExportAPI = true;
            gridViewSettings.SettingsExport.ExportSelectedRowsOnly = false;

            gridViewSettings.SettingsText.HeaderFilterShowBlanks = "(Rỗng)";
            gridViewSettings.SettingsText.HeaderFilterShowNonBlanks = "(Khác Rỗng)";
            gridViewSettings.SettingsText.HeaderFilterSelectAll = "(Chọn tất cả)";
            gridViewSettings.SettingsText.HeaderFilterShowAll = "(Tất cả)";
            gridViewSettings.SettingsText.HeaderFilterShowAll = "(Tất cả)";
            gridViewSettings.SettingsText.HeaderFilterCancelButton = "Hủy";
            gridViewSettings.SettingsText.HeaderFilterHeaderCaption = "Lọc dữ liệu";
            gridViewSettings.SettingsText.HeaderFilterFrom = "Lọc từ";
            gridViewSettings.SettingsText.HeaderFilterNextMonth = "Tháng sau";
            gridViewSettings.SettingsText.HeaderFilterThisMonth = "Tháng này";
            gridViewSettings.SettingsText.HeaderFilterThisWeek = "Tuần này";
            gridViewSettings.SettingsText.HeaderFilterThisYear = "Năm này";
            gridViewSettings.SettingsText.HeaderFilterTo = "Đến";
            gridViewSettings.SettingsText.HeaderFilterToday = "Hôm nay";
            gridViewSettings.SettingsText.HeaderFilterTomorrow = "Hôm sau";
            gridViewSettings.SettingsText.HeaderFilterYesterday = "Hôm qua";
            gridViewSettings.SettingsText.HeaderFilterLastMonth = "Tháng trước";
            gridViewSettings.SettingsText.HeaderFilterLastYear = "Năm trước";
            gridViewSettings.SettingsText.HeaderFilterLastWeek = "Tuần trước";
            gridViewSettings.SettingsText.HeaderFilterNextMonth = "Tháng sau";
            gridViewSettings.SettingsText.HeaderFilterNextYear = "Năm sau";
            gridViewSettings.SettingsText.HeaderFilterNextWeek = "Tuần sau";
            gridViewSettings.SettingsText.FilterBarClear = "Xóa";

            gridViewSettings.SettingsText.EmptyHeaders = "Nhập từ cần lọc";
            gridViewSettings.SettingsText.GroupPanel = "Kéo cột để xem theo nhóm";
            gridViewSettings.SettingsText.GroupContinuedOnNextPage = "Trang sau";

            gridViewSettings.SettingsText.BatchEditChangesPreviewInsertedValues = "Thêm mới";
            gridViewSettings.SettingsText.BatchEditChangesPreviewUpdatedValues = "Cập nhật";

            gridViewSettings.SettingsText.CommandNew = "Thêm";
            gridViewSettings.SettingsText.CommandUpdate = "Lưu";
            gridViewSettings.SettingsText.CommandEdit = "Cập nhật";
            gridViewSettings.SettingsText.CommandDelete = "Xóa";
            gridViewSettings.SettingsText.CommandCancel = "Hủy";
            gridViewSettings.SettingsText.CommandRecover = "Hoàn tác";
            gridViewSettings.SettingsText.CommandBatchEditPreviewChanges = "Xem trước";
            gridViewSettings.SettingsText.CommandBatchEditHidePreview = "Ẩn xem trước";
            gridViewSettings.SettingsText.CommandBatchEditCancel = "Hủy";
            gridViewSettings.SettingsText.CommandBatchEditUpdate = "Lưu tất cả";
            gridViewSettings.SettingsText.CommandApplyFilter = "Áp dụng lọc";
            gridViewSettings.SettingsText.CommandApplySearchPanelFilter = "Tìm";
            gridViewSettings.SettingsText.CommandClearFilter = "Xóa lọc";
            gridViewSettings.SettingsText.CommandClearSearchPanelFilter = "Xóa tìm";
            gridViewSettings.SettingsText.CommandSelect = "Chọn";

            gridViewSettings.SettingsText.EmptyDataRow = "Không có dữ liệu";

            gridViewSettings.SettingsText.ContextMenuExpandDetailRow = "Chi tiết";

            gridViewSettings.SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = true;
            gridViewSettings.SettingsCustomizationDialog.Enabled = true;
            gridViewSettings.SettingsText.CustomizationWindowCaption = "";
            gridViewSettings.SettingsText.CustomizationDialogColumnChooserTab = "Chọn cột";
            gridViewSettings.SettingsText.CustomizationDialogSortingTab = "Sắp xếp";
            gridViewSettings.SettingsText.CustomizationDialogGroupingTab = "Nhóm cột";
            gridViewSettings.SettingsText.CustomizationDialogFilteringTab = "Lọc";
            //gridViewSettings.Styles.Cell.Font.Size = 9;
            //gridViewSettings.Styles.Header.Font.Size = 9;
            //gridViewSettings.Styles.GroupRow.Font.Size = 9;
            //gridViewSettings.Styles.CommandColumn.Font.Size = 9;
            //gridViewSettings.Styles.PagerTopPanel.Font.Size = 9;
            //gridViewSettings.Styles.PagerBottomPanel.Font.Size = 9;
            //gridViewSettings.Styles.GroupFooter.Font.Size = 9;
            //gridViewSettings.Styles.GroupPanel.Font.Size = 9;
            //gridViewSettings.Styles.Footer.Font.Size = 9;
            //gridViewSettings.Styles.StatusBar.Font.Size = 5;

            gridViewSettings.Styles.Cell.Paddings.PaddingTop = 5;
            gridViewSettings.Styles.Cell.Paddings.PaddingBottom = 5;
            gridViewSettings.Styles.EditFormCell.Paddings.Padding = 5;
            gridViewSettings.Styles.Header.Paddings.Padding = 5;
            gridViewSettings.Styles.Footer.Paddings.Padding = 5;
            gridViewSettings.Styles.PagerBottomPanel.Paddings.Padding = 5;
            gridViewSettings.Styles.GroupFooter.Paddings.Padding = 5;
            gridViewSettings.Styles.CustomizationDialog.Paddings.Padding = 5;
            gridViewSettings.Styles.GroupPanel.Paddings.Padding = 5;
            gridViewSettings.Styles.StatusBar.Paddings.Padding = 5;
            gridViewSettings.Styles.StatusBar.Paddings.Padding = 5;
            gridViewSettings.StylesToolbar.Style.Paddings.Padding = 5;
            gridViewSettings.Settings.GridLines = GridLines.Both;

            gridViewSettings.Columns.Add(c =>
            {
                c.Name = "STT";
                c.Caption = "STT";
                c.VisibleIndex = 0;
                c.Width = 30;
                c.MaxWidth = 30;
                c.Settings.AllowSort = DefaultBoolean.True;
                c.Settings.AllowAutoFilter = DefaultBoolean.False;
                c.EditFormSettings.Visible = DefaultBoolean.False;
            });
            gridViewSettings.CustomColumnDisplayText = (s, e) =>
            {
                var gr = s as GridViewExtension;
                if (e.Column.Name != "STT")
                    return;
                e.Value = e.VisibleIndex + 1;
                e.DisplayText = (e.VisibleIndex + 1).ToString();
            };
            gridViewSettings.SettingsExport.BeforeExport = (sender, e) =>
            {
                MVCxGridView gridView = sender as MVCxGridView;
                if (sender == null)
                    return;
                gridView.Columns["STT"].Visible = true;
            };
            foreach (GridViewDataColumn column in gridViewSettings.Columns)
            {
                column.SettingsHeaderFilter.Mode = GridHeaderFilterMode.CheckedList;
            }
        }
    }
}