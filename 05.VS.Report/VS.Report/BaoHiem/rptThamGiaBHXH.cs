using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Vs.Report
{
    public partial class rptThamGiaBHXH : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThamGiaBHXH()
        {
            InitializeComponent();
            //MsgBox
            Commons.Modules.ObjSystems.ThayDoiNN(this);
        }

        private void rptThamGiaBHXH_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "rptThamGiaBHXH", rptThamGiaBHXH))
            //lblSO_BHXH.Text = lblSO_BHXH.Text + "<b>"++"</b>";
            //lbl_HO_TEN.Text = lbl_HO_TEN.Text + "<b>đâsdad</b>";

        }
    }
}


