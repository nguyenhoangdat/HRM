using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace VietSoftHRM
{
    public partial class ucEditDonVi : DevExpress.XtraEditors.XtraUserControl
    {
        public int id=0;
        public ucEditDonVi(int iIDDonVi)
        {
            InitializeComponent();
        }

        private void ucEditDonVi_Load(object sender, EventArgs e)
        {
          
        }
    }
}
