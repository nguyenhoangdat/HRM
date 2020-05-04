﻿using System;
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
using DevExpress.XtraLayout;

namespace Vs.HRM
{
    public partial class ucTienLuong : DevExpress.XtraEditors.XtraUserControl
    {
        static Int64 idcn = 0;
        bool cothem = false;
        public ucTienLuong(Int64 id)
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, new List<LayoutControlGroup>() { Root }, windowsUIButton);
            idcn = id;
        }

        #region function form Load
        private void LoadgrdTienLuong(int id)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListTienLuong", idcn, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_LCB"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdTienLuong, grvTienLuong, dt, false, true, true, true, true, this.Name);
            grvTienLuong.Columns["ID_LCB"].Visible = false;
            grvTienLuong.Columns["ID_CN"].Visible = false;
            grvTienLuong.Columns["ID_TO"].Visible = false;
            grvTienLuong.Columns["ID_CV"].Visible = false;
            grvTienLuong.Columns["ID_NK"].Visible = false;
            grvTienLuong.Columns["ID_NL"].Visible = false;
            grvTienLuong.Columns["ID_BL"].Visible = false;
            grvTienLuong.Columns["HS_LUONG"].Visible = false;
            grvTienLuong.Columns["LUONG_CO_BAN"].Visible = false;
            grvTienLuong.Columns["MUC_LUONG_THUC"].Visible = false;
            grvTienLuong.Columns["THUONG_CHUYEN_CAN"].Visible = false;
            grvTienLuong.Columns["PC_DOC_HAI"].Visible = false;
            grvTienLuong.Columns["THUONG_HT_CV"].Visible = false;
            grvTienLuong.Columns["PC_KY_NANG"].Visible = false;
            grvTienLuong.Columns["PC_SINH_HOAT"].Visible = false;
            grvTienLuong.Columns["PC_CON_NHO"].Visible = false;
            if (id != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(id));
                grvTienLuong.FocusedRowHandle = grvTienLuong.GetRowHandle(index);
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

            grdTienLuong.Enabled = visible;

            //SO_HIEU_BANGTextEdit.Properties.ReadOnly = visible;
            ID_CVLookUpEdit.Properties.ReadOnly = visible;
            ID_NKLookUpEdit.Properties.ReadOnly = visible;
            NGAY_KYDateEdit.Properties.ReadOnly = visible;
            SO_QUYET_DINHTextEdit.Properties.ReadOnly = visible;
            NGAY_HIEU_LUCDateEdit.Properties.ReadOnly = visible;
            NGACH_LUONGLookUpEdit.Properties.ReadOnly = visible;
            BAC_LUONGLookUpEdit.Properties.ReadOnly = visible;
            GHI_CHUTextEdit.Properties.ReadOnly = visible;
            HS_LUONGTextEdit.Properties.ReadOnly = visible;
            //LUONG_CO_BANTextEdit.Properties.ReadOnly = visible;
            //MUC_LUONG_THUCTextEdit.Properties.ReadOnly = visible;
            THUONG_CHUYEN_CANTextEdit.Properties.ReadOnly = visible;
            PC_DOC_HAITextEdit.Properties.ReadOnly = visible;
            THUONG_HT_CVTextEdit.Properties.ReadOnly = visible;
            PC_KY_NANGTextEdit.Properties.ReadOnly = visible;
            PC_SINH_HOATTextEdit.Properties.ReadOnly = visible;
            PC_CON_NHOTextEdit.Properties.ReadOnly = visible;
        }
        private void Bindingdata(bool bthem)
        {
            if (bthem == true)
            {
                ID_TOLookUpEdit.EditValue = "";
                ID_CVLookUpEdit.EditValue = "";
                ID_NKLookUpEdit.EditValue = "";
                NGAY_KYDateEdit.EditValue = DateTime.Today;
                SO_QUYET_DINHTextEdit.EditValue = "";
                NGAY_HIEU_LUCDateEdit.EditValue = DateTime.Today;
                NGACH_LUONGLookUpEdit.EditValue = "";
                BAC_LUONGLookUpEdit.EditValue = "";
                GHI_CHUTextEdit.EditValue = "";
                HS_LUONGTextEdit.EditValue = "";
                LUONG_CO_BANTextEdit.EditValue = "";
                MUC_LUONG_THUCTextEdit.EditValue = "";
                THUONG_CHUYEN_CANTextEdit.EditValue = "";
                PC_DOC_HAITextEdit.EditValue = "";
                THUONG_HT_CVTextEdit.EditValue = "";
                PC_KY_NANGTextEdit.EditValue = "";
                PC_SINH_HOATTextEdit.EditValue = "";
                BAC_LUONGLookUpEdit_EditValueChanged(null, null);
            }
            else
            {
                ID_TOLookUpEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("ID_TO");
                ID_CVLookUpEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("ID_CV");
                ID_NKLookUpEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("ID_NK");
                NGAY_KYDateEdit.EditValue = Convert.ToDateTime(grvTienLuong.GetFocusedRowCellValue("NGAY_KY")).Date;
                SO_QUYET_DINHTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("SO_QUYET_DINH");
                NGAY_HIEU_LUCDateEdit.EditValue = Convert.ToDateTime(grvTienLuong.GetFocusedRowCellValue("NGAY_HIEU_LUC")).Date;
                NGACH_LUONGLookUpEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("ID_NL");
                BAC_LUONGLookUpEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("ID_BL");
                GHI_CHUTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("GHI_CHU");
                HS_LUONGTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("HS_LUONG");
                LUONG_CO_BANTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("LUONG_CO_BAN");
                THUONG_CHUYEN_CANTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("THUONG_CHUYEN_CAN");
                PC_DOC_HAITextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("PC_DOC_HAI");
                THUONG_HT_CVTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("THUONG_HT_CV");
                PC_KY_NANGTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("PC_KY_NANG");
                PC_SINH_HOATTextEdit.EditValue = grvTienLuong.GetFocusedRowCellValue("PC_SINH_HOAT");
                PC_CON_NHOTextEdit.EditValue = Convert.ToDouble(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT dbo.[funGetPhuCapConNho](" + Commons.Modules.iCongNhan + ")"));
                HS_LUONGTextEdit_EditValueChanged(null, null);
            }
        }
        private void SaveData()
        {
            double luongthucold = 0;
            try
            {
                //lay luong gan nhat cua cong nhan do
                if (cothem == true)
                {
                    luongthucold = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT MUC_LUONG_THUC FROM dbo.LUONG_CO_BAN WHERE ID_CN = " + idcn + " AND  NGAY_HIEU_LUC = (SELECT MAX(NGAY_HIEU_LUC) FROM dbo.LUONG_CO_BAN WHERE ID_CN = " + idcn + ")"));
                }
                else
                {
                    luongthucold = Convert.ToDouble(grvTienLuong.GetFocusedRowCellValue("MUC_LUONG_THUC"));
                }
            }
            catch (Exception ex)
            {
                luongthucold = 0;
            }
            try
            {

                int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateTienLuong",
                        grvTienLuong.GetFocusedRowCellValue("ID_LCB"),
                        idcn,
                          ID_TOLookUpEdit.EditValue,
                          ID_CVLookUpEdit.EditValue,
                          ID_NKLookUpEdit.EditValue,
                          NGAY_KYDateEdit.EditValue,
                          SO_QUYET_DINHTextEdit.EditValue,
                          NGAY_HIEU_LUCDateEdit.EditValue,
                          NGACH_LUONGLookUpEdit.EditValue,
                          BAC_LUONGLookUpEdit.EditValue,
                          GHI_CHUTextEdit.EditValue,
                          HS_LUONGTextEdit.EditValue == "" ? 0 : HS_LUONGTextEdit.EditValue,
                          LUONG_CO_BANTextEdit.EditValue == "" ? 0 : LUONG_CO_BANTextEdit.EditValue,
                          MUC_LUONG_THUCTextEdit.EditValue == "" ? 0 : MUC_LUONG_THUCTextEdit.EditValue,
                          THUONG_CHUYEN_CANTextEdit.EditValue == "" ? 0 : THUONG_CHUYEN_CANTextEdit.EditValue,
                          PC_DOC_HAITextEdit.EditValue == "" ? 0 : PC_DOC_HAITextEdit.EditValue,
                          THUONG_HT_CVTextEdit.EditValue == "" ? 0 : THUONG_HT_CVTextEdit.EditValue,
                          PC_KY_NANGTextEdit.EditValue == "" ? 0 : PC_KY_NANGTextEdit.EditValue,
                          PC_SINH_HOATTextEdit.EditValue == "" ? 0 : PC_SINH_HOATTextEdit.EditValue,
                          PC_CON_NHOTextEdit.EditValue == "" ? 0 : PC_CON_NHOTextEdit.EditValue,
                          cothem));
                LoadgrdTienLuong(n);
                //--thêm phụ lục hợp đồng  cho công nhân đó
                //-- lấy id hợp đông lao động theo công nhân kèm điều kiện ngày lớn nhất
                try
                {
                    int idhd = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT ID_HDLD FROM dbo.HOP_DONG_LAO_DONG WHERE ID_CN = " + idcn + " AND  NGAY_BAT_DAU_HD = (SELECT MAX(NGAY_BAT_DAU_HD) FROM dbo.HOP_DONG_LAO_DONG WHERE ID_CN = " + idcn + ")"));


                    string sophieu = SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT MAX(SO_PLHD) + 1 FROM dbo.PHU_LUC_HDLD WHERE ID_HDLD = " + idhd + "").ToString();

                    if (idhd != 0)
                    {
                        if (Convert.ToDouble(MUC_LUONG_THUCTextEdit.EditValue) != luongthucold)
                        {
                            //insert vào phụ hợp đồng
                            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spUpdatetPhuLucHopDong",
                    idhd,
                    sophieu == "" ? "1" : sophieu,
                    sophieu == "" ? "1" : sophieu,
                    string.Format(Commons.Modules.ObjSystems.ThongTinChung()["PL_NOI_DUNG_THAY_DOI"].ToString(), string.Format("{0:N0}", luongthucold), string.Format("{0:N0}",  MUC_LUONG_THUCTextEdit.EditValue)),
                    string.Format(Commons.Modules.ObjSystems.ThongTinChung()["PL_THOI_GIAN_THUC_HIEN"].ToString(), DateTime.Now.Day, DateTime.Now.Date.Month, DateTime.Now.Date.Year),
                   NGAY_KYDateEdit.EditValue,
                   ID_NKLookUpEdit.EditValue,
                   Commons.Modules.ObjSystems.ThongTinChung()["PL_GHI_CHU"].ToString(),
                   1
               );
                        }
                    }
                }
                catch (Exception ex)
                {
                }

            }
            catch (Exception ex)
            { }
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteTienLuong"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.LUONG_CO_BAN WHERE ID_LCB = " + grvTienLuong.GetFocusedRowCellValue("ID_LCB") + "");
                grvTienLuong.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelKhongThanhCong") + "\n" + ex.Message.ToString());
            }
        }
        #endregion
        #region sự kiện form
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
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
                        if (grvTienLuong.RowCount == 0) return;
                        try
                        {

                            if (grvTienLuong.GetFocusedRowCellValue("ID_LCB").ToString() == "")
                            {
                                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgVuilongchondulieucansua"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeSua"), MessageBoxButtons.OK, MessageBoxIcon.Hand); return;
                            }
                        }
                        catch (Exception)
                        {
                            XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgVuilongchondulieucansua"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeSua"), MessageBoxButtons.OK, MessageBoxIcon.Hand); return;
                        }
                        cothem = false;
                        enableButon(false);
                        break;
                    }

                case "xoa":
                    {
                        if (grvTienLuong.RowCount == 0) return;
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
        private void grvTienLuong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
        }
        #endregion
        private void UcTienLuong_Load(object sender, EventArgs e)
        {
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TOLookUpEdit, Commons.Modules.ObjSystems.DataTo(-1, -1, false), "ID_TO", "TEN_TO", "TEN_TO");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_NKLookUpEdit, Commons.Modules.ObjSystems.DataNguoiKy(), "ID_NK", "HO_TEN", "HO_TEN");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_CVLookUpEdit, Commons.Modules.ObjSystems.DataChucVu(false), "ID_CV", "TEN_CV", "TEN_CV");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(NGACH_LUONGLookUpEdit, Commons.Modules.ObjSystems.DataNgachLuong(false), "ID_NL", "TEN_NL", "TEN_NL");
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(BAC_LUONGLookUpEdit, Commons.Modules.ObjSystems.DataBacLuong(Convert.ToInt32(NGACH_LUONGLookUpEdit.EditValue), false), "ID_BL", "TEN_BL", "TEN_BL");
            enableButon(true);
            LoadgrdTienLuong(-1);
            Commons.Modules.sPS = "";
        }
        private void NGACH_LUONGLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            Commons.Modules.ObjSystems.MLoadLookUpEdit(BAC_LUONGLookUpEdit, Commons.Modules.ObjSystems.DataBacLuong(Convert.ToInt32(NGACH_LUONGLookUpEdit.EditValue), false), "ID_BL", "TEN_BL", "TEN_BL");
        }
        private void BAC_LUONGLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            //load bật lương vào
            if (BAC_LUONGLookUpEdit.EditValue == "") return;
            DataTable dt = new DataTable();
            try
            {
                string sSql = "SELECT * FROM dbo.BAC_LUONG WHERE ID_BL = " + BAC_LUONGLookUpEdit.EditValue + "";
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                HS_LUONGTextEdit.EditValue = dt.Rows[0]["MUC_LUONG"];
                PC_DOC_HAITextEdit.EditValue = dt.Rows[0]["PC_DH"];
                THUONG_HT_CVTextEdit.EditValue = dt.Rows[0]["THUONG_TC"];
                THUONG_CHUYEN_CANTextEdit.EditValue = dt.Rows[0]["THUONG_CV_CC"];
                PC_SINH_HOATTextEdit.EditValue = dt.Rows[0]["PC_SINH_HOAT"];
                PC_KY_NANGTextEdit.EditValue = dt.Rows[0]["PC_KY_NANG"];
                LUONG_CO_BANTextEdit.EditValue = Convert.ToDouble(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT [dbo].[funGetLuongToiThieu](" + Commons.Modules.iCongNhan+",'"+ NGAY_HIEU_LUCDateEdit.DateTime.ToString("MM/dd/yyyy") +"')"));
                //PC_CON_NHOTextEdit
                PC_CON_NHOTextEdit.EditValue = Convert.ToDouble(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT dbo.[funGetPhuCapConNho](" + Commons.Modules.iCongNhan + ")"));
            }
            catch (Exception ex)
            { }
            Commons.Modules.sPS = "";
        }
        private void GrdTienLuong_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }
        }

        private void HS_LUONGTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                MUC_LUONG_THUCTextEdit.EditValue = Convert.ToDouble(HS_LUONGTextEdit.EditValue) + Convert.ToDouble(PC_DOC_HAITextEdit.EditValue) + Convert.ToDouble(PC_KY_NANGTextEdit.EditValue) + Convert.ToDouble(PC_SINH_HOATTextEdit.EditValue) + Convert.ToDouble(PC_CON_NHOTextEdit.EditValue) + Convert.ToDouble(THUONG_CHUYEN_CANTextEdit.EditValue) + Convert.ToDouble(THUONG_HT_CVTextEdit.EditValue);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
