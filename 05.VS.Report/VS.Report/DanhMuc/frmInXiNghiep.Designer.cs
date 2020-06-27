namespace VS.Report
{
    partial class frmInXiNghiep
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
            this.LK_DON_VI = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblDonVi = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LK_DON_VI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // LK_DON_VI
            // 
            this.LK_DON_VI.EditValue = "";
            this.LK_DON_VI.Location = new System.Drawing.Point(91, 12);
            this.LK_DON_VI.Name = "LK_DON_VI";
            this.LK_DON_VI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LK_DON_VI.Properties.PopupView = this.searchLookUpEdit1View;
            this.LK_DON_VI.Size = new System.Drawing.Size(297, 20);
            this.LK_DON_VI.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDonVi.Location = new System.Drawing.Point(35, 12);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(50, 18);
            this.lblDonVi.TabIndex = 1;
            this.lblDonVi.Text = "Don vi";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(322, 49);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 27);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(253, 49);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(63, 27);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmInXiNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 88);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.LK_DON_VI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInXiNghiep";
            this.Text = "frmInXiNghiep";
            this.Load += new System.EventHandler(this.frmInXiNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LK_DON_VI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit LK_DON_VI;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblDonVi;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
    }
}