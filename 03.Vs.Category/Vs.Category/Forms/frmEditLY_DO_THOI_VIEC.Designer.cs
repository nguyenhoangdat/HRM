﻿namespace Vs.Category
{
    partial class frmEditLY_DO_THOI_VIEC
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
            this.TEN_LD_TVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_LD_TV_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_LD_TV_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HE_SOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_LD_TV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_LD_TV_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_LD_TV_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHE_SO = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LD_TVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LD_TV_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LD_TV_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HE_SOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LD_TV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LD_TV_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LD_TV_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHE_SO)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 306);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(533, 47);
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
            this.tablePanel1.Size = new System.Drawing.Size(533, 353);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_LD_TVTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_LD_TV_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_LD_TV_HTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HE_SOTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(56, 38);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(420, 312);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_LD_TVTextEdit
            // 
            this.TEN_LD_TVTextEdit.Location = new System.Drawing.Point(83, 12);
            this.TEN_LD_TVTextEdit.Name = "TEN_LD_TVTextEdit";
            this.TEN_LD_TVTextEdit.Size = new System.Drawing.Size(325, 20);
            this.TEN_LD_TVTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LD_TVTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_LD_TVTextEdit, conditionValidationRule1);
            // 
            // TEN_LD_TV_ATextEdit
            // 
            this.TEN_LD_TV_ATextEdit.Location = new System.Drawing.Point(83, 36);
            this.TEN_LD_TV_ATextEdit.Name = "TEN_LD_TV_ATextEdit";
            this.TEN_LD_TV_ATextEdit.Size = new System.Drawing.Size(325, 20);
            this.TEN_LD_TV_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LD_TV_ATextEdit.TabIndex = 5;
            // 
            // TEN_LD_TV_HTextEdit
            // 
            this.TEN_LD_TV_HTextEdit.Location = new System.Drawing.Point(83, 60);
            this.TEN_LD_TV_HTextEdit.Name = "TEN_LD_TV_HTextEdit";
            this.TEN_LD_TV_HTextEdit.Size = new System.Drawing.Size(325, 20);
            this.TEN_LD_TV_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LD_TV_HTextEdit.TabIndex = 6;
            // 
            // HE_SOTextEdit
            // 
            this.HE_SOTextEdit.Location = new System.Drawing.Point(83, 84);
            this.HE_SOTextEdit.Name = "HE_SOTextEdit";
            this.HE_SOTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.HE_SOTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.HE_SOTextEdit.Properties.Mask.EditMask = "F";
            this.HE_SOTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.HE_SOTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.HE_SOTextEdit.Size = new System.Drawing.Size(325, 20);
            this.HE_SOTextEdit.StyleController = this.dataLayoutControl1;
            this.HE_SOTextEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(420, 312);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_LD_TV,
            this.ItemForTEN_LD_TV_A,
            this.ItemForTEN_LD_TV_H,
            this.ItemForHE_SO});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 292);
            // 
            // ItemForTEN_LD_TV
            // 
            this.ItemForTEN_LD_TV.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_LD_TV.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_LD_TV.Control = this.TEN_LD_TVTextEdit;
            this.ItemForTEN_LD_TV.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_LD_TV.Name = "ItemForTEN_LD_TV";
            this.ItemForTEN_LD_TV.Size = new System.Drawing.Size(400, 24);
            this.ItemForTEN_LD_TV.Text = "TEN_LD_TV";
            this.ItemForTEN_LD_TV.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForTEN_LD_TV_A
            // 
            this.ItemForTEN_LD_TV_A.Control = this.TEN_LD_TV_ATextEdit;
            this.ItemForTEN_LD_TV_A.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_LD_TV_A.Name = "ItemForTEN_LD_TV_A";
            this.ItemForTEN_LD_TV_A.Size = new System.Drawing.Size(400, 24);
            this.ItemForTEN_LD_TV_A.Text = "TEN_LD_TV_A";
            this.ItemForTEN_LD_TV_A.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForTEN_LD_TV_H
            // 
            this.ItemForTEN_LD_TV_H.Control = this.TEN_LD_TV_HTextEdit;
            this.ItemForTEN_LD_TV_H.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_LD_TV_H.Name = "ItemForTEN_LD_TV_H";
            this.ItemForTEN_LD_TV_H.Size = new System.Drawing.Size(400, 24);
            this.ItemForTEN_LD_TV_H.Text = "TEN_LD_TV_H";
            this.ItemForTEN_LD_TV_H.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForHE_SO
            // 
            this.ItemForHE_SO.Control = this.HE_SOTextEdit;
            this.ItemForHE_SO.Location = new System.Drawing.Point(0, 72);
            this.ItemForHE_SO.Name = "ItemForHE_SO";
            this.ItemForHE_SO.Size = new System.Drawing.Size(400, 220);
            this.ItemForHE_SO.Text = "HE_SO";
            this.ItemForHE_SO.TextSize = new System.Drawing.Size(68, 13);
            // 
            // frmEditLY_DO_THOI_VIEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 353);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditLY_DO_THOI_VIEC";
            this.Text = "frmEditLY_DO_THOI_VIEC";
            this.Load += new System.EventHandler(this.frmEditLY_DO_THOI_VIEC_Load);
            this.Resize += new System.EventHandler(this.frmEditLY_DO_THOI_VIEC_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LD_TVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LD_TV_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LD_TV_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HE_SOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LD_TV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LD_TV_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LD_TV_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHE_SO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit TEN_LD_TVTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_LD_TV_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_LD_TV_HTextEdit;
        private DevExpress.XtraEditors.TextEdit HE_SOTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LD_TV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LD_TV_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LD_TV_H;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHE_SO;
    }
}