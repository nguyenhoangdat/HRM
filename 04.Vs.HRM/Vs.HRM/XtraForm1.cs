using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Vs.HRM
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

            Commons.Modules.iCongNhan = 24;
            ucLyLich ns = new ucLyLich(24);
            //ucTaiNanLD ns = new ucTaiNanLD(24);
            this.Controls.Clear();
            this.Controls.Add(ns);
            ns.Dock = DockStyle.Fill;
        }
    }
}