namespace VietSoftHRM
{
    partial class ucListDMuc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.grdDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.grvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lab_Link = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.windowsUIButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.AppearanceButton.Normal.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.Options.UseForeColor = true;
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            windowsUIButtonImageOptions1.Image = global::VietSoftHRM.Properties.Resources.iconthem;
            windowsUIButtonImageOptions2.Image = global::VietSoftHRM.Properties.Resources.iconxoa;
            windowsUIButtonImageOptions3.Image = global::VietSoftHRM.Properties.Resources.iconsua;
            windowsUIButtonImageOptions4.Image = global::VietSoftHRM.Properties.Resources.iconsave;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "them", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "xoa", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "sua", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "luu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thoát", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "thoat", -1, false)});
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanel1.Controls.Add(this.searchControl);
            this.windowsUIButtonPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 233);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(899, 71);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Client = this.grdDanhMuc;
            this.searchControl.Location = new System.Drawing.Point(663, 5);
            this.searchControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.searchControl.Properties.Appearance.Options.UseFont = true;
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Properties.Client = this.grdDanhMuc;
            this.searchControl.Properties.FindDelay = 100;
            this.searchControl.Size = new System.Drawing.Size(232, 26);
            this.searchControl.TabIndex = 10;
            // 
            // grdDanhMuc
            // 
            this.grdDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.grdDanhMuc.MainView = this.grvDanhMuc;
            this.grdDanhMuc.Name = "grdDanhMuc";
            this.grdDanhMuc.Size = new System.Drawing.Size(753, 198);
            this.grdDanhMuc.TabIndex = 0;
            this.grdDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhMuc});
            this.grdDanhMuc.Validating += new System.ComponentModel.CancelEventHandler(this.grdDanhMuc_Validating);
            // 
            // grvDanhMuc
            // 
            this.grvDanhMuc.GridControl = this.grdDanhMuc;
            this.grvDanhMuc.Name = "grvDanhMuc";
            this.grvDanhMuc.OptionsView.ShowGroupPanel = false;
            // 
            // lab_Link
            // 
            this.lab_Link.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lab_Link.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lab_Link.Appearance.Options.UseFont = true;
            this.lab_Link.Appearance.Options.UseForeColor = true;
            this.lab_Link.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lab_Link.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_Link.Location = new System.Drawing.Point(0, 0);
            this.lab_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lab_Link.Name = "lab_Link";
            this.lab_Link.Size = new System.Drawing.Size(899, 35);
            this.lab_Link.TabIndex = 1;
            this.lab_Link.Text = "labelControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 35);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdDanhMuc);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(899, 198);
            this.splitContainerControl1.SplitterPosition = 136;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Element6";
            // 
            // ucListDMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lab_Link);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucListDMuc";
            this.Size = new System.Drawing.Size(899, 304);
            this.Load += new System.EventHandler(this.ucListUser_Load);
            this.windowsUIButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraEditors.SearchControl searchControl;
        public DevExpress.XtraEditors.LabelControl lab_Link;
        private DevExpress.XtraGrid.GridControl grdDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhMuc;
    }
}
