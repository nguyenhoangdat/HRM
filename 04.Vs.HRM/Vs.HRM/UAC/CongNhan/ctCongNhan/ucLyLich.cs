using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using System.IO;
using DevExpress.XtraBars.Docking2010;
namespace Vs.HRM
{
    public partial class ucLyLich : DevExpress.XtraEditors.XtraUserControl
    {
        bool cothem = false;
        public ucLyLich(Int64 id)
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this,Root,Tab, windowsUIButton);
        }
        private void ucLyLich_Load(object sender, EventArgs e)
        {
            Commons.Modules.sPS = "0Load";
            //ID_QGLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_QGLookUpEdit, Commons.Modules.ObjSystems.DataQuocGia(false), "ID_QG", "TEN_QG", "TEN_QG");
            //ID_TOLookupEdit
            //ID_CVLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_CVLookUpEdit, Commons.Modules.ObjSystems.DataChucVu(false), "ID_CV", "TEN_CV", "TEN_CV");

            //ID_LCVLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LCVLookUpEdit, Commons.Modules.ObjSystems.DataLoaiCV(false), "ID_LCV", "TEN_LCV", "TEN_LCV");

            //ID_LHDLDLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LHDLDLookUpEdit, Commons.Modules.ObjSystems.DataLoaiHDLD(false), "ID_LHDLD", "TEN_LHDLD", "TEN_LHDLD");

            //ID_TT_HDLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TT_HDLookUpEdit, Commons.Modules.ObjSystems.DataTinHTrangHD(false), "ID_TT_HD", "TEN_TT_HD", "TEN_TT_HD");

            //ID_TT_HTLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TT_HTLookUpEdit, Commons.Modules.ObjSystems.DataTinHTrangHT(false), "ID_TT_HT", "TEN_TT_HT", "TEN_TT_HT");
            //HINH_THUC_TUYENLookUpEdit populor

            //ID_LD_TVLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LD_TVLookUpEdit, Commons.Modules.ObjSystems.DataLyDoThoiViec(), "ID_LD_TV", "TEN_LD_TV", "TEN_LD_TV");
            //ID_DTLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_DTLookUpEdit, Commons.Modules.ObjSystems.DataDanToc(false), "ID_DT", "TEN_DT", "TEN_DT");
            ////////TON_GIAOLookUpEdit populor
            ////////NOI_SINHLookUpEdit populor
            ////////NGUYEN_QUANLookUpEdit populor

            //NOI_CAPLookupEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(NOI_CAPLookupEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue), false), "ID_TP", "TEN_TP", "TEN_TP");
            //ID_TT_HNLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TT_HNLookUpEdit, Commons.Modules.ObjSystems.DataTinHTrangHN(false), "ID_TT_HN", "TEN_TT_HN", "TEN_TT_HN");
            //ID_TPLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TPLookUpEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue), false), "ID_TP", "TEN_TP", "TEN_TP");
            //ID_QUANLookEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_QUANLookEdit, Commons.Modules.ObjSystems.DataQuan(Convert.ToInt32(ID_TPLookUpEdit.EditValue), false), "ID_QUAN", "TEN_QUAN", "TEN_QUAN");
            //ID_PXLookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_PXLookUpEdit, Commons.Modules.ObjSystems.DataPhuongXa(Convert.ToInt32(ID_QUANLookEdit.EditValue), false), "ID_PX", "TEN_PX", "TEN_PX");
            //ID_TP_TAM_TRULookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TP_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue), false), "ID_TP", "TEN_TP", "TEN_TP");
            //ID_QUAN_TAM_TRULookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_QUAN_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataQuan(Convert.ToInt32(ID_TP_TAM_TRULookUpEdit.EditValue), false), "ID_QUAN", "TEN_QUAN", "TEN_QUAN");
            //ID_PX_TAM_TRULookUpEdit
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_PX_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataPhuongXa(Convert.ToInt32(ID_QUAN_TAM_TRULookUpEdit.EditValue), false), "ID_PX", "TEN_PX", "TEN_PX");
            //đơn vị 
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_DVLookUpEdit, Commons.Modules.ObjSystems.DataDonVi(), "ID_DV", "TEN_DV", "TEN_DV");
            //xí nghiệp 
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_XNLookUpEdit, Commons.Modules.ObjSystems.DataXiNghiep(Convert.ToInt32(ID_DVLookUpEdit.EditValue)), "ID_XN", "TEN_XN", "TEN_XN");
            //tổ
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_TOLookupEdit, Commons.Modules.ObjSystems.DataTo(Convert.ToInt32(ID_DVLookUpEdit.EditValue), Convert.ToInt32(ID_XNLookUpEdit.EditValue), true), "ID_TO", "TEN_TO", "TEN_TO");
            //ID_LOAI_TDLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LOAI_TDLookUpEdit, Commons.Modules.ObjSystems.DataLoaiTrinhDo(false), "ID_LOAI_TD", "TEN_LOAI_TD", "TEN_LOAI_TD");
            //ID_TDVHLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TDVHLookUpEdit, Commons.Modules.ObjSystems.DataTDVH(Convert.ToInt32(ID_LOAI_TDLookUpEdit.EditValue), false), "ID_LOAI_TD", "TEN_LOAI_TD", "TEN_LOAI_TD");
            //LOAI_QUOC_TICHLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(LOAI_QUOC_TICHLookUpEdit, Commons.Modules.ObjSystems.DataLoaiQuocTich(false), "ID_LOAI_QT", "TEN_LOAI_QT", "TEN_LOAI_QT");
            //CAP_GIAY_PHEPLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(CAP_GIAY_PHEPLookUpEdit, Commons.Modules.ObjSystems.DataCapGiayPhep(false), "ID_CAP_GIAY_PHEP", "TEN_CAP_GIAY_PHEP", "TEN_CAP_GIAY_PHEP");
            Commons.Modules.sPS = "";
            enableButon(true);
            BinDingData(cothem);
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        cothem = true;
                        BinDingData(true);
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
                        //DeleteData();
                        break;
                    }
                case "luu":
                    {
                        if (!dxValidationProvider1.Validate()) return;
                        try
                        {
                            SaveData();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message.ToString());
                            break;
                        }
                        enableButon(true);
                        break;
                    }
                case "khongluu":
                    {
                        BinDingData(false);
                        enableButon(true);
                        dxValidationProvider1.Validate();
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        Application.Exit();
                        break;
                    }
                case "giadinh":
                    {
                        frmGiaDinh gd = new frmGiaDinh(HOTextEdit.EditValue + " " + TENTextEdit.EditValue);
                        gd.ShowDialog();
                        break;
                    }
                case "doanthe":
                    {
                        frmDoanThe gd = new frmDoanThe();
                        gd.ShowDialog();
                        break;
                    }

                case "lienlac":
                    {
                        frmThongTinLienLac gd = new frmThongTinLienLac(HOTextEdit.EditValue + " " + TENTextEdit.EditValue);
                        gd.ShowDialog();
                        break;
                    }
                default:
                    break;
            }

        }
        #region function load
        #endregion

        #region function dung chung
        private void LoadNgonNgu()
        {
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT KEYWORD,VIETNAM AS NN FROM dbo.LANGUAGES WHERE	FORM = 'ucLyLich'"));

            //if (Tab.SelectedTabPage == groupThongTinBoXung)
            //{
            ItemForMS_CN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "MS_CN", this.Name);
            ItemForMS_THE_CC.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "MS_THE_CC", this.Name);
            ItemForVAO_LAM_LAI.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "VAO_LAM_LAI", this.Name);
            ItemForHO.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "HO", this.Name);
            ItemForTEN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "TEN", this.Name);
            ItemForID_QG.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_QG", this.Name);
            ItemForNGAY_SINH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_SINH", this.Name);
            ItemForNAM_SINH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NAM_SINH", this.Name);
            ItemForPHAI.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "PHAI", this.Name);
            ItemForID_TO.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TO", this.Name);
            ItemForID_DV.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_DV", this.Name);
            ItemForID_XN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_XN", this.Name);
            ItemForID_CV.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_CV", this.Name);
            ItemForID_LCV.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_LCV", this.Name);
            ItemForID_LHDLD.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_LHDLD", this.Name);
            ItemForNGAY_HOC_VIEC.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_HOC_VIEC", this.Name);
            ItemForNGAY_THU_VIEC.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_THU_VIEC", this.Name);
            ItemForNGAY_VAO_LAM.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_VAO_LAM", this.Name);
            ItemForID_TT_HD.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TT_HD", this.Name);
            ItemForID_TT_HT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TT_HT", this.Name);
            ItemForHINH_THUC.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "HINH_THUC_TUYEN", this.Name);
            ItemForPHEP_CT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "PHEP_CT", this.Name);
            ItemForPHEP_CD.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "PHEP_CD", this.Name);
            ItemForTHAM_GIA_BHXH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "THAM_GIA_BHXH", this.Name);
            ItemForLD_TINH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LD_TINH", this.Name);
            ItemForLAO_DONG_CONG_NHAT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LAO_DONG_CONG_NHAT", this.Name);
            ItemForTRUC_TIEP_SX.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "TRUC_TIEP_SX", this.Name);
            ItemForNGAY_NGHI_VIEC.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_NGHI_VIEC", this.Name);
            ItemForID_LD_TV.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_LD_TV", this.Name);
            ItemForGHI_CHU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "GHI_CHU", this.Name);
            VAO_LAM_LAICheckEdit.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "VAO_LAM_LAI", this.Name);
            TRUC_TIEP_SXCheckEdit.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "TRUC_TIEP_SX", this.Name);
            PHAICheckEdit.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "PHAI", this.Name);
            LAO_DONG_CNCheckEdit.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LAO_DONG_CONG_NHAT", this.Name);
            THAM_GIA_BHXHCheckEdit.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "THAM_GIA_BHXH", this.Name);
            LD_TINHCheckEdit.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LD_TINH", this.Name);


            //load ngon ngu tab 1
            ItemForMA_THE_ATM.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "MA_THE_ATM", this.Name);
            ItemForSO_CMND.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "SO_CMND", this.Name);
            ItemForID_DT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_DT", this.Name);
            ItemForEMAIL.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "EMAIL", this.Name);
            ItemForDT_DI_DONG.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "DT_DI_DONG", this.Name);
            ItemForSO_TAI_KHOAN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "SO_TAI_KHOAN", this.Name);
            ItemForNGAY_CAP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_CAP", this.Name);
            ItemForTON_GIAO.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "TON_GIAO", this.Name);
            ItemForNOI_SINH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NOI_SINH", this.Name);
            ItemForNOI_CAP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NOI_CAP", this.Name);
            ItemForMS_THUE.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "MS_THUE", this.Name);
            ItemForDT_NHA.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "DT_NHA", this.Name);
            ItemForDT_NGUOI_THAN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "DT_NGUOI_THAN", this.Name);
            ItemForTEN_KHONG_DAU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "TEN_KHONG_DAU", this.Name);
            ItemForID_TT_HN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TT_HN", this.Name);
            ItemForNGUYEN_QUAN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGUYEN_QUAN", this.Name);
            //}
            //else
            //    if (Tab.SelectedTabPage == groupTamTruThuongTru)
            //{
            //load task 2
            //ItemForDIA_CHI_THUONG_TRU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "DIA_CHI_THUONG_TRU", this.Name);
            ItemForID_TP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TP", this.Name);
            ItemForID_QUAN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_QUAN", this.Name);
            ItemForID_PX.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_PX", this.Name);
            ItemForTHON_XOM.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "THON_XOM", this.Name);
            ItemForSO_GIAY_PHEP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "SO_GIAY_PHEP", this.Name);
            ItemForNGAY_CAP_GP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_CAP_GP", this.Name);
            ItemForDIA_CHI_TAM_TRU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "DIA_CHI_TAM_TRU", this.Name);
            ItemForID_TP_TAM_TRU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TP_TAM_TRU", this.Name);
            ItemForID_QUAN_TAM_TRU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_QUAN_TAM_TRU", this.Name);
            ItemForID_PX_TAM_TRU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_PX_TAM_TRU", this.Name);
            ItemForTHON_XOM_TAM_TRU.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "THON_XOM_TAM_TRU", this.Name);
            ItemForCAP_GIAY_PHEP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "CAP_GIAY_PHEP", this.Name);
            ItemForNGAY_HH_GP.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_HH_GP", this.Name);
            //}
            //else
            //{
            //load task 3
            ItemForSO_BHXH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "SO_BHXH", this.Name);
            ItemForNGAY_DBHXH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_DBHXH", this.Name);
            ItemForNGAY_CHAM_DUT_NOP_BHXH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_CHAM_DUT", this.Name);
            ItemForNGAY_THU_HOI_BHYT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_THU_HOI", this.Name);
            //ItemForSO_THE.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "SO_THE", this.Name);
            //ItemForID_MS_TINH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_MS_TINH", this.Name);
            //ItemForID_BV.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_BV", this.Name);
            //ItemForNGAY_HH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_HH", this.Name);
            ItemForID_TDVH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TDVH", this.Name);
            ItemForID_LOAI_TD.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_LOAI_TD", this.Name);
            ItemForCHUYEN_MON.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "CHUYEN_MON", this.Name);
            ItemForLOAI_QUOC_TICH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LOAI_QUOC_TICH", this.Name);
            ItemForLD_NN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LD_NN", this.Name);
            ItemForNGAY_DBHXH_DT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_DBHXH_DT", this.Name);
            ItemForLD_GIAM_LDNN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LD_GIAM_LDNN", this.Name);
        }
        private void BinDingData(bool bthem)
        {
            if (bthem == true)
            {
                HINH_CNPictureEdit.EditValue = "";
                MS_CNTextEdit.EditValue = "";
                MS_THE_CCTextEdit.EditValue = "";
                VAO_LAM_LAICheckEdit.EditValue = false;
                HOTextEdit.EditValue = "";
                TENTextEdit.EditValue = "";
                //ID_QGLookUpEdit.EditValue = "";
                NGAY_SINHDateEdit.EditValue = DateTime.Today;
                NAM_SINHDateEdit.EditValue = DateTime.Today;
                PHAICheckEdit.EditValue = false;
                //ID_TOLookupEdit.EditValue = "";
                //ID_CVLookUpEdit.EditValue = "";
                //ID_LCVLookUpEdit.EditValue = "";
                //ID_LHDLDLookUpEdit.EditValue = "";
                NGAY_HOC_VIECDateEdit.EditValue = DateTime.Today;
                NGAY_THU_VIECDateEdit.EditValue = DateTime.Today;
                NGAY_VAO_LAMDateEdit.EditValue = DateTime.Today;
                //ID_TT_HDLookUpEdit.EditValue = "";
                //ID_TT_HTLookUpEdit.EditValue = "";
                HINH_THUC_TUYENTextEdit.EditValue = "";
                PHEP_CTTextEdit.EditValue = 0;
                PHEP_CDTextEdit.EditValue = 0;
                THAM_GIA_BHXHCheckEdit.EditValue = false;
                LD_TINHCheckEdit.EditValue = false;
                LAO_DONG_CNCheckEdit.EditValue = false;
                TRUC_TIEP_SXCheckEdit.EditValue = false;
                NGAY_NGHI_VIECDateEdit.EditValue = DateTime.Today;
                //ID_LD_TVLookUpEdit.EditValue = "";
                GHI_CHUMemoEdit.EditValue = "";
                //ID_DTLookUpEdit.EditValue = "";
                TON_GIAOTextEdit.EditValue = "";
                NOI_SINHTextEdit.EditValue = "";
                NGUYEN_QUANTextEdit.EditValue = "";
                SO_CMNDTextEdit.EditValue = "";
                NGAY_CAPDateEdit.EditValue = DateTime.Today;
                //NOI_CAPLookupEdit.EditValue = "";
                //ID_TT_HNLookUpEdit.EditValue = "";
                MA_THE_ATMTextEdit.EditValue = "";
                SO_TAI_KHOANTextEdit.EditValue = "";
                MS_THUETextEdit.EditValue = "";
                TEN_KHONG_DAUTextEdit.EditValue = "";
                LD_NNCheckEdit.EditValue = false;
                DT_DI_DONGTextEdit.EditValue = "";
                DT_NHATextEdit.EditValue = "";
                DT_NGUOI_THANTextEdit.EditValue = "";
                EMAILTextEdit.EditValue = "";
                DIA_CHI_THUONG_TRUTextEdit.EditValue = "";
                //ID_TPLookUpEdit.EditValue = "";
                //ID_QUANLookEdit.EditValue = "";
                //ID_PXLookUpEdit.EditValue = "";
                THON_XOMTextEdit.EditValue = "";
                DIA_CHI_TAM_TRUTextEdit.EditValue = "";
                //ID_TP_TAM_TRULookUpEdit.EditValue = "";
                //ID_QUAN_TAM_TRULookUpEdit.EditValue = "";
                //ID_PX_TAM_TRULookUpEdit.EditValue = "";
                THON_XOM_TAM_TRUTextEdit.EditValue = "";
                SO_BHXHTextEdit.EditValue = "";
                NGAY_DBHXHDateEdit.EditValue = DateTime.Today;
                NGAY_DBHXH_DTDateEdit.EditValue = DateTime.Today;
                NGAY_CHAM_DUT_NOP_BHXHDateEdit.EditValue = DateTime.Today;
                NGAY_THU_HOI_BHYTDateEdit.EditValue = DateTime.Today;
                //ID_TDVHLookUpEdit.EditValue = "";
                //ID_LOAI_TDLookUpEdit.EditValue = "";
                CHUYEN_MONTextEdit.EditValue = "";
                //LOAI_QUOC_TICHLookUpEdit.EditValue = "";
                //CAP_GIAY_PHEPLookUpEdit.EditValue = "";
                SO_GIAY_PHEPTextEdit.EditValue = "";
                NGAY_CAP_GPDateEdit.EditValue = DateTime.Today;
                NGAY_HH_GPDateEdit.EditValue = DateTime.Today;
                LD_GIAM_LDNNTextEdit.EditValue = "";
            }
            else
            {
                //lấy danh sách chi tiết công nhân 

                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListCTCongNhan", Commons.Modules.iCongNhan, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                try
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dt.Rows[0]["Hinh_CN"]);
                    MemoryStream mem = new MemoryStream(data);

                    HINH_CNPictureEdit.EditValue = Image.FromStream(mem);

                }
                catch
                {
                }
                MS_CNTextEdit.EditValue = dt.Rows[0]["MS_CN"];
                MS_THE_CCTextEdit.EditValue = dt.Rows[0]["MS_THE_CC"];
                VAO_LAM_LAICheckEdit.EditValue = dt.Rows[0]["VAO_LAM_LAI"];
                HOTextEdit.EditValue = dt.Rows[0]["HO"];
                TENTextEdit.EditValue = dt.Rows[0]["TEN"];
                ID_QGLookUpEdit.EditValue = dt.Rows[0]["ID_QG"];
                NGAY_SINHDateEdit.EditValue = dt.Rows[0]["NGAY_SINH"];
                NAM_SINHDateEdit.EditValue = dt.Rows[0]["NAM_SINH"];
                PHAICheckEdit.EditValue = dt.Rows[0]["PHAI"];
                ID_TOLookupEdit.EditValue = dt.Rows[0]["ID_TO"];
                ID_CVLookUpEdit.EditValue = dt.Rows[0]["ID_CV"];
                ID_LCVLookUpEdit.EditValue = dt.Rows[0]["ID_LCV"];
                ID_LHDLDLookUpEdit.EditValue = dt.Rows[0]["ID_LHDLD"];
                NGAY_HOC_VIECDateEdit.EditValue = dt.Rows[0]["NGAY_HOC_VIEC"];
                NGAY_THU_VIECDateEdit.EditValue = dt.Rows[0]["NGAY_THU_VIEC"];
                NGAY_VAO_LAMDateEdit.EditValue = dt.Rows[0]["NGAY_VAO_LAM"];
                ID_TT_HDLookUpEdit.EditValue = dt.Rows[0]["ID_TT_HD"];
                ID_TT_HTLookUpEdit.EditValue = dt.Rows[0]["ID_TT_HT"];
                HINH_THUC_TUYENTextEdit.EditValue = dt.Rows[0]["HINH_THUC_TUYEN"];
                PHEP_CTTextEdit.EditValue = dt.Rows[0]["PHEP_CT"];
                PHEP_CDTextEdit.EditValue = dt.Rows[0]["PHEP_CD"];
                THAM_GIA_BHXHCheckEdit.EditValue = dt.Rows[0]["THAM_GIA_BHXH"];
                LD_TINHCheckEdit.EditValue = dt.Rows[0]["LD_TINH"];
                LAO_DONG_CNCheckEdit.EditValue = dt.Rows[0]["LAO_DONG_CONG_NHAT"];
                TRUC_TIEP_SXCheckEdit.EditValue = dt.Rows[0]["TRUC_TIEP_SX"];
                NGAY_NGHI_VIECDateEdit.EditValue = dt.Rows[0]["NGAY_NGHI_VIEC"];
                ID_LD_TVLookUpEdit.EditValue = dt.Rows[0]["ID_LD_TV"];
                GHI_CHUMemoEdit.EditValue = dt.Rows[0]["GHI_CHU"];
                ID_DTLookUpEdit.EditValue = dt.Rows[0]["ID_DT"];
                TON_GIAOTextEdit.EditValue = dt.Rows[0]["TON_GIAO"];
                NOI_SINHTextEdit.EditValue = dt.Rows[0]["NOI_SINH"];
                NGUYEN_QUANTextEdit.EditValue = dt.Rows[0]["NGUYEN_QUAN"];
                SO_CMNDTextEdit.EditValue = dt.Rows[0]["SO_CMND"];
                NGAY_CAPDateEdit.EditValue = dt.Rows[0]["NGAY_CAP"];
                NOI_CAPLookupEdit.EditValue = dt.Rows[0]["NOI_CAP"];
                ID_TT_HNLookUpEdit.EditValue = dt.Rows[0]["ID_TT_HN"];
                MA_THE_ATMTextEdit.EditValue = dt.Rows[0]["MA_THE_ATM"];
                SO_TAI_KHOANTextEdit.EditValue = dt.Rows[0]["SO_TAI_KHOAN"];
                MS_THUETextEdit.EditValue = dt.Rows[0]["MS_THUE"];
                TEN_KHONG_DAUTextEdit.EditValue = dt.Rows[0]["TEN_KHONG_DAU"];
                LD_NNCheckEdit.EditValue = dt.Rows[0]["LD_NN"];
                DT_DI_DONGTextEdit.EditValue = dt.Rows[0]["DT_DI_DONG"];
                DT_NHATextEdit.EditValue = dt.Rows[0]["DT_NHA"];
                DT_NGUOI_THANTextEdit.EditValue = dt.Rows[0]["DT_NGUOI_THAN"];
                EMAILTextEdit.EditValue = dt.Rows[0]["EMAIL"];
                DIA_CHI_THUONG_TRUTextEdit.EditValue = dt.Rows[0]["DIA_CHI_THUONG_TRU"];
                ID_TPLookUpEdit.EditValue = dt.Rows[0]["ID_TP"];
                ID_QUANLookEdit.EditValue = dt.Rows[0]["ID_QUAN"];
                ID_PXLookUpEdit.EditValue = dt.Rows[0]["ID_PX"];
                THON_XOMTextEdit.EditValue = dt.Rows[0]["THON_XOM"];
                DIA_CHI_TAM_TRUTextEdit.EditValue = dt.Rows[0]["DIA_CHI_TAM_TRU"];
                ID_TP_TAM_TRULookUpEdit.EditValue = dt.Rows[0]["ID_TP_TAM_TRU"];
                ID_QUAN_TAM_TRULookUpEdit.EditValue = dt.Rows[0]["ID_QUAN_TAM_TRU"];
                ID_PX_TAM_TRULookUpEdit.EditValue = dt.Rows[0]["ID_PX_TAM_TRU"];
                THON_XOM_TAM_TRUTextEdit.EditValue = dt.Rows[0]["THON_XOM_TAM_TRU"];
                SO_BHXHTextEdit.EditValue = dt.Rows[0]["SO_BHXH"];
                NGAY_DBHXHDateEdit.EditValue = dt.Rows[0]["NGAY_DBHXH"];
                NGAY_DBHXH_DTDateEdit.EditValue = dt.Rows[0]["NGAY_DBHXH_DT"];
                NGAY_CHAM_DUT_NOP_BHXHDateEdit.EditValue = dt.Rows[0]["NGAY_CHAM_DUT_NOP_BHXH"];
                NGAY_THU_HOI_BHYTDateEdit.EditValue = dt.Rows[0]["NGAY_THU_HOI_BHYT"];
                ID_TDVHLookUpEdit.EditValue = dt.Rows[0]["ID_TDVH"];
                ID_LOAI_TDLookUpEdit.EditValue = dt.Rows[0]["ID_LOAI_TD"];
                CHUYEN_MONTextEdit.EditValue = dt.Rows[0]["CHUYEN_MON"];
                LOAI_QUOC_TICHLookUpEdit.EditValue = dt.Rows[0]["LOAI_QUOC_TICH"];
                CAP_GIAY_PHEPLookUpEdit.EditValue = dt.Rows[0]["CAP_GIAY_PHEP"];
                SO_GIAY_PHEPTextEdit.EditValue = dt.Rows[0]["SO_GIAY_PHEP"];
                NGAY_CAP_GPDateEdit.EditValue = dt.Rows[0]["NGAY_CAP_GP"];
                NGAY_HH_GPDateEdit.EditValue = dt.Rows[0]["NGAY_HH_GP"];
                LD_GIAM_LDNNTextEdit.EditValue = dt.Rows[0]["LD_GIAM_LDNN"];
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
            windowsUIButton.Buttons[7].Properties.Visible = visible;
            windowsUIButton.Buttons[8].Properties.Visible = !visible;
            windowsUIButton.Buttons[9].Properties.Visible = !visible;
            windowsUIButton.Buttons[10].Properties.Visible = visible;
            MS_CNTextEdit.Properties.ReadOnly = visible;
            MS_THE_CCTextEdit.Properties.ReadOnly = visible;
            VAO_LAM_LAICheckEdit.Properties.ReadOnly = visible;
            HOTextEdit.Properties.ReadOnly = visible;
            TENTextEdit.Properties.ReadOnly = visible;
            ID_QGLookUpEdit.Properties.ReadOnly = visible;
            NGAY_SINHDateEdit.Properties.ReadOnly = visible;
            NAM_SINHDateEdit.Properties.ReadOnly = visible;
            PHAICheckEdit.Properties.ReadOnly = visible;
            ID_TOLookupEdit.Properties.ReadOnly = visible;
            ID_CVLookUpEdit.Properties.ReadOnly = visible;
            ID_LCVLookUpEdit.Properties.ReadOnly = visible;
            ID_LHDLDLookUpEdit.Properties.ReadOnly = visible;
            NGAY_HOC_VIECDateEdit.Properties.ReadOnly = visible;
            NGAY_THU_VIECDateEdit.Properties.ReadOnly = visible;
            NGAY_VAO_LAMDateEdit.Properties.ReadOnly = visible;
            ID_TT_HDLookUpEdit.Properties.ReadOnly = visible;
            ID_TT_HTLookUpEdit.Properties.ReadOnly = visible;
            HINH_THUC_TUYENTextEdit.Properties.ReadOnly = visible;
            PHEP_CTTextEdit.Properties.ReadOnly = visible;
            PHEP_CDTextEdit.Properties.ReadOnly = visible;
            THAM_GIA_BHXHCheckEdit.Properties.ReadOnly = visible;
            LD_TINHCheckEdit.Properties.ReadOnly = visible;
            LAO_DONG_CNCheckEdit.Properties.ReadOnly = visible;
            TRUC_TIEP_SXCheckEdit.Properties.ReadOnly = visible;
            NGAY_NGHI_VIECDateEdit.Properties.ReadOnly = visible;
            ID_LD_TVLookUpEdit.Properties.ReadOnly = visible;
            GHI_CHUMemoEdit.Properties.ReadOnly = visible;
            ID_DTLookUpEdit.Properties.ReadOnly = visible;
            TON_GIAOTextEdit.Properties.ReadOnly = visible;
            NOI_SINHTextEdit.Properties.ReadOnly = visible;
            NGUYEN_QUANTextEdit.Properties.ReadOnly = visible;
            SO_CMNDTextEdit.Properties.ReadOnly = visible;
            NGAY_CAPDateEdit.Properties.ReadOnly = visible;
            NOI_CAPLookupEdit.Properties.ReadOnly = visible;
            ID_TT_HNLookUpEdit.Properties.ReadOnly = visible;
            MA_THE_ATMTextEdit.Properties.ReadOnly = visible;
            SO_TAI_KHOANTextEdit.Properties.ReadOnly = visible;
            MS_THUETextEdit.Properties.ReadOnly = visible;
            TEN_KHONG_DAUTextEdit.Properties.ReadOnly = visible;
            LD_NNCheckEdit.Properties.ReadOnly = visible;
            DT_DI_DONGTextEdit.Properties.ReadOnly = visible;
            DT_NHATextEdit.Properties.ReadOnly = visible;
            DT_NGUOI_THANTextEdit.Properties.ReadOnly = visible;
            EMAILTextEdit.Properties.ReadOnly = visible;
            DIA_CHI_THUONG_TRUTextEdit.Properties.ReadOnly = visible;
            ID_TPLookUpEdit.Properties.ReadOnly = visible;
            ID_QUANLookEdit.Properties.ReadOnly = visible;
            ID_PXLookUpEdit.Properties.ReadOnly = visible;
            THON_XOMTextEdit.Properties.ReadOnly = visible;
            DIA_CHI_TAM_TRUTextEdit.Properties.ReadOnly = visible;
            ID_TP_TAM_TRULookUpEdit.Properties.ReadOnly = visible;
            ID_QUAN_TAM_TRULookUpEdit.Properties.ReadOnly = visible;
            ID_PX_TAM_TRULookUpEdit.Properties.ReadOnly = visible;
            THON_XOM_TAM_TRUTextEdit.Properties.ReadOnly = visible;
            SO_BHXHTextEdit.Properties.ReadOnly = visible;
            NGAY_DBHXHDateEdit.Properties.ReadOnly = visible;
            NGAY_DBHXH_DTDateEdit.Properties.ReadOnly = visible;
            NGAY_CHAM_DUT_NOP_BHXHDateEdit.Properties.ReadOnly = visible;
            NGAY_THU_HOI_BHYTDateEdit.Properties.ReadOnly = visible;
            ID_TDVHLookUpEdit.Properties.ReadOnly = visible;
            ID_LOAI_TDLookUpEdit.Properties.ReadOnly = visible;
            CHUYEN_MONTextEdit.Properties.ReadOnly = visible;
            LOAI_QUOC_TICHLookUpEdit.Properties.ReadOnly = visible;
            CAP_GIAY_PHEPLookUpEdit.Properties.ReadOnly = visible;
            SO_GIAY_PHEPTextEdit.Properties.ReadOnly = visible;
            NGAY_CAP_GPDateEdit.Properties.ReadOnly = visible;
            NGAY_HH_GPDateEdit.Properties.ReadOnly = visible;
            LD_GIAM_LDNNTextEdit.Properties.ReadOnly = visible;
        }
        private byte[] imgToByteConverter(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        }
        private void SaveData()
        {
            Commons.Modules.iCongNhan = Convert.ToInt64(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateCongNhan",
                Commons.Modules.iCongNhan,
            imgToByteConverter(HINH_CNPictureEdit.Image),
            MS_CNTextEdit.EditValue,
            MS_THE_CCTextEdit.EditValue,
            VAO_LAM_LAICheckEdit.EditValue,
            HOTextEdit.EditValue,
            TENTextEdit.EditValue,
            ID_QGLookUpEdit.EditValue.ToString() == "" ? null : ID_QGLookUpEdit.EditValue,
            NGAY_SINHDateEdit.EditValue,
            NAM_SINHDateEdit.DateTime.Year,
            PHAICheckEdit.EditValue,
            ID_TOLookupEdit.EditValue.ToString() == "" ? null : ID_TOLookupEdit.EditValue,
            ID_CVLookUpEdit.EditValue.ToString() == "" ? null : ID_CVLookUpEdit.EditValue,
            ID_LCVLookUpEdit.EditValue.ToString() == "" ? null : ID_LCVLookUpEdit.EditValue,
            ID_LHDLDLookUpEdit.EditValue.ToString() == "" ? null : ID_LHDLDLookUpEdit.EditValue,
            NGAY_HOC_VIECDateEdit.EditValue,
            NGAY_THU_VIECDateEdit.EditValue,
            NGAY_VAO_LAMDateEdit.EditValue,
            ID_TT_HDLookUpEdit.EditValue.ToString() == "" ? null : ID_TT_HDLookUpEdit.EditValue,
            ID_TT_HTLookUpEdit.EditValue.ToString() == "" ? null : ID_TT_HTLookUpEdit.EditValue,
            HINH_THUC_TUYENTextEdit.EditValue,
            PHEP_CTTextEdit.EditValue,
            PHEP_CDTextEdit.EditValue,
            THAM_GIA_BHXHCheckEdit.EditValue,
            LD_TINHCheckEdit.EditValue,
            LAO_DONG_CNCheckEdit.EditValue,
            TRUC_TIEP_SXCheckEdit.EditValue,
            NGAY_NGHI_VIECDateEdit.EditValue,
            ID_LD_TVLookUpEdit.EditValue.ToString() == "" ? null : ID_LD_TVLookUpEdit.EditValue,
            GHI_CHUMemoEdit.EditValue,
            ID_DTLookUpEdit.EditValue.ToString() == "" ? null : ID_DTLookUpEdit.EditValue,
            TON_GIAOTextEdit.EditValue,
            NOI_SINHTextEdit.EditValue,
            NGUYEN_QUANTextEdit.EditValue,
            SO_CMNDTextEdit.EditValue,
            NGAY_CAPDateEdit.EditValue,
            NOI_CAPLookupEdit.EditValue.ToString() == "" ? null : NOI_CAPLookupEdit.EditValue,
            ID_TT_HNLookUpEdit.EditValue.ToString() == "" ? null : ID_TT_HNLookUpEdit.EditValue,
            MA_THE_ATMTextEdit.EditValue,
            SO_TAI_KHOANTextEdit.EditValue,
            MS_THUETextEdit.EditValue,
            TEN_KHONG_DAUTextEdit.EditValue,
            LD_NNCheckEdit.EditValue,
            DT_DI_DONGTextEdit.EditValue,
            DT_NHATextEdit.EditValue,
            DT_NGUOI_THANTextEdit.EditValue,
            EMAILTextEdit.EditValue,
            DIA_CHI_THUONG_TRUTextEdit.EditValue,
            ID_TPLookUpEdit.EditValue.ToString() == "" ? null : ID_TPLookUpEdit.EditValue,
            ID_QUANLookEdit.EditValue,
            ID_PXLookUpEdit.EditValue.ToString() == "" ? null : ID_PXLookUpEdit.EditValue,
            THON_XOMTextEdit.EditValue,
            DIA_CHI_TAM_TRUTextEdit.EditValue,
            ID_TP_TAM_TRULookUpEdit.EditValue.ToString() == "" ? null : ID_TP_TAM_TRULookUpEdit.EditValue,
            ID_QUAN_TAM_TRULookUpEdit.EditValue.ToString() == "" ? null : ID_QUAN_TAM_TRULookUpEdit.EditValue,
            ID_PX_TAM_TRULookUpEdit.EditValue.ToString() == "" ? null : ID_PX_TAM_TRULookUpEdit.EditValue,
            THON_XOM_TAM_TRUTextEdit.EditValue,
            SO_BHXHTextEdit.EditValue,
            NGAY_DBHXHDateEdit.EditValue,
            NGAY_DBHXH_DTDateEdit.EditValue,
            NGAY_CHAM_DUT_NOP_BHXHDateEdit.EditValue,
            NGAY_THU_HOI_BHYTDateEdit.EditValue,
            ID_TDVHLookUpEdit.EditValue.ToString() == "" ? null : ID_TDVHLookUpEdit.EditValue,
            ID_LOAI_TDLookUpEdit.EditValue.ToString() == "" ? null : ID_LOAI_TDLookUpEdit.EditValue,
            CHUYEN_MONTextEdit.EditValue,
            LOAI_QUOC_TICHLookUpEdit.EditValue.ToString() == "" ? null : LOAI_QUOC_TICHLookUpEdit.EditValue,
            CAP_GIAY_PHEPLookUpEdit.EditValue.ToString() == "" ? null : CAP_GIAY_PHEPLookUpEdit.EditValue,
            SO_GIAY_PHEPTextEdit.EditValue,
            NGAY_CAP_GPDateEdit.EditValue,
            NGAY_HH_GPDateEdit.EditValue,
            LD_GIAM_LDNNTextEdit.EditValue,
            cothem));

        }
        #endregion

        private void ID_QGLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_QGLookUpEdit.EditValue.ToString() == "") return;
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TPLookUpEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue), false), "ID_TP", "TEN_TP", "TEN_TP");

            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TP_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue), false), "ID_TP", "TEN_TP", "TEN_TP");

            Commons.Modules.sPS = "";
        }

        private void ID_TPLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_TPLookUpEdit.EditValue.ToString() == "") return;
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_QUANLookEdit, Commons.Modules.ObjSystems.DataQuan(Convert.ToInt32(ID_TPLookUpEdit.EditValue), false), "ID_QUAN", "TEN_QUAN", "TEN_QUAN");
            Commons.Modules.sPS = "";
        }

        private void ID_QUANLookEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_QUANLookEdit.EditValue.ToString() == "") return;
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_PXLookUpEdit, Commons.Modules.ObjSystems.DataPhuongXa(Convert.ToInt32(ID_QUANLookEdit.EditValue), false), "ID_PX", "TEN_PX", "TEN_PX");
            Commons.Modules.sPS = "";
        }
        private void ID_TP_TAM_TRULookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_TP_TAM_TRULookUpEdit.EditValue.ToString() == "") return;
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_QUAN_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataQuan(Convert.ToInt32(ID_TP_TAM_TRULookUpEdit.EditValue), false), "ID_QUAN", "TEN_QUAN", "TEN_QUAN");
            Commons.Modules.sPS = "";
        }

        private void ID_QUAN_TAM_TRULookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_QUAN_TAM_TRULookUpEdit.EditValue.ToString() == "") return;
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_PX_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataPhuongXa(Convert.ToInt32(ID_QUAN_TAM_TRULookUpEdit.EditValue), false), "ID_PX", "TEN_PX", "TEN_PX");
            Commons.Modules.sPS = "";
        }

        private void ID_LOAI_TDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_LOAI_TDLookUpEdit.EditValue.ToString() == "") return;
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TDVHLookUpEdit, Commons.Modules.ObjSystems.DataTDVH(Convert.ToInt32(ID_LOAI_TDLookUpEdit.EditValue), false), "ID_TDVH", "TEN_TDVH", "TEN_TDVH");
            Commons.Modules.sPS = "";
        }

        private void ID_DVLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            //xí nghiệp 
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_XNLookUpEdit, Commons.Modules.ObjSystems.DataXiNghiep(Convert.ToInt32(ID_DVLookUpEdit.EditValue)), "ID_XN", "TEN_XN", "TEN_XN");
            //tổ
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_TOLookupEdit, Commons.Modules.ObjSystems.DataTo(Convert.ToInt32(ID_DVLookUpEdit.EditValue), Convert.ToInt32(ID_DVLookUpEdit.EditValue), true), "ID_TO", "TEN_TO", "TEN_TO");
            Commons.Modules.sPS = "";
        }

        private void ID_XNLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            //tổ
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(ID_TOLookupEdit, Commons.Modules.ObjSystems.DataTo(Convert.ToInt32(ID_DVLookUpEdit.EditValue), Convert.ToInt32(ID_DVLookUpEdit.EditValue), true), "ID_TO", "TEN_TO", "TEN_TO");
            Commons.Modules.sPS = "";
        }
    }
}
