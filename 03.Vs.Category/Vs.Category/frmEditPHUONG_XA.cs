using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vs.Category
{
    public partial class frmEditPHUONG_XA : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        Int64 iId = -1;
        Boolean bAddEdit = true;  // true la add false la edit
        public frmEditPHUONG_XA(Int64 iIdForm, Boolean bAddEditForm)
        {
            InitializeComponent();
            iId = iIdForm;
            bAddEdit = bAddEditForm;
        }


        private void frmEditPHUONG_XA_Load(object sender, EventArgs e)
        {
           

        }
    }
}
