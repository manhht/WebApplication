using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web;
using System.Web.UI.WebControls;
using DevExpress.Web.Mvc;
using DevExpress.Web.Mvc.UI;
using System.Web.Mvc;
using static DevExpress.DataAccess.Native.Sql.QueryBuilder.AvailableItemData;
using DevExpress.Utils;

namespace WebApplication.Code
{
    public static class LayoutHelper
    {
        public static void PageToolbarSetting(MenuSettings menuSettings,string name_menu)
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

            gridViewSettings.Styles.Cell.Wrap = DefaultBoolean.False;
            gridViewSettings.Styles.PagerBottomPanel.CssClass = "pager";
            gridViewSettings.Styles.FocusedRow.CssClass = "focused";

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
            gridViewSettings.SettingsPager.PageSize = 15;
            gridViewSettings.SettingsPager.Position = PagerPosition.TopAndBottom;
            gridViewSettings.SettingsPager.PageSizeItemSettings.ShowAllItem = true;
            gridViewSettings.SettingsPager.EnableAdaptivity = true;
            gridViewSettings.SettingsPager.PageSizeItemSettings.Visible = true;
            gridViewSettings.SettingsPager.PageSizeItemSettings.AllItemText = "Tất cả";
            gridViewSettings.SettingsPager.Summary.Text = "Đang xem {0} đến {1} trong tổng số {2} mục";
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
            gridViewSettings.SettingsText.CommandUpdate = "Cập nhật";
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
            //gridViewSettings.Styles.Cell.Font.Size = 9;
            gridViewSettings.Styles.Header.Font.Size = 9;
            gridViewSettings.Styles.GroupRow.Font.Size = 9;
            gridViewSettings.Styles.CommandColumn.Font.Size = 9;
            gridViewSettings.Styles.PagerTopPanel.Font.Size = 9;
            gridViewSettings.Styles.PagerBottomPanel.Font.Size = 9;
            gridViewSettings.Styles.GroupFooter.Font.Size = 9;
            gridViewSettings.Styles.GroupPanel.Font.Size = 9;
            gridViewSettings.Styles.Footer.Font.Size = 9;
            gridViewSettings.Styles.StatusBar.Font.Size = 5;

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

            foreach (GridViewDataColumn column in gridViewSettings.Columns)
                column.SettingsHeaderFilter.Mode = GridHeaderFilterMode.CheckedList;
        }
    }
}