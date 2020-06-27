using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;

namespace VS.Report
{
    public partial class frmInXiNghiep : DevExpress.XtraEditors.XtraForm
    {
        public frmInXiNghiep()
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDonVi()
        {
            try
            { 
                DataTable dt = new DataTable();
                Commons.Modules.UserName = "admin";
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboDON_VI", Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(LK_DON_VI, dt, "ID_DV", "TEN_DV", "TEN_DV");
            }
            catch (Exception EX)
            {
                XtraMessageBox.Show(EX.Message.ToString());
            }
        }

        private void frmInXiNghiep_Load(object sender, EventArgs e)
        {
            LoadDonVi();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn;
            DataTable dt = new DataTable();
            frmViewReport frm = new frmViewReport();
            //frm.rpt = new rptDSTo();
            frm.rpt = new rptDSXiNghiep();

            try
            {
                conn = new System.Data.SqlClient.SqlConnection(Commons.IConnections.CNStr);
                conn.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("rptDSXiNghiep", conn);

                cmd.Parameters.Add("@UName", SqlDbType.NVarChar, 50).Value = Commons.Modules.UserName;
                cmd.Parameters.Add("@NNgu", SqlDbType.Int).Value = Commons.Modules.TypeLanguage;
                cmd.Parameters.Add("@Dvi", SqlDbType.Int).Value = LK_DON_VI.EditValue;
                cmd.CommandType = CommandType.StoredProcedure;
                System.Data.SqlClient.SqlDataAdapter adp = new System.Data.SqlClient.SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds);


                dt = new DataTable();
                dt = ds.Tables[1].Copy();
                dt.TableName = "DA_TA";
                frm.AddDataSource(dt);

                dt = new DataTable();
                dt = ds.Tables[0].Copy();
                dt.TableName = "TTC";
                frm.AddDataSource(dt);

                //dt = new DataTable();
                //dt = ds.Tables[2].Copy();
                //dt.TableName = "CONG_NHAN";
                //frm.AddDataSource(dt);


            }
            catch
            { }


            frm.ShowDialog();
        }
    }
}