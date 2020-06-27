﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace VS.Report
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DevExpress.XtraReports.Configuration.DesignSettings.Default.UseOfficeInspiredRibbonStyle = false;
            //BonusSkins.Register();
            Commons.IConnections.Username = "sa";
            Commons.IConnections.Server = @".\SQL2008";
            Commons.IConnections.Database = "VS_HRM";
            Commons.IConnections.Password = "123";
            //Application.Run(new XtraForm1());
            Application.Run(new frmInXiNghiep());
        }
    }
}
