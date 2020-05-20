using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vs.Report
{
    public partial class frmViewReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmViewReport()
        {
            InitializeComponent();
        }
        //private DataSet dsReportSource;
        //private static DataTable dtrptHeader;
        public DataSet dsReport = new DataSet();
        public XtraReport rpt;
        public void AddDataSource(DataTable tbSource)
        {
            try
            {
                try
                {
                    dsReport.Tables.Remove(tbSource.TableName);
                }
                catch { }
                dsReport.Tables.Add(tbSource.Copy());
            }
            catch { }
        }

        public void RemoveDataSource()
        {
            dsReport.Tables.Clear();
        }
        private void frmViewReport_Load(object sender, EventArgs e)
        {
            rpt.DataSource = dsReport;
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}
