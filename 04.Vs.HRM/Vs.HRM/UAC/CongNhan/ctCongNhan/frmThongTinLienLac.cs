﻿using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraGrid;

namespace Vs.HRM
{
    public partial class frmThongTinLienLac : DevExpress.XtraEditors.XtraForm
    {
        bool co = true;
        public frmThongTinLienLac(string tencn)
        {
            InitializeComponent();
            lbl_HoTenCN.Text = tencn.ToUpper();
        }
        private void frmThongTinLienLac_Load(object sender, EventArgs e)
        {
            LoadgrdNhom();
            enableButon(true);
        }
        private void grv_TTLL_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            View.SetRowCellValue(e.RowHandle, View.Columns["MASO"], grv_TTLL.RowCount);
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        enableButon(false);
                        Commons.Modules.ObjSystems.AddnewRow(grv_TTLL, true);
                        break;
                    }
                case "xoa":
                    {
                        DeleteData();
                        break;
                    }
                case "sua":
                    {
                        if (grv_TTLL.RowCount == 0) { XtraMessageBox.Show("Chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand); break; }
                        enableButon(false);
                        Commons.Modules.ObjSystems.AddnewRow(grv_TTLL, false);
                        grv_TTLL.OptionsBehavior.ReadOnly = false;
                        break;
                    }
                case "luu":
                    {
                        grv_TTLL.PostEditor();
                        grv_TTLL.UpdateCurrentRow();
                        Commons.Modules.ObjSystems.DeleteAddRow(grv_TTLL);
                        SaveData();
                        enableButon(true);
                        break;
                    }
                case "khongluu":
                    {
                        enableButon(true);
                        Commons.Modules.ObjSystems.DeleteAddRow(grv_TTLL);
                        LoadgrdNhom();
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = !visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;
        }
        private void LoadgrdNhom()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT MASO,PHUONGTIEN , NOIDUNG FROM dbo.THONG_TIN_LIEN_HE WHERE ID_CN = " + Commons.Modules.iCongNhan + " "));
            dt.Columns["MASO"].ReadOnly = false;
            dt.Columns["PHUONGTIEN"].ReadOnly = false;
            dt.Columns["NOIDUNG"].ReadOnly = false;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["MASO"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grd_TTLL, grv_TTLL, dt, false, false, true, true, true, this.Name);
            if (!string.IsNullOrEmpty(Commons.Modules.sId))
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(Convert.ToInt32(Commons.Modules.sId)));
                grv_TTLL.FocusedRowHandle = grv_TTLL.GetRowHandle(index);
            }
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteThongTinLienHe"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.THONG_TIN_LIEN_HE WHERE ID_CN = "+ Commons.Modules.iCongNhan +" AND MASO = "+grv_TTLL.GetFocusedRowCellValue("MASO")+"");
                grv_TTLL.DeleteSelectedRows();
            }
            catch (Exception ex)
            {

            }
        }
        private void SaveData()
        {
            try
            {

            //xóa toàn bộ dữ liệu
            string sSql = "DELETE FROM	 dbo.THONG_TIN_LIEN_HE WHERE ID_CN = " + Commons.Modules.iCongNhan + "";
            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr,CommandType.Text, sSql);
            DataTable dt = new DataTable();
            dt = (DataTable)grd_TTLL.DataSource;
                
            Commons.Modules.ObjSystems.MCreateTableToDatatable(Commons.IConnections.CNStr,"TMP"+Commons.Modules.UserName,dt,"");
            //insert lại toàn bộ dữ liệu
            sSql = "INSERT INTO dbo.THONG_TIN_LIEN_HE (ID_CN, MASO, PHUONGTIEN, NOIDUNG) SELECT "+Commons.Modules.iCongNhan+", MASO, PHUONGTIEN, NOIDUNG FROM TMP"+ Commons.Modules.UserName + "";
            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, sSql);
            Commons.Modules.ObjSystems.XoaTable("TMP" + Commons.Modules.UserName);

                XtraMessageBox.Show("Cập nhật thông tin liên lạc của nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void grd_TTLL_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }
        }
    }
}