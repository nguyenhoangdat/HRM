using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.DocumentView;
using DevExpress.Mvvm;
using VietSoftHRM.Class;
using Microsoft.Win32;
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Grid;

namespace VietSoftHRM
{
    public partial class ucListDMuc : DevExpress.XtraEditors.XtraUserControl
    {
        public Color color;
        public int iLoai;
        public int iIDOut;
        public string slinkcha;
        public string sSP = Commons.Modules.sPS;
        string sButtonTag = "";
        clsXuLy clsXL = new clsXuLy();
        public ucListDMuc()
        {
            InitializeComponent();
            clsXL.CreateMenuReset(grdDanhMuc);
        }
        private void ucListUser_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;
            LoadDanhMuc();
            //accorMenuleft.Appearance.AccordionControl.BackColor = color;
            //accorMenuleft.Appearance.AccordionControl.ForeColor = Color.White;
            //Commons.Modules.ObjSystems.ThayDoiNN(this);
        }
        //load tất danh mục từ menu
        private void LoadDanhMuc()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetMenuLeft", Commons.Modules.UserName, Commons.Modules.TypeLanguage, iLoai));
            foreach (DataRow item in dt.Rows)
            {
                AccordionControlElement element = new AccordionControlElement();
                element.Expanded = true;
                element.Text = item["NAME"].ToString();
                element.Name = item["KEY_MENU"].ToString();
                element.Tag = item["CONTROLS"].ToString();
                accorMenuleft.Elements.Add(element);
                DataTable dtchill = new DataTable();
                dtchill.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetMenuLeft", Commons.Modules.UserName, Commons.Modules.TypeLanguage, Convert.ToInt32(item["ID_MENU"])));
                if (dtchill.Rows.Count > 0)
                {
                    foreach (DataRow itemchill in dtchill.Rows)
                    {
                        AccordionControlElement elementchill = new AccordionControlElement();
                        elementchill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                        elementchill.Text = itemchill["NAME"].ToString();
                        elementchill.Name = itemchill["KEY_MENU"].ToString();
                        elementchill.Tag = itemchill["CONTROLS"].ToString();
                        element.Elements.Add(elementchill);
                        elementchill.Click += Element_Click;
                    }
                }
                else
                {
                    element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                }
            }


            //foreach (DataRow item in dt.Rows)
            //{
            //    SimpleButton button = new SimpleButton();
            //    Panel pan = new Panel();
            //    pan.Height = 10;
            //    pan.BackColor = Color.White;
            //    pan.Dock = DockStyle.Top;
            //    //splitContainerControl1.Panel1.Controls.Add(pan);
            //    button.Dock = DockStyle.Top;
            //    button.Height = 50;
            //    button.Cursor = Cursors.Hand;
            //    button.Appearance.BackColor = Color.FromArgb(240, 240, 240);
            //    button.Appearance.ForeColor = Color.Black;
            //    button.Click += Button_Click;
            //    button.Name = item["KEY_MENU"].ToString();
            //    button.Tag = item["CONTROLS"].ToString();
            //    button.Text = item["NAME"].ToString();
            //    //button.ImageOptions.Image = (Image)Properties.Resources.ResourceManager.GetObject(item["IMG"].ToString());
            //    button.ImageOptions.Image = Properties.Resources.icon_user;
            //    //splitContainerControl1.Panel1.Controls.Add(button);
            //}
        }

        private void Element_Click(object sender, EventArgs e)
        {
            try
            {
                var button = sender as AccordionControlElement;
                //doimauduocchon(button);
                if (button.Style == DevExpress.XtraBars.Navigation.ElementStyle.Item)
                {
                    lab_Link.Text = slinkcha + " / " + button.Text;
                    string ucName = button.Tag.ToString();
                    Commons.Modules.sPS = button.Name.ToString().Replace("mnu", "");
                    Commons.Modules.sPS = "spGetList" + Commons.Modules.sPS.ToString();
                    sButtonTag = button.Tag.ToString();
                    LoadGridDanhMuc(-1);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                var button = sender as SimpleButton;
                //doimauduocchon(button);
                lab_Link.Text = slinkcha + " / " + button.Text;

                string ucName = button.Tag.ToString();
                Commons.Modules.sPS = button.Name.ToString().Replace("mnu", "");
                Commons.Modules.sPS = "spGetList" + Commons.Modules.sPS.ToString();
                sButtonTag = button.Tag.ToString();
                LoadGridDanhMuc(-1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void LoadGridDanhMuc(int key)
        {
            try
            {
                grdDanhMuc.DataSource = null;
                grvDanhMuc.GroupSummary.Clear();
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, Commons.Modules.sPS, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                if (grdDanhMuc.DataSource is null)
                    Commons.Modules.ObjSystems.MLoadXtraGrid(grdDanhMuc, grvDanhMuc, dt, false, true, false, false, true, this.Name);
                else
                    Commons.Modules.ObjSystems.MLoadXtraGrid(grdDanhMuc, grvDanhMuc, dt, false, false, false, false);

                //if (grvDanhMuc.Columns.Count < 10) grvDanhMuc.OptionsView.ColumnAutoWidth = true;
                //grvDanhMuc.Columns["ID_DV"].Visible = false;
                //DevExpress.Utils.OptionsLayoutGrid opt = new DevExpress.Utils.OptionsLayoutGrid();
                //opt.Columns.StoreAllOptions = true;
                //grdDanhMuc.MainView.SaveLayoutToXml(Application.StartupPath + "\\XML\\grd" + Commons.Modules sSP.Replace("spGetList", "") + ".xml", opt);
                //grdDanhMuc.MainView.SaveLayoutToRegistry("DevExpress\\XtraGrid\\Layouts\\HRM\\grd" + sSP.Replace("spGetList", ""));
                //RepositoryItemMemoEdit memoEdit = new RepositoryItemMemoEdit();
                //memoEdit.ReadOnly = true;
                //memoEdit.AutoHeight = true;
                //memoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                //memoEdit.WordWrap = true;
                //grv_DonVi.GridControl.RepositoryItems.Add(memoEdit);
                //grv_DonVi.Columns["DIA_CHI"].ColumnEdit = memoEdit;
                //grv_DonVi.OptionsView.RowAutoHeight = true;
                if (key != -1)
                {
                    int index = dt.Rows.IndexOf(dt.Rows.Find(key));
                    grvDanhMuc.FocusedRowHandle = grvDanhMuc.GetRowHandle(index);
                }
                else
                {
                    grvDanhMuc.FocusedRowHandle = 0;
                }
                try
                {
                    if (sButtonTag != "")
                    {
                        string[] slist = sButtonTag.Split(';');
                        for (int i = 0; i < slist.Length; i++)
                        {
                            grvDanhMuc.Columns[slist[i].ToString()].GroupIndex = i;
                        }
                        grvDanhMuc.OptionsView.ShowGroupedColumns = true;
                        grvDanhMuc.ExpandAllGroups();
                    }
                }
                catch { }
                //Calculate group summaries. 
                GridGroupSummaryItem item = new GridGroupSummaryItem();
                item.FieldName = grvDanhMuc.Columns[1].FieldName;
                item.SummaryType = DevExpress.Data.SummaryItemType.Count;
                grvDanhMuc.GroupSummary.Add(item);
                //Group and sort data.
                clsXL.loadXmlgrd(grdDanhMuc);
            }
            catch (Exception ex)
            {
            }
        }

        private void Sua()
        {
            try
            {
                XtraUserControl ctl;
                 //Type newType = Type.GetType("VietSoftHRM.ucEditTO", true, true);
                Type newType = Type.GetType("VietSoftHRM.ucEdit" + Commons.Modules.sPS.Replace("spGetList", ""), true, true);
                object o1 = Activator.CreateInstance(newType, grvDanhMuc.GetFocusedRowCellValue(grvDanhMuc.Columns[0].FieldName));
                ctl = o1 as XtraUserControl;
                if (CustomFlyoutDialog.ShowForm(new frmMain(), null, ctl) == DialogResult.OK)
                {
                    LoadGridDanhMuc(Convert.ToInt32(variable.sId));
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void Xoa()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteDanhMuc"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE 	FROM " + Commons.Modules.sPS.Replace("spGetList", "") + " WHERE	" + grvDanhMuc.Columns[0].FieldName + " = " + grvDanhMuc.GetFocusedRowCellValue(grvDanhMuc.Columns[0].FieldName) + "");
                LoadGridDanhMuc(-1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());

            }
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        try
                        {
                            Type newType = Type.GetType("VietSoftHRM.ucEdit" + Commons.Modules.sPS.Replace("spGetList", ""), true, true);
                            object o1 = Activator.CreateInstance(newType, -1);
                            ctl = o1 as XtraUserControl;
                            if (CustomFlyoutDialog.ShowForm(new frmMain(), null, ctl) == DialogResult.OK)
                            {
                                //int DG = ((ctl)pnlFLP.Controls[0]).DG;
                                LoadGridDanhMuc(Convert.ToInt32(variable.sId));
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                        break;
                    }
                case "xoa":
                    {
                        Xoa();
                        break;
                    }
                case "sua":
                    {
                        Sua();
                        break;
                    }
                case "luu":
                    {
                        clsXL.SaveXmlGrid(grdDanhMuc);
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        Application.Exit();
                        break;
                    }
                default:
                    break;
            }
        }

        private void grdDanhMuc_Validated(object sender, EventArgs e)
        {
            clsXL.SaveRegisterGrid(grdDanhMuc);

        }
        
        private void grdDanhMuc_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                Xoa();
                //view.DeleteSelectedRows();
            }
        }

        private void grvDanhMuc_DoubleClick(object sender, EventArgs e)
        {
            Sua();
        }
    }
}
