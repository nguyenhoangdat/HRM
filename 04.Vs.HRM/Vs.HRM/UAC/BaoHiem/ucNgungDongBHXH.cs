using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;
using System.Collections.Generic;
using DevExpress.XtraLayout;
using System.Threading;

namespace Vs.HRM
{
    public partial class ucNgungDongBHXH : DevExpress.XtraEditors.XtraUserControl
    {
        public static ucNgungDongBHXH _instance;
        public static ucNgungDongBHXH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNgungDongBHXH();
                return _instance;
            }
        }
        string sBT = "tabNgungDongBHXH"+Commons.Modules.ModuleName;
        public ucNgungDongBHXH()
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, new List<LayoutControlGroup>() { Root }, windowsUIButton);
        }
        private void ucNgungDongBHXH_Load(object sender, EventArgs e)
        {
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboDonVi(cboDV);
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboDV, cboXN);
            Commons.Modules.ObjSystems.LoadCboTo(cboDV, cboXN, cboTo);
            LoadGrdCongNhan();
            radTinHTrang_SelectedIndexChanged(null, null);
            Commons.Modules.sPS = "";
            enableButon(true);
        }

        private void cboDV_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboDV, cboXN);
            Commons.Modules.ObjSystems.LoadCboTo(cboDV, cboXN, cboTo);
            LoadGrdCongNhan();
            Commons.Modules.sPS = "";
        }
        private void cboXN_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboTo(cboDV, cboXN, cboTo);
            LoadGrdCongNhan();
            Commons.Modules.sPS = "";
        }
        private void cboTo_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadGrdCongNhan();
            Commons.Modules.sPS = "";
        }

        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "themsua":
                    {
                        if(grvCongNhan.RowCount == 0)
                        {
                            Commons.Modules.ObjSystems.msgChung(Commons.ThongBao.msgBanChuaChonDuLieu);
                            return;
                        }
                        Commons.Modules.ObjSystems.AddnewRow(grvNgungDongBHXH, true);
                        enableButon(false);
                        break;
                    }
                case "xoa":
                    {
                        XoaNgungDongBHXH();
                        break;
                    }
                case "luu":
                    {
                        Validate();
                        if (grvNgungDongBHXH.HasColumnErrors) return;
                        if(Savedata() ==false)
                        {
                            Commons.Modules.ObjSystems.msgChung(Commons.ThongBao.msgDuLieuDangSuDung);
                        }
                        enableButon(true);
                        Commons.Modules.ObjSystems.DeleteAddRow(grvNgungDongBHXH);
                        break;
                    }
                case "khongluu":
                    {
                        Commons.Modules.ObjSystems.DeleteAddRow(grvNgungDongBHXH);
                        LoadgrdNgungDongBHXH();
                        enableButon(true);
                        break;
                    }
                case "thoat":
                    {
                        Commons.Modules.ObjSystems.GotoHome(this);
                        break;
                    }
            }
        }

        #region hàm xử lý dữ liệu
        private void LoadGrdCongNhan()
        {
            try
            {
                Commons.Modules.sPS = "0Load";
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetCongNhanTheoTT", cboDV.EditValue, cboXN.EditValue, cboTo.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdCongNhan, grvCongNhan, dt, false, false, true, true, true, "");
                grvCongNhan.Columns["ID_CN"].Visible = false;
                grvCongNhan.Columns["TINH_TRANG"].Visible = false;
                Commons.Modules.sPS = "";
            }
            catch (Exception)
            {
            }
        }
        private void LoadgrdNgungDongBHXH()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT * FROM dbo.DS_CN_TAM_NGUNG_BHXH WHERE ID_CN = " + grvCongNhan.GetFocusedRowCellValue("ID_CN") + " "));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdNgungDongBHXH, grvNgungDongBHXH, dt, false, false,true, true, true, "");
                grvNgungDongBHXH.Columns["ID_CN"].Visible = false;
            }
            catch (Exception)
            {
            }

        }
        private bool Savedata()
        {
            try
            {
                //kiểm lại dữ liệu có trùng khóa hay chưa
                Commons.Modules.ObjSystems.MCreateTableToDatatable(Commons.IConnections.CNStr, sBT, Commons.Modules.ObjSystems.ConvertDatatable(grvNgungDongBHXH), "");
                string sSql = "DELETE DS_CN_TAM_NGUNG_BHXH WHERE ID_CN = "+grvCongNhan.GetFocusedRowCellValue("ID_CN")+" INSERT INTO dbo.DS_CN_TAM_NGUNG_BHXH(ID_CN,NGAY_NGUNG_BHXH,NGAY_THAM_GIA_BHXH,TRA_THE) SELECT ID_CN, NGAY_NGUNG_BHXH, NGAY_THAM_GIA_BHXH, TRA_THE FROM "+sBT+"";
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, sSql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = !visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = visible;
            searchControl.Visible = visible;
        }
        private void XoaNgungDongBHXH()
        {
            if (grvNgungDongBHXH.RowCount == 0) { Commons.Modules.ObjSystems.msgChung(Commons.ThongBao.msgKhongCoDuLieuXoa); return; }
            if (Commons.Modules.ObjSystems.msgHoi(Commons.ThongBao.msgXoa) == DialogResult.No) return;
            //xóa
            try
            {
                string sSql = "DELETE dbo.DS_CN_TAM_NGUNG_BHXH WHERE ID_CN = " + grvNgungDongBHXH.GetFocusedRowCellValue("ID_CN") + "  AND NGAY_NGUNG_BHXH = '"+Convert.ToDateTime(grvNgungDongBHXH.GetFocusedRowCellValue("NGAY_NGUNG_BHXH")).ToString("MM/dd/yyyy") +"' ";
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, sSql);
                grvNgungDongBHXH.DeleteSelectedRows();
            }
            catch
            {
                Commons.Modules.ObjSystems.msgChung(Commons.ThongBao.msgKhongCoDuLieuXoa);
            }
        }
        #endregion

        private void radTinHTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtTmp = new DataTable();
            string sdkien = "( 1 = 1 )";
            try
            {
                dtTmp = (DataTable)grdCongNhan.DataSource;

                if (radTinHTrang.SelectedIndex == 1) sdkien = "(TINH_TRANG = 1)";
                if (radTinHTrang.SelectedIndex == 2) sdkien = "(TINH_TRANG = 0)";
                dtTmp.DefaultView.RowFilter = sdkien;
            }
            catch
            {
                try
                {
                    dtTmp.DefaultView.RowFilter = "";
                }
                catch { }
            }
        }

        private void grvCongNhan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadgrdNgungDongBHXH();
        }

        private void grvNgungDongBHXH_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView View = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            DevExpress.XtraGrid.Columns.GridColumn ngayngung = View.Columns["NGAY_NGUNG_BHXH"];

            grvNgungDongBHXH.SetFocusedRowCellValue("ID_CN", grvCongNhan.GetFocusedRowCellValue("ID_CN"));
            DataTable dt = Commons.Modules.ObjSystems.ConvertDatatable(View);
            if (dt.AsEnumerable().Count(x => x.Field<DateTime>("NGAY_NGUNG_BHXH").Equals(Convert.ToDateTime(View.GetRowCellValue(e.RowHandle, ngayngung)))) > 1)
            {
                e.Valid = false;
                View.SetColumnError(ngayngung, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraNgayNgungDongBHXH", Commons.Modules.TypeLanguage)); return;
            }

        }

        private void grdNgungDongBHXH_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                XoaNgungDongBHXH();
            }
        }
    }
}
