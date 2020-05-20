namespace VietSoftHRM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPageHome = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.titlegroup = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::VietSoftHRM.WaitForm1), true, true, true);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame
            // 
            this.tablePanel1.SetColumn(this.navigationFrame, 0);
            this.tablePanel1.SetColumnSpan(this.navigationFrame, 2);
            this.navigationFrame.Controls.Add(this.navigationPageHome);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(4, 92);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageHome});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.tablePanel1.SetRow(this.navigationFrame, 1);
            this.navigationFrame.SelectedPage = this.navigationPageHome;
            this.navigationFrame.Size = new System.Drawing.Size(1077, 504);
            this.navigationFrame.TabIndex = 5;
            this.navigationFrame.Text = "navigationFrame1";
            this.navigationFrame.TransitionAnimationProperties.FrameInterval = 5000;
            this.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            // 
            // navigationPageHome
            // 
            this.navigationPageHome.Controls.Add(this.layoutControl1);
            this.navigationPageHome.Name = "navigationPageHome";
            this.navigationPageHome.Size = new System.Drawing.Size(1077, 504);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chartControl3);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.chartControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1077, 504);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chartControl2
            // 
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(315, 6);
            this.chartControl2.Name = "chartControl2";
            series2.Name = "Series 1";
            series2.View = pieSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(756, 231);
            this.chartControl2.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.simpleLabelItem3,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1077, 504);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(309, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(758, 233);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(181, 28);
            this.chartControl1.Name = "chartControl1";
            series3.Name = "Series 1";
            pieSeriesView2.MinAllowedSizePercentage = 48.7D;
            series3.View = pieSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl1.Size = new System.Drawing.Size(427, 293);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Tình trạng công nhân";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AllowSelectedItemBorder = false;
            this.tablePanel1.SetColumn(this.tileBar, 0);
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.titlegroup);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.ItemSize = 50;
            this.tileBar.Location = new System.Drawing.Point(3, 3);
            this.tileBar.MaxId = 27;
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(22, 7, 22, 19);
            this.tablePanel1.SetRow(this.tileBar, 0);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar.SelectionBorderWidth = 3;
            this.tileBar.SelectionColor = System.Drawing.Color.Empty;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.Size = new System.Drawing.Size(973, 82);
            this.tileBar.TabIndex = 4;
            this.tileBar.Text = "tileBar";
            this.tileBar.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // titlegroup
            // 
            this.titlegroup.Name = "titlegroup";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 106F)});
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.tileBar);
            this.tablePanel1.Controls.Add(this.navigationFrame);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 88F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(1085, 600);
            this.tablePanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tablePanel1.SetColumn(this.panel1, 1);
            this.panel1.Controls.Add(this.dropDownButton1);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(982, 12);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 0);
            this.panel1.Size = new System.Drawing.Size(100, 64);
            this.panel1.TabIndex = 8;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.AutoSize = true;
            this.dropDownButton1.AutoWidthInLayoutControl = true;
            this.dropDownButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.Location = new System.Drawing.Point(0, 27);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(100, 37);
            this.dropDownButton1.TabIndex = 6;
            this.dropDownButton1.ShowDropDownControl += new DevExpress.XtraEditors.ShowDropDownControlEventHandler(this.dropDownButton1_ShowDropDownControl);
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Options.UseTextOptions = true;
            this.lblUserName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.LineVisible = true;
            this.lblUserName.Location = new System.Drawing.Point(0, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 27);
            this.lblUserName.TabIndex = 7;
            // 
            // radialMenu1
            // 
            this.radialMenu1.AlphaChannel = ((byte)(250));
            this.radialMenu1.ArcSelectedThickness = 0;
            this.radialMenu1.AutoExpand = true;
            this.radialMenu1.InnerRadius = 0;
            this.radialMenu1.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring;
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.CloseUp += new System.EventHandler(this.radialMenu1_CloseUp);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1085, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1085, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 600);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1085, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 600);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(163, 6);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(150, 165);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(309, 167);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(154, 20);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 167);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(309, 22);
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(154, 20);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 189);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(309, 22);
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(154, 20);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 211);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(309, 22);
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(154, 20);
            // 
            // chartControl3
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl3.Diagram = xyDiagram1;
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Location = new System.Drawing.Point(6, 239);
            this.chartControl3.Name = "chartControl3";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl3.Size = new System.Drawing.Size(1065, 259);
            this.chartControl3.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chartControl3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 233);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1067, 261);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 600);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationPageHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup titlegroup;
        public DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageHome;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}