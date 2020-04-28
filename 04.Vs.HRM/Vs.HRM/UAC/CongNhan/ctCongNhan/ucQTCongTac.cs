using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraLayout;
using System.Data.Linq.SqlClient;

namespace Vs.HRM
{
    public partial class ucQTCongTac : DevExpress.XtraEditors.XtraUserControl
    {
        Int64 idcn = 0;
        bool cothem = false;
        DataTable tableTTC_CN = new DataTable();
        public ucQTCongTac(Int64 id)
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, new List<LayoutControlGroup>() { Root }, windowsUIButton);
            idcn = id;
        }
        private void Loaddatatable()
        {
            tableTTC_CN.Clear();
            tableTTC_CN.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT * FROM dbo.funQuaTrinhCongTac(" + idcn + "," + Commons.Modules.TypeLanguage + ")"));

        }
        #region sự kiệm form
        private void ucQTCongTac_Load(object sender, EventArgs e)
        {
            try
            {
                Loaddatatable();
            }
            catch
            {
            }
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboDonVi(DON_VILookUpEdit);
            Commons.Modules.ObjSystems.LoadCboXiNghiep(DON_VILookUpEdit, XI_NGHIEPLookUpEdit);
            LoadComboboxTo();
            Commons.Modules.sPS = "";
            //ID_LQDLookUpEdit.EditValue = "";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LQDLookUpEdit, Commons.Modules.ObjSystems.DataLoaiQuyetDinh(false), "ID_LQD", "TEN_LQD", "TEN_LQD");
            //ID_CNLookTextEdit.EditValue = "";
            //Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_CNLookTextEdit, Commons.Modules.ObjSystems.DataCongNhan(false), "ID_CN", "TEN_CN", "TEN_CN");
            //ID_NKLookUpEdit.EditValue = "";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_NKLookUpEdit, Commons.Modules.ObjSystems.DataNguoiKy(), "ID_NK", "HO_TEN", "HO_TEN");
            //DON_VILookUpEdit.EditValue = "";
            //Commons.Modules.ObjSystems.LoadCboTo(DON_VILookUpEdit, XI_NGHIEPLookUpEdit, ID_TOLookUpEdit);
            //ID_CVLookUpEdit.EditValue = "";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_CVLookUpEdit, Commons.Modules.ObjSystems.DataChucVu(false), "ID_CV", "TEN_CV", "TEN_CV");
            //ID_CV_CULookUpEdit.EditValue = "";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_CV_CULookUpEdit, Commons.Modules.ObjSystems.DataChucVu(false), "ID_CV", "TEN_CV", "TEN_CV");
            //ID_LCVLookUpEdit.EditValue = "";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LCVLookUpEdit, Commons.Modules.ObjSystems.DataLoaiCV(false), "ID_LCV", "TEN_LCV", "TEN_LCV");
            //ID_LCV_CULookUpEdit.EditValue = "";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LCV_CULookUpEdit, Commons.Modules.ObjSystems.DataLoaiCV(false), "ID_LCV", "TEN_LCV", "TEN_LCV");
            LoadgrdCongTac(-1);
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
                        Bindingdata(false);
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
        private void grvCongTac_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
        }
        private void DON_VILookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboXiNghiep(DON_VILookUpEdit, XI_NGHIEPLookUpEdit);
            LoadComboboxTo();
            Commons.Modules.sPS = "";
        }
        private void XI_NGHIEPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadComboboxTo();
            Commons.Modules.sPS = "";
        }
        private void grdCongTac_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }
        }

        #endregion

        #region function load
        private void LoadgrdCongTac(int id)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListCongTac", idcn, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_QTCT"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdCongTac, grvCongTac, dt, false, true, true, true, true, this.Name);
            grvCongTac.Columns["ID_QTCT"].Visible = false;
            grvCongTac.Columns["ID_CN"].Visible = false;
            grvCongTac.Columns["ID_LQD"].Visible = false;
            grvCongTac.Columns["ID_NK"].Visible = false;
            grvCongTac.Columns["ID_CV"].Visible = false;
            grvCongTac.Columns["ID_LCV"].Visible = false;
            grvCongTac.Columns["ID_TO_CU"].Visible = false;
            grvCongTac.Columns["ID_TO"].Visible = false;
            grvCongTac.Columns["ID_CV_CU"].Visible = false;
            grvCongTac.Columns["ID_LCV_CU"].Visible = false;
            grvCongTac.Columns["MUC_LUONG"].Visible = false;
            grvCongTac.Columns["MUC_LUONG_CU"].Visible = false;
            grvCongTac.Columns["TEN_XN"].Visible = false;
            grvCongTac.Columns["TEN_TO"].Visible = false;
            grvCongTac.Columns["ID_XN"].Visible = false;
            grvCongTac.Columns["ID_DV"].Visible = false;
            grvCongTac.Columns["GHI_CHU"].Visible = false;
            grvCongTac.Columns["NGAY_KY"].Visible = false;
            grvCongTac.Columns["TEN_CN"].Visible = false;
            if (id != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(id));
                grvCongTac.FocusedRowHandle = grvCongTac.GetRowHandle(index);
            }
        }

        private void LoadComboboxTo()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboTODen", DON_VILookUpEdit.EditValue, XI_NGHIEPLookUpEdit.EditValue, tableTTC_CN.Rows[0]["ID_TO"], Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_TOLookUpEdit, dt, "ID_TO", "TEN_TO", "TEN_TO");

        }



        #endregion

        #region funciton dùm chung
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = !visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;

            grdCongTac.Enabled = visible;
            //SO_HIEU_BANGTextEdit.Properties.ReadOnly = visible;
            SO_QUYET_DINHTextEdit.Properties.ReadOnly = visible;
            NGAY_KYDateEdit.Properties.ReadOnly = visible;
            NGAY_HIEU_LUCDateEdit.Properties.ReadOnly = visible;
            ID_LQDLookUpEdit.Properties.ReadOnly = visible;
            ID_CNTextEdit.Properties.ReadOnly = true;
            ID_NKLookUpEdit.Properties.ReadOnly = visible;
            ID_CV_CULookUpEdit.Properties.ReadOnly = visible;
            DON_VI_CUTextEdit.Properties.ReadOnly = true;
            XI_NGHIEP_CUTextEdit.Properties.ReadOnly = true;
            ID_TO_CUTextEdit.Properties.ReadOnly = true;
            NOI_CONG_TACTextEdit.Properties.ReadOnly = visible;
            NHIEM_VUMemoEdit.Properties.ReadOnly = visible;
            MUC_LUONG_CUTextEdit.Properties.ReadOnly = visible;
            ID_LCV_CULookUpEdit.Properties.ReadOnly = visible;

            DON_VILookUpEdit.Properties.ReadOnly = visible;
            XI_NGHIEPLookUpEdit.Properties.ReadOnly = visible;
            ID_TOLookUpEdit.Properties.ReadOnly = visible;
            ID_CVLookUpEdit.Properties.ReadOnly = visible;
            ID_LCVLookUpEdit.Properties.ReadOnly = visible;
            MUC_LUONGTextEdit.Properties.ReadOnly = visible;
            GHI_CHUTextEdit.Properties.ReadOnly = visible;

        }
        private void Bindingdata(bool bthem)
        {

            Commons.Modules.sPS = "0Load";
            if (bthem == true)
            {
                Loaddatatable();
                //lấy dữ liệu mặc định theo id công nhân
                try
                {
                    NGAY_KYDateEdit.EditValue = DateTime.Today;
                    NGAY_HIEU_LUCDateEdit.EditValue = DateTime.Today;
                    SO_QUYET_DINHTextEdit.EditValue = "";
                    DON_VI_CUTextEdit.EditValue = tableTTC_CN.Rows[0]["TEN_DV"];
                    XI_NGHIEP_CUTextEdit.EditValue = tableTTC_CN.Rows[0]["TEN_XN"];
                    ID_TO_CUTextEdit.EditValue = tableTTC_CN.Rows[0]["TEN_TO"];
                    MUC_LUONG_CUTextEdit.EditValue = tableTTC_CN.Rows[0]["MUC_LUONG_CU"];
                    NOI_CONG_TACTextEdit.EditValue = "";
                    MUC_LUONGTextEdit.EditValue = 0;
                    GHI_CHUTextEdit.EditValue = "";
                    NHIEM_VUMemoEdit.EditValue = "";
                    ID_LQDLookUpEdit.EditValue = "";
                    ID_CNTextEdit.EditValue = tableTTC_CN.Rows[0]["HO_TEN"];
                    ID_NKLookUpEdit.EditValue = "";
                    ID_CV_CULookUpEdit.EditValue = tableTTC_CN.Rows[0]["ID_CV"];
                    ID_LCV_CULookUpEdit.EditValue = tableTTC_CN.Rows[0]["ID_LCV"];
                }
                catch
                {

                }
            }
            else
            {
                NGAY_KYDateEdit.EditValue = Convert.ToDateTime(grvCongTac.GetFocusedRowCellValue("NGAY_KY"));
                NGAY_HIEU_LUCDateEdit.EditValue = Convert.ToDateTime(grvCongTac.GetFocusedRowCellValue("NGAY_HIEU_LUC"));
                SO_QUYET_DINHTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("SO_QUYET_DINH");
                DON_VI_CUTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("TEN_DV");
                XI_NGHIEP_CUTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("TEN_XN");
                ID_TO_CUTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("TEN_TO");
                MUC_LUONG_CUTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("MUC_LUONG_CU");
                NOI_CONG_TACTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("NOI_CONG_TAC");
                MUC_LUONGTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("MUC_LUONG");
                GHI_CHUTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("GHI_CHU");
                NHIEM_VUMemoEdit.EditValue = grvCongTac.GetFocusedRowCellValue("NHIEM_VU");

                ID_LQDLookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_LQD");
                ID_CNTextEdit.EditValue = grvCongTac.GetFocusedRowCellValue("TEN_CN");
                ID_NKLookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_NK");
                DON_VILookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_DV");
                XI_NGHIEPLookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_XN");
                ID_TOLookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_TO");
                ID_CVLookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_CV");
                ID_LCVLookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_LCV");

                ID_CV_CULookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_CV_CU");
                ID_LCV_CULookUpEdit.EditValue = grvCongTac.GetFocusedRowCellValue("ID_LCV_CU");


            }
            Commons.Modules.sPS = "";
        }
        private void SaveData()
        {
            try
            {
                int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateQuaTrinhCongTac",
                grvCongTac.GetFocusedRowCellValue("ID_QTCT"),
                idcn,
                ID_LQDLookUpEdit.EditValue,
                ID_NKLookUpEdit.EditValue,
                ID_TOLookUpEdit.EditValue,
                ID_CVLookUpEdit.EditValue,
                ID_LCVLookUpEdit.EditValue,
                tableTTC_CN.Rows[0]["ID_TO"],
                ID_CV_CULookUpEdit.EditValue,
                ID_LCV_CULookUpEdit.EditValue,
                SO_QUYET_DINHTextEdit.EditValue,
                NGAY_KYDateEdit.EditValue,
                NGAY_HIEU_LUCDateEdit.EditValue,
                NOI_CONG_TACTextEdit.EditValue,
                NHIEM_VUMemoEdit.EditValue,
                MUC_LUONGTextEdit.EditValue,
                MUC_LUONG_CUTextEdit.EditValue,
                GHI_CHUTextEdit.EditValue,
                cothem
                ));
                LoadgrdCongTac(n);
            }
            //nếu là ngày hiệu lực là ngày mới nhất thì cập nhật lại bảng công nhân về tổ và chức vụ
            catch (Exception ex)
            { }
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhoaDaoTao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.QUA_TRINH_CONG_TAC WHERE ID_QTCT =" + grvCongTac.GetFocusedRowCellValue("ID_QTCT") + "");
                grvCongTac.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        #endregion
    }
}
