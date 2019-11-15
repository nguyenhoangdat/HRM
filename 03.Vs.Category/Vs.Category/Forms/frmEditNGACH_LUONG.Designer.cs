namespace Vs.Category
{
    partial class frmEditNGACH_LUONG
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
            this.MS_NLTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_NLTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_NL_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_NL_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMS_NL = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_NL = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_NL_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_NL_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MS_NLTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NLTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NL_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NL_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_NL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NL_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NL_H)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 349);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(657, 47);
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
            this.tablePanel1.Size = new System.Drawing.Size(657, 396);
            this.tablePanel1.TabIndex = 10;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.MS_NLTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_NLTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_NL_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_NL_HTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(69, 43);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(520, 350);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // MS_NLTextEdit
            // 
            this.MS_NLTextEdit.Location = new System.Drawing.Point(65, 12);
            this.MS_NLTextEdit.Name = "MS_NLTextEdit";
            this.MS_NLTextEdit.Size = new System.Drawing.Size(443, 20);
            this.MS_NLTextEdit.StyleController = this.dataLayoutControl1;
            this.MS_NLTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.MS_NLTextEdit, conditionValidationRule1);
            // 
            // TEN_NLTextEdit
            // 
            this.TEN_NLTextEdit.Location = new System.Drawing.Point(65, 36);
            this.TEN_NLTextEdit.Name = "TEN_NLTextEdit";
            this.TEN_NLTextEdit.Size = new System.Drawing.Size(443, 20);
            this.TEN_NLTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_NLTextEdit.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_NLTextEdit, conditionValidationRule2);
            // 
            // TEN_NL_ATextEdit
            // 
            this.TEN_NL_ATextEdit.Location = new System.Drawing.Point(65, 60);
            this.TEN_NL_ATextEdit.Name = "TEN_NL_ATextEdit";
            this.TEN_NL_ATextEdit.Size = new System.Drawing.Size(443, 20);
            this.TEN_NL_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_NL_ATextEdit.TabIndex = 6;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_NL_ATextEdit, conditionValidationRule3);
            // 
            // TEN_NL_HTextEdit
            // 
            this.TEN_NL_HTextEdit.Location = new System.Drawing.Point(65, 84);
            this.TEN_NL_HTextEdit.Name = "TEN_NL_HTextEdit";
            this.TEN_NL_HTextEdit.Size = new System.Drawing.Size(443, 20);
            this.TEN_NL_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_NL_HTextEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(520, 350);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMS_NL,
            this.ItemForTEN_NL,
            this.ItemForTEN_NL_A,
            this.ItemForTEN_NL_H});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 330);
            // 
            // ItemForMS_NL
            // 
            this.ItemForMS_NL.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForMS_NL.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForMS_NL.Control = this.MS_NLTextEdit;
            this.ItemForMS_NL.Location = new System.Drawing.Point(0, 0);
            this.ItemForMS_NL.Name = "ItemForMS_NL";
            this.ItemForMS_NL.Size = new System.Drawing.Size(500, 24);
            this.ItemForMS_NL.Text = "MS_NL";
            this.ItemForMS_NL.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForTEN_NL
            // 
            this.ItemForTEN_NL.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_NL.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_NL.Control = this.TEN_NLTextEdit;
            this.ItemForTEN_NL.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_NL.Name = "ItemForTEN_NL";
            this.ItemForTEN_NL.Size = new System.Drawing.Size(500, 24);
            this.ItemForTEN_NL.Text = "TEN_NL";
            this.ItemForTEN_NL.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForTEN_NL_A
            // 
            this.ItemForTEN_NL_A.Control = this.TEN_NL_ATextEdit;
            this.ItemForTEN_NL_A.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_NL_A.Name = "ItemForTEN_NL_A";
            this.ItemForTEN_NL_A.Size = new System.Drawing.Size(500, 24);
            this.ItemForTEN_NL_A.Text = "TEN_NL_A";
            this.ItemForTEN_NL_A.TextSize = new System.Drawing.Size(50, 13);
            // 
            // ItemForTEN_NL_H
            // 
            this.ItemForTEN_NL_H.Control = this.TEN_NL_HTextEdit;
            this.ItemForTEN_NL_H.Location = new System.Drawing.Point(0, 72);
            this.ItemForTEN_NL_H.Name = "ItemForTEN_NL_H";
            this.ItemForTEN_NL_H.Size = new System.Drawing.Size(500, 258);
            this.ItemForTEN_NL_H.Text = "TEN_NL_H";
            this.ItemForTEN_NL_H.TextSize = new System.Drawing.Size(50, 13);
            // 
            // frmEditNGACH_LUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 396);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmEditNGACH_LUONG";
            this.Text = "frmEditNGACH_LUONG";
            this.Load += new System.EventHandler(this.frmEditNGACH_LUONG_Load);
            this.Resize += new System.EventHandler(this.frmEditNGACH_LUONG_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MS_NLTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NLTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NL_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_NL_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMS_NL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NL_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_NL_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit MS_NLTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_NLTextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_NL_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_NL_HTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMS_NL;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_NL;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_NL_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_NL_H;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}