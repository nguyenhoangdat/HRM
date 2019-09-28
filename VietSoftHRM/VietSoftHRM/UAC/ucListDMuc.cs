using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.DocumentView;
using DevExpress.Mvvm;
using VietSoftHRM.Class;
using Microsoft.Win32;

namespace VietSoftHRM
{
    public partial class ucListDMuc : DevExpress.XtraEditors.XtraUserControl
    {
        public int iLoai;
        public string slinkcha;
        public string sSP = Commons.Modules.sPS;
        public ucListDMuc()
        {
            InitializeComponent();
        }

        //load tất danh mục từ menu
        private void LoadDanhMuc()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetMenuLeft", Commons.Modules.UserName, Commons.Modules.TypeLanguage, iLoai));
            foreach (DataRow item in dt.Rows)
            {
                SimpleButton button = new SimpleButton();
                Panel pan = new Panel();
                pan.Height = 10;
                pan.BackColor = Color.White;
                pan.Dock = DockStyle.Top;
                splitContainerControl1.Panel1.Controls.Add(pan);
                button.Dock = DockStyle.Top;
                button.Height = 50;
                button.Cursor = Cursors.Hand;
                button.Appearance.BackColor = Color.FromArgb(240, 240, 240);
                button.Appearance.ForeColor = Color.Black;
                button.Click += Button_Click;
                button.Name = item["KEY_MENU"].ToString();
                button.Tag = item["CONTROLS"].ToString();
                button.Text = item["NAME"].ToString();
                //button.ImageOptions.Image = (Image)Properties.Resources.ResourceManager.GetObject(item["IMG"].ToString());
                button.ImageOptions.Image = Properties.Resources.icon_user;
                splitContainerControl1.Panel1.Controls.Add(button);
           
            }
        }
        private void doimauduocchon(SimpleButton button)
        {
            foreach (SimpleButton item in splitContainerControl1.Panel1.Controls)
            {
                var bt = item as SimpleButton;
                if (bt.Name != button.Name)
                {
                    bt.Appearance.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    bt.Appearance.BackColor = Color.Black;
                }
            }
        }

        //sự kiện cho menulef
        private void LoadPanel2(XtraUserControl uccontrol)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(uccontrol);
            Commons.Modules.sPS = "spGetList" + Commons.Modules.sPS.ToString();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                var button = sender as SimpleButton;
                //doimauduocchon(button);
                lab_Link.Text = slinkcha + " / " + button.Text;

                string ucName = button.Tag.ToString();
                Commons.Modules.sPS = button.Name.ToString().Replace("mnu_", "");
                Commons.Modules.sPS = Commons.Modules.sPS.ToString().Replace("mnu", "");
                Commons.Modules.sPS = "spGetList" + Commons.Modules.sPS.ToString();
                LoadGridDonVi();
                //if (string.IsNullOrEmpty(ucName))
                //{ splitContainerControl1.Panel2.Controls.Clear(); }
                //else
                //{
                //      XtraUserControl ctl = new XtraUserControl();
                //    Type newType = Type.GetType(ucName, true, true);
                //    object o1 = Activator.CreateInstance(newType);
                //    ctl = o1 as XtraUserControl;
                //    ctl.Dock = DockStyle.Fill;
                //    LoadPanel2(ctl);
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        private void LoadGridDonVi()
        {
            try
            {
                grdDanhMuc.DataSource = null;
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, Commons.Modules.sPS, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdDanhMuc, grvDanhMuc, dt, false, true, false, true, true, this.Name);
                //if (grv_DonVi.Columns.Count < 10) grv_DonVi.OptionsView.ColumnAutoWidth = true;
                //grv_DonVi.Columns["ID_DV"].Visible = false;
                //DevExpress.Utils.OptionsLayoutGrid opt = new DevExpress.Utils.OptionsLayoutGrid();
                //opt.Columns.StoreAllOptions = true;
                //grd_DonVi.MainView.SaveLayoutToXml(Application.StartupPath + "\\XML\\grd" + sSP.Replace("spGetList", "") + ".xml", opt);
                //grd_DonVi.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));
                //RepositoryItemMemoEdit memoEdit = new RepositoryItemMemoEdit();
                //memoEdit.ReadOnly = true;
                //memoEdit.AutoHeight = true;
                //memoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                //memoEdit.WordWrap = true;
                //grv_DonVi.GridControl.RepositoryItems.Add(memoEdit);
                //grv_DonVi.Columns["DIA_CHI"].ColumnEdit = memoEdit;
                //grv_DonVi.OptionsView.RowAutoHeight = true;
                if (!bCheckReg())
                {
                    grdDanhMuc.MainView.RestoreLayoutFromXml(Application.StartupPath + "\\XML\\grd" + sSP.Replace("spGetList", "") + ".xml");
                    grdDanhMuc.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));
                }
                else
                    grdDanhMuc.MainView.RestoreLayoutFromRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + sSP.Replace("spGetList", ""));
            }
            catch (Exception ex)
            {
                grdDanhMuc.MainView.RestoreLayoutFromXml(Application.StartupPath + "\\XML\\grddefault.xml");
            }
        }
        private bool bCheckReg()
        {
            try
            {
                using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"DevExpress\\XtraGrid\\Layouts\grd" + Commons.Modules.sPS.Replace("spGetList", "")))
                {
                    string tmp = (string)registryKey.GetValue("(Default)");
                }
            }
            catch { return false; }
            return true;
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            DevExpress.XtraBars.Navigation.AccordionControlElement NewElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            NewElement = e.Element;
            splitContainerControl1.Panel2.Controls.Clear();
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            MessageBox.Show(btn.Tag.ToString());
            XtraUserControl ctl = new XtraUserControl();
            try
            {

                Type newType = Type.GetType("VietSoftHRM.ucEdit" + Commons.Modules.sPS.Replace("spGetList", ""), true, true);
                object o1 = Activator.CreateInstance(newType);
                ctl = o1 as XtraUserControl;
                ctl.Dock = DockStyle.Fill;
            }
            catch { }
            Int64 iID = -1;
            try
            {
            }
            catch
            {}
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        //thêm
                        ucEditDonVi uceditdv = new ucEditDonVi(-1);
                        CustomFlyoutDialog.ShowForm(new frmMain(), null, uceditdv);
                        break;
                    }
                case "xoa":
                    {
                        if (XtraMessageBox.Show("bạn có muốn xóa đơn vị này", "xóa", MessageBoxButtons.YesNo) == DialogResult.No) return;
                        //xóa
                        CustomFlyoutDialog.ShowForm(new frmMain(), null, new ucEditDonVi(iID));
                        break;
                    }
                case "sua":
                    {
                        //sữa
                        //ucEditDonVi uceditdv = new ucEditDonVi();
                        //uceditdv.id = grv;
                        //int n = grvDanhMuc.GetFocusedRowCellValue("ID_DV")
                        
                        CustomFlyoutDialog.ShowForm(new frmMain(), null, ctl);
                        break;
                    }
                default:
                    break;
            }
        }

        private void ucListUser_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;

            LoadDanhMuc();
        }

        private void grvDanhMuc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            grdDanhMuc.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\grd" + Commons.Modules.sPS.Replace("spGetList", ""));

        }
    }
}
