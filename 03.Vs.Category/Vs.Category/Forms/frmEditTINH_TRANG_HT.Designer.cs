namespace Vs.Category
{
    partial class frmEditTINH_TRANG_HT
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
            this.TEN_TT_HTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_TT_HT_ATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TEN_TT_HT_HTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTEN_TT_HT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_TT_HT_A = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTEN_TT_HT_H = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TT_HTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TT_HT_ATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TT_HT_HTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TT_HT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TT_HT_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TT_HT_H)).BeginInit();
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
            this.btnALL.Location = new System.Drawing.Point(0, 355);
            this.btnALL.Name = "btnALL";
            this.btnALL.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnALL.Size = new System.Drawing.Size(755, 47);
            this.btnALL.TabIndex = 9;
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
            this.tablePanel1.Size = new System.Drawing.Size(755, 355);
            this.tablePanel1.TabIndex = 11;
            // 
            // dataLayoutControl1
            // 
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Controls.Add(this.TEN_TT_HTTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_TT_HT_ATextEdit);
            this.dataLayoutControl1.Controls.Add(this.TEN_TT_HT_HTextEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(37, 39);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(678, 313);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // TEN_TT_HTTextEdit
            // 
            this.TEN_TT_HTTextEdit.Location = new System.Drawing.Point(84, 12);
            this.TEN_TT_HTTextEdit.Name = "TEN_TT_HTTextEdit";
            this.TEN_TT_HTTextEdit.Size = new System.Drawing.Size(582, 20);
            this.TEN_TT_HTTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_TT_HTTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.TEN_TT_HTTextEdit, conditionValidationRule1);
            // 
            // TEN_TT_HT_ATextEdit
            // 
            this.TEN_TT_HT_ATextEdit.Location = new System.Drawing.Point(84, 36);
            this.TEN_TT_HT_ATextEdit.Name = "TEN_TT_HT_ATextEdit";
            this.TEN_TT_HT_ATextEdit.Size = new System.Drawing.Size(582, 20);
            this.TEN_TT_HT_ATextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_TT_HT_ATextEdit.TabIndex = 5;
            // 
            // TEN_TT_HT_HTextEdit
            // 
            this.TEN_TT_HT_HTextEdit.Location = new System.Drawing.Point(84, 60);
            this.TEN_TT_HT_HTextEdit.Name = "TEN_TT_HT_HTextEdit";
            this.TEN_TT_HT_HTextEdit.Size = new System.Drawing.Size(582, 20);
            this.TEN_TT_HT_HTextEdit.StyleController = this.dataLayoutControl1;
            this.TEN_TT_HT_HTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(678, 313);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTEN_TT_HT,
            this.ItemForTEN_TT_HT_A,
            this.ItemForTEN_TT_HT_H});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(658, 293);
            // 
            // ItemForTEN_TT_HT
            // 
            this.ItemForTEN_TT_HT.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ItemForTEN_TT_HT.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForTEN_TT_HT.Control = this.TEN_TT_HTTextEdit;
            this.ItemForTEN_TT_HT.Location = new System.Drawing.Point(0, 0);
            this.ItemForTEN_TT_HT.Name = "ItemForTEN_TT_HT";
            this.ItemForTEN_TT_HT.Size = new System.Drawing.Size(658, 24);
            this.ItemForTEN_TT_HT.Text = "TEN_TT_HT";
            this.ItemForTEN_TT_HT.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForTEN_TT_HT_A
            // 
            this.ItemForTEN_TT_HT_A.Control = this.TEN_TT_HT_ATextEdit;
            this.ItemForTEN_TT_HT_A.Location = new System.Drawing.Point(0, 24);
            this.ItemForTEN_TT_HT_A.Name = "ItemForTEN_TT_HT_A";
            this.ItemForTEN_TT_HT_A.Size = new System.Drawing.Size(658, 24);
            this.ItemForTEN_TT_HT_A.Text = "TEN_TT_HT_A";
            this.ItemForTEN_TT_HT_A.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForTEN_TT_HT_H
            // 
            this.ItemForTEN_TT_HT_H.Control = this.TEN_TT_HT_HTextEdit;
            this.ItemForTEN_TT_HT_H.Location = new System.Drawing.Point(0, 48);
            this.ItemForTEN_TT_HT_H.Name = "ItemForTEN_TT_HT_H";
            this.ItemForTEN_TT_HT_H.Size = new System.Drawing.Size(658, 245);
            this.ItemForTEN_TT_HT_H.Text = "TEN_TT_HT_H";
            this.ItemForTEN_TT_HT_H.TextSize = new System.Drawing.Size(69, 13);
            // 
            // frmEditTINH_TRANG_HT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 402);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.btnALL);
            this.Name = "frmEditTINH_TRANG_HT";
            this.Text = "frmEditTINH_TRANG_HT";
            this.Load += new System.EventHandler(this.frmEditTINH_TRANG_HT_Load);
            this.Resize += new System.EventHandler(this.frmEditTINH_TRANG_HT_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TT_HTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TT_HT_ATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEN_TT_HT_HTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TT_HT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TT_HT_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTEN_TT_HT_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnALL;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TEN_TT_HTTextEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit TEN_TT_HT_ATextEdit;
        private DevExpress.XtraEditors.TextEdit TEN_TT_HT_HTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_TT_HT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_TT_HT_A;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTEN_TT_HT_H;
    }
}