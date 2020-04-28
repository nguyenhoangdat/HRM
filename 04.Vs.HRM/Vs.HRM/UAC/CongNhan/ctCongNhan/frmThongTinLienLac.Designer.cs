namespace Vs.HRM
{
    partial class frmThongTinLienLac
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions25 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions26 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions27 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions28 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions29 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions30 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grd_TTLL = new DevExpress.XtraGrid.GridControl();
            this.grv_TTLL = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_HoTenCN = new DevExpress.XtraLayout.SimpleLabelItem();
            this.windowsUIButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TTLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_HoTenCN)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grd_TTLL);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(615, 283);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grd_TTLL
            // 
            this.grd_TTLL.Location = new System.Drawing.Point(6, 36);
            this.grd_TTLL.MainView = this.grv_TTLL;
            this.grd_TTLL.Name = "grd_TTLL";
            this.grd_TTLL.Size = new System.Drawing.Size(603, 241);
            this.grd_TTLL.TabIndex = 0;
            this.grd_TTLL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_TTLL});
            this.grd_TTLL.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.grd_TTLL_ProcessGridKey);
            // 
            // grv_TTLL
            // 
            this.grv_TTLL.GridControl = this.grd_TTLL;
            this.grv_TTLL.Name = "grv_TTLL";
            this.grv_TTLL.OptionsView.ShowGroupPanel = false;
            this.grv_TTLL.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grv_TTLL_InitNewRow);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lbl_HoTenCN});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(615, 283);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grd_TTLL;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(605, 243);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lbl_HoTenCN
            // 
            this.lbl_HoTenCN.AllowHotTrack = false;
            this.lbl_HoTenCN.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lbl_HoTenCN.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.lbl_HoTenCN.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_HoTenCN.AppearanceItemCaption.Options.UseForeColor = true;
            this.lbl_HoTenCN.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lbl_HoTenCN.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_HoTenCN.Location = new System.Drawing.Point(0, 0);
            this.lbl_HoTenCN.Name = "lbl_HoTenCN";
            this.lbl_HoTenCN.Size = new System.Drawing.Size(605, 30);
            this.lbl_HoTenCN.TextSize = new System.Drawing.Size(160, 28);
            // 
            // windowsUIButton
            // 
            windowsUIButtonImageOptions25.Image = global::Vs.HRM.Properties.Resources.iconthem;
            windowsUIButtonImageOptions26.Image = global::Vs.HRM.Properties.Resources.iconsua;
            windowsUIButtonImageOptions27.Image = global::Vs.HRM.Properties.Resources.iconxoa;
            windowsUIButtonImageOptions28.Image = global::Vs.HRM.Properties.Resources.iconsave;
            windowsUIButtonImageOptions29.Image = global::Vs.HRM.Properties.Resources.iconNosave;
            windowsUIButtonImageOptions30.Image = global::Vs.HRM.Properties.Resources.iconExit;
            this.windowsUIButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions25, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "them", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sữa", true, windowsUIButtonImageOptions26, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "sua", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions27, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "xoa", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu", true, windowsUIButtonImageOptions28, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "luu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Không lưu", true, windowsUIButtonImageOptions29, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "khongluu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thoát", true, windowsUIButtonImageOptions30, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "thoat", -1, false)});
            this.windowsUIButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowsUIButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButton.Location = new System.Drawing.Point(0, 283);
            this.windowsUIButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButton.Name = "windowsUIButton";
            this.windowsUIButton.Padding = new System.Windows.Forms.Padding(5);
            this.windowsUIButton.Size = new System.Drawing.Size(615, 65);
            this.windowsUIButton.TabIndex = 12;
            this.windowsUIButton.Text = "windowsUIButtonPanel1";
            this.windowsUIButton.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButton_ButtonClick);
            // 
            // frmThongTinLienLac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 348);
            this.Controls.Add(this.windowsUIButton);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmThongTinLienLac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongTinLienLac";
            this.Load += new System.EventHandler(this.frmThongTinLienLac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_TTLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TTLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_HoTenCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grd_TTLL;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_TTLL;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem lbl_HoTenCN;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButton;
    }
}