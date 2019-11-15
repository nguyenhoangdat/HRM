using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;

namespace Vs.HRM
{
    public partial class ucKeHoachNghiPhep : DevExpress.XtraEditors.XtraUserControl
    {
        public static ucKeHoachNghiPhep _instance;

        public static ucKeHoachNghiPhep Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucKeHoachNghiPhep();
                return _instance;
            }
        }
        public ucKeHoachNghiPhep()
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, Root, windowsUIButton);
        }
        private void ucKeHoachNghiPhep_Load(object sender, EventArgs e)
        {
            enableButon(true);
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboDonVi(cboSearch_DV);
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboSearch_DV, cboSearch_XN);
            Commons.Modules.ObjSystems.LoadCboTo(cboSearch_DV, cboSearch_XN, cboSearch_TO);
            LoadGrdCongNhan(false);
            Commons.Modules.sPS = "";
            dateNam.EditValue = DateTime.Now;
            radTinHTrang.SelectedIndex = 1;
        }
        private void LoadCboDonVi()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboDON_VI", Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboSearch_DV, dt, "ID_DV", "TEN_DV", "TEN_DV");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void LoadCboXiNghiep()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboXI_NGHIEP", cboSearch_DV.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboSearch_XN, dt, "ID_XN", "TEN_XN", "TEN_XN");
                cboSearch_XN.EditValue = -1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void LoadCboTo()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboTO", cboSearch_DV.EditValue, cboSearch_XN.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboSearch_TO, dt, "ID_TO", "TEN_TO", "TEN_TO");
                cboSearch_TO.EditValue = -1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }

        }
        private void LoadCboLDV()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboLDV", Commons.Modules.UserName, Commons.Modules.TypeLanguage, 0));
                Commons.Modules.ObjSystems.MLoadLookUpEdit(cboLDV, dt, "ID_LDV", "TEN_LDV", "TEN_LDV");
                Commons.Modules.sPrivate = "0LOAD";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void LoadGrdCongNhan(bool cochon)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetCongNhanNghiPhep", cboSearch_DV.EditValue, cboSearch_XN.EditValue, cboSearch_TO.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdDSCN, grvDSCN, dt, false, false, true, true, true, "");
            dt.Columns["CHON"].ReadOnly = false;
            grvDSCN.Columns["CHON"].Visible = false;
            if (cochon == false)
            {
                grvDSCN.Columns["ID_CN"].Visible = false;
                grvDSCN.Columns["TinhTrang"].Visible = false;
                grvDSCN.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
                grvDSCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            }
            else
            {
                grvDSCN.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
                grvDSCN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                grvDSCN.OptionsSelection.CheckBoxSelectorField = "CHON";
            }
            grvDSCN.OptionsView.ColumnAutoWidth = true;
        }
        private void LoadGrdKHNP()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListKeHoachNghiPhep", dateNam.DateTime.Year, grvDSCN.GetFocusedRowCellValue("ID_CN"), Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdKHNP, grvKHNP, dt, false, false, false, true, true, "");
                Commons.Modules.ObjSystems.AddCombXtra("ID_LDV", "TEN_LDV", grvKHNP, "spGetComboLDV");
                grvKHNP.Columns["ID_LDV"].Width = 150;
                grvKHNP.Columns["ID_KHNP"].Visible = false;

            }
            catch (Exception)
            {

            }
        }
        private void grvDSCN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadGrdKHNP();
        }
        private void radTinHTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtTmp = new DataTable();
            string sdkien = "( 1 = 1 )";
            try
            {
                dtTmp = (DataTable)grdDSCN.DataSource;

                if (radTinHTrang.SelectedIndex == 1) sdkien = "(TinhTrang = 1)";
                if (radTinHTrang.SelectedIndex == 2) sdkien = "(TinhTrang = 0)";
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
        private void cboSearch_DV_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboSearch_DV, cboSearch_XN);
            Commons.Modules.ObjSystems.LoadCboTo(cboSearch_DV, cboSearch_XN, cboSearch_TO);
            LoadGrdCongNhan(false);
            Commons.Modules.sPS = "";
        }
        private void cboSearch_XN_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboTo(cboSearch_DV, cboSearch_XN, cboSearch_TO);
            LoadGrdCongNhan(false);
            Commons.Modules.sPS = "";
        }
        private void cboSearch_TO_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadGrdCongNhan(false);
            Commons.Modules.sPS = "";
        }
        private void AddnewRow(GridView view, bool add)
        {
            view.OptionsBehavior.Editable = true;
            if (add == true)
            {
                view.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            }
        }
        private void DeleteAddRow(GridView view)
        {
            view.OptionsBehavior.Editable = false;
            view.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            LoadGrdKHNP();
        }

        private void UpdateKeHoachNghiPhep()
        {

            Commons.Modules.ObjSystems.MCreateTableToDatatable(Commons.IConnections.CNStr, "tabKHNP" + Commons.Modules.UserName, Commons.Modules.ObjSystems.ConvertDatatable(grdKHNP), "");
            string sSql = "UPDATE A set A.TU_NGAY = B.TU_NGAY, A.DEN_NGAY = B.DEN_NGAY,A.NGAY_VAO_LAM_LAI = b.NGAY_VAO_LAM_LAI,SO_GIO = b.SO_GIO,a.GHI_CHU = b.GHI_CHU from dbo.KE_HOACH_NGHI_PHEP A, dbo.tabKHNP" + Commons.Modules.UserName + " B where B.ID_KHNP = A.ID_KHNP and A.ID_CN = " + grvDSCN.GetFocusedRowCellValue("ID_CN") + " INSERT INTO dbo.KE_HOACH_NGHI_PHEP(ID_LDV, ID_CN, TU_NGAY, DEN_NGAY, NGAY_VAO_LAM_LAI, SO_NGAY, SO_GIO, GHI_CHU) SELECT ID_LDV," + grvDSCN.GetFocusedRowCellValue("ID_CN") + ",TU_NGAY,DEN_NGAY,NGAY_VAO_LAM_LAI,NULL,SO_GIO,GHI_CHU FROM tabKHNP" + Commons.Modules.UserName + " WHERE ID_KHNP NOT IN(SELECT ID_KHNP FROM dbo.KE_HOACH_NGHI_PHEP WHERE ID_CN = " + grvDSCN.GetFocusedRowCellValue("ID_CN") + ")";
            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, sSql);
            Commons.Modules.ObjSystems.XoaTable("tabKHNP" + Commons.Modules.UserName);
            //LoadGrdKHNP();
        }
        private void LoadCapNhatPhep()
        {
            LoadGrdCongNhan(true);
            Commons.Modules.sPrivate = "0Load";
            LoadCboLDV();
            memoGhiChu.ResetText();
            datDNgay.DateTime = DateTime.Now;
            datTNgay.DateTime = DateTime.Now;
            datNVao.DateTime = datDNgay.DateTime.AddDays(1);
            numSoGio.Value = Commons.Modules.iGio;
            Commons.Modules.sPrivate = "";
        }
        private bool KiemTraCapNhatPhep(DataTable dt)
        {
            bool resulst = true;
            foreach (DataRow item in dt.Rows)
            {
                if (Convert.ToBoolean(item["CHON"]) == true)
                {
                    try
                    {
                        int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT dbo.fuKiemTraKeHoachNghiPhep(" + Convert.ToInt64(item["ID_CN"]) + ",'" + datTNgay.DateTime.ToString("MM/dd/yyyy") + "','" + datDNgay.DateTime.ToString("MM/dd/yyyy") + "')"));
                        if (n > 0)
                        {
                            resulst = false;
                        }
                    }
                    catch
                    { }
                }
            }
            return resulst;
        }
        private void InsertCapNhatPhep(DataTable dt)
        {

            foreach (DataRow item in dt.Rows)
            {
                if (Convert.ToBoolean(item["CHON"]) == true)
                {
                    try
                    {
                        int n = Convert.ToInt32(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT dbo.fuKiemTraKeHoachNghiPhep(" + Convert.ToInt64(item["ID_CN"]) + ",'" + datTNgay.DateTime.ToString("MM/dd/yyyy") + "','" + datDNgay.DateTime.ToString("MM/dd/yyyy") + "')"));
                        if (n == 0)
                        {
                            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spInSertKeHoachNghiPhep", cboLDV.EditValue, Convert.ToInt64(item["ID_CN"]), datTNgay.EditValue, datDNgay.EditValue, datNVao.EditValue, numSoGio.Value, memoGhiChu.EditValue);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
        private void DeleteCapNhatPhep(DataTable dt)
        {

            foreach (DataRow item in dt.Rows)
            {
                if (Convert.ToBoolean(item["CHON"]) == true)
                {
                    try
                    {
                        string sSql = "DELETE dbo.KE_HOACH_NGHI_PHEP WHERE ID_CN = " + +Convert.ToInt64(item["ID_CN"]) + " AND ID_LDV = " + cboLDV.EditValue + " AND CONVERT(DATE,TU_NGAY) = '" + datTNgay.DateTime.ToString("MM/dd/yyyy") + "' AND CONVERT(DATE,DEN_NGAY) ='" + datDNgay.DateTime.ToString("MM/dd/yyyy") + "'";
                        SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, sSql);
                    }
                    catch
                    {
                    }
                }
            }
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "themsua":
                    {
                        enableButon(false);
                        windowsUIButton.Buttons[7].Properties.Visible = false;
                        windowsUIButton.Buttons[8].Properties.Visible = false;
                        AddnewRow(grvKHNP, true);
                        break;
                    }
                case "capnhatphep":
                    {
                        enableButon(false);
                        grdDSCN.Enabled = true;
                        cboSearch_DV.Enabled = true;
                        cboSearch_XN.Enabled = true;
                        cboSearch_TO.Enabled = true;
                        radTinHTrang.Enabled = true;
                        windowsUIButton.Buttons[2].Properties.Visible = true;
                        windowsUIButton.Buttons[4].Properties.Visible = false;
                        windowsUIButton.Buttons[5].Properties.Visible = false;
                        LoadCapNhatPhep();
                        navigationFrame1.SelectedPage = navigationPage2;
                        break;
                    }
                case "xoa":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteCapNhatPhep"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        if (navigationFrame1.SelectedPage == navigationPage1)
                        {
                            XoaKHNP();
                        }
                        else
                        {
                            DataTable dt = new DataTable();
                            dt = Commons.Modules.ObjSystems.ConvertDatatable(grdDSCN);
                            int n = dt.AsEnumerable().Count(x => x.Field<bool>("CHON").Equals(true));
                            if (n < 1)
                            {
                                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanChuaChonNhanVienNao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                            }
                            DeleteCapNhatPhep(dt);
                        }
                        break;
                    }
                case "luu":
                    {
                        try
                        {


                            grvKHNP.PostEditor();
                            grvKHNP.UpdateCurrentRow();
                            DataTable dt = new DataTable();
                            dt = Commons.Modules.ObjSystems.ConvertDatatable(grdKHNP).AsEnumerable().OrderBy(x => x.Field<DateTime>("TU_NGAY")).CopyToDataTable();
                            bool kt = true;
                            for (int i = 0; i < dt.Rows.Count - 1; i++)
                            {
                                TimeSpan tim = Convert.ToDateTime(dt.Rows[i]["DEN_NGAY"]) - Convert.ToDateTime(dt.Rows[i + 1]["TU_NGAY"]);
                                if (tim.Days > 0)
                                {
                                    kt = false;
                                }

                            }
                            if (kt == false)
                            {
                                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDaBiTrungBanKiemTraLai"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                grvKHNP.RefreshData();
                                enableButon(true);
                                UpdateKeHoachNghiPhep();
                                DeleteAddRow(grvKHNP);
                            }
                        }
                        catch
                        {

                        }
                        break;
                    }
                case "khongluu":
                    {
                        grvKHNP.RefreshData();
                        enableButon(true);
                        DeleteAddRow(grvKHNP);
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        Application.Exit();
                        break;
                    }
                case "capnhat":
                    {
                        DataTable dt = new DataTable();
                        dt = Commons.Modules.ObjSystems.ConvertDatatable(grdDSCN);
                        int n = dt.AsEnumerable().Count(x => x.Field<bool>("CHON").Equals(true));
                        if (n < 1)
                        {
                            XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanChuaChonNhanVienNao"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                        }
                        if (KiemTraCapNhatPhep(dt) == false)
                        {
                            DialogResult dl = XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDaBiTrungNgayBanCoMuonCapNhat"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (dl == DialogResult.OK)
                            {
                                InsertCapNhatPhep(dt);
                            }
                        }
                        else
                        {
                            InsertCapNhatPhep(dt);
                        }
                        break;
                    }
                case "trove":
                    {
                        navigationFrame1.SelectedPage = navigationPage1;
                        LoadGrdCongNhan(false);
                        enableButon(true);
                        grvDSCN_FocusedRowChanged(null, null);
                        break;
                    }
                default:
                    break;
            }
        }
        private void grvKHNP_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //int ngay = 0;
            //DevExpress.XtraGrid.Views.Grid.GridView View = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            //DevExpress.XtraGrid.Columns.GridColumn mslydovang = View.Columns["ID_LDV"];
            //DevExpress.XtraGrid.Columns.GridColumn tungay = View.Columns["TU_NGAY"];
            //DevExpress.XtraGrid.Columns.GridColumn denngay = View.Columns["DEN_NGAY"];
            //DevExpress.XtraGrid.Columns.GridColumn ngayvaolam = View.Columns["NGAY_VAO_LAM_LAI"];
            //if (View.GetRowCellValue(e.RowHandle, mslydovang).ToString() == "")
            //{
            //    e.Valid = false;
            //    View.SetColumnError(mslydovang, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage)); return;
            //}
            //if (View.GetRowCellValue(e.RowHandle, tungay).ToString() == "")
            //{
            //    e.Valid = false;
            //    View.SetColumnError(tungay, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage)); return;
            //}
            //if (View.GetRowCellValue(e.RowHandle, denngay).ToString() == "")
            //{
            //    e.Valid = false;
            //    View.SetColumnError(denngay, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage)); return;
            //}
            //if (View.GetRowCellValue(e.RowHandle, ngayvaolam).ToString() == "")
            //{
            //    e.Valid = false;
            //    View.SetColumnError(ngayvaolam, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgKiemtraTenUserNULL", Commons.Modules.TypeLanguage)); return;
            //}

            //DateTime tn = Convert.ToDateTime(View.GetRowCellValue(e.RowHandle, tungay));
            //DateTime dn = Convert.ToDateTime(View.GetRowCellValue(e.RowHandle, denngay));
            //DateTime nvl = Convert.ToDateTime(View.GetRowCellValue(e.RowHandle, ngayvaolam));
            //DevExpress.XtraGrid.Columns.GridColumn sogio = View.Columns["SO_GIO"];

            //if (dn < tn)
            //{
            //    e.Valid = false;
            //    View.SetColumnError(denngay, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgDenNgayKhongNhoHonTuNgay", Commons.Modules.TypeLanguage)); return;
            //}
            //if (nvl < tn)
            //{
            //    e.Valid = false;
            //    View.SetColumnError(ngayvaolam, Commons.Modules.ObjLanguages.GetLanguage(Commons.Modules.ModuleName, this.Name, "MsgNgayVaoLamKhongNhoHonTuNgay", Commons.Modules.TypeLanguage)); return;
            //}
            //do
            //{
            //    if (tn.DayOfWeek != DayOfWeek.Sunday)
            //    {
            //        ngay += Commons.Modules.iGio;
            //    }
            //    tn = tn.AddDays(1);
            //} while (dn >= tn);
            //View.SetFocusedRowCellValue(sogio, ngay);
        }
        private void XoaKHNP()
        {
            //if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteUser"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            if (grvKHNP.RowCount == 0) return;
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.KE_HOACH_NGHI_PHEP WHERE ID_KHNP  = " + grvKHNP.GetFocusedRowCellValue("ID_KHNP") + "");
                grvKHNP.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());
            }
        }
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = visible;
            windowsUIButton.Buttons[6].Properties.Visible = visible;

            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = !visible;
            windowsUIButton.Buttons[7].Properties.Visible = !visible;
            windowsUIButton.Buttons[8].Properties.Visible = !visible;
            grdDSCN.Enabled = visible;
            cboSearch_DV.Enabled = visible;
            cboSearch_XN.Enabled = visible;
            cboSearch_TO.Enabled = visible;
            radTinHTrang.Enabled = visible;
        }
        private void grdKHNP_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteCapNhatPhep"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                XoaKHNP();
            }
        }
        private void datDNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPrivate == "0LOAD") return;
            int ngay = 0;
            datNVao.DateTime = datDNgay.DateTime.AddDays(TinhNgayVaoLam(datDNgay.DateTime));
            TimeSpan time = datDNgay.DateTime - datTNgay.DateTime;
            TimeSpan time1 = datNVao.DateTime - datTNgay.DateTime;
            if (time.Days < 0)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTuNgayKhongLonHonDenNgay"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (time1.Days < 0)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTuNgayKhongLonHonNgayVaoLam"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            try
            {
                DateTime tn = datTNgay.DateTime.Date;
                if (Commons.Modules.iNNghi == 1)
                {
                    do
                    {
                        if (tn.DayOfWeek != DayOfWeek.Sunday)
                        {
                            ngay += Commons.Modules.iGio;
                        }
                        tn = tn.AddDays(1);
                    } while (datDNgay.DateTime.Date >= tn.Date);
                    numSoGio.Value = ngay; return;
                }
                if (Commons.Modules.iNNghi == 0)
                {
                    do
                    {
                        ngay += Commons.Modules.iGio;
                        tn = tn.AddDays(1);
                    } while (datDNgay.DateTime.Date >= tn.Date);
                    numSoGio.Value = ngay; return;
                }
                else
                {
                    do
                    {
                        if (tn.DayOfWeek != DayOfWeek.Sunday || tn.DayOfWeek != DayOfWeek.Saturday)
                        {
                            ngay += Commons.Modules.iGio;
                        }
                        tn = tn.AddDays(1);
                    } while (datDNgay.DateTime.Date >= tn.Date);
                    numSoGio.Value = ngay; return;
                }
            }
            catch (Exception)
            {

            }
        }
        private void dateNam_EditValueChanged(object sender, EventArgs e)
        {
            LoadGrdKHNP();
        }
        private int TinhNgayVaoLam(DateTime denngay)
        {
            int resulst = 0;
            switch (Commons.Modules.iNNghi)
            {
                case 0:
                    {
                        resulst = 1;
                        break;
                    }
                case 1:
                    {
                        if (denngay.DayOfWeek == DayOfWeek.Saturday)
                        {
                            resulst = 2;
                        }
                        else
                        {
                            resulst = 1;
                        }
                        break;
                    }
                case 2:
                    {
                        if (denngay.DayOfWeek == DayOfWeek.Saturday)
                        {
                            resulst = 3;
                        }
                        else
                        {
                            if (denngay.DayOfWeek == DayOfWeek.Saturday)
                            {
                                resulst = 2;
                            }
                            else
                            {
                                resulst = 1;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }
            return resulst;
        }

        private void grvKHNP_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view == null) return;
                if (e.Column.Name == "colID_LDV")
                {
                    view.SetRowCellValue(e.RowHandle, view.Columns["TU_NGAY"], DateTime.Now);
                    view.SetRowCellValue(e.RowHandle, view.Columns["DEN_NGAY"], DateTime.Now);
                    return;
                }
                if (e.Column.Name == "colTU_NGAY")
                {
                    view.SetRowCellValue(e.RowHandle, view.Columns["DEN_NGAY"], Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, view.Columns["TU_NGAY"]))); return;
                }
                if (e.Column.Name != "colDEN_NGAY") return;

                DateTime tn = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, view.Columns["TU_NGAY"]));
                DateTime dn = Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, view.Columns["DEN_NGAY"]));
                TimeSpan time = tn - dn;
                if (time.Days > 0)
                {
                    view.SetRowCellValue(e.RowHandle, view.Columns["TU_NGAY"], dn);
                }
                view.SetRowCellValue(e.RowHandle, view.Columns["NGAY_VAO_LAM_LAI"], Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, view.Columns["DEN_NGAY"])).AddDays(TinhNgayVaoLam(Convert.ToDateTime(view.GetRowCellValue(e.RowHandle, view.Columns["DEN_NGAY"])))));
                int ngay = 0;
                do
                {
                    if (tn.DayOfWeek != DayOfWeek.Sunday)
                    {
                        ngay += Commons.Modules.iGio;
                    }
                    tn = tn.AddDays(1);
                } while (dn >= tn);
                view.SetFocusedRowCellValue(view.Columns["SO_GIO"], ngay);
            }
            catch
            {

            }
        }
    }
}