﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;

namespace Vs.Category
{
    public partial class frmEditTRINH_DO_VAN_HOA : DevExpress.XtraEditors.XtraForm
    {
        Int64 Id = 0;
        Boolean AddEdit = true;  // true la add false la edit
        public frmEditTRINH_DO_VAN_HOA(Int64 iId, Boolean bAddEdit)
        {
            InitializeComponent();
            Id = iId;
            AddEdit = bAddEdit;
        }

        private void frmEditTRINH_DO_VAN_HOA_Load(object sender, EventArgs e)
        {
            LoadLoaiTD();
            if (!AddEdit) LoadText();
            Commons.Modules.ObjSystems.ThayDoiNN(this, layoutControlGroup1, btnALL);
        }

        private void frmEditTRINH_DO_VAN_HOA_Resize(object sender, EventArgs e) => dataLayoutControl1.Refresh();

        private void LoadLoaiTD()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListLOAI_TRINH_DO", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            ID_LOAI_TDSearchLookUpEdit.Properties.DataSource = dt;
            ID_LOAI_TDSearchLookUpEdit.Properties.ValueMember = "ID_LOAI_TD";
            ID_LOAI_TDSearchLookUpEdit.Properties.DisplayMember = "TEN_LOAI_TD";
            ID_LOAI_TDSearchLookUpEdit.Properties.PopulateViewColumns();

            try
            {

                ID_LOAI_TDSearchLookUpEdit.Properties.View.Columns["ID_LOAI_TD"].Visible = false;
                ID_LOAI_TDSearchLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None;
                ID_LOAI_TDSearchLookUpEdit.Properties.View.Columns["TEN_LOAI_TD"].Caption = Commons.Modules.ObjLanguages.GetLanguage("ucListDMuc", "TEN_LOAI_TD");
                ID_LOAI_TDSearchLookUpEdit.Properties.View.Columns["TEN_LOAI_TD"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
                string sSql = "SELECT ID_TDVH, TEN_TDVH, TEN_TDVH_A, TEN_TDVH_H, ID_LOAI_TD " +
                    "FROM TRINH_DO_VAN_HOA WHERE ID_TDVH =	" + Id.ToString();
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                TEN_TDVHTextEdit.EditValue = dtTmp.Rows[0]["TEN_TDVH"].ToString();
                TEN_TDVH_ATextEdit.EditValue = dtTmp.Rows[0]["TEN_TDVH_A"].ToString();
                TEN_TDVH_HTextEdit.EditValue = dtTmp.Rows[0]["TEN_TDVH_H"].ToString();
                ID_LOAI_TDSearchLookUpEdit.EditValue = dtTmp.Rows[0]["ID_LOAI_TD"];
            }
            catch (Exception EX)
            {

                XtraMessageBox.Show(EX.Message.ToString());
            }
        }
        private void LoadTextNull()
        {
            try
            {
                TEN_TDVHTextEdit.EditValue = String.Empty;
                TEN_TDVH_ATextEdit.EditValue = String.Empty;
                TEN_TDVH_HTextEdit.EditValue = String.Empty;
                
                TEN_TDVHTextEdit.Focus();
            }
            catch { }
        }
        private void btnALL_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            try
            {
                WindowsUIButton btn = e.Button as WindowsUIButton;
                XtraUserControl ctl = new XtraUserControl();
                switch (btn.Tag.ToString())
                {

                    case "luu":
                        {
                            if (!dxValidationProvider1.Validate()) return;
                            if (bKiemTrung()) return;
                            Commons.Modules.sId = SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spUpdateTRINH_DO_VAN_HOA", (AddEdit ? -1 : Id),
                                TEN_TDVHTextEdit.EditValue, TEN_TDVH_ATextEdit.EditValue,
                                TEN_TDVH_HTextEdit.EditValue, ID_LOAI_TDSearchLookUpEdit.EditValue).ToString();
                            if (AddEdit)
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
                            this.Close();
                            break;
                        }
                    default: break;
                }
            }
            catch (Exception EX)
            {

                XtraMessageBox.Show(EX.Message.ToString());
            }

        }
        private bool bKiemTrung()
        {
            try
            {
                DataTable dtTmp = new DataTable();
                Int16 iKiem = 0;

                iKiem = Convert.ToInt16(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spCheckData", "ID_TDVH",
                    (AddEdit ? "-1" : Id.ToString()), "TRINH_DO_VAN_HOA", "TEN_TDVH", TEN_TDVHTextEdit.EditValue.ToString(),
                    "", "", "", ""));
                if (iKiem > 0)
                {
                    XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTEN_TDVHNayDaTonTai"));
                    TEN_TDVHTextEdit.Focus();
                    return true;
                }

                iKiem = 0;

                if (!string.IsNullOrEmpty(TEN_TDVH_ATextEdit.Text))
                {
                    iKiem = Convert.ToInt16(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spCheckData", "ID_TDVH",
                        (AddEdit ? "-1" : Id.ToString()), "TRINH_DO_VAN_HOA", "TEN_TDVH_A", TEN_TDVH_ATextEdit.EditValue.ToString(),
                        "", "", "", ""));
                    if (iKiem > 0)
                    {
                        XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTEN_TDVH_ANayDaTonTai"));
                        TEN_TDVH_ATextEdit.Focus();
                        return true;
                    }
                }

                iKiem = 0;
                if (!string.IsNullOrEmpty(TEN_TDVH_HTextEdit.Text))
                {
                    iKiem = Convert.ToInt16(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spCheckData", "ID_TDVH",
                        (AddEdit ? "-1" : Id.ToString()), "TRINH_DO_VAN_HOA", "TEN_TDVH_H", TEN_TDVH_HTextEdit.EditValue.ToString(),
                        "", "", "", ""));
                    if (iKiem > 0)
                    {
                        XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTEN_TDVH_HNayDaTonTai"));
                        TEN_TDVH_HTextEdit.Focus();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
                return true;
            }
            return false;
        }
        
    }
}