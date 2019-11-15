﻿namespace Vs.Category
{
    partial class frmEditLOAI_CONG_VIEC
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
            this.btnALL = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TEN_LCVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_LCV_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_LCV_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DOC_HAICheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.PHEP_CTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ID_LTSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_LCV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_LCV_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_LCV_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDOC_HAI = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPHEP_CT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_LT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LCVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LCV_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LCV_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOC_HAICheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHEP_CTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_LTSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LCV_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LCV_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDOC_HAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPHEP_CT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_LT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
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
            this.btnALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnALL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnALL.Location = new System.Drawing.Point(0, 280);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(578, 47);
            this.btnALL.TabIndex = 11;
            this.btnALL.Text = "windowsUIButtonPanel2";
            this.btnALL.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btnALL_ButtonClick);
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
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.tablePanel1.Size = new System.Drawing.Size(578, 327);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_LCVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_LCV_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_LCV_HTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DOC_HAICheckEdit);
            this.dataLayoutControl1.Controls.Add(this.PHEP_CTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ID_LTSearchLookUpEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(61, 36);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(456, 288);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_LCVTextEdit
            // 
            this.TEN_LCVTextEdit.Location = new System.Drawing.Point(71, 12);
            this.TEN_LCVTextEdit.Name = "TEN_LCVTextEdit";
            this.TEN_LCVTextEdit.Size = new System.Drawing.Size(373, 20);
            this.TEN_LCVTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LCVTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_LCVTextEdit, conditionValidationRule1);
            // 
            // TEN_LCV_ATextEdit
            // 
            this.TEN_LCV_ATextEdit.Location = new System.Drawing.Point(71, 36);
            this.TEN_LCV_ATextEdit.Name = "TEN_LCV_ATextEdit";
            this.TEN_LCV_ATextEdit.Size = new System.Drawing.Size(373, 20);
            this.TEN_LCV_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LCV_ATextEdit.TabIndex = 5;
            // 
            // TEN_LCV_HTextEdit
            // 
            this.TEN_LCV_HTextEdit.Location = new System.Drawing.Point(71, 60);
            this.TEN_LCV_HTextEdit.Name = "TEN_LCV_HTextEdit";
            this.TEN_LCV_HTextEdit.Size = new System.Drawing.Size(373, 20);
            this.TEN_LCV_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LCV_HTextEdit.TabIndex = 6;
            // 
            // DOC_HAICheckEdit
            // 
            this.DOC_HAICheckEdit.Location = new System.Drawing.Point(12, 84);
            this.DOC_HAICheckEdit.Name = "DOC_HAICheckEdit";
            this.DOC_HAICheckEdit.Properties.Caption = "DOC_HAI";
            this.DOC_HAICheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DOC_HAICheckEdit.Size = new System.Drawing.Size(103, 19);
            this.DOC_HAICheckEdit.StyleController = this.dataLayoutControl1;
            this.DOC_HAICheckEdit.TabIndex = 7;
            // 
            // PHEP_CTTextEdit
            // 
            this.PHEP_CTTextEdit.Location = new System.Drawing.Point(202, 84);
            this.PHEP_CTTextEdit.Name = "PHEP_CTTextEdit";
            this.PHEP_CTTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PHEP_CTTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PHEP_CTTextEdit.Properties.Mask.EditMask = "n0";
            this.PHEP_CTTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PHEP_CTTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PHEP_CTTextEdit.Size = new System.Drawing.Size(50, 20);
            this.PHEP_CTTextEdit.StyleController = this.dataLayoutControl1;
            this.PHEP_CTTextEdit.TabIndex = 8;
            // 
            // ID_LTSearchLookUpEdit
            // 
            this.ID_LTSearchLookUpEdit.Location = new System.Drawing.Point(339, 84);
            this.ID_LTSearchLookUpEdit.Name = "ID_LTSearchLookUpEdit";
            this.ID_LTSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ID_LTSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ID_LTSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ID_LTSearchLookUpEdit.Properties.NullText = "";
            this.ID_LTSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.ID_LTSearchLookUpEdit.Size = new System.Drawing.Size(105, 20);
            this.ID_LTSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ID_LTSearchLookUpEdit.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(456, 288);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_LCV,
            this.ItemForTEN_LCV_A,
            this.ItemForTEN_LCV_H,
            this.ItemForDOC_HAI,
            this.ItemForPHEP_CT,
            this.ItemForID_LT,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(436, 268);
            // 
            // ItemForTEN_LCV
            // 
            this.ItemForTEN_LCV.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_LCV.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_LCV.Control = this.TEN_LCVTextEdit;
            this.ItemForTEN_LCV.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_LCV.Name = "ItemForTEN_LCV";
            this.ItemForTEN_LCV.Size = new System.Drawing.Size(436, 24);
            this.ItemForTEN_LCV.Text = "TEN_LCV";
            this.ItemForTEN_LCV.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ItemForTEN_LCV_A
            // 
            this.ItemForTEN_LCV_A.Control = this.TEN_LCV_ATextEdit;
            this.ItemForTEN_LCV_A.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_LCV_A.Name = "ItemForTEN_LCV_A";
            this.ItemForTEN_LCV_A.Size = new System.Drawing.Size(436, 24);
            this.ItemForTEN_LCV_A.Text = "TEN_LCV_A";
            this.ItemForTEN_LCV_A.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ItemForTEN_LCV_H
            // 
            this.ItemForTEN_LCV_H.Control = this.TEN_LCV_HTextEdit;
            this.ItemForTEN_LCV_H.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_LCV_H.Name = "ItemForTEN_LCV_H";
            this.ItemForTEN_LCV_H.Size = new System.Drawing.Size(436, 24);
            this.ItemForTEN_LCV_H.Text = "TEN_LCV_H";
            this.ItemForTEN_LCV_H.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ItemForDOC_HAI
            // 
            this.ItemForDOC_HAI.Control = this.DOC_HAICheckEdit;
            this.ItemForDOC_HAI.Location = new System.Drawing.Point(0, 72);
            this.ItemForDOC_HAI.Name = "ItemForDOC_HAI";
            this.ItemForDOC_HAI.Size = new System.Drawing.Size(107, 196);
            this.ItemForDOC_HAI.Text = "DOC_HAI";
            this.ItemForDOC_HAI.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDOC_HAI.TextVisible = false;
            // 
            // ItemForPHEP_CT
            // 
            this.ItemForPHEP_CT.Control = this.PHEP_CTTextEdit;
            this.ItemForPHEP_CT.Location = new System.Drawing.Point(131, 72);
            this.ItemForPHEP_CT.Name = "ItemForPHEP_CT";
            this.ItemForPHEP_CT.Size = new System.Drawing.Size(113, 196);
            this.ItemForPHEP_CT.Text = "PHEP_CT";
            this.ItemForPHEP_CT.TextSize = new System.Drawing.Size(56, 13);
            // 
            // ItemForID_LT
            // 
            this.ItemForID_LT.Control = this.ID_LTSearchLookUpEdit;
            this.ItemForID_LT.Location = new System.Drawing.Point(268, 72);
            this.ItemForID_LT.Name = "ItemForID_LT";
            this.ItemForID_LT.Size = new System.Drawing.Size(168, 196);
            this.ItemForID_LT.Text = "ID_LT";
            this.ItemForID_LT.TextSize = new System.Drawing.Size(56, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(107, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(24, 196);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(244, 72);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(24, 196);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmEditLOAI_CONG_VIEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 327);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditLOAI_CONG_VIEC";
            this.Text = "frmEditLOAI_CONG_VIEC";
            this.Load += new System.EventHandler(this.frmEditLOAI_CONG_VIEC_Load);
            this.Resize += new System.EventHandler(this.frmEditLOAI_CONG_VIEC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LCVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LCV_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LCV_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOC_HAICheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHEP_CTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_LTSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LCV_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LCV_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDOC_HAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPHEP_CT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_LT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TEN_LCVTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_LCV_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_LCV_HTextEdit;
        private DevExpress.XtraEditors.CheckEdit DOC_HAICheckEdit;
        private DevExpress.XtraEditors.TextEdit PHEP_CTTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit ID_LTSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LCV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LCV_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LCV_H;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDOC_HAI;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPHEP_CT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_LT;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}