using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;

namespace Vs.HRM
{
    public partial class frmPhuLucHDLD : DevExpress.XtraEditors.XtraForm
    {
        bool cothem = false;
        int idhdld = 0;
        public frmPhuLucHDLD(string sohd, string ngayhd, int idhd)
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, layoutControlGroup1, windowsUIButton);
            lbl_SoHD.Text = sohd;
            lbl_NgayHD.Text = ngayhd;
            idhdld = idhd;
        }

        #region sự kiện của form
        private void frmPhuLucHDLD_Load(object sender, EventArgs e)
        {
            //load combobox ID_QHLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(NGUOI_KYLookUpEdit, Commons.Modules.ObjSystems.DataNguoiKy(), "ID_NK", "HO_TEN", "HO_TEN");
            LoadgrdPhuLucHopDong("-1");
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
                        if (grvPLHD.RowCount == 0) return;
                        cothem = false;
                        enableButon(false);
                        break;
                    }

                case "xoa":
                    {
                        if (grvPLHD.RowCount == 0) return;
                        DeleteData();
                        break;
                    }
                case "luu":
                    {
                        if (!dxValidationProvider1.Validate()) return;
                        if (SaveData() == false) return;
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
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }
        private void grvPLHD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
        }
        private void grdPLHD_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }
        }
        #endregion

        #region hàm load form
        //hàm load gridview
        private void LoadgrdPhuLucHopDong(string id)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListPhuLucHopDong", idhdld, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["SO_PLHD"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdPLHD, grvPLHD, dt, false, true, true, true, true, this.Name);
            grvPLHD.Columns["NOI_DUNG_THAY_DOI"].Visible = false;
            grvPLHD.Columns["THOI_GIAN_THUC_HIEN"].Visible = false;
            grvPLHD.Columns["GHI_CHU"].Visible = false;
            grvPLHD.Columns["NGUOI_KY"].Visible = false;
            if (id != "-1")
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(id));
                grvPLHD.FocusedRowHandle = grvPLHD.GetRowHandle(index);
            }
            if (grvPLHD.RowCount == 1)
            {
                Bindingdata(false);
            }
        }
        //hàm bingding dữ liệu
        private void Bindingdata(bool bthem)
        {
            Commons.Modules.sPS = "0Load";
            if (bthem == true)
            {
                //lấy dữ liệu mặc định theo id công nhân
                try
                {
                    string sSql = "SELECT TOP	1 *,(SELECT MAX(SO_PLHD) +1 FROM dbo.PHU_LUC_HDLD WHERE ID_HDLD = " + idhdld + ") AS SOPL FROM dbo.PHU_LUC_HDLD WHERE NGAY_KY = (SELECT MAX(NGAY_KY) FROM dbo.PHU_LUC_HDLD)";
                    DataTable dt = new DataTable();
                    dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));

                    SO_PLHDTextEdit.EditValue = dt.Rows[0]["SOPL"];
                    NOI_DUNG_THAY_DOIMemoEdit.EditValue = dt.Rows[0]["NOI_DUNG_THAY_DOI"];
                    THOI_GIAN_THUC_HIENMemoEdit.EditValue = dt.Rows[0]["THOI_GIAN_THUC_HIEN"];
                    NGAY_KYDateEdit.EditValue = dt.Rows[0]["NGAY_KY"];
                    NGUOI_KYLookUpEdit.EditValue = dt.Rows[0]["NGUOI_KY"];
                    GHI_CHUMemoEdit.EditValue = dt.Rows[0]["GHI_CHU"];

                }
                catch (Exception ex)
                {
                    //XtraMessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                SO_PLHDTextEdit.EditValue = grvPLHD.GetFocusedRowCellValue("SO_PLHD");
                NOI_DUNG_THAY_DOIMemoEdit.EditValue = grvPLHD.GetFocusedRowCellValue("NOI_DUNG_THAY_DOI");
                THOI_GIAN_THUC_HIENMemoEdit.EditValue = grvPLHD.GetFocusedRowCellValue("THOI_GIAN_THUC_HIEN");
                NGAY_KYDateEdit.EditValue = grvPLHD.GetFocusedRowCellValue("NGAY_KY");
                NGUOI_KYLookUpEdit.EditValue = grvPLHD.GetFocusedRowCellValue("NGUOI_KY");
                GHI_CHUMemoEdit.EditValue = grvPLHD.GetFocusedRowCellValue("GHI_CHU");
            }
        }
        //hàm tắc mở control
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = !visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;
            grdPLHD.Enabled = visible;
            //ID_QHLookUpEdit.Properties.ReadOnly = visible;
            SO_PLHDTextEdit.Properties.ReadOnly = visible;
            NOI_DUNG_THAY_DOIMemoEdit.Properties.ReadOnly = visible;
            THOI_GIAN_THUC_HIENMemoEdit.Properties.ReadOnly = visible;
            NGAY_KYDateEdit.Properties.ReadOnly = visible;
            NGUOI_KYLookUpEdit.Properties.ReadOnly = visible;
            GHI_CHUMemoEdit.Properties.ReadOnly = visible;
        }
        #endregion

        #region hàm sử lý data
        //hàm sử lý khi lưu dữ liệu(thêm/sữa)
        private bool SaveData()
        {
            try
            {
                string sophieu = "";
                try
                {
                    sophieu = grvPLHD.GetFocusedRowCellValue("SO_PLHD").ToString();
                }
                catch (Exception)
                {
                    sophieu = "";
                }

                string n = SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdatetPhuLucHopDong",
                    idhdld,
                    sophieu,
                    SO_PLHDTextEdit.EditValue.ToString(),
                    NOI_DUNG_THAY_DOIMemoEdit.EditValue,
                    THOI_GIAN_THUC_HIENMemoEdit.EditValue,
                    NGAY_KYDateEdit.EditValue,
                    NGUOI_KYLookUpEdit.EditValue,
                    GHI_CHUMemoEdit.EditValue,
                    cothem
                ).ToString();
                LoadgrdPhuLucHopDong(n);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //hàm xử lý khi xóa dữ liệu
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeletePhuLucHopDong"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE	dbo.PHU_LUC_HDLD WHERE ID_HDLD  = " + idhdld + " AND SO_PLHD = " + grvPLHD.GetFocusedRowCellValue("SO_PLHD") + "");
                grvPLHD.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}