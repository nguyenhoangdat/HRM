using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.LookAndFeel;

namespace VS.Report
{
    public partial class frmViewReport : XtraForm
    {
        //private DataSet dsReportSource;
        //private static DataTable dtrptHeader;
        public DataSet dsReport = new DataSet();
        public XtraReport rpt;
        //XtraForm frmWait;
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

        public frmViewReport()
        {
            //frmWait = new XtraForm()
            //{
            //    FormBorderStyle = FormBorderStyle.None,
            //    Size = new System.Drawing.Size(300, 25),
            //    ShowInTaskbar = false,
            //    StartPosition = FormStartPosition.CenterScreen,
            //    TopMost = true
            //};
            Commons.Modules.ObjSystems.ShowWaitForm(this);
            InitializeComponent();

        }



        private void frmViewReport_Load(object sender, EventArgs e)
        {
            try
            {
                //ReportDesignTool designTool = new ReportDesignTool(rpt);

                //// Invoke the Ribbon End-User Report Designer form  
                //// and load the report into it.
                //designTool.ShowRibbonDesigner();

                //// Invoke the Ribbon End-User Report Designer form modally 
                //// with the specified look and feel settings.
                //designTool.ShowRibbonDesignerDialog(DevExpress.LookAndFeel.UserLookAndFeel.Default);

                

            }
            catch { }

            #region Create form wait            
            // Create a ProgressBar along with its ReflectorBar.
            //ProgressBarControl progressBar = new ProgressBarControl();
            //ReflectorBar reflectorBar = new ReflectorBar(progressBar);
            
            //frmWait.Controls.Add(progressBar);
            //progressBar.Dock = DockStyle.Fill;
            //frmWait.Show();


            try
            {
                documentViewer1.PrintingSystem = rpt.PrintingSystem;
                rpt.DataSource = dsReport;
                //rpt.PrintingSystem.ProgressReflector = reflectorBar;


                //if (System.IO.File.Exists(filePath))
                //{
                //    rpt.LoadLayout("D:\\rptTienThuongXepLoai.prnx.repx");
                //}
                //else
                //{
                //    System.Console.WriteLine("The source file does not exist.");
                //}

                rpt.CreateDocument();
            }
            finally
            {
                // Unregister the reflector bar, so that it no longer
                // reflects the state of a ProgressReflector.
                ////////rpt.PrintingSystem.ResetProgressReflector();
                ////////frmWait.Close();
                ////////frmWait.Dispose();
            }
            #endregion

            Commons.Modules.ObjSystems.HideWaitForm();

        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.DataSource = dsReport;
            rpt.CreateDocument();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bbiDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Create a Design Tool instance with a report assigned to it.
            ReportDesignTool dt = new ReportDesignTool(rpt);

            // Access the report's properties.
            dt.Report.DrawGrid = false;

            // Access the Designer form's properties.
            dt.DesignForm.SetWindowVisibility(DesignDockPanelType.FieldList | DesignDockPanelType.PropertyGrid, false);

            // Show the Designer form, modally.
            //dt.ShowDesignerDialog();
            //dt.ShowRibbonDesignerDialog();
            dt.ShowDesigner(DevExpress.LookAndFeel.UserLookAndFeel.Default, DesignDockPanelType.PropertyGrid | DesignDockPanelType.ReportExplorer);



            //XRDesignRibbonForm designForm = new XRDesignRibbonForm();

            //// Create a new blank report.
            //designForm.OpenReport(rpt);

            //// Display the Report Designer form.
            ////designForm.Show();

            //// Display the Report Designer form, modally.
            //designForm.ShowDialog();

        }
    }
}
