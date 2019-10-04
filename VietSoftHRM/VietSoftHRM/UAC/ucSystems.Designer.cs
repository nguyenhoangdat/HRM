namespace VietSoftHRM
{
    partial class ucSystems
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
            this.lab_Link = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accorMenuleft = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accorMenuleft)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Link
            // 
            this.lab_Link.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lab_Link.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lab_Link.Appearance.Options.UseFont = true;
            this.lab_Link.Appearance.Options.UseForeColor = true;
            this.lab_Link.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lab_Link.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_Link.Location = new System.Drawing.Point(0, 0);
            this.lab_Link.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lab_Link.Name = "lab_Link";
            this.lab_Link.Size = new System.Drawing.Size(899, 35);
            this.lab_Link.TabIndex = 1;
            this.lab_Link.Text = "labelControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.accorMenuleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 387);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 387);
            this.panel2.TabIndex = 4;
            // 
            // accorMenuleft
            // 
            this.accorMenuleft.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accorMenuleft.Appearance.AccordionControl.ForeColor = System.Drawing.Color.White;
            this.accorMenuleft.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accorMenuleft.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accorMenuleft.Appearance.Group.Normal.ForeColor = System.Drawing.Color.Gainsboro;
            this.accorMenuleft.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accorMenuleft.Appearance.Hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.accorMenuleft.Appearance.Hint.Options.UseBackColor = true;
            this.accorMenuleft.Appearance.Item.Normal.ForeColor = System.Drawing.Color.White;
            this.accorMenuleft.Appearance.Item.Normal.Options.UseForeColor = true;
            this.accorMenuleft.Appearance.Item.Normal.Options.UseTextOptions = true;
            this.accorMenuleft.Appearance.Item.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accorMenuleft.Appearance.Item.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.accorMenuleft.Appearance.Item.Pressed.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.accorMenuleft.Appearance.Item.Pressed.ForeColor = System.Drawing.Color.White;
            this.accorMenuleft.Appearance.Item.Pressed.Options.UseFont = true;
            this.accorMenuleft.Appearance.Item.Pressed.Options.UseForeColor = true;
            this.accorMenuleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.accorMenuleft.Location = new System.Drawing.Point(0, 0);
            this.accorMenuleft.Name = "accorMenuleft";
            this.accorMenuleft.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accorMenuleft.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accorMenuleft.ShowItemExpandButtons = false;
            this.accorMenuleft.Size = new System.Drawing.Size(214, 387);
            this.accorMenuleft.TabIndex = 3;
            this.accorMenuleft.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ucSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_Link);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSystems";
            this.Size = new System.Drawing.Size(899, 422);
            this.Load += new System.EventHandler(this.ucSystems_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accorMenuleft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.LabelControl lab_Link;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Navigation.AccordionControl accorMenuleft;
    }
}
