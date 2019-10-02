using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting.Export;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Commons
{
    public class OSystems
    {
        #region LoadLookupedit
        public bool MLoadLookUpEdit(DevExpress.XtraEditors.LookUpEdit cbo, string sQuery, string Ma, string Ten, string TenCot)
        {
            try
            {
                cbo.Properties.DataSource = null;
                cbo.Properties.DisplayMember = "";
                cbo.Properties.ValueMember = "";

                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, CommandType.Text, sQuery));
                cbo.Properties.DataSource = dtTmp;
                cbo.Properties.DisplayMember = Ten;
                cbo.Properties.ValueMember = Ma;
                cbo.Properties.Columns.Clear();
                cbo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(Ten));
                cbo.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cbo.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                cbo.Properties.BestFitMode = BestFitMode.BestFit;
                cbo.Properties.SearchMode = SearchMode.AutoComplete;
                cbo.EditValue = dtTmp.Rows[0][Ma];
                if (dtTmp.Rows.Count > 10)
                    cbo.Properties.DropDownRows = 15;
                else
                    cbo.Properties.DropDownRows = 10;
                cbo.Properties.Columns[Ten].Caption = TenCot;
                if (TenCot.Trim() == "")
                    cbo.Properties.ShowHeader = false;
                else
                    cbo.Properties.ShowHeader = true;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool MLoadLookUpEdit(DevExpress.XtraEditors.LookUpEdit cbo, DataTable dtTmp, string Ma, string Ten, string TenCot)
        {
            try
            {
                cbo.Properties.DataSource = null;
                cbo.Properties.DisplayMember = "";
                cbo.Properties.ValueMember = "";
                cbo.Properties.DataSource = dtTmp;
                cbo.Properties.DisplayMember = Ten;
                cbo.Properties.ValueMember = Ma;
                cbo.Properties.Columns.Clear();
                cbo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(Ten));
                cbo.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cbo.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                cbo.Properties.BestFitMode = BestFitMode.BestFit;
                cbo.Properties.SearchMode = SearchMode.AutoComplete;
                cbo.EditValue = dtTmp.Rows[0][Ma];
                if (dtTmp.Rows.Count > 10)
                    cbo.Properties.DropDownRows = 15;
                else
                    cbo.Properties.DropDownRows = 10;
                cbo.Properties.Columns[Ten].Caption = TenCot;
                if (TenCot.Trim() == "")
                    cbo.Properties.ShowHeader = false;
                else
                    cbo.Properties.ShowHeader = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool MLoadLookUpEdit(DevExpress.XtraEditors.LookUpEdit cbo, string sStored, string Ma, string Ten, string TenCot, bool bStored)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                if (bStored)
                    dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, sStored));
                else
                    dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, CommandType.Text, sStored));
                cbo.Properties.DataSource = null;
                cbo.Properties.DisplayMember = "";
                cbo.Properties.ValueMember = "";
                cbo.Properties.DataSource = dtTmp;
                cbo.Properties.DisplayMember = Ten;
                cbo.Properties.ValueMember = Ma;
                cbo.Properties.Columns.Clear();
                cbo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(Ten));
                cbo.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cbo.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                cbo.Properties.BestFitMode = BestFitMode.BestFit;
                cbo.Properties.SearchMode = SearchMode.AutoComplete;
                cbo.EditValue = dtTmp.Rows[0][Ma];
                if (dtTmp.Rows.Count > 10)
                    cbo.Properties.DropDownRows = 15;
                else
                    cbo.Properties.DropDownRows = 10;
                cbo.Properties.Columns[Ten].Caption = TenCot;
                if (TenCot.Trim() == "")
                    cbo.Properties.ShowHeader = false;
                else
                    cbo.Properties.ShowHeader = true;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool MLoadLookUpEdit(DevExpress.XtraEditors.LookUpEdit cbo, string sStored, string Ma, string Ten, string TenCot, bool bStored, string Param)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                if (bStored)
                    dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, sStored, Param));
                else
                    dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, CommandType.Text, sStored));
                cbo.Properties.DataSource = null;
                cbo.Properties.DisplayMember = "";
                cbo.Properties.ValueMember = "";

                cbo.Properties.DataSource = dtTmp;
                cbo.Properties.DisplayMember = Ten;
                cbo.Properties.ValueMember = Ma;
                cbo.Properties.Columns.Clear();
                cbo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(Ten));
                cbo.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cbo.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                cbo.Properties.BestFitMode = BestFitMode.BestFit;
                cbo.Properties.SearchMode = SearchMode.AutoComplete;
                cbo.EditValue = dtTmp.Rows[0][Ma];
                if (dtTmp.Rows.Count > 10)
                    cbo.Properties.DropDownRows = 15;
                else
                    cbo.Properties.DropDownRows = 10;
                cbo.Properties.Columns[Ten].Caption = TenCot;
                if (TenCot.Trim() == "")
                    cbo.Properties.ShowHeader = false;
                else
                    cbo.Properties.ShowHeader = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool MLoadLookUpEdit(DevExpress.XtraEditors.LookUpEdit cbo, string sStored, string Ma, string Ten, string TenCot, bool bStored, string Param, string Param1)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                if (bStored)
                    dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, sStored, Param, Param1));
                else
                    dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, CommandType.Text, sStored));
                cbo.Properties.DataSource = null;
                cbo.Properties.DisplayMember = "";
                cbo.Properties.ValueMember = "";
                cbo.Properties.DataSource = dtTmp;
                cbo.Properties.DisplayMember = Ten;
                cbo.Properties.ValueMember = Ma;
                cbo.Properties.Columns.Clear();
                cbo.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(Ten));
                cbo.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                cbo.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                cbo.Properties.BestFitMode = BestFitMode.BestFit;
                cbo.Properties.SearchMode = SearchMode.AutoComplete;
                cbo.EditValue = dtTmp.Rows[0][Ma];
                if (dtTmp.Rows.Count > 10)
                    cbo.Properties.DropDownRows = 15;
                else
                    cbo.Properties.DropDownRows = 10;
                cbo.Properties.Columns[Ten].Caption = TenCot;
                if (TenCot.Trim() == "")
                    cbo.Properties.ShowHeader = false;
                else
                    cbo.Properties.ShowHeader = true;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion


        #region Load xtragrid
        public bool MLoadXtraGrid(DevExpress.XtraGrid.GridControl grd, DevExpress.XtraGrid.Views.Grid.GridView grv, string sQuery, bool MEditable, bool MPopulateColumns, bool MColumnAutoWidth, bool MBestFitColumns)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, CommandType.Text, sQuery));

                grd.DataSource = dtTmp;
                grv.OptionsBehavior.Editable = MEditable;
                if (MPopulateColumns == true)
                    grv.PopulateColumns();
                grv.OptionsView.ColumnAutoWidth = MColumnAutoWidth;
                grv.OptionsView.AllowHtmlDrawHeaders = true;
                grv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                grv.OptionsBehavior.FocusLeaveOnTab = true;
                if (MBestFitColumns)
                    grv.BestFitColumns();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool MLoadXtraGrid(DevExpress.XtraGrid.GridControl grd, DevExpress.XtraGrid.Views.Grid.GridView grv, DataTable dtTmp, bool MEditable, bool MPopulateColumns, bool MColumnAutoWidth, bool MBestFitColumns)
        {
            try
            {
                grd.DataSource = dtTmp;
                grv.OptionsBehavior.Editable = MEditable;
                if (MPopulateColumns == true)
                    grv.PopulateColumns();
                grv.OptionsView.ColumnAutoWidth = MColumnAutoWidth;
                grv.OptionsView.AllowHtmlDrawHeaders = true;
                grv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                if (MBestFitColumns)
                    grv.BestFitColumns();
                grv.OptionsBehavior.FocusLeaveOnTab = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool MLoadXtraGrid(DevExpress.XtraGrid.GridControl grd, DevExpress.XtraGrid.Views.Grid.GridView grv, string sQuery, bool MEditable, bool MPopulateColumns, bool MColumnAutoWidth, bool MBestFitColumns, bool MloadNNgu, string fName)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(IConnections.CNStr, CommandType.Text, sQuery));

                grd.DataSource = dtTmp;
                grv.OptionsBehavior.Editable = MEditable;
                if (MPopulateColumns == true)
                    grv.PopulateColumns();
                grv.OptionsView.ColumnAutoWidth = MColumnAutoWidth;
                grv.OptionsView.AllowHtmlDrawHeaders = true;
                grv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                if (MBestFitColumns)
                    grv.BestFitColumns();
                if (MloadNNgu)
                    MLoadNNXtraGrid(grv, fName);
                grv.OptionsBehavior.FocusLeaveOnTab = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool MLoadXtraGrid(DevExpress.XtraGrid.GridControl grd, DevExpress.XtraGrid.Views.Grid.GridView grv, DataTable dtTmp, bool MEditable, bool MPopulateColumns, bool MColumnAutoWidth, bool MBestFitColumns, bool MloadNNgu, string fName)
        {
            try
            {
                grd.DataSource = dtTmp;
                grv.OptionsBehavior.Editable = MEditable;
                if (MPopulateColumns == true)
                    grv.PopulateColumns();
                grv.OptionsView.ColumnAutoWidth = MColumnAutoWidth;
                grv.OptionsView.AllowHtmlDrawHeaders = true;
                grv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
                if (MBestFitColumns)
                    grv.BestFitColumns();

                if (MloadNNgu)
                    MLoadNNXtraGrid(grv, fName);

                grv.OptionsBehavior.FocusLeaveOnTab = true;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void MLoadNNXtraGrid(DevExpress.XtraGrid.Views.Grid.GridView grv, string fName)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in grv.Columns)
            {
                if (col.Visible)
                {
                    col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    col.AppearanceHeader.Options.UseTextOptions = true;
                    col.Caption = Modules.ObjLanguages.GetLanguage(Modules.ModuleName, fName, col.FieldName, Modules.TypeLanguage);
                }
            }
        }

        public void MLoadNNXtraGrid(DevExpress.XtraGrid.Views.Grid.GridView grv, string fName, int NN)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in grv.Columns)
            {
                if (col.Visible)
                {
                    col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    col.AppearanceHeader.Options.UseTextOptions = true;
                    col.Caption = Modules.ObjLanguages.GetLanguage(Modules.ModuleName, fName, col.FieldName, NN);
                }
            }
        }
        #endregion

        #region thay doi nn
        public void ThayDoiNN(Form frm)
        {
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT KEYWORD , CASE " + Modules.TypeLanguage + " WHEN 0 THEN VIETNAM WHEN 1 THEN ENGLISH ELSE CHINESE END AS NN  FROM LANGUAGES WHERE FORM = N'" + frm.Name + "' "));

            frm.Text = GetNN(dtTmp, frm.Name, frm.Name);
            List<Control> resultControlList = new List<Control>();
            GetControlsCollection(frm,ref resultControlList, null);
            foreach (Control control1 in resultControlList)
            {
                try
                {
                    DoiNN(control1,frm, dtTmp);
                }
                catch (Exception ex)
                {
                }
            }
            try
            {
                //MTabOrder MTab = new MTabOrder(frm);
                //MTab.MSetTabOrder(MTabOrder.TabScheme.AcrossFirst);
            }
            catch (Exception ex)
            {
            }
        }

        public void ThayDoiNN(XtraUserControl frm)
        {
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT KEYWORD , CASE " + Modules.TypeLanguage + " WHEN 0 THEN VIETNAM WHEN 1 THEN ENGLISH ELSE CHINESE END AS NN  FROM LANGUAGES WHERE FORM = N'" + frm.Name + "' "));

            frm.Text = GetNN(dtTmp, frm.Name, frm.Name);
            List<Control> resultControlList = new List<Control>();
            GetControlsCollection(frm, ref resultControlList, null);
            foreach (Control control1 in resultControlList)
            {
                try
                {
                    DoiNN(control1, frm, dtTmp);
                }
                catch (Exception ex)
                {
                }
            }
            try
            {
                //MTabOrder MTab = new MTabOrder(frm);
                //MTab.MSetTabOrder(MTabOrder.TabScheme.AcrossFirst);
            }
            catch (Exception ex)
            {
            }
        }
                public void DoiNN(Control Ctl, Form frm, DataTable dtNgu)
        {
            // iFontsize
            // sFontForm
            try
            {
                switch (Ctl.GetType().Name.ToString())
                {
                    case "LookUpEdit":
                        {
                            DevExpress.XtraEditors.LookUpEdit CtlDev;
                            CtlDev = (DevExpress.XtraEditors.LookUpEdit)Ctl;
                            CtlDev.Properties.NullText = "";
                            break;
                        }
                    case "Label":
                    case "RadioButton":
                    case "CheckBox":
                        {
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);// Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, Ctl.Name, Modules.TypeLanguage)

                            if (Ctl.GetType().Name.ToString() == "Label")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.Label_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.Label_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            if (Ctl.GetType().Name.ToString() == "RadioButton")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.RadioButton_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.RadioButton_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            if (Ctl.GetType().Name.ToString() == "CheckBox")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.CheckBox_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.CheckBox_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            break;
                        }

                    //case "GroupBox":
                    //    {
                    //        Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);
                    //        if ((Ctl.Name == "grbList"))
                    //        {
                    //            DataTable dtItem = new DataTable();
                    //            try
                    //            {
                    //                dtItem.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "Get_lstDanhsachbaocao", Commons.Modules.UserName, -1, Commons.Modules.TypeLanguage, 1));
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //            }
                    //            foreach (Control ctl1 in Ctl.Controls)
                    //            {
                    //                if ((ctl1.GetType().Name.ToLower() == "navbarcontrol"))
                    //                {
                    //                    foreach (NavBarGroup cl in (NavBarControl)ctl1.Groups)
                    //                        cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                    //                    foreach (NavBarItem cl in (NavBarControl)ctl1.Items)
                    //                    {
                    //                        try
                    //                        {
                    //                            cl.Caption = dtItem.Select().Where(x => x("REPORT_NAME").ToString().Trim() == cl.Name.Trim()).Take(1).Single()("TEN_REPORT");
                    //                        }
                    //                        catch (Exception ex)
                    //                        {
                    //                            cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                    //                        }
                    //                    }
                    //                    break;
                    //                }
                    //            }
                    //        }

                    //        break;
                    //    }

                    case "TabPage":
                        {
                            Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);          // Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, Ctl.Name, Modules.TypeLanguage)
                            break;
                        }

                    case "LabelControl":
                    case "CheckButton":
                    case "CheckEdit":
                    case "XtraTabPage":
                    case "GroupControl":
                        {
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);// Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, Ctl.Name, Modules.TypeLanguage)
                            if (Ctl.GetType().Name.ToString() == "CheckEdit")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.CheckEdit_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.CheckEdit_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            if (Ctl.GetType().Name.ToString() == "LabelControl")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.LabelControl_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.LabelControl_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            break;
                        }

                    case "Button":
                        {
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                            {
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);
                                //LoadImage(Ctl);
                            }

                            break;
                        }

                    case "SimpleButton":
                        {
                            DevExpress.XtraEditors.SimpleButton CtlDev;
                            CtlDev = (DevExpress.XtraEditors.SimpleButton)Ctl;
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                            {
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);
                                //LoadImageDev(CtlDev);
                            }

                            break;
                        }

                    case "RadioGroup":
                        {
                            DevExpress.XtraEditors.RadioGroup radGroup;
                            radGroup = (DevExpress.XtraEditors.RadioGroup)Ctl;
                            for (int i = 0; i <= radGroup.Properties.Items.Count - 1; i++)
                            {
                                if (string.IsNullOrEmpty(radGroup.Properties.Items[i].Value.ToString()))
                                    radGroup.Properties.Items[i].Value = radGroup.Properties.Items[i].Description;
                                radGroup.Properties.Items[i].Description = GetNN(dtNgu, radGroup.Properties.Items[i].Value.ToString(), frm.Name);          // Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, radGroup.Properties.Items(i).Description, Modules.TypeLanguage)
                            }
                            try
                            {
                                if (radGroup.SelectedIndex == -1)
                                    radGroup.SelectedIndex = 0;
                            }
                            catch (Exception ex)
                            {
                            }

                            break;
                        }

                    case "CheckedListBoxControl":
                        {
                            DevExpress.XtraEditors.CheckedListBoxControl chkGroup;
                            chkGroup = (DevExpress.XtraEditors.CheckedListBoxControl)Ctl;

                            for (int i = 0; i <= chkGroup.Items.Count - 1; i++)
                                chkGroup.Items[i].Description = GetNN(dtNgu, chkGroup.Items[i].Description, frm.Name);// Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, chkGroup.Items(i).Description, Modules.TypeLanguage)
                            break;
                        }

                    case "XtraTabControl":
                        {
                            DevExpress.XtraTab.XtraTabControl tabControl;
                            tabControl = (DevExpress.XtraTab.XtraTabControl)Ctl;
                            for (int i = 0; i <= tabControl.TabPages.Count - 1; i++)
                                tabControl.TabPages[i].Text = GetNN(dtNgu, tabControl.TabPages[i].Name, frm.Name);
                            break;
                        }

                    case "GridControl":
                        {
                            DevExpress.XtraGrid.GridControl grid;
                            grid = (DevExpress.XtraGrid.GridControl)Ctl;
                            DevExpress.XtraGrid.Views.Grid.GridView mainView = (DevExpress.XtraGrid.Views.Grid.GridView)grid.MainView;

                            foreach (DevExpress.XtraGrid.Views.Base.ColumnView view in grid.ViewCollection)
                            {
                                if ((view) is DevExpress.XtraGrid.Views.Grid.GridView)
                                {
                                    foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                                    {
                                        if (col.Visible)
                                        {
                                            col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                            col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                                            col.AppearanceHeader.Options.UseTextOptions = true;
                                            col.Caption = GetNN(dtNgu, col.FieldName, frm.Name);      // Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, col.Name, Modules.TypeLanguage),

                                            AutoCotDev(col);
                                        }
                                    }
                                    MVisGrid((DevExpress.XtraGrid.Views.Grid.GridView)view, frm.Name, view.Name.ToString(), Commons.Modules.UserName, true);
                                    try
                                    {
                                        //view.MouseUp -= this.GridView_MouseUp;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                    try
                                    {
                                        //view.MouseUp += this.GridView_MouseUp;
                                    }
                                    catch (Exception ex)
                                    {
                                    }

                                    try
                                    {
                                        //view.DoubleClick -= this.GridView_DoubleClick;
                                    }
                                    catch (Exception ex)
                                    {
                                    }

                                    try
                                    {
                                        //view.DoubleClick += this.GridView_DoubleClick;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }

                            break;
                        }

                    //case "DataGridView":
                    //    {
                    //        foreach (DataGridViewColumn cl in (DataGridView)Ctl.Columns)
                    //        {
                    //            cl.HeaderText = GetNN(dtNgu, cl.Name, frm.Name);
                    //            AutoCotGrid(cl);
                    //        }
                    //        (DataGridView)Ctl.ColumnHeadersDefaultCellStyle = Commons.Modules.DataGridViewCellStyle1;
                    //        (DataGridView)Ctl.DefaultCellStyle = Commons.Modules.DataGridViewCellStyle2;
                    //        MVisGrid((DataGridView)Ctl, frm.Name, (DataGridView)Ctl.Name.ToString(), Commons.Modules.UserName);
                    //        break;
                    //    }

                    //case "DataGridViewNew":
                    //    {
                    //        foreach (DataGridViewColumn cl in (DataGridView)Ctl.Columns)
                    //        {
                    //            cl.HeaderText = GetNN(dtNgu, cl.Name, frm.Name);
                    //            AutoCotGrid(cl);
                    //        }

                    //        MVisGrid((DataGridView)Ctl, frm.Name, (DataGridView)Ctl.Name.ToString(), Commons.Modules.UserName);
                    //        break;
                    //    }

                    //case "DataGridViewEditor":
                    //    {
                    //        foreach (DataGridViewColumn cl in (DataGridView)Ctl.Columns)
                    //        {
                    //            cl.HeaderText = GetNN(dtNgu, cl.Name, frm.Name);
                    //            AutoCotGrid(cl);
                    //        }

                    //        (DataGridView)Ctl.ColumnHeadersDefaultCellStyle = Commons.Modules.DataGridViewCellStyle1;
                    //        (DataGridView)Ctl.DefaultCellStyle = Commons.Modules.DataGridViewCellStyle2;

                    //        MVisGrid((DataGridView)Ctl, frm.Name, (DataGridView)Ctl.Name.ToString(), Commons.Modules.UserName);
                    //        break;
                    //    }

                    //case object _ when "NavBarControl" | "navBarControl":
                    //    {
                    //        foreach (NavBarGroup cl in (NavBarControl)Ctl.Groups)
                    //            cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                    //        foreach (NavBarItem cl in (NavBarControl)Ctl.Items)
                    //            cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                    //        break;
                    //    }
                }
            }
            catch (Exception ex)
            {
            }
        }



        public void DoiNN(Control Ctl, XtraUserControl frm, DataTable dtNgu)
        {
            // iFontsize
            // sFontForm
            try
            {
                switch (Ctl.GetType().Name.ToString())
                {
                    case "LookUpEdit":
                        {
                            DevExpress.XtraEditors.LookUpEdit CtlDev;
                            CtlDev = (DevExpress.XtraEditors.LookUpEdit)Ctl;
                            CtlDev.Properties.NullText = "";
                            break;
                        }
                    case "Label":
                    case "TextBoxMaskBox":
                    case "RadioButton":
                    case "CheckBox":
                        {
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);// Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, Ctl.Name, Modules.TypeLanguage)

                            if (Ctl.GetType().Name.ToString() == "Label")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.Label_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.Label_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            if (Ctl.GetType().Name.ToString() == "RadioButton")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.RadioButton_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.RadioButton_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            if (Ctl.GetType().Name.ToString() == "CheckBox")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.CheckBox_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.CheckBox_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            break;
                        }

                    //case "GroupBox":
                    //    {
                    //        Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);
                    //        if ((Ctl.Name == "grbList"))
                    //        {
                    //            DataTable dtItem = new DataTable();
                    //            try
                    //            {
                    //                dtItem.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "Get_lstDanhsachbaocao", Commons.Modules.UserName, -1, Commons.Modules.TypeLanguage, 1));
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //            }
                    //            foreach (Control ctl1 in Ctl.Controls)
                    //            {
                    //                if ((ctl1.GetType().Name.ToLower() == "navbarcontrol"))
                    //                {
                    //                    foreach (NavBarGroup cl in (NavBarControl)ctl1.Groups)
                    //                        cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                    //                    foreach (NavBarItem cl in (NavBarControl)ctl1.Items)
                    //                    {
                    //                        try
                    //                        {
                    //                            cl.Caption = dtItem.Select().Where(x => x("REPORT_NAME").ToString().Trim() == cl.Name.Trim()).Take(1).Single()("TEN_REPORT");
                    //                        }
                    //                        catch (Exception ex)
                    //                        {
                    //                            cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                    //                        }
                    //                    }
                    //                    break;
                    //                }
                    //            }
                    //        }

                    //        break;
                    //    }

                    case "TabPage":
                        {
                            Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);          // Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, Ctl.Name, Modules.TypeLanguage)
                            break;
                        }

                    case "LabelControl":
                    case "CheckButton":
                    case "CheckEdit":
                    case "XtraTabPage":
                    case "GroupControl":
                        {
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);// Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, Ctl.Name, Modules.TypeLanguage)
                            if (Ctl.GetType().Name.ToString() == "CheckEdit")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.CheckEdit_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.CheckEdit_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                            if (Ctl.GetType().Name.ToString() == "LabelControl")
                            {
                                try
                                {
                                    //Ctl.MouseDoubleClick -= this.LabelControl_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                                try
                                {
                                    //Ctl.MouseDoubleClick += this.LabelControl_MouseDoubleClick;
                                }
                                catch (Exception ex)
                                {
                                }
                            }

                            break;
                        }

                    case "Button":
                        {
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                            {
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);
                                //LoadImage(Ctl);
                            }

                            break;
                        }

                    case "SimpleButton":
                        {
                            DevExpress.XtraEditors.SimpleButton CtlDev;
                            CtlDev = (DevExpress.XtraEditors.SimpleButton)Ctl;
                            if (Ctl.Name.ToUpper().Substring(0, 4) != "NONN" & Ctl.Name.Length > 4)
                            {
                                Ctl.Text = GetNN(dtNgu, Ctl.Name, frm.Name);
                                //LoadImageDev(CtlDev);
                            }

                            break;
                        }

                    case "RadioGroup":
                        {
                            DevExpress.XtraEditors.RadioGroup radGroup;
                            radGroup = (DevExpress.XtraEditors.RadioGroup)Ctl;
                            for (int i = 0; i <= radGroup.Properties.Items.Count - 1; i++)
                            {
                                if (string.IsNullOrEmpty(radGroup.Properties.Items[i].Value.ToString()))
                                    radGroup.Properties.Items[i].Value = radGroup.Properties.Items[i].Description;
                                radGroup.Properties.Items[i].Description = GetNN(dtNgu, radGroup.Properties.Items[i].Value.ToString(), frm.Name);          // Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, radGroup.Properties.Items(i).Description, Modules.TypeLanguage)
                            }
                            try
                            {
                                if (radGroup.SelectedIndex == -1)
                                    radGroup.SelectedIndex = 0;
                            }
                            catch (Exception ex)
                            {
                            }

                            break;
                        }

                    case "CheckedListBoxControl":
                        {
                            DevExpress.XtraEditors.CheckedListBoxControl chkGroup;
                            chkGroup = (DevExpress.XtraEditors.CheckedListBoxControl)Ctl;

                            for (int i = 0; i <= chkGroup.Items.Count - 1; i++)
                                chkGroup.Items[i].Description = GetNN(dtNgu, chkGroup.Items[i].Description, frm.Name);// Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, chkGroup.Items(i).Description, Modules.TypeLanguage)
                            break;
                        }

                    case "XtraTabControl":
                        {
                            DevExpress.XtraTab.XtraTabControl tabControl;
                            tabControl = (DevExpress.XtraTab.XtraTabControl)Ctl;
                            for (int i = 0; i <= tabControl.TabPages.Count - 1; i++)
                                tabControl.TabPages[i].Text = GetNN(dtNgu, tabControl.TabPages[i].Name, frm.Name);
                            break;
                        }

                    case "GridControl":
                        {
                            DevExpress.XtraGrid.GridControl grid;
                            grid = (DevExpress.XtraGrid.GridControl)Ctl;
                            DevExpress.XtraGrid.Views.Grid.GridView mainView = (DevExpress.XtraGrid.Views.Grid.GridView)grid.MainView;

                            foreach (DevExpress.XtraGrid.Views.Base.ColumnView view in grid.ViewCollection)
                            {
                                if ((view) is DevExpress.XtraGrid.Views.Grid.GridView)
                                {
                                    foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
                                    {
                                        if (col.Visible)
                                        {
                                            col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                            col.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                                            col.AppearanceHeader.Options.UseTextOptions = true;
                                            col.Caption = GetNN(dtNgu, col.FieldName, frm.Name);      // Modules.ObjLanguages.GetLanguage(Modules.ModuleName, frm.Name, col.Name, Modules.TypeLanguage),

                                            AutoCotDev(col);
                                        }
                                    }
                                    MVisGrid((DevExpress.XtraGrid.Views.Grid.GridView)view, frm.Name, view.Name.ToString(), Commons.Modules.UserName, true);
                                    try
                                    {
                                        //view.MouseUp -= this.GridView_MouseUp;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                    try
                                    {
                                        //view.MouseUp += this.GridView_MouseUp;
                                    }
                                    catch (Exception ex)
                                    {
                                    }

                                    try
                                    {
                                        //view.DoubleClick -= this.GridView_DoubleClick;
                                    }
                                    catch (Exception ex)
                                    {
                                    }

                                    try
                                    {
                                        //view.DoubleClick += this.GridView_DoubleClick;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }

                            break;
                        }

                        //case "DataGridView":
                        //    {
                        //        foreach (DataGridViewColumn cl in (DataGridView)Ctl.Columns)
                        //        {
                        //            cl.HeaderText = GetNN(dtNgu, cl.Name, frm.Name);
                        //            AutoCotGrid(cl);
                        //        }
                        //        (DataGridView)Ctl.ColumnHeadersDefaultCellStyle = Commons.Modules.DataGridViewCellStyle1;
                        //        (DataGridView)Ctl.DefaultCellStyle = Commons.Modules.DataGridViewCellStyle2;
                        //        MVisGrid((DataGridView)Ctl, frm.Name, (DataGridView)Ctl.Name.ToString(), Commons.Modules.UserName);
                        //        break;
                        //    }

                        //case "DataGridViewNew":
                        //    {
                        //        foreach (DataGridViewColumn cl in (DataGridView)Ctl.Columns)
                        //        {
                        //            cl.HeaderText = GetNN(dtNgu, cl.Name, frm.Name);
                        //            AutoCotGrid(cl);
                        //        }

                        //        MVisGrid((DataGridView)Ctl, frm.Name, (DataGridView)Ctl.Name.ToString(), Commons.Modules.UserName);
                        //        break;
                        //    }

                        //case "DataGridViewEditor":
                        //    {
                        //        foreach (DataGridViewColumn cl in (DataGridView)Ctl.Columns)
                        //        {
                        //            cl.HeaderText = GetNN(dtNgu, cl.Name, frm.Name);
                        //            AutoCotGrid(cl);
                        //        }

                        //        (DataGridView)Ctl.ColumnHeadersDefaultCellStyle = Commons.Modules.DataGridViewCellStyle1;
                        //        (DataGridView)Ctl.DefaultCellStyle = Commons.Modules.DataGridViewCellStyle2;

                        //        MVisGrid((DataGridView)Ctl, frm.Name, (DataGridView)Ctl.Name.ToString(), Commons.Modules.UserName);
                        //        break;
                        //    }

                        //case object _ when "NavBarControl" | "navBarControl":
                        //    {
                        //        foreach (NavBarGroup cl in (NavBarControl)Ctl.Groups)
                        //            cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                        //        foreach (NavBarItem cl in (NavBarControl)Ctl.Items)
                        //            cl.Caption = GetNN(dtNgu, cl.Name, frm.Name);
                        //        break;
                        //    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void MVisGrid(DevExpress.XtraGrid.Views.Grid.GridView grv, string sForm, string sControl, string UName, bool MDev)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                string sDLieuForm = "";
                dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "MGetDsCotVis", sForm, sControl, UName));
                if (dtTmp.Rows.Count <= 0)
                    return;

                sDLieuForm = Convert.ToString(dtTmp.Rows[0]["COL_VIS"].ToString());
                if (sDLieuForm.ToUpper() == "ALL")
                    return;


                string[] chuoi_tach = sDLieuForm.Split(new Char[] { '@' });

                foreach (string s in chuoi_tach)
                {
                    if (s.ToString().Trim() != "")
                    {
                        try
                        {
                            grv.Columns[s].Visible = false;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void AutoCotDev(DevExpress.XtraGrid.Columns.GridColumn col)
        {
            try
            {
                if (col.ColumnType.ToString() == typeof(DateTime).ToString())
                    col.BestFit();
                else if (col.Name.Contains("MS_MAY"))
                    col.BestFit();
                else if (col.Name.Contains("MS_PT"))
                    col.BestFit();
            }
            catch (Exception ex)
            {
            }
        }
        public string GetNN(DataTable dtNN, string sKeyWord, string sFormName)
        {
            string sNN = "";
            try
            {
                sNN = ((DataRow[])dtNN.Select("KEYWORD = '" + sKeyWord + "'")[0][1]).ToString();
            }
            catch (Exception ex)
            {
                sNN = Modules.ObjLanguages.GetLanguage(Modules.ModuleName, sFormName, sKeyWord, Modules.TypeLanguage);
            }
            return sNN;
        }
        public void GetControlsCollection(Control root, ref List<Control> AllControls, Func<Control, Control> filter)
        {
            foreach (Control child in root.Controls)
            {
                if (Commons.Modules.lstControlName.Any(x => x.ToString() == child.GetType().Name))
                    AllControls.Add(child);
                if (child.Controls.Count > 0)
                    GetControlsCollection(child, ref AllControls, filter);
            }
        }

        //public string GetNN(LayoutControlGroup layout, string sKeyWord, string sFormName)
        //{
        //}
        #endregion
    }
}
