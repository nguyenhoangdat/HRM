﻿namespace Vs.Category
{
    partial class frmEditCHE_DO_NGHI
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
            this.TEN_CHE_DOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_CHE_DO_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_CHE_DO_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_CHE_DO = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_CHE_DO_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_CHE_DO_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CHE_DOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CHE_DO_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CHE_DO_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CHE_DO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CHE_DO_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CHE_DO_H)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 305);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(575, 47);
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
            this.tablePanel1.Size = new System.Drawing.Size(575, 352);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_CHE_DOTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_CHE_DO_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_CHE_DO_HTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(61, 38);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(583, 32, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(454, 311);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_CHE_DOTextEdit
            // 
            this.TEN_CHE_DOTextEdit.Location = new System.Drawing.Point(94, 12);
            this.TEN_CHE_DOTextEdit.Name = "TEN_CHE_DOTextEdit";
            this.TEN_CHE_DOTextEdit.Size = new System.Drawing.Size(348, 20);
            this.TEN_CHE_DOTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_CHE_DOTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_CHE_DOTextEdit, conditionValidationRule1);
            // 
            // TEN_CHE_DO_ATextEdit
            // 
            this.TEN_CHE_DO_ATextEdit.Location = new System.Drawing.Point(94, 36);
            this.TEN_CHE_DO_ATextEdit.Name = "TEN_CHE_DO_ATextEdit";
            this.TEN_CHE_DO_ATextEdit.Size = new System.Drawing.Size(348, 20);
            this.TEN_CHE_DO_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_CHE_DO_ATextEdit.TabIndex = 5;
            // 
            // TEN_CHE_DO_HTextEdit
            // 
            this.TEN_CHE_DO_HTextEdit.Location = new System.Drawing.Point(94, 60);
            this.TEN_CHE_DO_HTextEdit.Name = "TEN_CHE_DO_HTextEdit";
            this.TEN_CHE_DO_HTextEdit.Size = new System.Drawing.Size(348, 20);
            this.TEN_CHE_DO_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_CHE_DO_HTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(454, 311);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_CHE_DO,
            this.ItemForTEN_CHE_DO_A,
            this.ItemForTEN_CHE_DO_H});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(434, 291);
            // 
            // ItemForTEN_CHE_DO
            // 
            this.ItemForTEN_CHE_DO.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_CHE_DO.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_CHE_DO.Control = this.TEN_CHE_DOTextEdit;
            this.ItemForTEN_CHE_DO.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_CHE_DO.Name = "ItemForTEN_CHE_DO";
            this.ItemForTEN_CHE_DO.Size = new System.Drawing.Size(434, 24);
            this.ItemForTEN_CHE_DO.Text = "TEN_CHE_DO";
            this.ItemForTEN_CHE_DO.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForTEN_CHE_DO_A
            // 
            this.ItemForTEN_CHE_DO_A.Control = this.TEN_CHE_DO_ATextEdit;
            this.ItemForTEN_CHE_DO_A.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_CHE_DO_A.Name = "ItemForTEN_CHE_DO_A";
            this.ItemForTEN_CHE_DO_A.Size = new System.Drawing.Size(434, 24);
            this.ItemForTEN_CHE_DO_A.Text = "TEN_CHE_DO_A";
            this.ItemForTEN_CHE_DO_A.TextSize = new System.Drawing.Size(79, 13);
            // 
            // ItemForTEN_CHE_DO_H
            // 
            this.ItemForTEN_CHE_DO_H.Control = this.TEN_CHE_DO_HTextEdit;
            this.ItemForTEN_CHE_DO_H.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_CHE_DO_H.Name = "ItemForTEN_CHE_DO_H";
            this.ItemForTEN_CHE_DO_H.Size = new System.Drawing.Size(434, 243);
            this.ItemForTEN_CHE_DO_H.Text = "TEN_CHE_DO_H";
            this.ItemForTEN_CHE_DO_H.TextSize = new System.Drawing.Size(79, 13);
            // 
            // frmEditCHE_DO_NGHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 352);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditCHE_DO_NGHI";
            this.Text = "frmEditCHE_DO_NGHI";
            this.Load += new System.EventHandler(this.frmEditCHE_DO_NGHI_Load);
            this.Resize += new System.EventHandler(this.frmEditCHE_DO_NGHI_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CHE_DOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CHE_DO_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_CHE_DO_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CHE_DO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CHE_DO_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_CHE_DO_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit TEN_CHE_DOTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_CHE_DO_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_CHE_DO_HTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_CHE_DO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_CHE_DO_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_CHE_DO_H;
    }
}