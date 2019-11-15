namespace Vs.Category
{
    partial class frmEditTHANH_PHO
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnWDUI = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TEN_TPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_TP_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_TP_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ID_QGSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MS_TINHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_TP = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_TP_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_TP_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_QG = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMS_TINH = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TP_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TP_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_QGSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MS_TINHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TP_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TP_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_QG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_TINH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWDUI
            // 
            windowsUIButtonImageOptions1.Image = global::Vs.Category.Properties.Resources.iconsave;
            windowsUIButtonImageOptions2.Image = global::Vs.Category.Properties.Resources.iconxoa;
            this.btnWDUI.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "luu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Hủy", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "huy", -1, false)});
            this.btnWDUI.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnWDUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWDUI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWDUI.Location = new System.Drawing.Point(0, 223);
            this.btnWDUI.Name = "btnWDUI";
            this.btnWDUI.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWDUI.Size = new System.Drawing.Size(686, 47);
            this.btnWDUI.TabIndex = 11;
            this.btnWDUI.Text = "windowsUIButtonPanel2";
            this.btnWDUI.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btnWDUI_ButtonClick);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel1.Controls.Add(this.dataLayoutControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.tablePanel1.Size = new System.Drawing.Size(686, 270);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.False;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_TPTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_TP_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_TP_HTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ID_QGSearchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.MS_TINHTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(72, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(543, 237);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_TPTextEdit
            // 
            this.TEN_TPTextEdit.Location = new System.Drawing.Point(60, 29);
            this.TEN_TPTextEdit.Name = "TEN_TPTextEdit";
            this.TEN_TPTextEdit.Size = new System.Drawing.Size(475, 20);
            this.TEN_TPTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_TPTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_TPTextEdit, conditionValidationRule1);
            // 
            // TEN_TP_ATextEdit
            // 
            this.TEN_TP_ATextEdit.Location = new System.Drawing.Point(60, 51);
            this.TEN_TP_ATextEdit.Name = "TEN_TP_ATextEdit";
            this.TEN_TP_ATextEdit.Size = new System.Drawing.Size(475, 20);
            this.TEN_TP_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_TP_ATextEdit.TabIndex = 5;
            // 
            // TEN_TP_HTextEdit
            // 
            this.TEN_TP_HTextEdit.Location = new System.Drawing.Point(60, 73);
            this.TEN_TP_HTextEdit.Name = "TEN_TP_HTextEdit";
            this.TEN_TP_HTextEdit.Size = new System.Drawing.Size(475, 20);
            this.TEN_TP_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_TP_HTextEdit.TabIndex = 6;
            // 
            // ID_QGSearchLookUpEdit
            // 
            this.ID_QGSearchLookUpEdit.Location = new System.Drawing.Point(60, 7);
            this.ID_QGSearchLookUpEdit.Name = "ID_QGSearchLookUpEdit";
            this.ID_QGSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ID_QGSearchLookUpEdit.Properties.NullText = "";
            this.ID_QGSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.ID_QGSearchLookUpEdit.Size = new System.Drawing.Size(210, 20);
            this.ID_QGSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ID_QGSearchLookUpEdit.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.Value1 = "@";
            this.dxValidationProvider1.SetValidationRule(this.ID_QGSearchLookUpEdit, conditionValidationRule2);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MS_TINHTextEdit
            // 
            this.MS_TINHTextEdit.Location = new System.Drawing.Point(324, 7);
            this.MS_TINHTextEdit.Name = "MS_TINHTextEdit";
            this.MS_TINHTextEdit.Size = new System.Drawing.Size(211, 20);
            this.MS_TINHTextEdit.StyleController = this.dataLayoutControl1;
            this.MS_TINHTextEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(543, 237);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_TP,
            this.ItemForTEN_TP_A,
            this.ItemForTEN_TP_H,
            this.ItemForID_QG,
            this.ItemForMS_TINH});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(529, 225);
            // 
            // ItemForTEN_TP
            // 
            this.ItemForTEN_TP.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_TP.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_TP.Control = this.TEN_TPTextEdit;
            this.ItemForTEN_TP.Location = new System.Drawing.Point(0, 22);
            this.ItemForTEN_TP.Name = "ItemForTEN_TP";
            this.ItemForTEN_TP.Size = new System.Drawing.Size(529, 22);
            this.ItemForTEN_TP.Text = "TEN_TP";
            this.ItemForTEN_TP.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForTEN_TP_A
            // 
            this.ItemForTEN_TP_A.Control = this.TEN_TP_ATextEdit;
            this.ItemForTEN_TP_A.Location = new System.Drawing.Point(0, 44);
            this.ItemForTEN_TP_A.Name = "ItemForTEN_TP_A";
            this.ItemForTEN_TP_A.Size = new System.Drawing.Size(529, 22);
            this.ItemForTEN_TP_A.Text = "TEN_TP_A";
            this.ItemForTEN_TP_A.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForTEN_TP_H
            // 
            this.ItemForTEN_TP_H.Control = this.TEN_TP_HTextEdit;
            this.ItemForTEN_TP_H.Location = new System.Drawing.Point(0, 66);
            this.ItemForTEN_TP_H.Name = "ItemForTEN_TP_H";
            this.ItemForTEN_TP_H.Size = new System.Drawing.Size(529, 159);
            this.ItemForTEN_TP_H.Text = "TEN_TP_H";
            this.ItemForTEN_TP_H.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForID_QG
            // 
            this.ItemForID_QG.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForID_QG.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForID_QG.Control = this.ID_QGSearchLookUpEdit;
            this.ItemForID_QG.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_QG.Name = "ItemForID_QG";
            this.ItemForID_QG.Size = new System.Drawing.Size(264, 22);
            this.ItemForID_QG.Text = "ID_QG";
            this.ItemForID_QG.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForMS_TINH
            // 
            this.ItemForMS_TINH.Control = this.MS_TINHTextEdit;
            this.ItemForMS_TINH.Location = new System.Drawing.Point(264, 0);
            this.ItemForMS_TINH.Name = "ItemForMS_TINH";
            this.ItemForMS_TINH.Size = new System.Drawing.Size(265, 22);
            this.ItemForMS_TINH.Text = "MS_TINH";
            this.ItemForMS_TINH.TextSize = new System.Drawing.Size(50, 13);
            // 
            // frmEditTHANH_PHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 270);
            this.Controls.Add(this.btnWDUI);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditTHANH_PHO";
            this.Text = "frmEditTHANH_PHO";
            this.Load += new System.EventHandler(this.frmEditTHANH_PHO_Load);
            this.Resize += new System.EventHandler(this.frmEditTHANH_PHO_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TP_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TP_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_QGSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MS_TINHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TP_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TP_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_QG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_TINH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnWDUI;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TEN_TPTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_TP_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_TP_HTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit ID_QGSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit MS_TINHTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_TP;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_TP_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_TP_H;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_QG;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMS_TINH;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}