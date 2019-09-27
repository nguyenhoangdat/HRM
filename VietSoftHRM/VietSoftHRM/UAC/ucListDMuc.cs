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

namespace VietSoftHRM
{
    public partial class ucListDMuc : DevExpress.XtraEditors.XtraUserControl
    {
      
        public int iLoai;
        public string slinkcha;
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

                XtraUserControl ctl = new XtraUserControl();
                string ucName = button.Tag.ToString();
                Commons.Modules.sPS = button.Name.ToString().Replace("mnu_", "");
                Commons.Modules.sPS = Commons.Modules.sPS.ToString().Replace("mnu", "");
                Commons.Modules.sPS = "spGetList" + Commons.Modules.sPS.ToString();

                if (string.IsNullOrEmpty(ucName))
                { splitContainerControl1.Panel2.Controls.Clear(); }
                else
                {
                    Type newType = Type.GetType(ucName, true, true);
                    object o1 = Activator.CreateInstance(newType);
                    ctl = o1 as XtraUserControl;
                    ctl.Dock = DockStyle.Fill;
                    LoadPanel2(ctl);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            DevExpress.XtraBars.Navigation.AccordionControlElement NewElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            NewElement = e.Element;
            splitContainerControl1.Panel2.Controls.Clear();
        }
        DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction closeAppAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
        {
            Caption = "Confirm",
            Description = "Quit the application?"
        };
        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            CustomFlyoutDialog.ShowForm(new frmMain(), null, new ucEditDonVi());
        }
  
        FlyoutAction CreateCloseAction()
        {
            FlyoutAction closeAction = new FlyoutAction();
            closeAction.Caption = Text;
            closeAction.Description = "Do you really want to close the demo?";
            closeAction.Commands.Add(FlyoutCommand.Yes);
            closeAction.Commands.Add(FlyoutCommand.No);
            return closeAction;
        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Tag.ToString() == "1")
            {
                //splitContainerControl1.Panel2.Tag
                //Uctest 
                foreach (Control ctr in splitContainerControl1.Panel2.Controls)
                {
                    if (ctr.Name == "Uctest")
                    {
                        //Uctest view = ctr as Uctest;
                        //view.Them();
                    }

                }
            }
            if (btn.Tag.ToString() == "2")
            {
                //splitContainerControl1.Panel2.Tag
                //Uctest 
                foreach (Control ctr in splitContainerControl1.Panel2.Controls)
                {
                    if (ctr.Name == "Uctest")
                    {
                        //Uctest view = ctr as Uctest;
                        //view.Sua();
                    }

                }
            }
        }

        private void ucListUser_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;

            LoadDanhMuc();
        }

    }
}
