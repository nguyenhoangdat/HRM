using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraLayout.Utils;

namespace Vs.HRM
{
    public partial class ucQLNS : DevExpress.XtraEditors.XtraUserControl
    {

        public AccordionControl accorMenuleft;
        public ucQLNS()
        {
            InitializeComponent();
        }
        private void ucQLNS_Load(object sender, EventArgs e)
        {

            Commons.Modules.sPS = "0Load";
            LoadCboDonVi();
            LoadCboXiNghiep();
            LoadCboTo();
            LoadNhanSu(-1);
            Commons.Modules.sPS = "";
            LoadTinhTrangHopDong();
        }
        private void LoadCboDonVi()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboDON_VI", Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboDV, dt, "ID_DV", "TEN_DV", "TEN_DV");
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
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboXI_NGHIEP", cboDV.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboXN, dt, "ID_XN", "TEN_XN", "TEN_XN");
                cboXN.EditValue = -1;
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
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComboTO", cboDV.EditValue, cboXN.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
                Commons.Modules.ObjSystems.MLoadSearchLookUpEdit(cboTo, dt, "ID_TO", "TEN_TO", "TEN_TO");
                cboTo.EditValue = -1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }

        }

        private void LoadTinhTrangHopDong()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComBoTinhTrangHopDong", Commons.Modules.UserName, Commons.Modules.TypeLanguage, 1));
            Commons.Modules.ObjSystems.MLoadLookUpEdit(cbo_TTHT, dt, "ID_TT_HT", "TEN_TT_HT", "TEN_TT_HT");
        }
        private void cboDV_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadCboXiNghiep();
            LoadCboTo();
            LoadNhanSu(-1);
            Commons.Modules.sPS = "";
        }

        private void cboXN_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadCboTo();
            LoadNhanSu(-1);
            Commons.Modules.sPS = "";
        }

        private void cboTo_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadNhanSu(-1);
            Commons.Modules.sPS = "";
        }

        private void LoadNhanSu(int iIdNs)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListNS", cboDV.EditValue, cboXN.EditValue, cboTo.EditValue, cbo_TTHT.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                grdNS.DataSource = dtTmp;
            }
            catch { }

        }
        private void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            try
            {
                if (e.Item == null || e.Item.Elements.Count == 0)
                    return;
                e.Item.Elements[0].Appearance.Normal.BackColor = System.Drawing.ColorTranslator.FromHtml(tileViewCN.GetRowCellValue(e.RowHandle, tileViewCN.Columns["MAU_TT"]).ToString());
            }
            catch { }
        }

        private void grdNS_DoubleClick(object sender, EventArgs e)
        {
            //windowsUIButton_ButtonClick( )
        }

        //private void windowsUIButton_ButtonClick(object sender, ButtonEventArgs e)
        //{
        //    WindowsUIButton btn = e.Button as WindowsUIButton;
        //    XtraUserControl ctl = new XtraUserControl();
        //    switch (btn.Tag.ToString())
        //    {
        //        case "them":
        //            {
        //                navigationFrame1.SelectedPage = navigationPage2;
        //                break;
        //            }
        //        case "sua":
        //            {
        //                navigationFrame1.SelectedPage = navigationPage2;
        //                break;
        //            }
        //        case "xoa":
        //            {
        //                break;
        //            }
        //        case "luu":
        //            {
        //                accorMenuleft.Visible = true;
        //                navigationFrame1.SelectedPage = navigationPage1;
        //                break;
        //            }
        //        case "khongluu":
        //            {
        //                accorMenuleft.Visible = true;
        //                navigationFrame1.SelectedPage = navigationPage1;
        //                break;
        //            }
        //        case "thoat":
        //            {
        //                if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
        //                Application.Exit();
        //                break;
        //            }
        //        default:
        //            break;
        //    }
        //}
        private void tileView1_DoubleClick(object sender, EventArgs e)
        {
            grdNS.Visible = false;
            accorMenuleft.Visible = false;
            ucCTQLNS dl = new ucCTQLNS(Convert.ToInt64(tileViewCN.GetFocusedRowCellValue(tileViewCN.Columns["ID_CN"])));
            dl.Refresh();
            navigationPage2.Controls.Add(dl);
            dl.Dock = DockStyle.Fill;
            dl.backWindowsUIButtonPanel.ButtonClick += BackWindowsUIButtonPanel_ButtonClick;
            navigationFrame1.SelectedPage = navigationPage2;
        }

        private void BackWindowsUIButtonPanel_ButtonClick(object sender, ButtonEventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
            navigationPage2.Controls.RemoveAt(0);
            accorMenuleft.Visible = true;
            LoadNhanSu(-1);
        }
        private void emptySpaceItem1_DoubleClick(object sender, EventArgs e)
        {
            ItemForDON_VI.Visibility = ItemForDON_VI.Visibility == LayoutVisibility.Never ? LayoutVisibility.Always : LayoutVisibility.Never;
            ItemForTO.Visibility = ItemForTO.Visibility == LayoutVisibility.Never ? LayoutVisibility.Always : LayoutVisibility.Never;
            ItemForTT_HT.Visibility = ItemForTT_HT.Visibility == LayoutVisibility.Never ? LayoutVisibility.Always : LayoutVisibility.Never;
            ItemForXI_NGHIEP.Visibility = ItemForXI_NGHIEP.Visibility == LayoutVisibility.Never ? LayoutVisibility.Always : LayoutVisibility.Never;
            ItemForSerchControl.Visibility = ItemForSerchControl.Visibility == LayoutVisibility.Never ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
    } 
}
