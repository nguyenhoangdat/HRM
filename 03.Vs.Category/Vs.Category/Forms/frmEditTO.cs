﻿using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;

namespace Vs.Category
{
    public partial class frmEditTO : DevExpress.XtraEditors.XtraForm
    {
        Int64 iIdTo = 0;
        Boolean bAddEditTo = true;  // true la add false la edit

        public frmEditTO(Int64 iId, Boolean bAddEdit)
        {
            InitializeComponent();
            iIdTo = iId;
            bAddEditTo = bAddEdit;
        }
        private void frmEditTO_Load(object sender, EventArgs e)
        {
            LoadXiNghiep();
            if (!bAddEditTo) LoadText();
            Commons.Modules.ObjSystems.ThayDoiNN(this, layoutControlGroup1, windowsUIButtonPanel2);

        }
        private void LoadXiNghiep()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListXI_NGHIEP", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            ID_XNLookUpEdit.Properties.DataSource = dt;
            ID_XNLookUpEdit.Properties.ValueMember = "ID_XN";
            ID_XNLookUpEdit.Properties.DisplayMember = "TEN_XN";
            ID_XNLookUpEdit.Properties.PopulateViewColumns();

            try
            {
                
                ID_XNLookUpEdit.Properties.View.Columns["ID_XN"].Visible = false;
                ID_XNLookUpEdit.Properties.View.Columns["ID_DV"].Visible = false;
                ID_XNLookUpEdit.Properties.View.Columns["MS_XN"].Visible = false;
                ID_XNLookUpEdit.Properties.View.Columns["STT_XN"].Visible = false;
                ID_XNLookUpEdit.Properties.View.Columns["GOP_PB"].Visible = false;
                ID_XNLookUpEdit.Properties.View.Columns["GOP_TH"].Visible = false;
                ID_XNLookUpEdit.Properties.View.Columns["STT_DV"].Visible = false;
                ID_XNLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None;
                
                ID_XNLookUpEdit.Properties.View.Columns["TEN_DV"].Caption = Commons.Modules.ObjLanguages.GetLanguage("ucListDMuc", "TEN_DV");
                ID_XNLookUpEdit.Properties.View.Columns["TEN_XN"].Caption = Commons.Modules.ObjLanguages.GetLanguage("ucListDMuc", "TEN_XN");

                ID_XNLookUpEdit.Properties.View.Columns["TEN_XN"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                ID_XNLookUpEdit.Properties.View.Columns["TEN_DV"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                if (bAddEditTo)
                {
                    try
                    {
                        string sSql = "SELECT TOP 1 ID_XN FROM dbo.[TO] WHERE ID_TO = " + iIdTo.ToString();
                        sSql = Convert.ToString(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, sSql).ToString());
                        ID_XNLookUpEdit.EditValue = Convert.ToInt64(sSql);

                        sSql = "SELECT ISNULL(MAX(STT_TO),0) + 1 FROM dbo.[TO] WHERE ID_XN = " + sSql.ToString();
                        sSql = (String)SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, sSql).ToString();
                        STT_TOTextEdit.EditValue = Convert.ToInt64(sSql);
                    }
                    catch
                    {

                        if(dt.Rows.Count>0) ID_XNLookUpEdit.EditValue = dt.Rows[0][0];
                    }
                }


            }
            catch(Exception EX)
            {
                XtraMessageBox.Show(EX.Message.ToString());

            }
        }
        private void LoadText()
        {
            string sSql = "";
            sSql = "SELECT ID_TO,ID_XN,MS_TO,TEN_TO,TEN_TO_A,TEN_TO_H,STT_TO FROM dbo.[TO] WHERE ID_TO = " + iIdTo.ToString();
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
            if (dtTmp.Rows.Count <= 0) return;

            ID_XNLookUpEdit.EditValue = dtTmp.Rows[0]["ID_XN"];
            MS_TOTextEdit.EditValue = dtTmp.Rows[0]["MS_TO"];
            TEN_TOTextEdit.EditValue = dtTmp.Rows[0]["TEN_TO"];
            TEN_TO_ANHTextEdit.EditValue = dtTmp.Rows[0]["TEN_TO_A"];
            TEN_TO_HOATextEdit.EditValue = dtTmp.Rows[0]["TEN_TO_H"];
            STT_TOTextEdit.EditValue = dtTmp.Rows[0]["STT_TO"];

        }

        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            try
            {
                switch (btn.Tag.ToString())
                {
                    case "luu":
                        {
                            if (!dxValidationProvider1.Validate()) return;
                            Commons.Modules.sId = SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateTo", (bAddEditTo ? -1 : iIdTo), ID_XNLookUpEdit.EditValue, MS_TOTextEdit.EditValue, TEN_TOTextEdit.EditValue, TEN_TO_ANHTextEdit.EditValue, TEN_TO_HOATextEdit.EditValue, STT_TOTextEdit.EditValue).ToString();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            break;
                        }
                    case "huy":
                        {
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                            break;
                        }
                    default: break;
                }
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmEditTO_Resize(object sender, EventArgs e) => dataLayoutControl1.Refresh();
    }

}
