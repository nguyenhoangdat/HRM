using System;
using System.Data;
using System.Drawing;
using Microsoft.ApplicationBlocks.Data;
using System.Threading;

namespace VietSoftHRM
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region design giao dien
        private void Txt_user_Click(object sender, EventArgs e)
        {
            txt_user.ResetText();
            txt_user.ForeColor = Color.SteelBlue;
            pan_user.BackColor = Color.SteelBlue;
            pic_user.Image = Properties.Resources.icon_user1;

        }

        private void Txt_pass_Click(object sender, EventArgs e)
        {
            txt_pass.ResetText();
            txt_pass.ForeColor = Color.SteelBlue;
            pan_pass.BackColor = Color.SteelBlue;
            pic_pass.Image = Properties.Resources.icon_pass1;
        }

        private void Cbo_database_Click(object sender, EventArgs e)
        {
            cbo_database.ForeColor = Color.SteelBlue;
            pan_database.BackColor = Color.SteelBlue;
            pic_database.Image = Properties.Resources.icon_data1;

        }
        private void Txt_user_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text))
            {
                txt_user.Text = "Username";
            }
            txt_user.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            pan_user.BackColor = Color.FromArgb(80, 80, 80);
            pic_user.Image = Properties.Resources.icon_user;
        }
        private void Txt_pass_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_pass.Text))
            {
                txt_pass.Text = "Password";
            }
            txt_pass.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            pan_pass.BackColor = Color.FromArgb(80, 80, 80);
            pic_pass.Image = Properties.Resources.icon_pass;
        }

        private void Cbo_database_Validated(object sender, EventArgs e)
        {

            cbo_database.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            pan_database.BackColor = Color.FromArgb(80, 80, 80);
            pic_database.Image = Properties.Resources.icon_data;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            LoadcboDataBase();
            Commons.Modules.ObjSystems.ThayDoiNN(this);
        }
        #endregion

        #region Load control
        private void LoadcboDataBase()
        {
            //cbo_database.Properties.datas
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT * FROM sys.sysdatabases where name LIKE '%HRM%'"));
            Commons.Modules.ObjSystems.MLoadLookUpEdit(cbo_database, dt, "name", "name", "");
        }
        #endregion
        //login
        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain form2 = new frmMain();
            form2.ShowDialog();
            this.Close();
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {

        }

        private void pan_database_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void pic_database_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pic_user_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}