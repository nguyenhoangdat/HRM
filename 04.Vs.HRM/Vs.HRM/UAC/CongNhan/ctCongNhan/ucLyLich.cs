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
using DevExpress.XtraLayout;
using System.IO;
using DevExpress.XtraBars.Docking2010;

namespace Vs.HRM
{
    public partial class ucLyLich : DevExpress.XtraEditors.XtraUserControl
    {
        Int64 idcn = 0;
        public ucLyLich(Int64 id)
        {
            idcn = id;
            InitializeComponent();
            LoadNgonNgu();

        }
        private void ucLyLich_Load(object sender, EventArgs e)
        {
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
            //TON_GIAOLookUpEdit populor

            //NOI_SINHLookUpEdit populor

            //NGUYEN_QUANLookUpEdit populor

            //NOI_CAPLookupEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(NOI_CAPLookupEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue),false), "ID_TP", "TEN_TP", "TEN_TP");

            //ID_TT_HNLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TT_HNLookUpEdit, Commons.Modules.ObjSystems.DataCongNhan(false), "ID_TT_HN", "TEN_TT_HN", "TEN_TT_HN");
            //ID_TPLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TPLookUpEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue),false), "ID_TP", "TEN_TP", "TEN_TP");
            //ID_PXLookUpEdit 

            //ID_TP_TAM_TRULookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_TP_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataThanhPho(Convert.ToInt32(ID_QGLookUpEdit.EditValue),false), "ID_TP", "TEN_TP", "TEN_TP");

            //ID_QUAN_TAM_TRULookUpEdit
            ////ID_QUAN,TEN_QUAN
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_QUAN_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataQuan(Convert.ToInt32(ID_TP_TAM_TRULookUpEdit.EditValue), false), "ID_QUAN", "TEN_QUAN", "TEN_QUAN");


            //ID_PX_TAM_TRULookUpEdit
            //ID_PX,TEN_PX
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_PX_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataPhuongXa(Convert.ToInt32(ID_QUAN_TAM_TRULookUpEdit.EditValue), false), "ID_PX", "TEN_PX", "TEN_PX");


            //ID_TDVHLookUpEdit 
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_PX_TAM_TRULookUpEdit, Commons.Modules.ObjSystems.DataPhuongXa(Convert.ToInt32(ID_QUAN_TAM_TRULookUpEdit.EditValue), false), "ID_PX", "TEN_PX", "TEN_PX");

            //ID_LOAI_TDLookUpEdit 

            //LOAI_QUOC_TICHLookUpEdit 

            //CAP_GIAY_PHEPLookUpEdit 

            BinDingData();
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "luu":
                    {
                        SaveData();
                        break;
                    }
                default: break;
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
            ItemForSO_THE.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "SO_THE", this.Name);
            ItemForID_MS_TINH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_MS_TINH", this.Name);
            ItemForID_BV.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_BV", this.Name);
            ItemForNGAY_HH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_HH", this.Name);
            ItemForID_TDVH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_TDVH", this.Name);
            ItemForID_LOAI_TD.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "ID_LOAI_TD", this.Name);
            ItemForCHUYEN_MON.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "CHUYEN_MON", this.Name);
            ItemForLOAI_QUOC_TICH.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LOAI_QUOC_TICH", this.Name);
            ItemForLD_NN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LD_NN", this.Name);
            ItemForNGAY_DBHXH_DT.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "NGAY_DBHXH_DT", this.Name);
            ItemForLD_GIAM_LDNN.Text = Commons.Modules.ObjSystems.GetNN(dtTmp, "LD_GIAM_LDNN", this.Name);
        }
        private void BinDingData()
        {
            if(idcn == -1)
            {
                HINH_CNPictureEdit.EditValue ="";
                MS_CNTextEdit.EditValue ="";
                MS_THE_CCTextEdit.EditValue ="";
                VAO_LAM_LAICheckEdit.EditValue =false;
                HOTextEdit.EditValue ="";
                TENTextEdit.EditValue ="";
                ID_QGLookUpEdit.EditValue ="";
                NGAY_SINHDateEdit.EditValue ="";
                NAM_SINHDateEdit.EditValue ="";
                PHAICheckEdit.EditValue =false;
                ID_TOLookupEdit.EditValue ="";
                ID_CVLookUpEdit.EditValue ="";
                ID_LCVLookUpEdit.EditValue ="";
                ID_LHDLDLookUpEdit.EditValue ="";
                NGAY_HOC_VIECDateEdit.EditValue ="";
                NGAY_THU_VIECDateEdit.EditValue ="";
                NGAY_VAO_LAMDateEdit.EditValue ="";
                ID_TT_HDLookUpEdit.EditValue ="";
                ID_TT_HTLookUpEdit.EditValue ="";
                HINH_THUC_TUYENTextEdit.EditValue ="";
                PHEP_CTTextEdit.EditValue ="";
                PHEP_CDTextEdit.EditValue ="";
                THAM_GIA_BHXHCheckEdit.EditValue =false;
                LD_TINHCheckEdit.EditValue ="";
                LAO_DONG_CNCheckEdit.EditValue =false;
                TRUC_TIEP_SXCheckEdit.EditValue =false;
                NGAY_NGHI_VIECDateEdit.EditValue = DateTime.Today;
                ID_LD_TVLookUpEdit.EditValue ="";
                GHI_CHUMemoEdit.EditValue ="";
                ID_DTLookUpEdit.EditValue = "";
                TON_GIAOTextEdit.EditValue ="";
                NOI_SINHTextEdit.EditValue ="";
                NGUYEN_QUANTextEdit.EditValue ="";
                SO_CMNDTextEdit.EditValue ="";
                NGAY_CAPDateEdit.EditValue = DateTime.Today;
                NOI_CAPLookupEdit.EditValue ="";
                ID_TT_HNLookUpEdit.EditValue ="";
                MA_THE_ATMTextEdit.EditValue ="";
                SO_TAI_KHOANTextEdit.EditValue ="";
                MS_THUETextEdit.EditValue ="";
                TEN_KHONG_DAUTextEdit.EditValue ="";
                LD_NNCheckEdit.EditValue =false;
                DT_DI_DONGTextEdit.EditValue ="";
                DT_NHATextEdit.EditValue ="";
                DT_NGUOI_THANTextEdit.EditValue ="";
                EMAILTextEdit.EditValue ="";
                DIA_CHI_THUONG_TRUTextEdit.EditValue ="";
                ID_TPLookUpEdit.EditValue ="";
                ID_QUANLookEdit.EditValue ="";
                ID_PXLookUpEdit.EditValue ="";
                THON_XOMTextEdit.EditValue ="";
                DIA_CHI_TAM_TRUTextEdit.EditValue ="";
                ID_TP_TAM_TRULookUpEdit.EditValue ="";
                ID_QUAN_TAM_TRULookUpEdit.EditValue ="";
                ID_PX_TAM_TRULookUpEdit.EditValue ="";
                THON_XOM_TAM_TRUTextEdit.EditValue ="";
                SO_BHXHTextEdit.EditValue ="";
                NGAY_DBHXHDateEdit.EditValue = DateTime.Today;
                NGAY_DBHXH_DTDateEdit.EditValue = DateTime.Today;
                NGAY_CHAM_DUT_NOP_BHXHDateEdit.EditValue = DateTime.Today;
                NGAY_THU_HOI_BHYTDateEdit.EditValue = DateTime.Today;
                ID_TDVHLookUpEdit.EditValue ="";
                ID_LOAI_TDLookUpEdit.EditValue ="";
                CHUYEN_MONTextEdit.EditValue ="";
                LOAI_QUOC_TICHLookUpEdit.EditValue ="";
                CAP_GIAY_PHEPLookUpEdit.EditValue ="";
                SO_GIAY_PHEPTextEdit.EditValue ="";
                NGAY_CAP_GPDateEdit.EditValue = DateTime.Today;
                NGAY_HH_GPDateEdit.EditValue = DateTime.Today;
                LD_GIAM_LDNNTextEdit.EditValue ="";
            }
            else
            {
                //lấy danh sách chi tiết công nhân 
              

                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListCTCongNhan", idcn, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
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
        //another easy way to convert image to bytearray
        private  byte[] imgToByteConverter(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        }
        private void SaveData()
        {
            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spUpdateCongNhan",
                idcn,
            imgToByteConverter(HINH_CNPictureEdit.Image),
            MS_CNTextEdit.EditValue,
            MS_THE_CCTextEdit.EditValue,
            VAO_LAM_LAICheckEdit.EditValue,
            HOTextEdit.EditValue,
            TENTextEdit.EditValue,
            ID_QGLookUpEdit.EditValue,
            NGAY_SINHDateEdit.EditValue,
            NAM_SINHDateEdit.EditValue,
            PHAICheckEdit.EditValue,
            ID_TOLookupEdit.EditValue,
            ID_CVLookUpEdit.EditValue,
            ID_LCVLookUpEdit.EditValue,
            ID_LHDLDLookUpEdit.EditValue,
            NGAY_HOC_VIECDateEdit.EditValue,
            NGAY_THU_VIECDateEdit.EditValue,
            NGAY_VAO_LAMDateEdit.EditValue,
            ID_TT_HDLookUpEdit.EditValue,
            ID_TT_HTLookUpEdit.EditValue,
            HINH_THUC_TUYENTextEdit.EditValue,
            PHEP_CTTextEdit.EditValue,
            PHEP_CDTextEdit.EditValue,
            THAM_GIA_BHXHCheckEdit.EditValue,
            LD_TINHCheckEdit.EditValue,
            LAO_DONG_CNCheckEdit.EditValue,
            TRUC_TIEP_SXCheckEdit.EditValue,
            NGAY_NGHI_VIECDateEdit.EditValue,
            ID_LD_TVLookUpEdit.EditValue,
            GHI_CHUMemoEdit.EditValue,
            ID_DTLookUpEdit.EditValue,
            TON_GIAOTextEdit.EditValue,
            NOI_SINHTextEdit.EditValue,
            NGUYEN_QUANTextEdit.EditValue,
            SO_CMNDTextEdit.EditValue,
            NGAY_CAPDateEdit.EditValue,
            NOI_CAPLookupEdit.EditValue,
            ID_TT_HNLookUpEdit.EditValue,
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
            ID_TPLookUpEdit.EditValue,
            ID_QUANLookEdit.EditValue,
            ID_PXLookUpEdit.EditValue,
            THON_XOMTextEdit.EditValue,
            DIA_CHI_TAM_TRUTextEdit.EditValue,
            ID_TP_TAM_TRULookUpEdit.EditValue,
            ID_QUAN_TAM_TRULookUpEdit.EditValue,
            ID_PX_TAM_TRULookUpEdit.EditValue,
            THON_XOM_TAM_TRUTextEdit.EditValue,
            SO_BHXHTextEdit.EditValue,
            NGAY_DBHXHDateEdit.EditValue,
            NGAY_DBHXH_DTDateEdit.EditValue,
            NGAY_CHAM_DUT_NOP_BHXHDateEdit.EditValue,
            NGAY_THU_HOI_BHYTDateEdit.EditValue,
            ID_TDVHLookUpEdit.EditValue,
            ID_LOAI_TDLookUpEdit.EditValue,
            CHUYEN_MONTextEdit.EditValue,
            LOAI_QUOC_TICHLookUpEdit.EditValue,
            CAP_GIAY_PHEPLookUpEdit.EditValue,
            SO_GIAY_PHEPTextEdit.EditValue,
            NGAY_CAP_GPDateEdit.EditValue,
            NGAY_HH_GPDateEdit.EditValue,
            LD_GIAM_LDNNTextEdit.EditValue);
        }
        #endregion
    }
}
