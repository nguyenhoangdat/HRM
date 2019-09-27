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
using System.Threading;
using Microsoft.Win32;
using VietSoftHRM.Class;

namespace VietSoftHRM
{
    public partial class ucDonVi : DevExpress.XtraEditors.XtraUserControl
    {
        //PROCEDURE
        public string sSP = Commons.Modules.sPS;
        AddResetMenu menu = new AddResetMenu();
        public ucDonVi()
        {
            InitializeComponent();
        }
        private void ucDonVi_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            try
            {
                LoadGridDonVi();
                menu.CreateMenuNewPBT(grd_DonVi);
            }
            catch { splashScreenManager1.CloseWaitForm(); }
            splashScreenManager1.CloseWaitForm();
        }
        private void LoadGridDonVi()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, sSP, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grd_DonVi, grv_DonVi, dt, false, true, false, true, true, this.Name);
                //if (grv_DonVi.Columns.Count < 10) grv_DonVi.OptionsView.ColumnAutoWidth = true;
                //grv_DonVi.Columns["ID_DV"].Visible = false;
                //DevExpress.Utils.OptionsLayoutGrid opt = new DevExpress.Utils.OptionsLayoutGrid();
                //opt.Columns.StoreAllOptions = true;
                //grd_DonVi.MainView.SaveLayoutToXml(Application.StartupPath + "\\XML\\grd" + sSP.Replace("spGetList", "") + ".xml", opt);
                //grd_DonVi.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));


                if (!bCheckReg())
                {
                    grd_DonVi.MainView.RestoreLayoutFromXml(Application.StartupPath + "\\XML\\grd" + sSP.Replace("spGetList", "") + ".xml");
                    grd_DonVi.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));
                }
                else
                    grd_DonVi.MainView.RestoreLayoutFromRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));
            }
            catch (Exception ex)
            {
                grd_DonVi.MainView.RestoreLayoutFromXml(Application.StartupPath + "\\XML\\grddefault.xml");
            }
        }
        private void ucDonVi_Validated(object sender, EventArgs e)
        {
            grd_DonVi.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));
        }
        private bool bCheckReg()
        {
            try
            {
                using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"DevExpress\\XtraGrid\\Layouts\grd" + sSP.Replace("spGetList", "")))
                {
                    string tmp = (string)registryKey.GetValue("(Default)");
                }
            }
            catch { return false; }
            return true;
        }
    }
}
