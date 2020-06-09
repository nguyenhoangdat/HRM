using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace VS.Report
{
    public partial class rptTienThuongXepLoai : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTienThuongXepLoai()
        {
            InitializeComponent();
            
            this.xrTableCell4.TextFormatString = "{0:n" + Commons.Modules.iSoLeDG.ToString() + "}";
            this.xrTableCell5.TextFormatString = "{0:n" + Commons.Modules.iSoLeTT.ToString() + "}";
            
            this.xrTableCell20.TextFormatString = "{0:n" + Commons.Modules.iSoLeDG.ToString() + "}";
            this.xrTableCell21.TextFormatString = "{0:n" + Commons.Modules.iSoLeTT.ToString() + "}";
        }

        private void groupFooterBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTable table = sender as XRTable;

        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTable table = sender as XRTable;
            double fSum = 0;
            try
            {
                fSum = Convert.ToDouble(xrTableCell21.Summary.GetResult());
            }
            catch { }
            string sSql = "SELECT REPLACE(REPLACE(REPLACE(dbo.NumtoText('" +  fSum.ToString() + "','.'),'  ',' '),'  ',''),' . và',',')";
            try
            {
                sSql = Convert.ToString(Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, System.Data.CommandType.Text, sSql));
            }
            catch
            { sSql = ""; }

            xrLabel6.Text = sSql;//fSum.ToString();


        }
    }
}
