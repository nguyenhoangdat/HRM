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
            Commons.Modules.ObjSystems.ThayDoiNN(this);
        }
        private void LoadText()
        {
            string sSql = "SELECT ID_DV ,MSDV ,TEN_DON_VI ,TEN_DON_VI_ANH ,TEN_DON_VI_HOA ,TEN_NGAN ,DIA_CHI ,MAC_DINH ,CHU_QUAN ,DIEN_THOAI ,FAX ,MS_BHYT ,MS_BHXH ,SO_TAI_KHOAN ,TEN_NGAN_HANG ,KY_HIEU ,NGUOI_DAI_DIEN ,CHUC_VU ,SO_HS FROM dbo.DON_VI WHERE ID_DV =	" + iIdDV.ToString();
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text,sSql));

            ItemForMSDV.EditValue = dtTmp.Rows[0]["MSDV"].ToString();
            ItemForTEN_DON_VI.EditValue = dtTmp.Rows[0]["TEN_DON_VI"].ToString();
            ItemForTEN_DON_VI_ANH.EditValue = dtTmp.Rows[0]["TEN_DON_VI_ANH"].ToString();
            ItemForTEN_DON_VI_HOA.EditValue = dtTmp.Rows[0]["TEN_DON_VI_HOA"].ToString();
            ItemForTEN_NGAN.EditValue = dtTmp.Rows[0]["TEN_NGAN"].ToString();
            ItemForDIA_CHI.EditValue = dtTmp.Rows[0]["DIA_CHI"].ToString();
            ItemForMAC_DINH.EditValue = Convert.ToBoolean(dtTmp.Rows[0]["MAC_DINH"]);
            ItemForCHU_QUAN.EditValue = dtTmp.Rows[0]["CHU_QUAN"].ToString();
            ItemForDIEN_THOAI.EditValue = dtTmp.Rows[0]["DIEN_THOAI"].ToString();
            ItemForFAX.EditValue = dtTmp.Rows[0]["FAX"].ToString();
            ItemForMS_BHYT.EditValue = dtTmp.Rows[0]["MS_BHYT"].ToString();
            ItemForMS_BHXH.EditValue = dtTmp.Rows[0]["MS_BHXH"].ToString();
            ItemForSO_TAI_KHOAN.EditValue = dtTmp.Rows[0]["SO_TAI_KHOAN"].ToString();
            ItemForTEN_NGAN_HANG.EditValue = dtTmp.Rows[0]["TEN_NGAN_HANG"].ToString();
            ItemForKY_HIEU.EditValue = dtTmp.Rows[0]["KY_HIEU"].ToString();
            ItemForNGUOI_DAI_DIEN.EditValue = dtTmp.Rows[0]["NGUOI_DAI_DIEN"].ToString();
            ItemForCHUC_VU.EditValue = dtTmp.Rows[0]["CHUC_VU"].ToString();
            ItemForSO_HS.EditValue = dtTmp.Rows[0]["SO_HS"].ToString();


        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            variable.sId =
            SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateDonVi", iIdDV, ItemForMSDV.EditValue, ItemForTEN_DON_VI.EditValue, ItemForTEN_DON_VI_ANH.EditValue, ItemForTEN_DON_VI_HOA.EditValue, ItemForTEN_NGAN.EditValue, ItemForDIA_CHI.EditValue, Convert.ToBoolean(ItemForMAC_DINH.EditValue), ItemForCHU_QUAN.EditValue, ItemForDIEN_THOAI.EditValue, ItemForFAX.EditValue, ItemForMS_BHYT.EditValue, ItemForMS_BHXH.EditValue, ItemForSO_TAI_KHOAN.EditValue, ItemForTEN_NGAN_HANG.EditValue, ItemForKY_HIEU.EditValue, ItemForNGUOI_DAI_DIEN.EditValue, ItemForCHUC_VU.EditValue, ItemForSO_HS.EditValue).ToString();
            this.ParentForm.DialogResult = DialogResult.OK;
            XtraUserControl frm = (this.Parent as XtraUserControl);
            this.ParentForm.Close();
        }
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
