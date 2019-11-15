namespace VietSoftHRM
{
    partial class ucListUsers
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
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.grdListUser = new DevExpress.XtraGrid.GridControl();
            this.grvListUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.windowButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.groupListUsers = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListUser)).BeginInit();
            this.windowButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupListUsers)).BeginInit();
            this.groupListUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Client = this.grdListUser;
            this.searchControl.Location = new System.Drawing.Point(618, 37);
            this.searchControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl.Properties.Appearance.Options.UseFont = true;
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Properties.Client = this.grdListUser;
            this.searchControl.Properties.FindDelay = 100;
            this.searchControl.Size = new System.Drawing.Size(286, 30);
            this.searchControl.TabIndex = 10;
            // 
            // grdListUser
            // 
            this.grdListUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListUser.Location = new System.Drawing.Point(2, 21);
            this.grdListUser.MainView = this.grvListUser;
            this.grdListUser.Name = "grdListUser";
            this.grdListUser.Size = new System.Drawing.Size(904, 341);
            this.grdListUser.TabIndex = 0;
            this.grdListUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvListUser});
            this.grdListUser.Load += new System.EventHandler(this.grdListUser_Load);
            // 
            // grvListUser
            // 
            this.grvListUser.GridControl = this.grdListUser;
            this.grvListUser.Name = "grvListUser";
            this.grvListUser.OptionsView.ShowGroupPanel = false;
            this.grvListUser.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grvListUser_RowCellStyle);
            // 
            // windowButton
            // 
            windowsUIButtonImageOptions1.Image = global::VietSoftHRM.Properties.Resources.iconthem;
            windowsUIButtonImageOptions2.Image = global::VietSoftHRM.Properties.Resources.iconExit;
            this.windowButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset mật khẩu", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "resetpass", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thoát", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "thoat", -1, false)});
            this.windowButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowButton.Controls.Add(this.searchControl);
            this.windowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowButton.Location = new System.Drawing.Point(0, 364);
            this.windowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowButton.Name = "windowButton";
            this.windowButton.Padding = new System.Windows.Forms.Padding(5);
            this.windowButton.Size = new System.Drawing.Size(908, 71);
            this.windowButton.TabIndex = 4;
            this.windowButton.Text = "windowsUIButtonPanel1";
            this.windowButton.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowButton_ButtonClick);
            // 
            // groupListUsers
            // 
            this.groupListUsers.Controls.Add(this.grdListUser);
            this.groupListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupListUsers.Location = new System.Drawing.Point(0, 0);
            this.groupListUsers.Name = "groupListUsers";
            this.groupListUsers.Size = new System.Drawing.Size(908, 364);
            this.groupListUsers.TabIndex = 5;
            this.groupListUsers.Text = "groupControl1";
            // 
            // ucListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupListUsers);
            this.Controls.Add(this.windowButton);
            this.Name = "ucListUsers";
            this.Size = new System.Drawing.Size(908, 435);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvListUser)).EndInit();
            this.windowButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupListUsers)).EndInit();
            this.groupListUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SearchControl searchControl;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowButton;
        private DevExpress.XtraEditors.GroupControl groupListUsers;
        private DevExpress.XtraGrid.GridControl grdListUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grvListUser;
    }
}
