using DevExpress.XtraEditors.DXErrorProvider;

namespace Vs.Category
{
    partial class frmEditLOAI_HDLD
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
            this.TEN_LHDLDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_LHDLD_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_LHDLD_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SO_THANGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_LHDLD = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_LHDLD_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_LHDLD_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSO_THANG = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LHDLDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LHDLD_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LHDLD_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO_THANGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LHDLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LHDLD_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LHDLD_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSO_THANG)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 262);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(526, 47);
            this.btnALL.TabIndex = 7;
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
            this.tablePanel1.Size = new System.Drawing.Size(526, 262);
            this.tablePanel1.TabIndex = 9;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_LHDLDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_LHDLD_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_LHDLD_HTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SO_THANGTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(27, 29);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(470, 230);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_LHDLDTextEdit
            // 
            this.TEN_LHDLDTextEdit.Location = new System.Drawing.Point(87, 12);
            this.TEN_LHDLDTextEdit.Name = "TEN_LHDLDTextEdit";
            this.TEN_LHDLDTextEdit.Size = new System.Drawing.Size(368, 20);
            this.TEN_LHDLDTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LHDLDTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_LHDLDTextEdit, conditionValidationRule1);
            // 
            // TEN_LHDLD_ATextEdit
            // 
            this.TEN_LHDLD_ATextEdit.Location = new System.Drawing.Point(87, 36);
            this.TEN_LHDLD_ATextEdit.Name = "TEN_LHDLD_ATextEdit";
            this.TEN_LHDLD_ATextEdit.Size = new System.Drawing.Size(368, 20);
            this.TEN_LHDLD_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LHDLD_ATextEdit.TabIndex = 5;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_LHDLD_ATextEdit, conditionValidationRule2);
            // 
            // TEN_LHDLD_HTextEdit
            // 
            this.TEN_LHDLD_HTextEdit.Location = new System.Drawing.Point(87, 60);
            this.TEN_LHDLD_HTextEdit.Name = "TEN_LHDLD_HTextEdit";
            this.TEN_LHDLD_HTextEdit.Size = new System.Drawing.Size(368, 20);
            this.TEN_LHDLD_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_LHDLD_HTextEdit.TabIndex = 6;
            // 
            // SO_THANGTextEdit
            // 
            this.SO_THANGTextEdit.Location = new System.Drawing.Point(87, 84);
            this.SO_THANGTextEdit.Name = "SO_THANGTextEdit";
            this.SO_THANGTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SO_THANGTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SO_THANGTextEdit.Properties.Mask.EditMask = "N0";
            this.SO_THANGTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SO_THANGTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SO_THANGTextEdit.Size = new System.Drawing.Size(368, 20);
            this.SO_THANGTextEdit.StyleController = this.dataLayoutControl1;
            this.SO_THANGTextEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(470, 230);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_LHDLD,
            this.ItemForTEN_LHDLD_A,
            this.ItemForTEN_LHDLD_H,
            this.ItemForSO_THANG});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(450, 210);
            // 
            // ItemForTEN_LHDLD
            // 
            this.ItemForTEN_LHDLD.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_LHDLD.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_LHDLD.Control = this.TEN_LHDLDTextEdit;
            this.ItemForTEN_LHDLD.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_LHDLD.Name = "ItemForTEN_LHDLD";
            this.ItemForTEN_LHDLD.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.ItemForTEN_LHDLD.Size = new System.Drawing.Size(450, 24);
            this.ItemForTEN_LHDLD.Text = "TEN_LHDLD";
            this.ItemForTEN_LHDLD.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForTEN_LHDLD_A
            // 
            this.ItemForTEN_LHDLD_A.Control = this.TEN_LHDLD_ATextEdit;
            this.ItemForTEN_LHDLD_A.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_LHDLD_A.Name = "ItemForTEN_LHDLD_A";
            this.ItemForTEN_LHDLD_A.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.ItemForTEN_LHDLD_A.Size = new System.Drawing.Size(450, 24);
            this.ItemForTEN_LHDLD_A.Text = "TEN_LHDLD_A";
            this.ItemForTEN_LHDLD_A.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForTEN_LHDLD_H
            // 
            this.ItemForTEN_LHDLD_H.Control = this.TEN_LHDLD_HTextEdit;
            this.ItemForTEN_LHDLD_H.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_LHDLD_H.Name = "ItemForTEN_LHDLD_H";
            this.ItemForTEN_LHDLD_H.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.ItemForTEN_LHDLD_H.Size = new System.Drawing.Size(450, 24);
            this.ItemForTEN_LHDLD_H.Text = "TEN_LHDLD_H";
            this.ItemForTEN_LHDLD_H.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForSO_THANG
            // 
            this.ItemForSO_THANG.Control = this.SO_THANGTextEdit;
            this.ItemForSO_THANG.Location = new System.Drawing.Point(0, 72);
            this.ItemForSO_THANG.Name = "ItemForSO_THANG";
            this.ItemForSO_THANG.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.ItemForSO_THANG.Size = new System.Drawing.Size(450, 138);
            this.ItemForSO_THANG.Text = "SO_THANG";
            this.ItemForSO_THANG.TextSize = new System.Drawing.Size(69, 13);
            // 
            // frmEditLOAI_HDLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 309);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.btnALL);
            this.Name = "frmEditLOAI_HDLD";
            this.Text = "frmEditLOAI_HDLD";
            this.Load += new System.EventHandler(this.frmEditLOAI_HDLD_Load);
            this.Resize += new System.EventHandler(this.frmEditLOAI_HDLD_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LHDLDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LHDLD_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_LHDLD_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO_THANGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LHDLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LHDLD_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_LHDLD_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSO_THANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TEN_LHDLDTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_LHDLD_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_LHDLD_HTextEdit;
        private DevExpress.XtraEditors.TextEdit SO_THANGTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LHDLD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LHDLD_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_LHDLD_H;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSO_THANG;
        private DXValidationProvider dxValidationProvider1;
    }
}