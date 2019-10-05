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
    public partial class ucEditTO : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEditTO(Int64 iId)
        {
            InitializeComponent();
            LoadXiNghiep();
        }
        private void LoadXiNghiep()
        {
            //T1.ID_XN,T1.ID_DV,T2.TEN_DON_VI,T1.MS_XN, T2.TEN_XN,T1.STT_XN,T1.GOP_PB,T1.GOP_TH
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListXI_NGHIEP", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            Commons.Modules.ObjSystems.MLoadLookUpEditNoRemove(ID_XNLookUpEdit,dt, "ID_XN", "TEN_XN","");
            try
            {

                ID_XNLookUpEdit.Properties.Columns[0].Visible = false;
                ID_XNLookUpEdit.Properties.Columns[0].Visible = false;
                ID_XNLookUpEdit.Properties.Columns["ID_DV"].Visible = false;
                ID_XNLookUpEdit.Properties.Columns["MS_XN"].Visible = false;
                ID_XNLookUpEdit.Properties.Columns["STT_XN"].Visible = false;
                ID_XNLookUpEdit.Properties.Columns["GOP_PB"].Visible = false;
                ID_XNLookUpEdit.Properties.Columns["GOP_TH"].Visible = false;

            }
            catch 
            {

                
            }     
        }
    }

}
