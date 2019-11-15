﻿using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using System.Linq;

namespace VietSoftHRM
{

    public partial class ucNHOM : DevExpress.XtraEditors.XtraUserControl
    {
        private int grid = 1;
        private bool co = true;
        private int dem;

        public ucNHOM()
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, windowsUIButtonPanel1);
        }
        #region sự kiện form
        private void ucNHOM_Load(object sender, EventArgs e)
        {
           LoadgrdNhom();
            enableButon(true);
            
        }
        private void grvNhom_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadUser();
        }
        private void grvUser_Click(object sender, EventArgs e)
        {
            grid = 2;
        }
        private void grvNhom_Click(object sender, EventArgs e)
        {
            grid = 1;
            Commons.Modules.sId = grvNhom.GetFocusedRowCellValue("ID_NHOM").ToString();
        }
        private void grdUser_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                XoaUser();
            }
        }
        private void grdNhom_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                XoaNhom();
            }
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        enableButon(false);
                        enabledControl(false);
                        co = true;
                        if (grid == 1)
                        {
                            dem = grvNhom.RowCount;
                            AddnewRow(grvNhom, true);
                            grvUser.OptionsBehavior.ReadOnly = true;
                            grvNhom.OptionsBehavior.ReadOnly = false;
                        }
                        else
                        {
                            dem = grvUser.RowCount;
                            AddnewRow(grvUser, true);
                            grvNhom.OptionsBehavior.ReadOnly = true;
                            grvUser.OptionsBehavior.ReadOnly = false;
                        }
                        break;
                    }
                case "xoa":
                    {
                        if (grid == 1)
                        {
                            XoaNhom();
                        }
                        else
                        {
                            XoaUser();
                        }
                        break;
                    }
                case "sua":
                    {
                        enabledControl(false);
                        enableButon(false);
                        co = false;
                        if (grid == 1)
                        {
                            AddnewRow(grvNhom, false);
                            grvUser.OptionsBehavior.ReadOnly = true;
                            grvNhom.OptionsBehavior.ReadOnly = false;
                        }
                        else
                        {
                            AddnewRow(grvUser, false);
                            grvUser.OptionsBehavior.ReadOnly = false;
                            grvNhom.OptionsBehavior.ReadOnly = true;
                        }
                        break;
                    }
                case "luu":
                    {
                        enabledControl(true);
                        enableButon(true);
                        if (grid == 1)
                        {
                            grvNhom.PostEditor();
                            grvNhom.UpdateCurrentRow();
                            GhiNhom();
                        }
                        else
                        {
                            grvUser.PostEditor();
                            grvUser.UpdateCurrentRow();
                            GhiUser();
                        }
                        DeleteAddRow(grvNhom);
                        DeleteAddRow(grvUser);
                        break;
                    }
                case "khongluu":
                    {
                        enabledControl(true);
                        enableButon(true);
                        DeleteAddRow(grvNhom);
                        DeleteAddRow(grvUser);
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        Application.Exit();
                        break;
                    }
                default:
                    break;
            }
        }

        #endregion


        #region hàm xử lý
        private void LoadgrdNhom()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetAllNhom", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.Columns["TEN_NHOM"].ReadOnly = false;
            dt.Columns["GHI_CHU"].ReadOnly = false;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_NHOM"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdNhom, grvNhom, dt, false, false, false, true, true, this.Name);
            grdNhom.DataSource = dt;
            grvNhom.Columns["ID_NHOM"].Visible = false;
            grvNhom.Columns["GHI_CHU"].Width = 200;
            if (!string.IsNullOrEmpty(Commons.Modules.sId))
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(Convert.ToInt32(Commons.Modules.sId)));
                grvNhom.FocusedRowHandle = grvNhom.GetRowHandle(index);
            }
            grvNhom_Click(null, null);
            
        }
        //load user
        private void LoadUser()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetUserbyGroup", Convert.ToInt64(grvNhom.GetFocusedRowCellValue("ID_NHOM")), Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                //dt.Columns["TO"].ReadOnly = false;
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdUser, grvUser, dt, false, false, true, true, true, this.Name);
                //add combobox nhan vien
                grvUser.Columns["ID_USER"].Visible = false;
                Commons.Modules.ObjSystems.AddCombXtra("ID_CN", "TEN_CN", grvUser, "spGetCongNhan");
                Commons.Modules.ObjSystems.AddCombXtra("ID_TO", "TEN_TO", grvUser, "spGetTo");
            }
            catch
            {

            }
        }
        private void AddnewRow(GridView view, bool add)
        {
            view.OptionsBehavior.Editable = true;
            if (add == true)
            {
                view.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            }
        }
        private void DeleteAddRow(GridView view)
        {
            view.OptionsBehavior.Editable = false;
            view.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }
        private void LockGrid(GridView grid, bool TT)
        {
            for (int i = 0; i <= grid.Columns.Count - 1; i++)
            {
                grid.Columns[i].OptionsColumn.AllowEdit = !TT;
                grid.Columns[i].OptionsColumn.ReadOnly = TT;
            }
        }
        private void XoaNhom()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteNhom"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.NHOM WHERE ID_NHOM = " + grvNhom.GetFocusedRowCellValue("ID_NHOM") + "");
                grvNhom.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        private void XoaUser()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteUser"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.USERS WHERE ID_USER = " + grvUser.GetFocusedRowCellValue("ID_USER") + "");
                grvUser.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        private void GhiUser()
        {
            try
            {
                if (co == false)
                {
                    for (int i = 0; i < grvUser.RowCount; i++)
                    {
                        //sữa những dòng đã có
                        SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spGhiUser", grvUser.GetRowCellValue(i, "ID_USER"), grvNhom.GetFocusedRowCellValue("ID_NHOM"), grvUser.GetRowCellValue(i, "ID_TO"), grvUser.GetRowCellValue(i, "ID_CN"), grvUser.GetRowCellValue(i, "USER_NAME"), grvUser.GetRowCellValue(i, "FULL_NAME"), grvUser.GetRowCellValue(i, "PASSWORD"), grvUser.GetRowCellValue(i, "DESCRIPTION"), grvUser.GetRowCellValue(i, "USER_MAIL"), grvUser.GetRowCellValue(i, "ACTIVE"), 0);
                    }
                }
                else
                {
                    //thêm thì lấy những dòng nào chưa có trong table 
                    for (int i = dem; i < grvUser.RowCount; i++)
                    {
                        if (string.IsNullOrEmpty(grvUser.GetRowCellValue(i, "USER_NAME")+ "")) break;
                        SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spGhiUser", -1, grvNhom.GetFocusedRowCellValue("ID_NHOM"), grvUser.GetRowCellValue(i, "ID_TO"), grvUser.GetRowCellValue(i, "ID_CN"), grvUser.GetRowCellValue(i, "USER_NAME"), grvUser.GetRowCellValue(i, "FULL_NAME"), Commons.Modules.ObjSystems.Encrypt("123", true), grvUser.GetRowCellValue(i, "DESCRIPTION"), grvUser.GetRowCellValue(i, "USER_MAIL"), grvUser.GetRowCellValue(i, "ACTIVE"), 1);
                    }
                }
            }
            catch
            {
            }

        }
        private void GhiNhom()
        {
            try
            {
                if (co == false)
                {
                    for (int i = 0; i < grvUser.RowCount; i++)
                    {
                        //sữa những dòng đã có
                        SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spGhiNhom", grvNhom.GetRowCellValue(i, "ID_NHOM"), grvNhom.GetRowCellValue(i, "TEN_NHOM"), grvNhom.GetRowCellValue(i, "GHI_CHU"), 0);
                    }
                }
                else
                {
                    //thêm thì lấy những dòng nào chưa có trong table 
                    for (int i = dem; i < grvNhom.RowCount; i++)
                    {
                        if (string.IsNullOrEmpty(grvNhom.GetRowCellValue(i, "TEN_NHOM")+"")) break;
                        SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spGhiNhom", -1, grvNhom.GetRowCellValue(i, "TEN_NHOM"), grvNhom.GetRowCellValue(i, "GHI_CHU"), 1);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }

        }
        private void enableButon(bool visible)
        {
            windowsUIButtonPanel1.Buttons[0].Properties.Visible = visible;
            windowsUIButtonPanel1.Buttons[1].Properties.Visible = visible;
            windowsUIButtonPanel1.Buttons[2].Properties.Visible = visible;
            windowsUIButtonPanel1.Buttons[3].Properties.Visible = visible;

            windowsUIButtonPanel1.Buttons[4].Properties.Visible = !visible;
            windowsUIButtonPanel1.Buttons[5].Properties.Visible = !visible;
            windowsUIButtonPanel1.Buttons[6].Properties.Visible = visible;
        }

        private void enabledControl(bool enabled)
        {
            if(enabled == true)
            {
                grdUser.Enabled = true;
                grdNhom.Enabled = true;
                return;
            }
            if (grid == 1)
            {
                grdUser.Enabled = enabled;
                grdNhom.Enabled = !enabled;
            }
            else
            {
                grdUser.Enabled = !enabled;
                grdNhom.Enabled = enabled;
            }
        }
        private bool CheckUser(string user)
        {
            //kiểm tra user name đã có tồn tại hay chưa
            int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr,CommandType.Text, "SELECT COUNT(*) FROM dbo.USERS WHERE USER_NAME = '"+ user +"'"));
                if (n > 1)
                    return false;
                else
                    return true;
        }
        private void grvUser_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            DevExpress.XtraGrid.Columns.GridColumn sMaNhom = View.Columns["ID_NHOM"];
            DevExpress.XtraGrid.Columns.GridColumn sTenUser = View.Columns["USER_NAME"];
            DevExpress.XtraGrid.Columns.GridColumn sFullName = View.Columns["FULL_NAME"];

            if (View.GetRowCellValue(e.RowHandle, sTenUser).ToString() == "")
            {
                e.Valid = false;
                View.SetColumnError(sTenUser, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage));
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage), "", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (View.GetRowCellValue(e.RowHandle, sTenUser).ToString() == "")
            {
                e.Valid = false;
                View.SetColumnError(sTenUser, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage));
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage), "", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
            }
            if (!CheckUser(View.GetRowCellValue(e.RowHandle, sTenUser).ToString()))
            {
                e.Valid = false;
                View.SetColumnError(sTenUser, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgDatontainguoidung", Commons.Modules.TypeLanguage));
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgDatontainguoidung", Commons.Modules.TypeLanguage), "", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
            }
            if (View.GetRowCellValue(e.RowHandle, sFullName).ToString() == "")
            {
                e.Valid = false;
                View.SetColumnError(sFullName, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraFullNameNULL", Commons.Modules.TypeLanguage));
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraFullNameNULL", Commons.Modules.TypeLanguage), "", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
            }
        }

        private void grvNhom_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            DevExpress.XtraGrid.Columns.GridColumn sTenNhom = View.Columns["TEN_NHOM"];
            if (View.GetRowCellValue(e.RowHandle, sTenNhom).ToString() == "")
            {
                e.Valid = false;
                View.SetColumnError(sTenNhom, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgTenNhomKhongNull", Commons.Modules.TypeLanguage));
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage), "", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }


        #endregion
        //load nhom




    }
}
