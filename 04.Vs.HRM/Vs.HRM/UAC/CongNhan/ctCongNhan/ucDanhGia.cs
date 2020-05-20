using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;

namespace Vs.HRM
{
    public partial class ucDanhGia : DevExpress.XtraEditors.XtraUserControl
    {
        Int64 idcn = 0;
        bool cothem = false;
        public ucDanhGia(Int64 id)
        {
            idcn = id;
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, new List<LayoutControlGroup>(){Root}, windowsUIButton);
        }
        #region sự kiện form
        private void ucDanhGia_Load(object sender, EventArgs e)
        {
            LoadGrdBangDanhGia(-1);
            LoadGrdBangDanhGiaCT(false);
            enableButon(true);
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        LoadGrdBangDanhGiaCT(true);
                        AddnewRow();
                        Bindingdata(true);
                        cothem = true;
                        enableButon(false);
                        break;
                    }
                case "sua":
                    {
                        AddnewRow();
                        cothem = false;
                        enableButon(false);
                        break;
                    }

                case "xoa":
                    {
                        XoaBangDanhGia();
                        break;
                    }
                case "luu":
                    {
                        if (!Validate()) return;
                        SaveData();
                        enableButon(true);
                        Bindingdata(false);
                        DeleteAddRow();
                        break;
                    }
                case "khongluu":
                    {
                        LoadGrdBangDanhGiaCT(false);
                        enableButon(true);
                        Bindingdata(false);
                        DeleteAddRow();
                        break;
                    }
                case "thoat":
                    {
                        Commons.Modules.ObjSystems.GotoHome(this);
                        break;
                    }
                case "nddanhgia":
                    {
                        frmNDDanhGia nd = new frmNDDanhGia();
                        if(nd.ShowDialog() == DialogResult.Yes)
                        {
                            LoadGrdBangDanhGiaCT(false);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void grvDanhGia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
            LoadGrdBangDanhGiaCT(false);
        }
        private void grvDanhGiaCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            grvDanhGiaCT.ClearColumnErrors();
            DevExpress.XtraGrid.Views.Grid.GridView View = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            if (View == null) return;
            DataTable dt = Commons.Modules.ObjSystems.ConvertDatatable(grvDanhGiaCT);
            int n = dt.AsEnumerable().Count(x => x.Field<Int64>("ID_NDDG") == Convert.ToInt64(View.GetRowCellValue(e.RowHandle, View.Columns["ID_NDDG"])));
            if (n > 1)
            {
                e.Valid = false;
                View.SetColumnError(View.Columns["ID_NDDG"], Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage), DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                return;
            }
        }

        private void grvDanhGiaCT_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }


        private void grdDanhGiaCT_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                XoaBangDanhGiaCT();
            }
        }

        private void grdDanhGia_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                XoaBangDanhGia();
            }
        }

        #endregion

        #region function Load

        private void LoadGrdBangDanhGia(int iID)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListBangDanhGia", idcn));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_DG"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdDanhGia, grvDanhGia, dt, false, false, true, true, true, this.Name);
            grvDanhGia.Columns["ID_DG"].Visible = false;
            if (iID != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(iID));
                grvDanhGia.FocusedRowHandle = grvDanhGia.GetRowHandle(index);
            }
        }

        private void LoadGrdBangDanhGiaCT(bool them)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListBangDanhGiaCT", them == false ? grvDanhGia.GetFocusedRowCellValue("ID_DG") : -1, Commons.Modules.TypeLanguage));
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdDanhGiaCT, grvDanhGiaCT, dt, false, false, true, true, true, this.Name);
            Commons.Modules.ObjSystems.AddCombo("ID_NDDG", "TEN_NDDG", grvDanhGiaCT, Commons.Modules.ObjSystems.DataNoiDungDanhGia(false));
        }
        #endregion

        #region function dùng chung
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[4].Properties.Visible = visible;
            windowsUIButton.Buttons[5].Properties.Visible = visible;
            windowsUIButton.Buttons[6].Properties.Visible = !visible;
            windowsUIButton.Buttons[7].Properties.Visible = !visible;
            windowsUIButton.Buttons[8].Properties.Visible = visible;
        }
        private void Bindingdata(bool bthem)
        {
            if (bthem == true)
            {
                try
                {
                    NGAY_DGDateEdit.EditValue = DateTime.Today;
                    NGUOI_DGTextEdit.EditValue = "";
                    NOI_DUNGMemoEdit.EditValue = "";

                }
                catch
                {
                }
            }
            else
            {
                NGAY_DGDateEdit.EditValue = Convert.ToDateTime(grvDanhGia.GetFocusedRowCellValue("NGAY_DANH_GIA"));
                NGUOI_DGTextEdit.EditValue = grvDanhGia.GetFocusedRowCellValue("NGUOI_DANH_GIA");
                NOI_DUNGMemoEdit.EditValue = grvDanhGia.GetFocusedRowCellValue("NOI_DUNG");
            }
        }
        private void SaveData()
        {
            try
            {
                grvDanhGiaCT.PostEditor();
                grvDanhGiaCT.UpdateCurrentRow();
                //tạo bảng tạm chi tiết
                Commons.Modules.ObjSystems.MCreateTableToDatatable(Commons.IConnections.CNStr, "sbtBangDanhGia" + Commons.Modules.UserName, Commons.Modules.ObjSystems.ConvertDatatable(grvDanhGiaCT), "");
                LoadGrdBangDanhGia(
              Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateBangDanhGia",
                    grvDanhGia.GetFocusedRowCellValue("ID_DG"),
                    idcn,
                    NGAY_DGDateEdit.EditValue,
                    NGUOI_DGTextEdit.EditValue,
                    NOI_DUNGMemoEdit.EditValue,
                    cothem,
                    "sbtBangDanhGia" + Commons.Modules.UserName
                    )));
                LoadGrdBangDanhGiaCT(false);
            }
            catch
            { }
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhoaDaoTao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                //SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.QUA_TRINH_CONG_TAC WHERE ID_QTCT =" + grvCongTac.GetFocusedRowCellValue("ID_QTCT") + "");
                //grvCongTac.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        private void AddnewRow()
        {
            grvDanhGiaCT.OptionsBehavior.Editable = true;
            grvDanhGiaCT.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            grvDanhGiaCT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
        }
        private void DeleteAddRow()
        {
            grvDanhGiaCT.OptionsBehavior.Editable = false;
            grvDanhGiaCT.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            grvDanhGiaCT.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }
        private void XoaBangDanhGia()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhoaDaoTao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                XoaBangDanhGiaCT();
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE FROM dbo.BANG_DANH_GIA WHERE ID_DG = " + grvDanhGia.GetFocusedRowCellValue("ID_DG") + "");
                grvDanhGia.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        private void XoaBangDanhGiaCT()
        {
            //if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhoaDaoTao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE FROM dbo.BANG_DANH_GIA_CHI_TIET WHERE ID_DG = " + grvDanhGia.GetFocusedRowCellValue("ID_DG") + " AND ID_NDDG = " + grvDanhGiaCT.GetFocusedRowCellValue("ID_NDDG") + " ");
                grvDanhGiaCT.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

    }
}
