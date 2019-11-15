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
            this.accorMenuleft = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accorMenuleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            this.windowsUIButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDanhMuc
            // 
            this.grdDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDanhMuc.Location = new System.Drawing.Point(213, 0);
            this.grdDanhMuc.MainView = this.grvDanhMuc;
            this.grdDanhMuc.Name = "grdDanhMuc";
            this.grdDanhMuc.Size = new System.Drawing.Size(1184, 738);
            this.grdDanhMuc.TabIndex = 2;
            this.grdDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhMuc});
            this.grdDanhMuc.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.grdDanhMuc_ProcessGridKey);
            this.grdDanhMuc.Validated += new System.EventHandler(this.grdDanhMuc_Validated);
            // 
            // grvDanhMuc
            // 
            this.grvDanhMuc.ColumnPanelRowHeight = 2;
            this.grvDanhMuc.DetailHeight = 349;
            this.grvDanhMuc.GridControl = this.grdDanhMuc;
            this.grvDanhMuc.Name = "grvDanhMuc";
            this.grvDanhMuc.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsBehavior.AutoExpandAllGroups = true;
            this.grvDanhMuc.OptionsCustomization.AllowRowSizing = true;
            this.grvDanhMuc.OptionsFind.FindDelay = 100;
            this.grvDanhMuc.OptionsPrint.AllowMultilineHeaders = true;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowCustomAnnotations = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvDanhMuc.OptionsView.RowAutoHeight = true;
            this.grvDanhMuc.OptionsView.ShowAutoFilterRow = true;
            this.grvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.grvDanhMuc.RowHeight = 2;
            this.grvDanhMuc.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.grvDanhMuc_CustomDrawGroupRow);
            this.grvDanhMuc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grvDanhMuc_MouseDown);
            this.grvDanhMuc.DoubleClick += new System.EventHandler(this.grvDanhMuc_DoubleClick);
            // 
            // lab_Link
            // 
            this.lab_Link.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lab_Link.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lab_Link, 0);
            this.lab_Link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Link.Location = new System.Drawing.Point(4, 5);
            this.lab_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lab_Link.Name = "lab_Link";
            this.tablePanel1.SetRow(this.lab_Link, 0);
            this.lab_Link.Size = new System.Drawing.Size(1395, 30);
            this.lab_Link.TabIndex = 1;
            this.lab_Link.Text = "labelControl1";
            // 
            // panel1
            // 
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.grdDanhMuc);
            this.panel1.Controls.Add(this.accorMenuleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 1);
            this.panel1.Size = new System.Drawing.Size(1397, 738);
            this.panel1.TabIndex = 3;
            // 
            // accorMenuleft
            // 
            this.accorMenuleft.AllowItemSelection = true;
            this.accorMenuleft.Appearance.Item.Normal.Options.UseTextOptions = true;
            this.accorMenuleft.Appearance.Item.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accorMenuleft.Appearance.Item.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.accorMenuleft.Appearance.Item.Pressed.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.accorMenuleft.Appearance.Item.Pressed.Options.UseFont = true;
            this.accorMenuleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.accorMenuleft.Location = new System.Drawing.Point(0, 0);
            this.accorMenuleft.Name = "accorMenuleft";
            this.accorMenuleft.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accorMenuleft.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accorMenuleft.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accorMenuleft.ShowItemExpandButtons = false;
            this.accorMenuleft.Size = new System.Drawing.Size(213, 738);
            this.accorMenuleft.TabIndex = 3;
            this.accorMenuleft.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Client = this.grdDanhMuc;
            this.searchControl.Location = new System.Drawing.Point(1185, 28);
            this.searchControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl.Properties.Appearance.Options.UseFont = true;
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Properties.Client = this.grdDanhMuc;
            this.searchControl.Properties.FindDelay = 100;
            this.searchControl.Size = new System.Drawing.Size(213, 30);
            this.searchControl.TabIndex = 10;
            // 
            // windowsUIButtonPanel1
            // 
            windowsUIButtonImageOptions1.Image = global::VietSoftHRM.Properties.Resources.iconthem;
            windowsUIButtonImageOptions2.Image = global::VietSoftHRM.Properties.Resources.iconsua;
            windowsUIButtonImageOptions3.Image = global::VietSoftHRM.Properties.Resources.iconxoa;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "them", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "sua", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "xoa", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("In", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "in", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thoát", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "thoat", -1, false)});
            this.tablePanel1.SetColumn(this.windowsUIButtonPanel1, 0);
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanel1.Controls.Add(this.searchControl);
            this.windowsUIButtonPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 784);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Padding = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.tablePanel1.SetRow(this.windowsUIButtonPanel1, 2);
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1403, 70);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.lab_Link);
            this.tablePanel1.Controls.Add(this.windowsUIButtonPanel1);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 31F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F)});
            this.tablePanel1.Size = new System.Drawing.Size(1403, 854);
            this.tablePanel1.TabIndex = 4;
            // 
            // ucListDMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucListDMuc";
            this.Size = new System.Drawing.Size(1403, 854);
            this.Load += new System.EventHandler(this.ucListUser_Load);
            this.Resize += new System.EventHandler(this.ucListDMuc_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accorMenuleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            this.windowsUIButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grdDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchControl searchControl;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraBars.Navigation.AccordionControl accorMenuleft;
        public DevExpress.XtraEditors.LabelControl lab_Link;
    }
}
