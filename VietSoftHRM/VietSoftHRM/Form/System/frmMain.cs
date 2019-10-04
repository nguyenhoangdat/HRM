using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
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
            Commons.Modules.ObjSystems.ThayDoiNN(this);
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
            String sSql;

            sSql = "SELECT T3.[ID_MENU],[KEY_MENU],CASE " + Commons.Modules.TypeLanguage.ToString() + " WHEN 0 THEN T3.[TEN_MENU] WHEN 1 THEN ISNULL(NULLIF(T3.[TEN_MENU_ANH],''),T3.[TEN_MENU]) ELSE ISNULL(NULLIF(T3.[TEN_MENU_HOA],''),T3.[TEN_MENU]) END AS NAME,[ROOT],[HIDE],[BACK_COLOR],[IMG],[STT_MENU],[CONTROLS],[DROPDOW]	   FROM NHOM_MENU T1 INNER JOIN dbo.USERS T2 ON T1.ID_NHOM = T2.ID_NHOM INNER JOIN dbo.MENU T3 ON T1.ID_MENU = T3.ID_MENU  WHERE T2.USER_NAME = '" + Commons.Modules.UserName + "' AND [ROOT] = 0 ORDER BY[STT_MENU],[TEN_MENU]";
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));

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

                //if (Convert.ToBoolean(item["DROPDOW"]) == true)
                //{
                //itembar.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
                //    TileBarDropDownContainer ddContainer = new TileBarDropDownContainer();
                //    ddContainer.BackColor = System.Drawing.ColorTranslator.FromHtml(item["BACK_COLOR"].ToString());
                //    TileBar innerBar = new TileBar() { Parent = ddContainer, Dock = DockStyle.Fill, ItemSize = 50, WideTileWidth = 150 };
                //    innerBar.Groups.Add(new TileGroup());

                //    //addgroup
                //    TileBarItem itemA1 = new TileBarItem() { Text = "SubItem1"};
                //    TileBarItem itemA2 = new TileBarItem() { Text = "SubItem2" };
                //    innerBar.Groups[0].Items.Add(itemA1);
                //    innerBar.Groups[0].Items.Add(itemA2);
                //    itembar.DropDownControl = ddContainer;

                //}
                group.Items.Add(itembar);
            }
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            if (Convert.ToInt32(e.Item.Tag) == 2)
            {
               
            }
            switch (Convert.ToInt32(e.Item.Tag))
            {
                case 1:
                    {
                        LoaducHeThong(e);
                        break;
                    }
                case 2:
                    {
                        LoaducDanhMuc(e);
                        break;
                    }
                default:
                    break;
            }
        }

        private void LoaducHeThong(TileItemEventArgs e)
        {
            ucSystems ucsymstem = new ucSystems();
            ucsymstem.Dock = DockStyle.Fill;
            ucsymstem.iLoai = Convert.ToInt32(e.Item.Tag);
            ucsymstem.lab_Link.Text = e.Item.Text;
            ucsymstem.color = e.Item.AppearanceItem.Normal.BackColor;
            LoadUac(ucsymstem);
        }


        private void LoaducDanhMuc(TileItemEventArgs e)
        {
            ucListDMuc uacDM = new ucListDMuc();
            uacDM.Dock = DockStyle.Fill;
            uacDM.iLoai = Convert.ToInt32(e.Item.Tag);
            uacDM.lab_Link.Text = e.Item.Text;
            uacDM.color = e.Item.AppearanceItem.Normal.BackColor;
            LoadUac(uacDM);
        }

        private void LoadUac(XtraUserControl uac)
        {
            NavigationPage page = new NavigationPage();
            page.Controls.Add(uac);
            navigationFrame.Pages.Add(page);
            navigationFrame.SelectedPage = page;
        }
        //private void btn_Logout_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    //frmLogin login = new frmLogin();
        //    //login.ShowDialog();
        //    //this.Close();

        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
