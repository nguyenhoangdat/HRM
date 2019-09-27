namespace VietSoftHRM
{
    partial class ucDonVi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::VietSoftHRM.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            this.grd_DonVi = new DevExpress.XtraGrid.GridControl();
            this.grv_DonVi = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // grd_DonVi
            // 
            this.grd_DonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_DonVi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd_DonVi.Location = new System.Drawing.Point(0, 0);
            this.grd_DonVi.MainView = this.grv_DonVi;
            this.grd_DonVi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd_DonVi.Name = "grd_DonVi";
            this.grd_DonVi.Size = new System.Drawing.Size(1021, 578);
            this.grd_DonVi.TabIndex = 0;
            this.grd_DonVi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_DonVi});
            // 
            // grv_DonVi
            // 
            this.grv_DonVi.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grv_DonVi.Appearance.HeaderPanel.Options.UseFont = true;
            this.grv_DonVi.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DonVi.Appearance.Row.Options.UseFont = true;
            this.grv_DonVi.DetailHeight = 538;
            this.grv_DonVi.FixedLineWidth = 3;
            this.grv_DonVi.GridControl = this.grd_DonVi;
            this.grv_DonVi.Name = "grv_DonVi";
            this.grv_DonVi.OptionsView.ShowGroupPanel = false;
            this.grv_DonVi.RowHeight = 40;
            // 
            // ucDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd_DonVi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucDonVi";
            this.Size = new System.Drawing.Size(1021, 578);
            this.Load += new System.EventHandler(this.ucDonVi_Load);
            this.Validated += new System.EventHandler(this.ucDonVi_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.grd_DonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DonVi)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl grd_DonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_DonVi;
    }
}
