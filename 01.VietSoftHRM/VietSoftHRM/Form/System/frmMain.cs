using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts;
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
            Commons.Modules.ObjSystems.ShowWaitForm(this);
            LoadMenuCha();
            Commons.Modules.ObjSystems.ThayDoiNN(this);
            lblUserName.Text = Commons.Modules.UserName;
            radialMenu1.AddItems(GetRadialMenuItems(barManager1));
            loadcharTinhTrangCN();
            Commons.Modules.ObjSystems.HideWaitForm();
        }
        private void loadcharTinhTrangCN()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetChartUserTinhTrangHT", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            pieChart.Series.Clear();
            pieChart.Titles.Clear();

            pieChart.Titles.Add(new ChartTitle() { Text = "Bểu Đồ Tình Trạng Hiện Tại Công Nhân" });
            // Create a pie series.
            Series series1 = new Series("charpie", ViewType.Pie);
            // Bind the series to data.
            series1.DataSource = dt;
            series1.ArgumentDataMember = "TEN_TT_HT";
            series1.ValueDataMembers.AddRange(new string[] { "SL_CN" });


            // Format the the series labels.
            series1.Label.TextPattern = "{VP:p0} ({V:0})";
            // Format the series legend items.
            series1.LegendTextPattern = "{A}";



            // Adjust the position of series labels. 
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Specify a data filter to explode points.
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Làm việc"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 30;
            myView.RuntimeExploding = true;

            // Customize the legend.
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the series to the chart.
            pieChart.Series.Add(series1);
        }
        private void LoadMenuCha()
        {
            //TileBarGroup group1 = new TileBarGroup();
            //tileBar.Groups.Add(group1);
            titlegroup.Text = "OPERATIONS";
            LoadTitleBar(titlegroup);
            tileBar.ItemSize = 50;
            tileBar.WideTileWidth = 150;
            tileBar.SelectedItem = titlegroup.GetTileItemByName("58");
        }
        private void LoadTitleBar(TileBarGroup group)
        {
            DataTable dt = new DataTable();
            try
            {
                String sSql;
                sSql = "SELECT T3.[ID_MENU],[KEY_MENU],CASE " + Commons.Modules.TypeLanguage.ToString() + " WHEN 0 THEN T3.[TEN_MENU] WHEN 1 THEN ISNULL(NULLIF(T3.[TEN_MENU_A],''),T3.[TEN_MENU]) ELSE ISNULL(NULLIF(T3.[TEN_MENU_H],''),T3.[TEN_MENU]) END AS NAME,[ROOT],[HIDE],[BACK_COLOR],[IMG],[STT_MENU],[CONTROLS],[DROPDOW] FROM NHOM_MENU T1 INNER JOIN dbo.USERS T2 ON T1.ID_NHOM = T2.ID_NHOM INNER JOIN dbo.MENU T3 ON T1.ID_MENU = T3.ID_MENU  WHERE T2.USER_NAME = '" + Commons.Modules.UserName + "' AND [ROOT] = 0 ORDER BY[STT_MENU],[NAME]";
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
                    itembar.Name = item["ID_MENU"].ToString();
                    titlegroup.Items.Add(itembar);
                }
            }

            catch (Exception EX)
            {
                XtraMessageBox.Show(EX.Message.ToString());
            }
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {

            switch (Convert.ToInt32(e.Item.Tag))
            {
                case 58:
                    {
                        navigationFrame.SelectedPage = navigationPageHome;
                        loadcharTinhTrangCN();
                        break;
                    }
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
                case 14:
                    {
                        LoaducCongNhan(e);
                        break;
                    }
                case 61:
                    {
                        LoaducBaoCao(e);
                        break;
                    }
                case 16:
                    {
                        //navigationFrame.SelectedPage = navigationPage1;
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

        private void LoaducCongNhan(TileItemEventArgs e)
        {
            ucCongNhan uacCN = new ucCongNhan(tileBar);
            uacCN.Dock = DockStyle.Fill;
            uacCN.iLoai = Convert.ToInt32(e.Item.Tag);
            uacCN.lab_Link.Text = e.Item.Text;
            LoadUac(uacCN);
        }
        private void LoaducDanhMuc(TileItemEventArgs e)
        {
            ucListDMuc uacDM = new ucListDMuc();
            uacDM.Dock = DockStyle.Fill;
            uacDM.iLoai = Convert.ToInt32(e.Item.Tag);
            uacDM.lab_Link.Text = e.Item.Text;
            //uacDM.color = e.Item.AppearanceItem.Normal.BackColor;
            LoadUac(uacDM);
        }
        private void LoaducBaoCao(TileItemEventArgs e)
        {
            ucListBaoCao ucListBC = new ucListBaoCao(tileBar);
            ucListBC.Dock = DockStyle.Fill;
            ucListBC.iLoai = Convert.ToInt32(e.Item.Tag);
            ucListBC.lab_Link.Text = e.Item.Text;
            ucListBC.color = e.Item.AppearanceItem.Normal.BackColor;
            LoadUac(ucListBC);
        }
        private void LoadUac(XtraUserControl uac)
        {
            //kiểm tra tồn tại chưa nếu tồn tại rồi thì select page ngược lại thì load

            if (checkfameexits(uac.Name).Tag != null)
            {
                navigationFrame.SelectedPage = checkfameexits(uac.Name);
            }
            else
            {
                NavigationPage page = new NavigationPage();
                page.Tag = uac.Name;
                page.Controls.Add(uac);
                navigationFrame.Pages.Add(page);
                navigationFrame.SelectedPage = page;
            }
        }
        private NavigationPage checkfameexits(string tab)
        {
            NavigationPage page = new NavigationPage();
            foreach (NavigationPage item in navigationFrame.Pages)
            {
                if (item.Tag == tab)
                {
                    page = item;
                }

            }
            return page;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dropDownButton1_ShowDropDownControl(object sender, ShowDropDownControlEventArgs e)
        {
            Point pt = this.Location;
            pt.Offset(new Point(this.Width, 0));
            radialMenu1.ShowPopup(pt);


        }
        BarItem[] GetRadialMenuItems(BarManager barManager)
        {
            // Create bar items to display in Radial Menu
            BarItem btnLogout = new BarButtonItem(barManager, "Logout");
            btnLogout.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            btnLogout.ItemClick += BtnLogout_ItemClick;

            // Sub-menu with 3 check buttons
            BarSubItem btnLanguage = new BarSubItem(barManager, "Language");
            btnLanguage.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            BarCheckItem btnViet = new BarCheckItem(barManager, false);
            btnViet.Caption = "Việt";
            btnViet.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            BarCheckItem btnAnh = new BarCheckItem(barManager, true);
            btnAnh.Caption = "Anh";
            btnAnh.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            BarCheckItem btnHoa = new BarCheckItem(barManager, false);
            btnHoa.Caption = "Hoa";
            btnHoa.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            BarItem[] subMenuLanguage = new BarItem[] { btnViet, btnAnh, btnHoa };
            btnLanguage.AddItems(subMenuLanguage);


            // submenu chang thems
            BarSubItem btnThems = new BarSubItem(barManager, "Thems");
            btnThems.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            BarCheckItem btnblu = new BarCheckItem(barManager, false);
            btnblu.Caption = "blu";
            btnblu.ItemClick += Btnblu_ItemClick;
            btnblu.ImageOptions.ImageUri.Uri = "Left;Size32x32";
            BarCheckItem btnred = new BarCheckItem(barManager, false);
            btnred.Caption = "red";
            btnred.ImageOptions.ImageUri.Uri = "Left;Size32x32";

            BarItem[] subMenuThems = new BarItem[] { btnblu,btnred };
            btnThems.AddItems(subMenuThems);
            return new BarItem[] { btnLogout, btnLanguage, btnThems };
        }

        private void Btnblu_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Blue);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            SkinPaletteRibbonGalleryBarItem a = new SkinPaletteRibbonGalleryBarItem();
            DevExpress.XtraBars.Helpers.SkinHelper.InitDropDownSkinGallery(a);
        }

        private void BtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            radialMenu1.HidePopup();
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void radialMenu1_CloseUp(object sender, EventArgs e)
        {
  
        }
    }
}
