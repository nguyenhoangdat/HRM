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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.grdDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.grvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lab_Link = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accorMenuleft = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accorMenuleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            this.windowsUIButtonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDanhMuc
            // 
            this.grdDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.grdDanhMuc.MainView = this.grvDanhMuc;
            this.grdDanhMuc.Name = "grdDanhMuc";
            this.grdDanhMuc.Size = new System.Drawing.Size(685, 316);
            this.grdDanhMuc.TabIndex = 2;
            this.grdDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhMuc});
            this.grdDanhMuc.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.grdDanhMuc_ProcessGridKey);
            this.grdDanhMuc.Validated += new System.EventHandler(this.grdDanhMuc_Validated);
            // 
            // grvDanhMuc
            // 
            this.grvDanhMuc.GridControl = this.grdDanhMuc;
            this.grvDanhMuc.Name = "grvDanhMuc";
            this.grvDanhMuc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsFind.FindDelay = 100;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowCustomAnnotations = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.grvDanhMuc.DoubleClick += new System.EventHandler(this.grvDanhMuc_DoubleClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.accorMenuleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 316);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdDanhMuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 316);
            this.panel2.TabIndex = 4;
            // 
            // accorMenuleft
            // 
            this.accorMenuleft.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accorMenuleft.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.accorMenuleft.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accorMenuleft.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accorMenuleft.Appearance.Group.Normal.ForeColor = System.Drawing.Color.Gainsboro;
            this.accorMenuleft.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accorMenuleft.Appearance.Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.accorMenuleft.Appearance.Hint.Options.UseBackColor = true;
            this.accorMenuleft.Appearance.Item.Normal.ForeColor = System.Drawing.Color.White;
            this.accorMenuleft.Appearance.Item.Normal.Options.UseForeColor = true;
            this.accorMenuleft.Appearance.Item.Normal.Options.UseTextOptions = true;
            this.accorMenuleft.Appearance.Item.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accorMenuleft.Appearance.Item.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.accorMenuleft.Appearance.Item.Pressed.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.accorMenuleft.Appearance.Item.Pressed.ForeColor = System.Drawing.Color.White;
            this.accorMenuleft.Appearance.Item.Pressed.Options.UseFont = true;
            this.accorMenuleft.Appearance.Item.Pressed.Options.UseForeColor = true;
            this.accorMenuleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.accorMenuleft.Location = new System.Drawing.Point(0, 0);
            this.accorMenuleft.Name = "accorMenuleft";
            this.accorMenuleft.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accorMenuleft.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accorMenuleft.ShowItemExpandButtons = false;
            this.accorMenuleft.Size = new System.Drawing.Size(214, 316);
            this.accorMenuleft.TabIndex = 3;
            this.accorMenuleft.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Client = this.grdDanhMuc;
            this.searchControl.Location = new System.Drawing.Point(609, 38);
            this.searchControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl.Properties.Appearance.Options.UseFont = true;
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Properties.Client = this.grdDanhMuc;
            this.searchControl.Properties.FindDelay = 100;
            this.searchControl.Size = new System.Drawing.Size(286, 30);
            this.searchControl.TabIndex = 10;
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
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 351);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(899, 71);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // ucListDMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_Link);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucListDMuc";
            this.Size = new System.Drawing.Size(899, 422);
            this.Load += new System.EventHandler(this.ucListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accorMenuleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            this.windowsUIButtonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl lab_Link;
        private DevExpress.XtraGrid.GridControl grdDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.AccordionControl accorMenuleft;
        private DevExpress.XtraEditors.SearchControl searchControl;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
    }
}
