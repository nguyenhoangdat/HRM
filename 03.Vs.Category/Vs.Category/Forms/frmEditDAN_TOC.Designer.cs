﻿namespace Vs.Category
{
    partial class frmEditDAN_TOC
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
            this.TEN_DTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_DT_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_DT_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_DT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_DT_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_DT_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_DTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_DT_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_DT_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_DT_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_DT_H)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 294);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(640, 47);
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
            this.tablePanel1.Size = new System.Drawing.Size(640, 341);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_DTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_DT_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_DT_HTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(67, 37);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(506, 301);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_DTTextEdit
            // 
            this.TEN_DTTextEdit.Location = new System.Drawing.Point(66, 12);
            this.TEN_DTTextEdit.Name = "TEN_DTTextEdit";
            this.TEN_DTTextEdit.Size = new System.Drawing.Size(428, 20);
            this.TEN_DTTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_DTTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_DTTextEdit, conditionValidationRule1);
            // 
            // TEN_DT_ATextEdit
            // 
            this.TEN_DT_ATextEdit.Location = new System.Drawing.Point(66, 36);
            this.TEN_DT_ATextEdit.Name = "TEN_DT_ATextEdit";
            this.TEN_DT_ATextEdit.Size = new System.Drawing.Size(428, 20);
            this.TEN_DT_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_DT_ATextEdit.TabIndex = 5;
            // 
            // TEN_DT_HTextEdit
            // 
            this.TEN_DT_HTextEdit.Location = new System.Drawing.Point(66, 60);
            this.TEN_DT_HTextEdit.Name = "TEN_DT_HTextEdit";
            this.TEN_DT_HTextEdit.Size = new System.Drawing.Size(428, 20);
            this.TEN_DT_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_DT_HTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(506, 301);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_DT,
            this.ItemForTEN_DT_A,
            this.ItemForTEN_DT_H});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(486, 281);
            // 
            // ItemForTEN_DT
            // 
            this.ItemForTEN_DT.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_DT.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_DT.Control = this.TEN_DTTextEdit;
            this.ItemForTEN_DT.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_DT.Name = "ItemForTEN_DT";
            this.ItemForTEN_DT.Size = new System.Drawing.Size(486, 24);
            this.ItemForTEN_DT.Text = "TEN_DT";
            this.ItemForTEN_DT.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForTEN_DT_A
            // 
            this.ItemForTEN_DT_A.Control = this.TEN_DT_ATextEdit;
            this.ItemForTEN_DT_A.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_DT_A.Name = "ItemForTEN_DT_A";
            this.ItemForTEN_DT_A.Size = new System.Drawing.Size(486, 24);
            this.ItemForTEN_DT_A.Text = "TEN_DT_A";
            this.ItemForTEN_DT_A.TextSize = new System.Drawing.Size(51, 13);
            // 
            // ItemForTEN_DT_H
            // 
            this.ItemForTEN_DT_H.Control = this.TEN_DT_HTextEdit;
            this.ItemForTEN_DT_H.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_DT_H.Name = "ItemForTEN_DT_H";
            this.ItemForTEN_DT_H.Size = new System.Drawing.Size(486, 233);
            this.ItemForTEN_DT_H.Text = "TEN_DT_H";
            this.ItemForTEN_DT_H.TextSize = new System.Drawing.Size(51, 13);
            // 
            // frmEditDAN_TOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 341);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditDAN_TOC";
            this.Text = "frmEditDAN_TOC";
            this.Load += new System.EventHandler(this.frmEditDAN_TOC_Load);
            this.Resize += new System.EventHandler(this.frmEditDAN_TOC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_DTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_DT_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_DT_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_DT_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_DT_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TEN_DTTextEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit TEN_DT_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_DT_HTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_DT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_DT_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_DT_H;
    }
}