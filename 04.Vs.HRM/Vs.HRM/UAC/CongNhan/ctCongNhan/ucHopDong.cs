﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraLayout;
namespace Vs.HRM
{
    public partial class ucHopDong : DevExpress.XtraEditors.XtraUserControl
    {
        Int64 idcn = 0;
        bool cothem = false;
        DataTable tableTTC_CN = new DataTable();
        public ucHopDong(Int64 id)
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, new List<LayoutControlGroup>() { Root }, windowsUIButton);
            idcn = id;
        }
        private void UcHopDong_Load(object sender, EventArgs e)
        {
            formatText();
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LHDLDLookUpEdit, Commons.Modules.ObjSystems.DataLoaiHDLD(false), "ID_LHDLD", "TEN_LHDLD", "TEN_LHDLD");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_CVLookUpEdit, Commons.Modules.ObjSystems.DataChucVu(false), "ID_CV", "TEN_CV", "TEN_CV");
            Commons.Modules.ObjSystems.MLoadLookUpEdit(NGUOI_KY_GIA_HANLookUpEdit, Commons.Modules.ObjSystems.DataNguoiKy(), "ID_NK", "HO_TEN", "HO_TEN");
            LoadgrdHopDong(-1);
            enableButon(true);
        }

        private void formatText()
        {
            LUONG_THU_VIECTextEdit.Properties.Mask.EditMask = "N" + Commons.Modules.iSoLeTT.ToString() + "";
            MUC_LUONG_CHINHTextEdit.Properties.Mask.EditMask = "N" + Commons.Modules.iSoLeTT.ToString() + "";
            CHI_SO_PHU_CAPTextEdit.Properties.Mask.EditMask = "N" + Commons.Modules.iSoLeTT.ToString() + "";
            MUC_LUONG_THUC_LINHTextEdit.Properties.Mask.EditMask = "N" + Commons.Modules.iSoLeTT.ToString() + "";
        }


        private void WindowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
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
                        if (grvHopDong.RowCount == 0) return;
                        cothem = false;
                        enableButon(false);
                        break;
                    }

                case "xoa":
                    {
                        if (grvHopDong.RowCount == 0) return;
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
                        Commons.Modules.ObjSystems.GotoHome(this);
                        break;
                    }
                case "phuluchd":
                    {
                        try
                        {
                            if (grvHopDong.GetFocusedRowCellValue("ID_HDLD").ToString() == "")
                            {
                                XtraMessageBox.Show("bạn cần chọn một hợp đồng cần xem mục lục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            XtraMessageBox.Show("bạn cần chọn một hợp đồng cần xem mục lục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        frmPhuLucHDLD pl = new frmPhuLucHDLD(ItemForSO_HDLD.Text + " :" + SO_HDLDTextEdit.EditValue.ToString(), ItemForNGAY_BAT_DAU_HD.Text +" :"+ NGAY_BAT_DAU_HDDateEdit.DateTime.Date.ToShortDateString(), Convert.ToInt32(grvHopDong.GetFocusedRowCellValue("ID_HDLD")));
                        pl.ShowDialog();
                        break;
                    }
                case "thaydoitk":
                    {
                        try
                        {
                            if (grvHopDong.GetFocusedRowCellValue("ID_HDLD").ToString() == "")
                            {
                                XtraMessageBox.Show("bạn cần chọn một hợp đồng để thay đổi thông tin bảo hiểm y tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            XtraMessageBox.Show("bạn cần chọn một hợp đồng để thay đổi thông tin bảo hiểm y tế", "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                        frmToKhaiBHXH bhyt = new frmToKhaiBHXH(ItemForSO_HDLD.Text + " :" + SO_HDLDTextEdit.EditValue.ToString(), ItemForNGAY_BAT_DAU_HD.Text + " :" + NGAY_BAT_DAU_HDDateEdit.DateTime.Date.ToShortDateString(), Convert.ToInt32(grvHopDong.GetFocusedRowCellValue("ID_HDLD")));
                        bhyt.ShowDialog();
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
            windowsUIButton.Buttons[4].Properties.Visible = visible;
            windowsUIButton.Buttons[5].Properties.Visible = visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;
            windowsUIButton.Buttons[7].Properties.Visible = !visible;
            windowsUIButton.Buttons[8].Properties.Visible = !visible;
            windowsUIButton.Buttons[9].Properties.Visible = visible;
            grdHopDong.Enabled = visible;
            SO_HDLDTextEdit.Properties.ReadOnly = visible;
            STT_HDLDTextEdit.Properties.ReadOnly = visible;
            ID_LHDLDLookUpEdit.Properties.ReadOnly = visible;
            NGAY_BAT_DAU_HDDateEdit.Properties.ReadOnly = visible;
            NGAY_HET_HDDateEdit.Properties.ReadOnly = visible;
            NGAY_KYDateEdit.Properties.ReadOnly = visible;
            HD_GIA_HANCheckEdit.Properties.ReadOnly = visible;
            NGAY_BD_THU_VIECDateEdit.Properties.ReadOnly = visible;
            NGAY_KT_THU_VIECDateEdit.Properties.ReadOnly = visible;
            LUONG_THU_VIECTextEdit.Properties.ReadOnly = visible;
            BAC_LUONGTextEdit.Properties.ReadOnly = visible;
            MUC_LUONG_CHINHTextEdit.Properties.ReadOnly = visible;
            CHI_SO_PHU_CAPTextEdit.Properties.ReadOnly = visible;
            MUC_LUONG_THUC_LINHTextEdit.Properties.ReadOnly = visible;
            DIA_DIEM_LAM_VIECTextEdit.Properties.ReadOnly = visible;
            PHUONG_TIENTextEdit.Properties.ReadOnly = visible;
            DIA_CHI_NOI_LAM_VIECTextEdit.Properties.ReadOnly = visible;
            PHU_CAPTextEdit.Properties.ReadOnly = visible;
            CONG_VIECTextEdit.Properties.ReadOnly = visible;
            ID_CVLookUpEdit.Properties.ReadOnly = visible;
            CHE_DO_LAM_VIECTextEdit.Properties.ReadOnly = visible;
            LAN_TRA_LUONGTextEdit.Properties.ReadOnly = visible;
            DCLDTextEdit.Properties.ReadOnly = visible;
            BHLDTextEdit.Properties.ReadOnly = visible;
            CHE_DO_DAO_TAOTextEdit.Properties.ReadOnly = visible;
            SO_NGAY_PHEPTextEdit.Properties.ReadOnly = visible;
            HINH_THUC_TRA_LUONGTextEdit.Properties.ReadOnly = visible;
            NGUOI_KY_GIA_HANLookUpEdit.Properties.ReadOnly = visible;
            CHE_DO_NANG_LUONGTextEdit.Properties.ReadOnly = visible;
            KHOAN_KHACTextEdit.Properties.ReadOnly = visible;

        }
        private void Bindingdata(bool bthem)
        {
            Commons.Modules.sPS = "0Load";
            if (bthem == true)
            {
                //lấy dữ liệu mặc định theo id công nhân
                try
                {
                    SO_HDLDTextEdit.EditValue = "";
                    STT_HDLDTextEdit.EditValue = "";
                    //ID_LHDLDLookUpEdit.EditValue,
                    if (grvHopDong.RowCount == 0)
                    {
                        NGAY_BAT_DAU_HDDateEdit.EditValue = DateTime.Today;
                    }
                    else
                    {
                        DataTable table = new DataTable();
                        table = (DataTable)grdHopDong.DataSource;
                        var result = table.AsEnumerable().First(x => x.Field<DateTime>("NGAY_HET_HD") == table.AsEnumerable().Max(y => y.Field<DateTime>("NGAY_HET_HD")))["NGAY_HET_HD"];
                        NGAY_BAT_DAU_HDDateEdit.EditValue = Convert.ToDateTime(result).AddDays(1);
                    }
                    NGAY_KYDateEdit.EditValue = DateTime.Today;
                    HD_GIA_HANCheckEdit.EditValue = true;
                    NGAY_BD_THU_VIECDateEdit.EditValue = null;
                    NGAY_KT_THU_VIECDateEdit.EditValue = null;
                    LUONG_THU_VIECTextEdit.EditValue = 0;
                    BAC_LUONGTextEdit.EditValue = Commons.Modules.ObjSystems.BLMCPC(idcn,NGAY_BAT_DAU_HDDateEdit.DateTime)["BL"];
                    MUC_LUONG_CHINHTextEdit.EditValue = Commons.Modules.ObjSystems.BLMCPC(idcn, NGAY_BAT_DAU_HDDateEdit.DateTime)["ML"];
                    CHI_SO_PHU_CAPTextEdit.EditValue = Commons.Modules.ObjSystems.BLMCPC(idcn, NGAY_BAT_DAU_HDDateEdit.DateTime)["PC"];
                    MUC_LUONG_THUC_LINHTextEdit.EditValue = Convert.ToDouble(MUC_LUONG_CHINHTextEdit.EditValue) + Convert.ToDouble(CHI_SO_PHU_CAPTextEdit.EditValue);
                    DIA_DIEM_LAM_VIECTextEdit.EditValue = "";
                    PHUONG_TIENTextEdit.EditValue = "";
                    DIA_CHI_NOI_LAM_VIECTextEdit.EditValue = "";
                    PHU_CAPTextEdit.EditValue = 0;
                    CONG_VIECTextEdit.EditValue = "";
                    //ID_CVLookUpEdit.EditValue
                    CHE_DO_LAM_VIECTextEdit.EditValue = "";
                    LAN_TRA_LUONGTextEdit.EditValue = "";
                    DCLDTextEdit.EditValue = "";
                    BHLDTextEdit.EditValue = "";
                    CHE_DO_DAO_TAOTextEdit.EditValue = "";
                    SO_NGAY_PHEPTextEdit.EditValue = "";
                    HINH_THUC_TRA_LUONGTextEdit.EditValue = "";
                    NGUOI_KY_GIA_HANLookUpEdit.EditValue = "";
                    CHE_DO_NANG_LUONGTextEdit.EditValue = "";
                    KHOAN_KHACTextEdit.EditValue = "";
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {

                    SO_HDLDTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("SO_HDLD");
                    STT_HDLDTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("STT_HDLD");
                    ID_LHDLDLookUpEdit.EditValue = Convert.ToInt32(grvHopDong.GetFocusedRowCellValue("ID_LHDLD"));
                    NGAY_BAT_DAU_HDDateEdit.EditValue = Convert.ToDateTime(grvHopDong.GetFocusedRowCellValue("NGAY_BAT_DAU_HD"));
                    NGAY_HET_HDDateEdit.EditValue = Convert.ToDateTime(grvHopDong.GetFocusedRowCellValue("NGAY_HET_HD"));
                    NGAY_KYDateEdit.EditValue = Convert.ToDateTime(grvHopDong.GetFocusedRowCellValue("NGAY_KY"));
                    HD_GIA_HANCheckEdit.EditValue = Convert.ToBoolean(grvHopDong.GetFocusedRowCellValue("HD_GIA_HAN"));
                    NGAY_BD_THU_VIECDateEdit.EditValue = grvHopDong.GetFocusedRowCellValue("NGAY_BD_THU_VIEC");
                    NGAY_KT_THU_VIECDateEdit.EditValue = grvHopDong.GetFocusedRowCellValue("NGAY_KT_THU_VIEC");
                    LUONG_THU_VIECTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("LUONG_THU_VIEC");
                    BAC_LUONGTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("BAC_LUONG");
                    MUC_LUONG_CHINHTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("MUC_LUONG_CHINH");
                    CHI_SO_PHU_CAPTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("CHI_SO_PHU_CAP");
                    MUC_LUONG_THUC_LINHTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("MUC_LUONG_THUC_LINH");
                    DIA_DIEM_LAM_VIECTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("DIA_DIEM_LAM_VIEC");
                    PHUONG_TIENTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("PHUONG_TIEN");
                    DIA_CHI_NOI_LAM_VIECTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("DIA_CHI_NOI_LAM_VIEC");
                    PHU_CAPTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("PHU_CAP");
                    CONG_VIECTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("CONG_VIEC");
                    ID_CVLookUpEdit.EditValue = Convert.ToInt32(grvHopDong.GetFocusedRowCellValue("ID_CV"));
                    CHE_DO_LAM_VIECTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("CHE_DO_LAM_VIEC");
                    LAN_TRA_LUONGTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("LAN_TRA_LUONG");
                    DCLDTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("DCLD");
                    BHLDTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("BHLD");
                    CHE_DO_DAO_TAOTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("CHE_DO_DAO_TAO");
                    SO_NGAY_PHEPTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("SO_NGAY_PHEP");
                    HINH_THUC_TRA_LUONGTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("HINH_THUC_TRA_LUONG");
                    NGUOI_KY_GIA_HANLookUpEdit.EditValue = Convert.ToInt32(grvHopDong.GetFocusedRowCellValue("NGUOI_KY_GIA_HAN"));
                    CHE_DO_NANG_LUONGTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("CHE_DO_NANG_LUONG");
                    KHOAN_KHACTextEdit.EditValue = grvHopDong.GetFocusedRowCellValue("KHOAN_KHAC");

                }
                catch (Exception ex)
                {
                }
            }
        }
        private void SaveData()
        {
            try
            {
                int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateHopDong",
              grvHopDong.GetFocusedRowCellValue("ID_HDLD"),
            idcn,
            SO_HDLDTextEdit.EditValue,
            STT_HDLDTextEdit.EditValue,
            ID_LHDLDLookUpEdit.EditValue,
            NGAY_BAT_DAU_HDDateEdit.EditValue,
            NGAY_HET_HDDateEdit.EditValue,
            NGAY_KYDateEdit.EditValue,
            HD_GIA_HANCheckEdit.EditValue,
            NGAY_BD_THU_VIECDateEdit.EditValue,
            NGAY_KT_THU_VIECDateEdit.EditValue,
            LUONG_THU_VIECTextEdit.EditValue,
            BAC_LUONGTextEdit.EditValue,
            MUC_LUONG_CHINHTextEdit.EditValue,
            CHI_SO_PHU_CAPTextEdit.EditValue,
            MUC_LUONG_THUC_LINHTextEdit.EditValue,
            DIA_DIEM_LAM_VIECTextEdit.EditValue,
            PHUONG_TIENTextEdit.EditValue,
            DIA_CHI_NOI_LAM_VIECTextEdit.EditValue,
            PHU_CAPTextEdit.EditValue,
            CONG_VIECTextEdit.EditValue,
            ID_CVLookUpEdit.EditValue,
            CHE_DO_LAM_VIECTextEdit.EditValue,
            LAN_TRA_LUONGTextEdit.EditValue,
            DCLDTextEdit.EditValue,
            BHLDTextEdit.EditValue,
            CHE_DO_DAO_TAOTextEdit.EditValue,
            SO_NGAY_PHEPTextEdit.EditValue,
            HINH_THUC_TRA_LUONGTextEdit.EditValue,
            NGUOI_KY_GIA_HANLookUpEdit.EditValue,
            CHE_DO_NANG_LUONGTextEdit.EditValue,
            KHOAN_KHACTextEdit.EditValue,
            cothem
                ));
                LoadgrdHopDong(n);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteKhoaDaoTao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.HOP_DONG_LAO_DONG WHERE ID_HDLD =" + grvHopDong.GetFocusedRowCellValue("ID_HDLD") + "");
                grvHopDong.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        private void LoadgrdHopDong(int id)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListHopDong", idcn, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_HDLD"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdHopDong, grvHopDong, dt, false, true, true, true, true, this.Name);
            grvHopDong.Columns["ID_HDLD"].Visible = false;
            grvHopDong.Columns["ID_LHDLD"].Visible = false;
            grvHopDong.Columns["HD_GIA_HAN"].Visible = false;
            grvHopDong.Columns["NGAY_BD_THU_VIEC"].Visible = false;
            grvHopDong.Columns["NGAY_KT_THU_VIEC"].Visible = false;
            grvHopDong.Columns["LUONG_THU_VIEC"].Visible = false;
            grvHopDong.Columns["BAC_LUONG"].Visible = false;
            grvHopDong.Columns["MUC_LUONG_CHINH"].Visible = false;
            grvHopDong.Columns["CHI_SO_PHU_CAP"].Visible = false;
            grvHopDong.Columns["MUC_LUONG_THUC_LINH"].Visible = false;
            grvHopDong.Columns["DIA_DIEM_LAM_VIEC"].Visible = false;
            grvHopDong.Columns["PHUONG_TIEN"].Visible = false;
            grvHopDong.Columns["DIA_CHI_NOI_LAM_VIEC"].Visible = false;
            grvHopDong.Columns["PHU_CAP"].Visible = false;
            grvHopDong.Columns["CONG_VIEC"].Visible = false;
            grvHopDong.Columns["ID_CV"].Visible = false;
            grvHopDong.Columns["CHE_DO_LAM_VIEC"].Visible = false;
            grvHopDong.Columns["LAN_TRA_LUONG"].Visible = false;
            grvHopDong.Columns["DCLD"].Visible = false;
            grvHopDong.Columns["BHLD"].Visible = false;
            grvHopDong.Columns["CHE_DO_DAO_TAO"].Visible = false;
            grvHopDong.Columns["SO_NGAY_PHEP"].Visible = false;
            grvHopDong.Columns["HINH_THUC_TRA_LUONG"].Visible = false;
            grvHopDong.Columns["NGUOI_KY_GIA_HAN"].Visible = false;
            grvHopDong.Columns["CHE_DO_NANG_LUONG"].Visible = false;
            grvHopDong.Columns["KHOAN_KHAC"].Visible = false;
            if (id != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(id));
                grvHopDong.FocusedRowHandle = grvHopDong.GetRowHandle(index);
            }
        }
        private void GrvHopDong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Bindingdata(false);
        }

        private void GrdHopDong_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteData();
            }
        }

        private void ID_LHDLDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //cộng ngày kết thúc hợp đồng lên theo số tháng
            int ithang = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT SO_THANG FROM dbo.LOAI_HDLD WHERE ID_LHDLD = " + ID_LHDLDLookUpEdit.EditValue + ""));
            if (ithang == 0)
            {
                NGAY_HET_HDDateEdit.EditValue = null;
            }
            else
            {
                NGAY_HET_HDDateEdit.EditValue = NGAY_BAT_DAU_HDDateEdit.DateTime.AddMonths(ithang);
            }
                BAC_LUONGTextEdit.EditValue = Commons.Modules.ObjSystems.BLMCPC(idcn, NGAY_BAT_DAU_HDDateEdit.DateTime)["BL"];
                MUC_LUONG_CHINHTextEdit.EditValue = Commons.Modules.ObjSystems.BLMCPC(idcn, NGAY_BAT_DAU_HDDateEdit.DateTime)["ML"];
                CHI_SO_PHU_CAPTextEdit.EditValue = Commons.Modules.ObjSystems.BLMCPC(idcn, NGAY_BAT_DAU_HDDateEdit.DateTime)["PC"];
                MUC_LUONG_THUC_LINHTextEdit.EditValue = Convert.ToDouble(MUC_LUONG_CHINHTextEdit.EditValue) + Convert.ToDouble(CHI_SO_PHU_CAPTextEdit.EditValue);
        }

        private void NGAY_BD_THU_VIECDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            NGAY_KT_THU_VIECDateEdit.EditValue = NGAY_BD_THU_VIECDateEdit.DateTime.AddMonths(2);
        }

        private void MUC_LUONG_CHINHTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            MUC_LUONG_THUC_LINHTextEdit.EditValue = Convert.ToDouble(MUC_LUONG_CHINHTextEdit.EditValue) + Convert.ToDouble(CHI_SO_PHU_CAPTextEdit.EditValue);
        }

        private void windowsUIButton_Click(object sender, EventArgs e)
        {

        }
    }
}
