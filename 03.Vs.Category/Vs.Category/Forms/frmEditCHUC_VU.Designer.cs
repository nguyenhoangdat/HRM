﻿namespace Vs.Category
{
    partial class frmEditCHUC_VU
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnALL = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.MS_CVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_CVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_CV_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_CV_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ID_LOAI_CVSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT_IN_CVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_CV_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_CV_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMS_CV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_CV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSTT_IN_CV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_LOAI_CV = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MS_CVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CV_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CV_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_LOAI_CVSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STT_IN_CVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CV_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CV_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_CV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSTT_IN_CV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_LOAI_CV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnALL
            // 
            windowsUIButtonImageOptions1.Image = global::Vs.Category.Properties.Resources.iconsave;
            windowsUIButtonImageOptions2.Image = global::Vs.Category.Properties.Resources.iconxoa;
            this.btnALL.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lưu", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "luu", -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Hủy", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "huy", -1, false)});
            this.btnALL.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnALL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnALL.Location = new System.Drawing.Point(0, 411);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(993, 47);
            this.btnALL.TabIndex = 6;
            this.btnALL.Text = "windowsUIButtonPanel2";
            this.btnALL.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btnALL_ButtonClick);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90.56F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.94F)});
            this.tablePanel1.Controls.Add(this.dataLayoutControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.tablePanel1.Size = new System.Drawing.Size(993, 411);
            this.tablePanel1.TabIndex = 8;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.MS_CVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_CVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_CV_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_CV_HTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ID_LOAI_CVSearchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.STT_IN_CVTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(47, 43);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(689, 129, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(895, 366);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MS_CVTextEdit
            // 
            this.MS_CVTextEdit.Location = new System.Drawing.Point(84, 36);
            this.MS_CVTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.MS_CVTextEdit.Name = "MS_CVTextEdit";
            this.MS_CVTextEdit.Size = new System.Drawing.Size(361, 20);
            this.MS_CVTextEdit.StyleController = this.dataLayoutControl1;
            this.MS_CVTextEdit.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.MS_CVTextEdit, conditionValidationRule1);
            // 
            // TEN_CVTextEdit
            // 
            this.TEN_CVTextEdit.Location = new System.Drawing.Point(84, 60);
            this.TEN_CVTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TEN_CVTextEdit.Name = "TEN_CVTextEdit";
            this.TEN_CVTextEdit.Size = new System.Drawing.Size(799, 20);
            this.TEN_CVTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_CVTextEdit.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_CVTextEdit, conditionValidationRule2);
            // 
            // TEN_CV_ATextEdit
            // 
            this.TEN_CV_ATextEdit.Location = new System.Drawing.Point(84, 84);
            this.TEN_CV_ATextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TEN_CV_ATextEdit.Name = "TEN_CV_ATextEdit";
            this.TEN_CV_ATextEdit.Size = new System.Drawing.Size(799, 20);
            this.TEN_CV_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_CV_ATextEdit.TabIndex = 7;
            // 
            // TEN_CV_HTextEdit
            // 
            this.TEN_CV_HTextEdit.Location = new System.Drawing.Point(84, 108);
            this.TEN_CV_HTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TEN_CV_HTextEdit.Name = "TEN_CV_HTextEdit";
            this.TEN_CV_HTextEdit.Size = new System.Drawing.Size(799, 20);
            this.TEN_CV_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_CV_HTextEdit.TabIndex = 8;
            // 
            // ID_LOAI_CVSearchLookUpEdit
            // 
            this.ID_LOAI_CVSearchLookUpEdit.Location = new System.Drawing.Point(84, 12);
            this.ID_LOAI_CVSearchLookUpEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ID_LOAI_CVSearchLookUpEdit.Name = "ID_LOAI_CVSearchLookUpEdit";
            this.ID_LOAI_CVSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ID_LOAI_CVSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ID_LOAI_CVSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ID_LOAI_CVSearchLookUpEdit.Properties.NullText = "";
            this.ID_LOAI_CVSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.ID_LOAI_CVSearchLookUpEdit.Size = new System.Drawing.Size(799, 20);
            this.ID_LOAI_CVSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ID_LOAI_CVSearchLookUpEdit.TabIndex = 9;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.ID_LOAI_CVSearchLookUpEdit, conditionValidationRule3);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // STT_IN_CVTextEdit
            // 
            this.STT_IN_CVTextEdit.Location = new System.Drawing.Point(521, 36);
            this.STT_IN_CVTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.STT_IN_CVTextEdit.Name = "STT_IN_CVTextEdit";
            this.STT_IN_CVTextEdit.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.STT_IN_CVTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT_IN_CVTextEdit.Properties.Mask.EditMask = "N0";
            this.STT_IN_CVTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.STT_IN_CVTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.STT_IN_CVTextEdit.Size = new System.Drawing.Size(362, 20);
            this.STT_IN_CVTextEdit.StyleController = this.dataLayoutControl1;
            this.STT_IN_CVTextEdit.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(895, 366);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_CV_A,
            this.ItemForTEN_CV_H,
            this.ItemForMS_CV,
            this.ItemForTEN_CV,
            this.ItemForSTT_IN_CV,
            this.ItemForID_LOAI_CV});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(875, 346);
            // 
            // ItemForTEN_CV_A
            // 
            this.ItemForTEN_CV_A.Control = this.TEN_CV_ATextEdit;
            this.ItemForTEN_CV_A.Location = new System.Drawing.Point(0, 72);
            this.ItemForTEN_CV_A.Name = "ItemForTEN_CV_A";
            this.ItemForTEN_CV_A.Size = new System.Drawing.Size(875, 24);
            this.ItemForTEN_CV_A.Text = "TEN_CV_A";
            this.ItemForTEN_CV_A.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForTEN_CV_H
            // 
            this.ItemForTEN_CV_H.Control = this.TEN_CV_HTextEdit;
            this.ItemForTEN_CV_H.Location = new System.Drawing.Point(0, 96);
            this.ItemForTEN_CV_H.Name = "ItemForTEN_CV_H";
            this.ItemForTEN_CV_H.Size = new System.Drawing.Size(875, 250);
            this.ItemForTEN_CV_H.Text = "TEN_CV_H";
            this.ItemForTEN_CV_H.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForMS_CV
            // 
            this.ItemForMS_CV.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForMS_CV.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForMS_CV.Control = this.MS_CVTextEdit;
            this.ItemForMS_CV.Location = new System.Drawing.Point(0, 24);
            this.ItemForMS_CV.Name = "ItemForMS_CV";
            this.ItemForMS_CV.Size = new System.Drawing.Size(437, 24);
            this.ItemForMS_CV.Text = "MS_CV";
            this.ItemForMS_CV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForTEN_CV
            // 
            this.ItemForTEN_CV.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_CV.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_CV.Control = this.TEN_CVTextEdit;
            this.ItemForTEN_CV.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_CV.Name = "ItemForTEN_CV";
            this.ItemForTEN_CV.Size = new System.Drawing.Size(875, 24);
            this.ItemForTEN_CV.Text = "TEN_CV";
            this.ItemForTEN_CV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForSTT_IN_CV
            // 
            this.ItemForSTT_IN_CV.Control = this.STT_IN_CVTextEdit;
            this.ItemForSTT_IN_CV.Location = new System.Drawing.Point(437, 24);
            this.ItemForSTT_IN_CV.Name = "ItemForSTT_IN_CV";
            this.ItemForSTT_IN_CV.Size = new System.Drawing.Size(438, 24);
            this.ItemForSTT_IN_CV.Text = "STT_IN_CV";
            this.ItemForSTT_IN_CV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForID_LOAI_CV
            // 
            this.ItemForID_LOAI_CV.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForID_LOAI_CV.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForID_LOAI_CV.Control = this.ID_LOAI_CVSearchLookUpEdit;
            this.ItemForID_LOAI_CV.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_LOAI_CV.Name = "ItemForID_LOAI_CV";
            this.ItemForID_LOAI_CV.Size = new System.Drawing.Size(875, 24);
            this.ItemForID_LOAI_CV.Text = "ID_LOAI_CV";
            this.ItemForID_LOAI_CV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // frmEditCHUC_VU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 458);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.btnALL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditCHUC_VU";
            this.Text = "frmEditCHUC_VU";
            this.Load += new System.EventHandler(this.frmEditCHUC_VU_Load);
            this.Resize += new System.EventHandler(this.frmEditCHUC_VU_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MS_CVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CV_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CV_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_LOAI_CVSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STT_IN_CVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CV_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CV_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_CV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSTT_IN_CV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_LOAI_CV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit MS_CVTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_CVTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_CV_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_CV_HTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit ID_LOAI_CVSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit STT_IN_CVTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMS_CV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_CV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_CV_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_CV_H;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_LOAI_CV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSTT_IN_CV;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}