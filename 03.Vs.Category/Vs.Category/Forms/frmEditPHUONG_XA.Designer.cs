﻿namespace Vs.Category
{
    partial class frmEditPHUONG_XA
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
            this.btnALL = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ID_TPSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_PXTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_PX_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_PX_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ID_QUANSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MS_XATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_PX = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_PX_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_PX_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMS_XA = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_QUAN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_TP = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_TPSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_PXTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_PX_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_PX_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_QUANSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MS_XATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_PX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_PX_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_PX_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_XA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_QUAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_TP)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 319);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(608, 47);
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
            this.tablePanel1.Size = new System.Drawing.Size(608, 366);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.ID_TPSearchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_PXTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_PX_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_PX_HTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ID_QUANSearchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.MS_XATextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(64, 40);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(480, 323);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ID_TPSearchLookUpEdit
            // 
            this.ID_TPSearchLookUpEdit.Location = new System.Drawing.Point(66, 12);
            this.ID_TPSearchLookUpEdit.Name = "ID_TPSearchLookUpEdit";
            this.ID_TPSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ID_TPSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ID_TPSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ID_TPSearchLookUpEdit.Properties.NullText = "";
            this.ID_TPSearchLookUpEdit.Properties.PopupView = this.gridView1;
            this.ID_TPSearchLookUpEdit.Size = new System.Drawing.Size(402, 20);
            this.ID_TPSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ID_TPSearchLookUpEdit.TabIndex = 8;
            this.ID_TPSearchLookUpEdit.EditValueChanged += new System.EventHandler(this.ID_TPSearchLookUpEdit_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TEN_PXTextEdit
            // 
            this.TEN_PXTextEdit.Location = new System.Drawing.Point(66, 60);
            this.TEN_PXTextEdit.Name = "TEN_PXTextEdit";
            this.TEN_PXTextEdit.Size = new System.Drawing.Size(402, 20);
            this.TEN_PXTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_PXTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_PXTextEdit, conditionValidationRule1);
            // 
            // TEN_PX_ATextEdit
            // 
            this.TEN_PX_ATextEdit.Location = new System.Drawing.Point(66, 84);
            this.TEN_PX_ATextEdit.Name = "TEN_PX_ATextEdit";
            this.TEN_PX_ATextEdit.Size = new System.Drawing.Size(402, 20);
            this.TEN_PX_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_PX_ATextEdit.TabIndex = 5;
            // 
            // TEN_PX_HTextEdit
            // 
            this.TEN_PX_HTextEdit.Location = new System.Drawing.Point(66, 108);
            this.TEN_PX_HTextEdit.Name = "TEN_PX_HTextEdit";
            this.TEN_PX_HTextEdit.Size = new System.Drawing.Size(402, 20);
            this.TEN_PX_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_PX_HTextEdit.TabIndex = 6;
            // 
            // ID_QUANSearchLookUpEdit
            // 
            this.ID_QUANSearchLookUpEdit.Location = new System.Drawing.Point(66, 36);
            this.ID_QUANSearchLookUpEdit.Name = "ID_QUANSearchLookUpEdit";
            this.ID_QUANSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ID_QUANSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ID_QUANSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ID_QUANSearchLookUpEdit.Properties.NullText = "";
            this.ID_QUANSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.ID_QUANSearchLookUpEdit.Size = new System.Drawing.Size(402, 20);
            this.ID_QUANSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ID_QUANSearchLookUpEdit.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.ID_QUANSearchLookUpEdit, conditionValidationRule2);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MS_XATextEdit
            // 
            this.MS_XATextEdit.Location = new System.Drawing.Point(66, 132);
            this.MS_XATextEdit.Name = "MS_XATextEdit";
            this.MS_XATextEdit.Size = new System.Drawing.Size(402, 20);
            this.MS_XATextEdit.StyleController = this.dataLayoutControl1;
            this.MS_XATextEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(480, 323);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_PX,
            this.ItemForTEN_PX_A,
            this.ItemForTEN_PX_H,
            this.ItemForMS_XA,
            this.ItemForID_QUAN,
            this.ItemForID_TP});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(460, 303);
            // 
            // ItemForTEN_PX
            // 
            this.ItemForTEN_PX.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_PX.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_PX.Control = this.TEN_PXTextEdit;
            this.ItemForTEN_PX.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_PX.Name = "ItemForTEN_PX";
            this.ItemForTEN_PX.Size = new System.Drawing.Size(460, 24);
            this.ItemForTEN_PX.Text = "TEN_PX";
            this.ItemForTEN_PX.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForTEN_PX_A
            // 
            this.ItemForTEN_PX_A.Control = this.TEN_PX_ATextEdit;
            this.ItemForTEN_PX_A.Location = new System.Drawing.Point(0, 72);
            this.ItemForTEN_PX_A.Name = "ItemForTEN_PX_A";
            this.ItemForTEN_PX_A.Size = new System.Drawing.Size(460, 24);
            this.ItemForTEN_PX_A.Text = "TEN_PX_A";
            this.ItemForTEN_PX_A.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForTEN_PX_H
            // 
            this.ItemForTEN_PX_H.Control = this.TEN_PX_HTextEdit;
            this.ItemForTEN_PX_H.Location = new System.Drawing.Point(0, 96);
            this.ItemForTEN_PX_H.Name = "ItemForTEN_PX_H";
            this.ItemForTEN_PX_H.Size = new System.Drawing.Size(460, 24);
            this.ItemForTEN_PX_H.Text = "TEN_PX_H";
            this.ItemForTEN_PX_H.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForMS_XA
            // 
            this.ItemForMS_XA.Control = this.MS_XATextEdit;
            this.ItemForMS_XA.Location = new System.Drawing.Point(0, 120);
            this.ItemForMS_XA.Name = "ItemForMS_XA";
            this.ItemForMS_XA.Size = new System.Drawing.Size(460, 183);
            this.ItemForMS_XA.Text = "MS_XA";
            this.ItemForMS_XA.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForID_QUAN
            // 
            this.ItemForID_QUAN.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForID_QUAN.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForID_QUAN.Control = this.ID_QUANSearchLookUpEdit;
            this.ItemForID_QUAN.Location = new System.Drawing.Point(0, 24);
            this.ItemForID_QUAN.Name = "ItemForID_QUAN";
            this.ItemForID_QUAN.Size = new System.Drawing.Size(460, 24);
            this.ItemForID_QUAN.Text = "ID_QUAN";
            this.ItemForID_QUAN.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForID_TP
            // 
            this.ItemForID_TP.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForID_TP.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForID_TP.Control = this.ID_TPSearchLookUpEdit;
            this.ItemForID_TP.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_TP.Name = "ItemForID_TP";
            this.ItemForID_TP.Size = new System.Drawing.Size(460, 24);
            this.ItemForID_TP.Text = "ID_TP";
            this.ItemForID_TP.TextSize = new System.Drawing.Size(51, 13);
            // 
            // frmEditPHUONG_XA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 366);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditPHUONG_XA";
            this.Text = "frmEditPHUONG_XA";
            this.Load += new System.EventHandler(this.frmEditPHUONG_XA_Load);
            this.Resize += new System.EventHandler(this.frmEditPHUONG_XA_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ID_TPSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_PXTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_PX_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_PX_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_QUANSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MS_XATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_PX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_PX_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_PX_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_XA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_QUAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit TEN_PXTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_PX_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_PX_HTextEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit ID_QUANSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit MS_XATextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_PX;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_PX_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_PX_H;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_QUAN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMS_XA;
        private DevExpress.XtraEditors.SearchLookUpEdit ID_TPSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForID_TP;
    }
}