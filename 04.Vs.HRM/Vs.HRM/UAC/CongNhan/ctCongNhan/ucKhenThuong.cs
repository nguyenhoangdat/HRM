using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;

namespace Vs.HRM
{
    public partial class ucKhenThuong : DevExpress.XtraEditors.XtraUserControl
    {
        static Int64 idcn = 0;
        bool cothem = false;
        public ucKhenThuong(Int64 id)
        {
            InitializeComponent();
            idcn = id;
        }
        private void UcKhenThuong_Load(object sender, EventArgs e)
        {
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_KT_KLLookUpEdit, Commons.Modules.ObjSystems.DataKhenThuongKyLuat(false), "ID_KT_KL", "TEN_KT_KL", "TEN_KT_KL");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(LOAI_KTLookUpEdit, Commons.Modules.ObjSystems.DataLoaiKhenThuong(false), "ID_LOAI_KT", "TEN_LOAI_KT", "TEN_LOAI_KT");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_NKLookUpEdit, Commons.Modules.ObjSystems.DataNguoiKy(), "ID_NK", "HO_TEN", "HO_TEN");
            enableButon(true);
            LoadgrdTienLuong(-1);
        }
        private void LoadgrdTienLuong(int id)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListKhenThuong", idcn, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_KTHUONG"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdKhenThuong, grvKhenThuong, dt, false, true, true, true, true, this.Name);
            grvKhenThuong.Columns["ID_KTHUONG"].Visible = false;
            grvKhenThuong.Columns["ID_CN"].Visible = false;
            grvKhenThuong.Columns["ID_NK"].Visible = false;
            grvKhenThuong.Columns["ID_KT_KL"].Visible = false;
            grvKhenThuong.Columns["LOAI_KT"].Visible = false;
            grvKhenThuong.Columns["NGAY_HIEU_LUC"].Visible = false;
            grvKhenThuong.Columns["GHI_CHU"].Visible = false;
            if (id != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(id));
                grvKhenThuong.FocusedRowHandle = grvKhenThuong.GetRowHandle(index);
            }
        }
        private void GrdKhenThuong_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }

        }

        private void WindowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        cothem = true;
                        Bindingdata(true);
                        enableButon(false);
                        break;
                    }
                case "sua":
                    {
                        cothem = false;
                        enableButon(false);
                        break;
                    }

                case "xoa":
                    {
                        DeleteData();
                        break;
                    }
                case "luu":
                    {
                        if (!dxValidationProvider1.Validate()) return;
                        SaveData();
                        enableButon(true);
                        break;
                    }
                case "khongluu":
                    {
                        enableButon(true);
                        if (grvKhenThuong.RowCount == 1)
                        {
                            Bindingdata(false);
                        }
                        dxValidationProvider1.Validate();
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

        #region function dung chung
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = !visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;
            grdKhenThuong.Enabled = visible;
            SO_QUYET_DINHTextEdit.Properties.ReadOnly = visible;
            NGAY_HIEU_LUCDateEdit.Properties.ReadOnly = visible;
            NGAY_KYDateEdit.Properties.ReadOnly = visible;
            ID_NKLookUpEdit.Properties.ReadOnly = visible;
            NOI_DUNGTextEdit.Properties.ReadOnly = visible;
            ID_KT_KLLookUpEdit.Properties.ReadOnly = visible;
            LOAI_KTLookUpEdit.Properties.ReadOnly = visible;
            GHI_CHUTextEdit.Properties.ReadOnly = visible;
        }
        private void Bindingdata(bool bthem)
        {
            if (bthem == true)
            {
                SO_QUYET_DINHTextEdit.EditValue = "";
                NGAY_HIEU_LUCDateEdit.EditValue = DateTime.Today;
                NGAY_KYDateEdit.EditValue = DateTime.Today;
                NOI_DUNGTextEdit.EditValue = "";
                GHI_CHUTextEdit.EditValue = "";

            }
            else
            {
                SO_QUYET_DINHTextEdit.EditValue = grvKhenThuong.GetFocusedRowCellValue("SO_QUYET_DINH");
                NGAY_HIEU_LUCDateEdit.EditValue = Convert.ToDateTime(grvKhenThuong.GetFocusedRowCellValue("NGAY_HIEU_LUC")).Date;
                NGAY_KYDateEdit.EditValue = Convert.ToDateTime(grvKhenThuong.GetFocusedRowCellValue("NGAY_KY")).Date;
                ID_NKLookUpEdit.EditValue = grvKhenThuong.GetFocusedRowCellValue("ID_NK");
                NOI_DUNGTextEdit.EditValue = grvKhenThuong.GetFocusedRowCellValue("NOI_DUNG");
                ID_KT_KLLookUpEdit.EditValue = Convert.ToInt32(grvKhenThuong.GetFocusedRowCellValue("ID_KT_KL"));
                LOAI_KTLookUpEdit.EditValue = Convert.ToInt32(grvKhenThuong.GetFocusedRowCellValue("LOAI_KT"));
                GHI_CHUTextEdit.EditValue = grvKhenThuong.GetFocusedRowCellValue("GHI_CHU");
            }
        }
        private void SaveData()
        {
            try
            {
                int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateKhenThuong",
                        grvKhenThuong.GetFocusedRowCellValue("ID_KTHUONG"),
                        idcn,
                        SO_QUYET_DINHTextEdit.EditValue,
                        NGAY_HIEU_LUCDateEdit.EditValue,
                        NGAY_KYDateEdit.EditValue,
                        ID_NKLookUpEdit.EditValue,
                        NOI_DUNGTextEdit.EditValue,
                        ID_KT_KLLookUpEdit.EditValue,
                        LOAI_KTLookUpEdit.EditValue,
                        GHI_CHUTextEdit.EditValue,
                          cothem));
                LoadgrdTienLuong(n);
            }
            catch (Exception ex)
            { }
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhenThuong"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.KHEN_THUONG WHERE ID_KTHUONG = " + grvKhenThuong.GetFocusedRowCellValue("ID_KTHUONG") + "");
                grvKhenThuong.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelKhongThanhCong") + "\n" + ex.Message.ToString());
            }
        }
        #endregion

        private void GrvKhenThuong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
        }
    }
}
