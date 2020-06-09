using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.ApplicationBlocks.Data;

namespace Vs.HRM
{
    public partial class ucThuongKhacLuong : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThuongKhacLuong()
        {
            InitializeComponent();
        }

        private void optCachThuong_Click(object sender, EventArgs e)
        {
            if(optCachThuong.SelectedIndex ==0)
            {
                txtTienQD.Properties.ReadOnly = true;
                txtSThang.Properties.ReadOnly = false;
                txtSTien.Properties.ReadOnly = false;
                txtSTGHan.Properties.ReadOnly = false;
            }
            else
            {
                txtSThang.Properties.ReadOnly = true;
                txtSTien.Properties.ReadOnly = true;
                txtSTGHan.Properties.ReadOnly = true;
                txtTienQD.Properties.ReadOnly = false;
            }
        }

        private void LoadThang(DateTime dThang)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spThuongKhacLuong", "01/01/1900", "01/01/1900", -1, -1, -1, Commons.Modules.UserName, Commons.Modules.TypeLanguage, "", "Cbo"));

            if (grdThang.DataSource == null)
            {
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdThang, grvThang, dt, false, true, true, true, true, this.Name);
                grvThang.Columns["TIEN_QUY_DINH"].Visible = false;
                grvThang.Columns["SO_THANG_TINH"].Visible = false;
                grvThang.Columns["SO_TIEN"].Visible = false;
                grvThang.Columns["TD_BC"].Visible = false;
            }
            else
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdThang, grvThang, dt, false, false, true, false, false, this.Name);

            try
            {

                if (dThang == Convert.ToDateTime("01/01/1900"))
                {
                    if (dt == null  || dt.Rows.Count <= 0) LoadNull();
                    else
                    {
                        //T1.ID_NDTKL, T1.NGAY_TKL, T1.TIEN_QUY_DINH, T1.SO_THANG_TINH, T1.SO_TIEN, T1.SO_TIEN_GH, T1.TD_BC
                        cboThang.Text = Convert.ToDateTime(dt.Rows[0]["NGAY_TTXL"].ToString()).ToShortDateString();
                        txtTienQD.Text = dt.Rows[0]["TIEN_QUY_DINH"].ToString();
                        txtSThang.Text = dt.Rows[0]["SO_THANG_TINH"].ToString();
                        txtSTien.Text = dt.Rows[0]["SO_TIEN"].ToString();
                        txtSTGHan.Text = dt.Rows[0]["SO_TIEN_GH"].ToString();
                        txtTDBC.Text = dt.Rows[0]["TD_BC"].ToString();
                    }
                }
                else
                {
                    cboThang.Text = dThang.Date.ToShortDateString();

                    DataRow[] dr;
                    dr = dt.Select("NGAY_TTXL" + "='" + cboThang.Text + "'", "NGAY_TTXL", DataViewRowState.CurrentRows);
                    if (dr.Count() == 1)
                    {
                        cboThang.Text = Convert.ToDateTime(dr[0]["NGAY_TTXL"].ToString()).ToShortDateString();
                        txtTienQD.Text = dr[0]["TIEN_QUY_DINH"].ToString();
                        txtSThang.Text = dr[0]["SO_THANG_TINH"].ToString();
                        txtSTien.Text = dr[0]["SO_TIEN"].ToString();
                        txtSTGHan.Text = dr[0]["SO_TIEN_GH"].ToString();
                        txtTDBC.Text = dr[0]["TD_BC"].ToString();
                    }
                    else { LoadNull(); }
                }
            }
            catch { LoadNull(); }

        }
        private void grvThang_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                GridView grv = (GridView)sender;
                cboThang.Text = Convert.ToDateTime(grv.GetFocusedRowCellValue("NGAY_TTXL").ToString()).ToShortDateString();
                txtTienQD.Text = grv.GetFocusedRowCellValue("TIEN_QUY_DINH").ToString();
                txtSThang.Text = grv.GetFocusedRowCellValue("SO_THANG_TINH").ToString();
                txtSTien.Text = grv.GetFocusedRowCellValue("SO_TIEN").ToString();
                txtSTGHan.Text = grv.GetFocusedRowCellValue("SO_TIEN_GH").ToString();
                txtTDBC.Text = grv.GetFocusedRowCellValue("TD_BC").ToString();
            }
            catch { LoadNull(); }
            cboThang.ClosePopup();
        }

        private void calThang_DateTimeCommit(object sender, EventArgs e)
        {
            try
            {
                cboThang.Text = calThang.DateTime.Date.ToShortDateString();
                DataTable dtTmp = Commons.Modules.ObjSystems.ConvertDatatable(grdThang);
                DataRow[] dr;
                dr = dtTmp.Select("NGAY_TTXL" + "='" + cboThang.Text + "'", "NGAY_TTXL", DataViewRowState.CurrentRows);
                if (dr.Count() == 1)
                {
                    cboThang.Text = Convert.ToDateTime(dr[0]["NGAY_TTXL"].ToString()).ToShortDateString();
                    txtTienQD.Text = dr[0]["TIEN_QUY_DINH"].ToString();
                    txtSThang.Text = dr[0]["SO_THANG_TINH"].ToString();
                    txtSTien.Text = dr[0]["DEN_THANG"].ToString();
                    txtSTGHan.Text = dr[0]["SO_TIEN_GH"].ToString();
                    txtTDBC.Text = dr[0]["TD_BC"].ToString();
                }
                else { LoadNull(); }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
                cboThang.Text = DateTime.Now.ToShortDateString();
            }
            cboThang.ClosePopup();
        }

        private void LoadNull()
        {
            try
            {
                if (cboThang.Text == "") cboThang.Text = DateTime.Now.ToShortDateString();
                txtTienQD.Text = "0";
                txtSThang.Text = "0";
                txtSTien.Text = "0";
                txtSTGHan.Text = "0";
                txtTDBC.Text = "";
            }
            catch (Exception ex)
            {
                cboThang.Text = "";txtTienQD.Text = "0";txtSThang.Text = "0";txtSTien.Text = "0";txtSTGHan.Text = "0";txtTDBC.Text = "";
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void ucThuongKhacLuong_Load(object sender, EventArgs e)
        {
            Commons.Modules.sPS = "0Load";
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spThuongKhacLuong", "01/01/1900", "01/01/1900", -1, -1, -1, Commons.Modules.UserName, Commons.Modules.TypeLanguage, "", "CboNoiDung"));
            Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboNDung, dt, "ID_NDTKL", "TEN_THUONG", "TEN_THUONG");

            LoadThang(Convert.ToDateTime("01/01/1900"));
            Commons.Modules.ObjSystems.LoadCboDonVi(cboDV);
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboDV, cboXN);
            Commons.Modules.ObjSystems.LoadCboTo(cboDV, cboXN, cboTo);
            Commons.Modules.sPS = "";
        }
    }
}
