using System;
using System.Data;
using System.Linq;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.ApplicationBlocks.Data;

namespace Vs.HRM
{
    public partial class ucBHXHThang : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBHXHThang()
        {
            InitializeComponent();
        }
        private void grvThang_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                cboThang.Text = grvThang.GetFocusedRowCellValue("THANG").ToString();
                LoadDot();
            }
            catch { }
            cboThang.ClosePopup();
        }

        private void calThang_DateTimeCommit(object sender, EventArgs e)
        {
            try
            {
                cboThang.Text = calThang.DateTime.ToString("MM/yyyy");
                DataTable dtTmp = Commons.Modules.ObjSystems.ConvertDatatable(grdThang);
                DataRow[] dr;
                dr = dtTmp.Select("NGAY_TTXL" + "='" + cboThang.Text + "'", "NGAY_TTXL", DataViewRowState.CurrentRows);
                if (dr.Count() == 1)
                {
                }
                else { }
            }
            catch (Exception ex)
            {
                cboThang.Text = calThang.DateTime.ToString("MM/yyyy");
            }
            cboThang.ClosePopup();
        }
        private void ucBHXHThang_Load(object sender, EventArgs e)
        {
            Commons.Modules.sPS = "0Load";
            datTNgay.DateTime = DateTime.Today.AddYears(-1);
            datDNgay.DateTime = DateTime.Today;
            LoadThang();
            LoadDot();
            Commons.Modules.sPS = "";
            LoadGrdDCBHXH();
            enableButon(true);
        }

        private void LoadGrdDCBHXH()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetDieuChinhBHXH", "01/" + cboThang.Text, cboDot.Text, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grd_CNDCTC, grv_CNDCTC, dt, false, false, false, true, true, this.Name);
                //Commons.Modules.ObjSystems.AddCombXtra("ID_CN", "TEN_CN", grv_CNDCTC, "spGetCongNhan");
                //Commons.Modules.ObjSystems.AddCombo("ID_LDV", "TEN_LDV", grv_CNDCTC, Commons.Modules.ObjSystems.DataLyDoVang(false));

                //grvDCTroCapBHXH.Columns["ID_HTC"].Visible = false;

                //grvDCTroCapBHXH.Columns["PHAN_TRAM_TRO_CAP"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["SO_NGAY_NGHI"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["MS_CN"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["THANG"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["THANG_CHUYEN"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["DOT"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["DOT_CHUYEN"].OptionsColumn.ReadOnly = true;
                //grvDCTroCapBHXH.Columns["MUC_HUONG_CU"].OptionsColumn.ReadOnly = true;

                //grvDCTroCapBHXH.Columns["MS_CN"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                //grvDCTroCapBHXH.Columns["ID_CN"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                //grvDCTroCapBHXH.Columns["ID_LDV"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;

                //grvDCTroCapBHXH.Columns["MS_CN"].Width = 100;
                //grvDCTroCapBHXH.Columns["ID_CN"].Width = 200;
                //grvDCTroCapBHXH.Columns["ID_LDV"].Width = 200;

                //grvDCTroCapBHXH.Columns["MUC_HUONG_CU"].DisplayFormat.FormatType = FormatType.Numeric;
                //grvDCTroCapBHXH.Columns["MUC_HUONG_CU"].DisplayFormat.FormatString = Commons.Modules.sSoLeTT;
                //grvDCTroCapBHXH.Columns["MUC_HUONG_MOI"].DisplayFormat.FormatType = FormatType.Numeric;
                //grvDCTroCapBHXH.Columns["MUC_HUONG_MOI"].DisplayFormat.FormatString = Commons.Modules.sSoLeTT;
                //grvDCTroCapBHXH.Columns["SO_TIEN_LECH"].DisplayFormat.FormatType = FormatType.Numeric;
                //grvDCTroCapBHXH.Columns["SO_TIEN_LECH"].DisplayFormat.FormatString = Commons.Modules.sSoLeTT;

            }
            catch (Exception ex) { }
        }
        private void LoadThang()
        {
            try
            {

                //ItemForDateThang.Visibility = LayoutVisibility.Never;
                DataTable dtthang = new DataTable();
                string sSql = "		SELECT SUBSTRING(CONVERT(VARCHAR(10),THANG,103),4,2) as M, RIGHT(CONVERT(VARCHAR(10),THANG,103),4) AS Y ,RIGHT(CONVERT(VARCHAR(10),THANG,103),7) AS THANG FROM dbo.BHXH_THANG ORDER BY Y DESC , M DESC";
                dtthang.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdThang, grvThang, dtthang, false, true, true, true, true, this.Name);
                grvThang.Columns["M"].Visible = false;
                grvThang.Columns["Y"].Visible = false;


            }
            catch (Exception ex)
            {
            }
        }
        private void LoadDot()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT DOT FROM BHXH_THANG WHERE CONVERT(NVARCHAR(10),THANG,103) = '01/" + cboThang.Text + "' ORDER BY DOT"));
                Commons.Modules.ObjSystems.MLoadComboboxEdit(cboDot, dt,"DOT");
            }
            catch (Exception ex)
            {
            }
        }

        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "sua":
                    {
                        if (string.IsNullOrEmpty(cboThang.Text) || cboDot.Text == null)
                        {
                            Commons.Modules.ObjSystems.msgChung("msgThangkhongduocdetrong");
                            return;
                        }

                        Commons.Modules.ObjSystems.AddnewRow(grv_CNDCTT, true);
                        Commons.Modules.ObjSystems.AddnewRow(grv_CNDCTC, true);
                        //ItemForThang.Visibility = LayoutVisibility.Never;
                        //ItemForDateThang.Visibility = LayoutVisibility.Always;
                        enableButon(false);
                        break;
                    }
                case "xoa":
                    {
                        //XoaTroCapBaoHiemXH();
                        break;
                    }
                case "luu":
                    {
                        Validate();
                        if (grv_CNDCTT.HasColumnErrors) return;
                        if (grv_CNDCTT.HasColumnErrors) return;
                        enableButon(true);
                        break;
                    }

                case "khongluu":
                    {
                        //LoadGrdTroCapBHXH();
                        //LoadGrdDCBHXH(false);
                        Commons.Modules.ObjSystems.DeleteAddRow(grv_CNDCTT);
                        Commons.Modules.ObjSystems.DeleteAddRow(grv_CNDCTC);
                        enableButon(true);
                        break;
                    }
                case "thoat":
                    {
                        Commons.Modules.ObjSystems.GotoHome(this);
                        break;
                    }
                default:
                    break;
            }
        }


        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = !visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;
            cboThang.ReadOnly = !visible;
            cboDot.ReadOnly = !visible;
        }

        private void cboDot_EditValueChanged(object sender, EventArgs e)
        {
            LoadGrdDCBHXH();
        }
    }
}
