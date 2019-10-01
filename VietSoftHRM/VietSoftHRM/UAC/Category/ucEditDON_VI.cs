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

namespace VietSoftHRM
{
    public partial class ucEditDON_VI : DevExpress.XtraEditors.XtraUserControl
    {
        private Int64 iIdDV = 0;
        public ucEditDON_VI(Int64 iId)//DataRowView row
        {
            InitializeComponent();
            iIdDV = iId;
        }
        private void ucEditDonVi_Load(object sender, EventArgs e)
        {
            if (iIdDV > 0)
            {
                LoadText();
            }
        }
        private void LoadText()
        {
            string sSql = "SELECT ID_DV ,MSDV ,TEN_DON_VI ,TEN_DON_VI_ANH ,TEN_DON_VI_HOA ,TEN_NGAN ,DIA_CHI ,MAC_DINH ,CHU_QUAN ,DIEN_THOAI ,FAX ,MS_BHYT ,MS_BHXH ,SO_TAI_KHOAN ,TEN_NGAN_HANG ,KY_HIEU ,NGUOI_DAI_DIEN ,CHUC_VU ,SO_HS FROM dbo.DON_VI WHERE ID_DV =	" + iIdDV.ToString();
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text,sSql));

            txtMaso.EditValue = dtTmp.Rows[0]["MSDV"].ToString();
            txtTendv.EditValue = dtTmp.Rows[0]["TEN_DON_VI"].ToString();
            txtTenDVA.EditValue = dtTmp.Rows[0]["TEN_DON_VI_ANH"].ToString();
            txtTenDVH.EditValue = dtTmp.Rows[0]["TEN_DON_VI_HOA"].ToString();
            txtTenNgan.EditValue = dtTmp.Rows[0]["TEN_NGAN"].ToString();
            txtDC.EditValue = dtTmp.Rows[0]["DIA_CHI"].ToString();
            chkMDinh.EditValue = Convert.ToBoolean(dtTmp.Rows[0]["MAC_DINH"]);
            txtCQuan.EditValue = dtTmp.Rows[0]["CHU_QUAN"].ToString();
            txtDThoai.EditValue = dtTmp.Rows[0]["DIEN_THOAI"].ToString();
            txtFax.EditValue = dtTmp.Rows[0]["FAX"].ToString();
            txtBHYT.EditValue = dtTmp.Rows[0]["MS_BHYT"].ToString();
            txtBHXH.EditValue = dtTmp.Rows[0]["MS_BHXH"].ToString();

            txtSTK.EditValue = dtTmp.Rows[0]["SO_TAI_KHOAN"].ToString();
            txtTNH.EditValue = dtTmp.Rows[0]["TEN_NGAN_HANG"].ToString();
            txtKHieu.EditValue = dtTmp.Rows[0]["KY_HIEU"].ToString();
            txtNDD.EditValue = dtTmp.Rows[0]["NGUOI_DAI_DIEN"].ToString();
            txtCVu.EditValue = dtTmp.Rows[0]["CHUC_VU"].ToString();
            txtSoHS.EditValue = dtTmp.Rows[0]["SO_HS"].ToString();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spUpdateDonVi",iIdDV,txtMaso.EditValue,txtTendv.EditValue,txtTenDVA.EditValue,txtTenDVH.EditValue,txtTenNgan.EditValue,txtDC.EditValue,Convert.ToBoolean(chkMDinh.EditValue),txtCQuan.EditValue,txtDThoai.EditValue,txtFax.EditValue,txtBHYT.EditValue,txtBHXH.EditValue,txtSTK.EditValue,txtTNH.EditValue,txtKHieu.EditValue,txtNDD.EditValue,txtCVu.EditValue,txtSoHS.EditValue);
            this.ParentForm.Close();
        }
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void chkMDinh_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
