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
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraLayout;

namespace Vs.HRM
{
    public partial class ucBangCap : DevExpress.XtraEditors.XtraUserControl
    {
        static Int64 idcn = 0;
        bool cothem = false;
        public ucBangCap(Int64 id)
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this,new List<LayoutControlGroup>() {Root,layoutControlGroup1}, windowsUIButton);
            idcn = id;
        }

        #region function form Load
        private void LoadgrdBangCap(int id)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListBangCap", idcn, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_BC"] };
            dt.Columns["ID_NK"].ReadOnly = false;
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdBangCapCN, grvBangCapCN, dt, false, true, true, true, true, this.Name);
            grvBangCapCN.Columns["TEN_BANG"].Visible = false;
            grvBangCapCN.Columns["XEP_LOAI"].Visible = false;
            grvBangCapCN.Columns["ID_NK"].Visible = false;
            grvBangCapCN.Columns["NOI_CAP"].Visible = false;
            grvBangCapCN.Columns["GHI_CHU"].Visible = false;
            grvBangCapCN.Columns["NGAY_KY"].Visible = false;
            grvBangCapCN.Columns["ID_BC"].Visible = false;
            grvBangCapCN.Columns["ID_LOAI_TD"].Visible = false;
            if (id != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(id));
                grvBangCapCN.FocusedRowHandle = grvBangCapCN.GetRowHandle(index);
            }
        }

        #endregion

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

            grdBangCapCN.Enabled = visible;

            SO_HIEU_BANGTextEdit.Properties.ReadOnly = visible;
            TEN_BANGTextEdit.Properties.ReadOnly = visible;
            NOI_HOCTextEdit.Properties.ReadOnly = visible;
            NGAY_BDDateEdit.Properties.ReadOnly = visible;
            NGAY_KTDateEdit.Properties.ReadOnly = visible;
            NGANH_DAO_TAOTextEdit.Properties.ReadOnly = visible;
            HT_DAO_TAOTextEdit.Properties.ReadOnly = visible;
            XEP_LOAITextEdit.Properties.ReadOnly = visible;
            TRINH_DOLookUpEdit.Properties.ReadOnly = visible;
            NGAY_KYDateEdit.Properties.ReadOnly = visible;
            ID_NKLookUpEdit.Properties.ReadOnly = visible;
            NOI_CAPTextEdit.Properties.ReadOnly = visible;
            GHI_CHUMemoEdit.Properties.ReadOnly = visible; 
        }
        private void Bindingdata(bool bthem)
        {
            if (bthem == true)
            {
                SO_HIEU_BANGTextEdit.EditValue = "";
                TEN_BANGTextEdit.EditValue = "";
                NOI_HOCTextEdit.EditValue = "";
                NGAY_BDDateEdit.EditValue = DateTime.Today;
                NGAY_KTDateEdit.EditValue = DateTime.Today;
                NGANH_DAO_TAOTextEdit.EditValue = "";
                HT_DAO_TAOTextEdit.EditValue = "";
                XEP_LOAITextEdit.EditValue = "";
                TRINH_DOLookUpEdit.EditValue = 1;
                NGAY_KYDateEdit.EditValue = DateTime.Today;
                ID_NKLookUpEdit.EditValue = 1;
                NOI_CAPTextEdit.EditValue = "";
                GHI_CHUMemoEdit.EditValue = "";
            }
            else
            {
                SO_HIEU_BANGTextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("SO_HIEU_BANG");
                TEN_BANGTextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("TEN_BANG");
                NOI_HOCTextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("NOI_HOC");
                NGAY_BDDateEdit.EditValue = Convert.ToDateTime(grvBangCapCN.GetFocusedRowCellValue("NGAY_BD")).Date;
                NGAY_KTDateEdit.EditValue = Convert.ToDateTime(grvBangCapCN.GetFocusedRowCellValue("NGAY_KT")).Date;
                NGANH_DAO_TAOTextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("NGANH_DAO_TAO");
                HT_DAO_TAOTextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("HT_DAO_TAO");
                XEP_LOAITextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("XEP_LOAI");
                TRINH_DOLookUpEdit.EditValue = Convert.ToInt64(grvBangCapCN.GetFocusedRowCellValue("ID_LOAI_TD"));
                NGAY_KYDateEdit.EditValue = Convert.ToDateTime(grvBangCapCN.GetFocusedRowCellValue("NGAY_KY")).Date;
                ID_NKLookUpEdit.EditValue =Convert.ToInt64(grvBangCapCN.GetFocusedRowCellValue("ID_NK"));
                NOI_CAPTextEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("NOI_CAP");
                GHI_CHUMemoEdit.EditValue = grvBangCapCN.GetFocusedRowCellValue("GHI_CHU"); 
            }
        }
        private void SaveData()
        {
            try
            {

            int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateBangCap",
                    grvBangCapCN.GetFocusedRowCellValue("ID_BC"),
                    idcn,
                    ID_NKLookUpEdit.EditValue,
                    TRINH_DOLookUpEdit.EditValue,
                    SO_HIEU_BANGTextEdit.EditValue,
                    NGAY_BDDateEdit.EditValue,
                    NGAY_KTDateEdit.EditValue,
                    NOI_HOCTextEdit.EditValue,
                    HT_DAO_TAOTextEdit.EditValue,
                    NGANH_DAO_TAOTextEdit.EditValue,
                    TEN_BANGTextEdit.EditValue,
                    XEP_LOAITextEdit.EditValue,
                    NGAY_KYDateEdit.EditValue,
                    NOI_CAPTextEdit.EditValue,
                    GHI_CHUMemoEdit.EditValue,cothem));
                    LoadgrdBangCap(n);
            }
            catch(Exception ex)
            {}
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhoaDaoTao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE	dbo.BANG_CAP WHERE ID_BC = " + grvBangCapCN.GetFocusedRowCellValue("ID_BC") + "");
                grvBangCapCN.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }

        #endregion

        #region sự kiện form
        private void ucBangCap_Load(object sender, EventArgs e)
        {
            LoadgrdBangCap(-1);
            Commons.Modules.ObjSystems.MLoadLookUpEdit(TRINH_DOLookUpEdit, Commons.Modules.ObjSystems.DataLoaiTrinhDo(false), "ID_LOAI_TD", "TEN_LOAI_TD", "TEN_LOAI_TD");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_NKLookUpEdit, Commons.Modules.ObjSystems.DataNguoiKy(), "ID_NK", "HO_TEN", "HO_TEN");
            Commons.Modules.ObjSystems.MAutoCompleteTextEdit(HT_DAO_TAOTextEdit, Commons.Modules.ObjSystems.ConvertDatatable(grdBangCapCN), "HT_DAO_TAO");
            Commons.Modules.ObjSystems.MAutoCompleteTextEdit(NGANH_DAO_TAOTextEdit, Commons.Modules.ObjSystems.ConvertDatatable(grdBangCapCN), "NGANH_DAO_TAO");
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
                        Bindingdata(true);
                        cothem = true;
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
        private void grvBangCapCN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
        }

        private void grdBangCapCN_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }
        }

        #endregion

    }
}
