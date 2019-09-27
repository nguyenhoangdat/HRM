using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;

namespace VietSoftHRM
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
          
            InitializeComponent();
        }

        //load menugroup
        private void frmMain_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(2000);
            LoadMenuCha();
            splashScreenManager1.CloseWaitForm();
        }
        private void LoadMenuCha()
        {
            TileBarGroup group1 = new TileBarGroup();
            tileBar.Groups.Add(group1);
            group1.Text = "OPERATIONS";
            LoadTitleBar(group1);
            tileBar.ItemSize = 50;
            tileBar.WideTileWidth = 150;
        }
        private TileBarDropDownContainer loadDropdown()
        {
            Button a = new Button();
            a.Text = "huong";
            var filtersContainer = new TileBarDropDownContainer();
            filtersContainer.Controls.Add(a);
            return filtersContainer;
        }
        private void LoadTitleBar(TileBarGroup group)
        {
            DataTable dt = new DataTable();
            //LOAD MENU 0= CHA , CÒN LẠI LÀ CON
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr , "spGetMenuLeft",Commons.Modules.UserName,Commons.Modules.TypeLanguage,0));
            foreach (DataRow item in dt.Rows)
            {
                TileBarItem itembar = new TileBarItem();
                itembar.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
                itembar.ItemSize = TileBarItemSize.Wide;
                itembar.Text = item["NAME"].ToString();
                itembar.AppearanceItem.Normal.BackColor = System.Drawing.ColorTranslator.FromHtml(item["BACK_COLOR"].ToString());
                itembar.Image = (Image)Properties.Resources.ResourceManager.GetObject(item["IMG"].ToString());
                itembar.TextAlignment = TileItemContentAlignment.MiddleRight;
                itembar.Tag = item["ID_MENU"].ToString();
                group.Items.Add(itembar);
            }
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            ucListDMuc uacDM = new ucListDMuc();
            uacDM.Dock = DockStyle.Fill;
            uacDM.iLoai = Convert.ToInt32(e.Item.Tag);
            uacDM.lab_Link.Text = e.Item.Text;
            LoadUac(uacDM);
        }

        private void LoadUac(XtraUserControl uac)
        {
            NavigationPage page = new NavigationPage();
            page.Controls.Add(uac);
            navigationFrame.Pages.Add(page);
            navigationFrame.SelectedPage = page;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
