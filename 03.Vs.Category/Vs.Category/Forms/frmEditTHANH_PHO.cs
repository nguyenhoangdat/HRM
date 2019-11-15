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
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;

namespace Vs.Category
{
    public partial class frmEditTHANH_PHO : DevExpress.XtraEditors.XtraForm
    {
        Int64 iId = -1;
        Boolean bAddEdit = true;  // true la add false la edit
        public frmEditTHANH_PHO(Int64 iIdForm, Boolean bAddEditForm)
        {
            InitializeComponent();
            iId = iIdForm;
            bAddEdit = bAddEditForm;

        }



        private void frmEditTHANH_PHO_Load(object sender, EventArgs e)
        {
            LoadQuocGia();
            if (!bAddEdit) LoadText();
            Commons.Modules.ObjSystems.ThayDoiNN(this, layoutControlGroup1, btnWDUI);

        }

        private void frmEditTHANH_PHO_Resize(object sender, EventArgs e) => dataLayoutControl1.Refresh();
        private void LoadQuocGia()
        {

            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListQUOC_GIA", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            ID_QGSearchLookUpEdit.Properties.DataSource = dt;
            ID_QGSearchLookUpEdit.Properties.ValueMember = "ID_QG";
            ID_QGSearchLookUpEdit.Properties.DisplayMember = "TEN_QG";
            ID_QGSearchLookUpEdit.Properties.PopulateViewColumns();

            try
            {

                ID_QGSearchLookUpEdit.Properties.View.Columns["ID_QG"].Visible = false;                
                ID_QGSearchLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None;
                ID_QGSearchLookUpEdit.Properties.View.Columns["TEN_QG"].Caption = Commons.Modules.ObjLanguages.GetLanguage("ucListDMuc", "TEN_QG");
                ID_QGSearchLookUpEdit.Properties.View.Columns["TEN_QG"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                string sSql = "";

                if (bAddEdit)
                {
                    try
                    {
                        sSql = "SELECT TOP 1 ID_QG FROM dbo.[THANH_PHO] WHERE ID_QG = " + iId.ToString();
                        sSql = Convert.ToString(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, sSql).ToString());
                        ID_QGSearchLookUpEdit.EditValue = Convert.ToInt64(sSql);
                    }
                    catch
                    {

                        if (dt.Rows.Count > 0) ID_QGSearchLookUpEdit.EditValue = dt.Rows[0][0];
                    }
                }


            }
            catch (Exception EX)
            {
                XtraMessageBox.Show(EX.Message.ToString());

            }
        }
        private void LoadText()
        {
            try
            {
                string sSql = "";
                sSql = "SELECT ID_QG,TEN_TP, TEN_TP_A, TEN_TP_H,  MS_TINH FROM dbo.THANH_PHO WHERE ID_TP = " + iId.ToString();
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                if (dtTmp.Rows.Count <= 0) return;

                ID_QGSearchLookUpEdit.EditValue = dtTmp.Rows[0]["ID_QG"];
                TEN_TPTextEdit.EditValue = dtTmp.Rows[0]["TEN_TP"];
                TEN_TP_ATextEdit.EditValue = dtTmp.Rows[0]["TEN_TP_A"];
                TEN_TP_HTextEdit.EditValue = dtTmp.Rows[0]["TEN_TP_H"];
                MS_TINHTextEdit.EditValue = dtTmp.Rows[0]["MS_TINH"];

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());

            }

        }

        private void LoadTextNull()
        {
            try
            {
                TEN_TPTextEdit.EditValue = string.Empty;
                TEN_TP_ATextEdit.EditValue = string.Empty;
                TEN_TP_HTextEdit.EditValue = string.Empty;
                MS_TINHTextEdit.EditValue = string.Empty;
                ID_QGSearchLookUpEdit.EditValue = ((DataTable)ID_QGSearchLookUpEdit.Properties.DataSource).Rows[0][0];
            }
            catch { }
        }


        private void btnWDUI_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
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
                            Commons.Modules.sId = SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateThanhPho", (bAddEdit ? -1 : iId), ID_QGSearchLookUpEdit.EditValue, TEN_TPTextEdit.EditValue, TEN_TP_ATextEdit.EditValue, TEN_TP_HTextEdit.EditValue,MS_TINHTextEdit.EditValue).ToString();

                            if (bAddEdit)
                            {
                                if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThemThanhCongBanMuonThemTiep"), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    LoadTextNull();
                                    return;
                                }
                            }
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
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }


    }
}