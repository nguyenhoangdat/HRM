namespace Vs.HRM
{
    partial class frmToKhaiBHXH
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions10 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions11 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions12 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.windowsUIButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.grdToKhaiBHXH = new DevExpress.XtraGrid.GridControl();
            this.grvToKhaiBHXH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SO_TKTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NOI_DUNG_THAY_DOIMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.TAI_LIEU_KEM_THEOMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSO_TK = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNOI_DUNG_THAY_DOI = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTAI_LIEU_KEM_THEO = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_SoHD = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lbl_NgayHD = new DevExpress.XtraLayout.SimpleLabelItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdToKhaiBHXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvToKhaiBHXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO_TKTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOI_DUNG_THAY_DOIMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAI_LIEU_KEM_THEOMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSO_TK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNOI_DUNG_THAY_DOI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTAI_LIEU_KEM_THEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_SoHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_NgayHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButton
            // 
            windowsUIButtonImageOptions7.Image = global::Vs.HRM.Properties.Resources.iconthem;
            windowsUIButtonImageOptions8.Image = global::Vs.HRM.Properties.Resources.iconsua;
            windowsUIButtonImageOptions9.Image = global::Vs.HRM.Properties.Resources.iconxoa;
            windowsUIButtonImageOptions10.Image = global::Vs.HRM.Properties.Resources.iconsave;
            windowsUIButtonImageOptions11.Image = global::Vs.HRM.Properties.Resources.iconNosave;
            windowsUIButtonImageOptions12.Image = global::Vs.HRM.Properties.Resources.iconExit;
            this.windowsUIButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "them", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sữa", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "sua", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Xóa", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "xoa", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu", true, windowsUIButtonImageOptions10, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "luu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Không lưu", true, windowsUIButtonImageOptions11, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "khongluu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thoát", true, windowsUIButtonImageOptions12, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "thoat", -1, false)});
            this.windowsUIButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowsUIButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButton.Location = new System.Drawing.Point(0, 388);
            this.windowsUIButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButton.Name = "windowsUIButton";
            this.windowsUIButton.Padding = new System.Windows.Forms.Padding(5);
            this.windowsUIButton.Size = new System.Drawing.Size(607, 65);
            this.windowsUIButton.TabIndex = 10;
            this.windowsUIButton.Text = "windowsUIButtonPanel1";
            this.windowsUIButton.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButton_ButtonClick);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.grdToKhaiBHXH);
            this.dataLayoutControl1.Controls.Add(this.SO_TKTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NOI_DUNG_THAY_DOIMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.TAI_LIEU_KEM_THEOMemoEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(607, 388);
            this.dataLayoutControl1.TabIndex = 11;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // grdToKhaiBHXH
            // 
            this.grdToKhaiBHXH.Location = new System.Drawing.Point(6, 156);
            this.grdToKhaiBHXH.MainView = this.grvToKhaiBHXH;
            this.grdToKhaiBHXH.Name = "grdToKhaiBHXH";
            this.grdToKhaiBHXH.Size = new System.Drawing.Size(595, 226);
            this.grdToKhaiBHXH.TabIndex = 7;
            this.grdToKhaiBHXH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvToKhaiBHXH});
            this.grdToKhaiBHXH.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.grd_ToKhaiBHXH_ProcessGridKey);
            // 
            // grvToKhaiBHXH
            // 
            this.grvToKhaiBHXH.GridControl = this.grdToKhaiBHXH;
            this.grvToKhaiBHXH.Name = "grvToKhaiBHXH";
            this.grvToKhaiBHXH.OptionsView.ShowGroupPanel = false;
            this.grvToKhaiBHXH.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvToKhaiBHXH_FocusedRowChanged);
            // 
            // SO_TKTextEdit
            // 
            this.SO_TKTextEdit.Location = new System.Drawing.Point(158, 28);
            this.SO_TKTextEdit.Name = "SO_TKTextEdit";
            this.SO_TKTextEdit.Size = new System.Drawing.Size(184, 26);
            this.SO_TKTextEdit.StyleController = this.dataLayoutControl1;
            this.SO_TKTextEdit.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.SO_TKTextEdit, conditionValidationRule2);
            // 
            // NOI_DUNG_THAY_DOIMemoEdit
            // 
            this.NOI_DUNG_THAY_DOIMemoEdit.Location = new System.Drawing.Point(158, 56);
            this.NOI_DUNG_THAY_DOIMemoEdit.Name = "NOI_DUNG_THAY_DOIMemoEdit";
            this.NOI_DUNG_THAY_DOIMemoEdit.Size = new System.Drawing.Size(443, 48);
            this.NOI_DUNG_THAY_DOIMemoEdit.StyleController = this.dataLayoutControl1;
            this.NOI_DUNG_THAY_DOIMemoEdit.TabIndex = 5;
            // 
            // TAI_LIEU_KEM_THEOMemoEdit
            // 
            this.TAI_LIEU_KEM_THEOMemoEdit.Location = new System.Drawing.Point(158, 106);
            this.TAI_LIEU_KEM_THEOMemoEdit.Name = "TAI_LIEU_KEM_THEOMemoEdit";
            this.TAI_LIEU_KEM_THEOMemoEdit.Size = new System.Drawing.Size(443, 48);
            this.TAI_LIEU_KEM_THEOMemoEdit.StyleController = this.dataLayoutControl1;
            this.TAI_LIEU_KEM_THEOMemoEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(607, 388);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSO_TK,
            this.ItemForNOI_DUNG_THAY_DOI,
            this.ItemForTAI_LIEU_KEM_THEO,
            this.layoutControlItem1,
            this.lbl_SoHD,
            this.lbl_NgayHD,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(597, 378);
            // 
            // ItemForSO_TK
            // 
            this.ItemForSO_TK.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ItemForSO_TK.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForSO_TK.Control = this.SO_TKTextEdit;
            this.ItemForSO_TK.Location = new System.Drawing.Point(0, 22);
            this.ItemForSO_TK.Name = "ItemForSO_TK";
            this.ItemForSO_TK.Size = new System.Drawing.Size(338, 28);
            this.ItemForSO_TK.Text = "SO_TK";
            this.ItemForSO_TK.TextSize = new System.Drawing.Size(149, 20);
            // 
            // ItemForNOI_DUNG_THAY_DOI
            // 
            this.ItemForNOI_DUNG_THAY_DOI.Control = this.NOI_DUNG_THAY_DOIMemoEdit;
            this.ItemForNOI_DUNG_THAY_DOI.Location = new System.Drawing.Point(0, 50);
            this.ItemForNOI_DUNG_THAY_DOI.Name = "ItemForNOI_DUNG_THAY_DOI";
            this.ItemForNOI_DUNG_THAY_DOI.Size = new System.Drawing.Size(597, 50);
            this.ItemForNOI_DUNG_THAY_DOI.StartNewLine = true;
            this.ItemForNOI_DUNG_THAY_DOI.Text = "NOI_DUNG_THAY_DOI";
            this.ItemForNOI_DUNG_THAY_DOI.TextSize = new System.Drawing.Size(149, 20);
            // 
            // ItemForTAI_LIEU_KEM_THEO
            // 
            this.ItemForTAI_LIEU_KEM_THEO.Control = this.TAI_LIEU_KEM_THEOMemoEdit;
            this.ItemForTAI_LIEU_KEM_THEO.Location = new System.Drawing.Point(0, 100);
            this.ItemForTAI_LIEU_KEM_THEO.Name = "ItemForTAI_LIEU_KEM_THEO";
            this.ItemForTAI_LIEU_KEM_THEO.Size = new System.Drawing.Size(597, 50);
            this.ItemForTAI_LIEU_KEM_THEO.StartNewLine = true;
            this.ItemForTAI_LIEU_KEM_THEO.Text = "TAI_LIEU_KEM_THEO";
            this.ItemForTAI_LIEU_KEM_THEO.TextSize = new System.Drawing.Size(149, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdToKhaiBHXH;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(597, 228);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lbl_SoHD
            // 
            this.lbl_SoHD.AllowHotTrack = false;
            this.lbl_SoHD.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.lbl_SoHD.AppearanceItemCaption.Options.UseForeColor = true;
            this.lbl_SoHD.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lbl_SoHD.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_SoHD.CustomizationFormText = "lbl_SoHD";
            this.lbl_SoHD.Location = new System.Drawing.Point(0, 0);
            this.lbl_SoHD.Name = "lbl_SoHD";
            this.lbl_SoHD.Size = new System.Drawing.Size(211, 22);
            this.lbl_SoHD.TextSize = new System.Drawing.Size(149, 20);
            // 
            // lbl_NgayHD
            // 
            this.lbl_NgayHD.AllowHotTrack = false;
            this.lbl_NgayHD.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.lbl_NgayHD.AppearanceItemCaption.Options.UseForeColor = true;
            this.lbl_NgayHD.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lbl_NgayHD.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_NgayHD.CustomizationFormText = "lbl_NgayHD";
            this.lbl_NgayHD.Location = new System.Drawing.Point(211, 0);
            this.lbl_NgayHD.MinSize = new System.Drawing.Size(151, 22);
            this.lbl_NgayHD.Name = "lbl_NgayHD";
            this.lbl_NgayHD.Size = new System.Drawing.Size(386, 22);
            this.lbl_NgayHD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lbl_NgayHD.TextSize = new System.Drawing.Size(149, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(338, 22);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(259, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmToKhaiBHXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 453);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.windowsUIButton);
            this.Name = "frmToKhaiBHXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmToKhaiBHXH";
            this.Load += new System.EventHandler(this.frmToKhaiBHXH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdToKhaiBHXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvToKhaiBHXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO_TKTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOI_DUNG_THAY_DOIMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAI_LIEU_KEM_THEOMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSO_TK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNOI_DUNG_THAY_DOI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTAI_LIEU_KEM_THEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_SoHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_NgayHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grdToKhaiBHXH;
        private DevExpress.XtraGrid.Views.Grid.GridView grvToKhaiBHXH;
        private DevExpress.XtraEditors.TextEdit SO_TKTextEdit;
        private DevExpress.XtraEditors.MemoEdit NOI_DUNG_THAY_DOIMemoEdit;
        private DevExpress.XtraEditors.MemoEdit TAI_LIEU_KEM_THEOMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSO_TK;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNOI_DUNG_THAY_DOI;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTAI_LIEU_KEM_THEO;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleLabelItem lbl_SoHD;
        private DevExpress.XtraLayout.SimpleLabelItem lbl_NgayHD;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}