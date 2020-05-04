namespace Vs.HRM
{
    partial class frmNDDanhGia
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.windowsUIButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.grdNDDanhGia = new DevExpress.XtraGrid.GridControl();
            this.grvNDDanhGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_NDDGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_NDDG_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_NDDG_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_NDDG = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_NDDG_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_NDDG_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNDDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNDDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NDDGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NDDG_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NDDG_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NDDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NDDG_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NDDG_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButton
            // 
            windowsUIButtonImageOptions1.Image = global::Vs.HRM.Properties.Resources.iconthem;
            windowsUIButtonImageOptions2.Image = global::Vs.HRM.Properties.Resources.iconsua;
            windowsUIButtonImageOptions3.Image = global::Vs.HRM.Properties.Resources.iconxoa;
            windowsUIButtonImageOptions4.Image = global::Vs.HRM.Properties.Resources.iconsave;
            windowsUIButtonImageOptions5.Image = global::Vs.HRM.Properties.Resources.iconNosave;
            windowsUIButtonImageOptions6.Image = global::Vs.HRM.Properties.Resources.iconExit;
            this.windowsUIButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "them", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sữa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "sua", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "xoa", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "luu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Không lưu", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "khongluu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thoát", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "thoat", -1, false)});
            this.windowsUIButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowsUIButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButton.Location = new System.Drawing.Point(0, 350);
            this.windowsUIButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButton.Name = "windowsUIButton";
            this.windowsUIButton.Padding = new System.Windows.Forms.Padding(5);
            this.windowsUIButton.Size = new System.Drawing.Size(450, 65);
            this.windowsUIButton.TabIndex = 10;
            this.windowsUIButton.Text = "windowsUIButtonPanel1";
            this.windowsUIButton.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButton_ButtonClick);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.grdNDDanhGia);
            this.dataLayoutControl1.Controls.Add(this.TEN_NDDGTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_NDDG_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_NDDG_HTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(450, 350);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // grdNDDanhGia
            // 
            this.grdNDDanhGia.Location = new System.Drawing.Point(6, 90);
            this.grdNDDanhGia.MainView = this.grvNDDanhGia;
            this.grdNDDanhGia.Name = "grdNDDanhGia";
            this.grdNDDanhGia.Size = new System.Drawing.Size(438, 254);
            this.grdNDDanhGia.TabIndex = 7;
            this.grdNDDanhGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNDDanhGia});
            this.grdNDDanhGia.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.grdNDDanhGia_ProcessGridKey);
            // 
            // grvNDDanhGia
            // 
            this.grvNDDanhGia.GridControl = this.grdNDDanhGia;
            this.grvNDDanhGia.Name = "grvNDDanhGia";
            this.grvNDDanhGia.OptionsView.ShowGroupPanel = false;
            this.grvNDDanhGia.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvNDDanhGia_FocusedRowChanged);
            // 
            // TEN_NDDGTextEdit
            // 
            this.TEN_NDDGTextEdit.Location = new System.Drawing.Point(102, 6);
            this.TEN_NDDGTextEdit.Name = "TEN_NDDGTextEdit";
            this.TEN_NDDGTextEdit.Size = new System.Drawing.Size(342, 26);
            this.TEN_NDDGTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_NDDGTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.TEN_NDDGTextEdit, conditionValidationRule1);
            // 
            // TEN_NDDG_ATextEdit
            // 
            this.TEN_NDDG_ATextEdit.Location = new System.Drawing.Point(102, 34);
            this.TEN_NDDG_ATextEdit.Name = "TEN_NDDG_ATextEdit";
            this.TEN_NDDG_ATextEdit.Size = new System.Drawing.Size(342, 26);
            this.TEN_NDDG_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_NDDG_ATextEdit.TabIndex = 5;
            // 
            // TEN_NDDG_HTextEdit
            // 
            this.TEN_NDDG_HTextEdit.Location = new System.Drawing.Point(102, 62);
            this.TEN_NDDG_HTextEdit.Name = "TEN_NDDG_HTextEdit";
            this.TEN_NDDG_HTextEdit.Size = new System.Drawing.Size(342, 26);
            this.TEN_NDDG_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_NDDG_HTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(450, 350);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_NDDG,
            this.ItemForTEN_NDDG_A,
            this.ItemForTEN_NDDG_H,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(440, 340);
            // 
            // ItemForTEN_NDDG
            // 
            this.ItemForTEN_NDDG.Control = this.TEN_NDDGTextEdit;
            this.ItemForTEN_NDDG.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_NDDG.Name = "ItemForTEN_NDDG";
            this.ItemForTEN_NDDG.Size = new System.Drawing.Size(440, 28);
            this.ItemForTEN_NDDG.Text = "TEN_NDDG";
            this.ItemForTEN_NDDG.TextSize = new System.Drawing.Size(93, 20);
            // 
            // ItemForTEN_NDDG_A
            // 
            this.ItemForTEN_NDDG_A.Control = this.TEN_NDDG_ATextEdit;
            this.ItemForTEN_NDDG_A.Location = new System.Drawing.Point(0, 28);
            this.ItemForTEN_NDDG_A.Name = "ItemForTEN_NDDG_A";
            this.ItemForTEN_NDDG_A.Size = new System.Drawing.Size(440, 28);
            this.ItemForTEN_NDDG_A.Text = "TEN_NDDG_A";
            this.ItemForTEN_NDDG_A.TextSize = new System.Drawing.Size(93, 20);
            // 
            // ItemForTEN_NDDG_H
            // 
            this.ItemForTEN_NDDG_H.Control = this.TEN_NDDG_HTextEdit;
            this.ItemForTEN_NDDG_H.Location = new System.Drawing.Point(0, 56);
            this.ItemForTEN_NDDG_H.Name = "ItemForTEN_NDDG_H";
            this.ItemForTEN_NDDG_H.Size = new System.Drawing.Size(440, 28);
            this.ItemForTEN_NDDG_H.Text = "TEN_NDDG_H";
            this.ItemForTEN_NDDG_H.TextSize = new System.Drawing.Size(93, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdNDDanhGia;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(440, 256);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmNDDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 415);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.windowsUIButton);
            this.Name = "frmNDDanhGia";
            this.Text = "frmNDDanhGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNDDanhGia_FormClosing);
            this.Load += new System.EventHandler(this.frmNDDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNDDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNDDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NDDGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NDDG_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NDDG_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NDDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NDDG_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NDDG_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdNDDanhGia;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNDDanhGia;
        private DevExpress.XtraEditors.TextEdit TEN_NDDGTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_NDDG_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_NDDG_HTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_NDDG;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_NDDG_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_NDDG_H;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}