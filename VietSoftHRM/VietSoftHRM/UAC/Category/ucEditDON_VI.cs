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
using VietSoftHRM.Class;
using DevExpress.XtraLayout;
using DevExpress.XtraBars.Docking2010;

namespace VietSoftHRM
{
    public partial class ucEditDON_VI : DevExpress.XtraEditors.XtraUserControl
    {
        public Int64 iIdDV = 0;
        public ucEditDON_VI(Int64 iId)//DataRowView row
        {
            InitializeComponent();
            iIdDV = iId;
        }
        private void ucEditDonVi_Load(object sender, EventArgs e)
        {
            if (iIdDV > 0)
                LoadText();
            Commons.Modules.ObjSystems.ThayDoiNN(this,layoutControlGroup1);
        }
        private void LoadText()
        {
            string sSql = "SELECT ID_DV ,MSDV ,TEN_DON_VI ,TEN_DON_VI_ANH ,TEN_DON_VI_HOA ,TEN_NGAN ,DIA_CHI ,MAC_DINH ,CHU_QUAN ,DIEN_THOAI ,FAX ,MS_BHYT ,MS_BHXH ,SO_TAI_KHOAN ,TEN_NGAN_HANG ,KY_HIEU ,NGUOI_DAI_DIEN ,CHUC_VU ,SO_HS FROM dbo.DON_VI WHERE ID_DV =	" + iIdDV.ToString();
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
            ItemForMSDV.Control.Text = dtTmp.Rows[0]["MSDV"].ToString();
            ItemForTEN_DON_VI.Control.Text = dtTmp.Rows[0]["TEN_DON_VI"].ToString();
            ItemForTEN_DON_VI_ANH.Control.Text = dtTmp.Rows[0]["TEN_DON_VI_ANH"].ToString();
            ItemForTEN_DON_VI_HOA.Control.Text = dtTmp.Rows[0]["TEN_DON_VI_HOA"].ToString();
            ItemForTEN_NGAN.Control.Text = dtTmp.Rows[0]["TEN_NGAN"].ToString();
            ItemForDIA_CHI.Control.Text = dtTmp.Rows[0]["DIA_CHI"].ToString();
            MAC_DINHCheckEdit.EditValue = Convert.ToBoolean(dtTmp.Rows[0]["MAC_DINH"]);
            ItemForCHU_QUAN.Control.Text = dtTmp.Rows[0]["CHU_QUAN"].ToString();
            ItemForDIEN_THOAI.Control.Text = dtTmp.Rows[0]["DIEN_THOAI"].ToString();
            ItemForFAX.Control.Text = dtTmp.Rows[0]["FAX"].ToString();
            ItemForMS_BHYT.Control.Text = dtTmp.Rows[0]["MS_BHYT"].ToString();
            ItemForMS_BHXH.Control.Text = dtTmp.Rows[0]["MS_BHXH"].ToString();
            ItemForSO_TAI_KHOAN.Control.Text = dtTmp.Rows[0]["SO_TAI_KHOAN"].ToString();
            ItemForTEN_NGAN_HANG.Control.Text = dtTmp.Rows[0]["TEN_NGAN_HANG"].ToString();
            ItemForKY_HIEU.Control.Text = dtTmp.Rows[0]["KY_HIEU"].ToString();
            ItemForNGUOI_DAI_DIEN.Control.Text = dtTmp.Rows[0]["NGUOI_DAI_DIEN"].ToString();
            ItemForCHUC_VU.Control.Text = dtTmp.Rows[0]["CHUC_VU"].ToString();
            ItemForSO_HS.Control.Text = dtTmp.Rows[0]["SO_HS"].ToString();
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            layoutControlGroup1.BeginUpdate();
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                
                case "luu":
                    {
                        variable.sId =
            SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateDonVi", iIdDV, ItemForMSDV.Control.Text, ItemForTEN_DON_VI.Control.Text, ItemForTEN_DON_VI_ANH.Control.Text, ItemForTEN_DON_VI_HOA.Control.Text, ItemForTEN_NGAN.Control.Text, ItemForDIA_CHI.Control.Text, Convert.ToBoolean(MAC_DINHCheckEdit.EditValue), ItemForCHU_QUAN.Control.Text, ItemForDIEN_THOAI.Control.Text, ItemForFAX.Control.Text, ItemForMS_BHYT.Control.Text, ItemForMS_BHXH.Control.Text, ItemForSO_TAI_KHOAN.Control.Text, ItemForTEN_NGAN_HANG.Control.Text, ItemForKY_HIEU.Control.Text, ItemForNGUOI_DAI_DIEN.Control.Text, ItemForCHUC_VU.Control.Text, ItemForSO_HS.Control.Text).ToString();
                        this.ParentForm.DialogResult = DialogResult.OK;
                        XtraUserControl frm = (this.Parent as XtraUserControl);
                        this.ParentForm.Close();
                        break;
                    }
                case "huy":
                    {
                        this.ParentForm.Close();
                        break;
                    }
                default: break;
            }
        }
    }
}
