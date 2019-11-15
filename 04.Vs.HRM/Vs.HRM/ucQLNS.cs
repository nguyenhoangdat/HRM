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
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Tile;

namespace Vs.HRM
{
    public partial class ucQLNS : DevExpress.XtraEditors.XtraUserControl
    {
        public ucQLNS()
        {
            InitializeComponent();

        }


        void SetupView(TileView cView)
        {
            try
            {
                // Setup tiles options
                cView.BeginUpdate();
                cView.OptionsTiles.RowCount = 3;
                cView.OptionsTiles.Padding = new Padding(20);
                cView.OptionsTiles.ItemPadding = new Padding(10);
                cView.OptionsTiles.IndentBetweenItems = 20;
                cView.OptionsTiles.ItemSize = new Size(340, 190);
                cView.Appearance.ItemNormal.ForeColor = Color.White;
                cView.Appearance.ItemNormal.BorderColor = Color.Transparent;
                //Setup tiles template
                TileViewItemElement leftPanel = new TileViewItemElement();
                TileViewItemElement splitLine = new TileViewItemElement();
                TileViewItemElement addressCaption = new TileViewItemElement();
                TileViewItemElement addressValue = new TileViewItemElement();
                TileViewItemElement yearBuiltCaption = new TileViewItemElement();
                TileViewItemElement yearBuiltValue = new TileViewItemElement();
                TileViewItemElement price = new TileViewItemElement();
                TileViewItemElement image = new TileViewItemElement();
                cView.TileTemplate.Add(leftPanel);
                cView.TileTemplate.Add(splitLine);
                cView.TileTemplate.Add(addressCaption);
                cView.TileTemplate.Add(addressValue);
                cView.TileTemplate.Add(yearBuiltCaption);
                cView.TileTemplate.Add(yearBuiltValue);
                cView.TileTemplate.Add(price);
                cView.TileTemplate.Add(image);
                //
                leftPanel.StretchVertical = true;
                leftPanel.Width = 122;
                leftPanel.TextLocation = new Point(-10, 0);
                leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101);
                //
                splitLine.StretchVertical = true;
                splitLine.Width = 3;
                splitLine.TextAlignment = TileItemContentAlignment.Manual;
                splitLine.TextLocation = new Point(110, 0);
                splitLine.Appearance.Normal.BackColor = Color.White;
                //
                addressCaption.Text = "ADDRESS";
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft;
                addressCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                addressValue.Column = cView.Columns["DIA_CHI_THUONG_TRU"];
                addressValue.AnchorElement = addressCaption;
                addressValue.AnchorIndent = 2;
                addressValue.MaxWidth = 100;

                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                yearBuiltCaption.Text = "YEAR BUILT";
                yearBuiltCaption.AnchorElement = addressValue;
                yearBuiltCaption.AnchorIndent = 14;
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                yearBuiltValue.Column = cView.Columns["NGAY_SINH"];
                yearBuiltValue.AnchorElement = yearBuiltCaption;
                yearBuiltValue.AnchorIndent = 2;
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                price.Column = cView.Columns["TEN_TT_HD"];
                price.TextAlignment = TileItemContentAlignment.BottomLeft;
                price.Appearance.Normal.Font = new Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //
                image.Column = cView.Columns["HINH_CN"];
                image.ImageSize = new Size(280, 220);
                image.ImageAlignment = TileItemContentAlignment.MiddleRight;
                image.ImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                image.ImageLocation = new Point(10, 10);

            }
            finally
            {
                cView.EndUpdate();
            }
        }

        private void ucQLNS_Load(object sender, EventArgs e)
        {
            Commons.Modules.sPS = "0Load";
            LoadCboDonVi();
            LoadCboXiNghiep();
            LoadCboTo();
            radTinhTrang.SelectedIndex = 1;
            LoadNhanSu(-1);
            Commons.Modules.sPS = "";
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
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListNS", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            //Commons.Modules.ObjSystems.MLoadXtraGrid(grdNS, grvNS, dtTmp, false, true, false, false);
            grdNS.DataSource = dtTmp;

            //grdNS.MainView.c
            //grvNS.FocusedRowHandle = 0;
            //grvNS.FocusedColumn = grvNS.Columns[0];
            //DevExpress.XtraGrid.Views.Card.CardView();
            //CardView cardView1 = new CardView();


            //CardView cardView1 = grdNS.MainView as CardView;
            //tileView1.PopulateColumns();

            //gridView2.PopulateColumns();
        }

        private void windowsUIButton_Click(object sender, EventArgs e)
        {
            grdNS.DataSource = null;
            DataTable dtTmp = new DataTable();
            dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetListNS", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            grdNS.DataSource = dtTmp;

            if (grdNS.MainView.ToString() == "DevExpress.XtraGrid.Views.Grid.GridView")
            {

                //grdNS.MainView = tileView1;

            }
            else
            {
                GridView cView = new GridView(grdNS);
                grdNS.MainView = cView;

            }


        }
    
    }
}
