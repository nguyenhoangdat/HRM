﻿using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Grid;
using VietSoftHRM.Class;
using System.Threading;
using DevExpress.XtraPrinting;
using VietSoftHRM.Properties;

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
        string sCount = "Count";
        
        public ucListDMuc()
        {
            InitializeComponent();
            Commons.Modules.OXtraGrid.CreateMenuReset(grdDanhMuc);
        }
        private void ucListUser_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;
            LoadDanhMuc();
            Commons.Modules.ObjSystems.ThayDoiNN(this);
            sCount = Commons.Modules.ObjLanguages.GetLanguage(this.Name.ToString(), "sCount");
            accorMenuleft.SelectElement(accorMenuleft.Elements[0].Elements[0]);
            Commons.Modules.sPS = "";
            Element_Click(accorMenuleft.Elements[0].Elements[0], null);
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
            
        }

        private void Element_Click(object sender, EventArgs e)
        {
            try
            {
                Commons.Modules.iPermission = 0;
                var button = sender as AccordionControlElement;                
                //doimauduocchon(button);
                if (button.Style == DevExpress.XtraBars.Navigation.ElementStyle.Item)
                {
                    string sSql = " SELECT T1.ID_PERMISION FROM dbo.NHOM_MENU T1 INNER JOIN dbo.MENU T2 ON T2.ID_MENU = T1.ID_MENU INNER JOIN dbo.USERS T3 ON T3.ID_NHOM = T1.ID_NHOM WHERE	T2.KEY_MENU = N'" + button.Name.ToString() + "' AND T3.USER_NAME = N'" + Commons.Modules.UserName + "' ";
                    Commons.Modules.iPermission = Convert.ToInt16(SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, sSql).ToString());
                    if (Commons.Modules.sPS == "spGetList" + button.Name.ToString().Replace("mnu", "")) return;


                    lab_Link.Text = slinkcha + " / " + button.Text;
                    string ucName = button.Tag.ToString();
                    Commons.Modules.sPS = button.Name.ToString().Replace("mnu", "");
                    Commons.Modules.sPS = "spGetList" + Commons.Modules.sPS.ToString();
                    sButtonTag = button.Tag.ToString();
                    LoadGridDanhMuc(-1);
                    

                    if (Commons.Modules.iPermission != 1) // READ ONLY
                    {
                        windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                        windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
                        windowsUIButtonPanel1.Buttons[2].Properties.Visible = false;
                        windowsUIButtonPanel1.Buttons[3].Properties.Visible = false;
                        //windowsUIButtonPanel1.Buttons[4].Properties.Visible = false;
                        //windowsUIButtonPanel1.Buttons[5].Properties.Visible = false;
                        //windowsUIButtonPanel1.Buttons[6].Properties.Visible = false;
                    }
                    else
                    {
                        windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
                        windowsUIButtonPanel1.Buttons[1].Properties.Visible = true;
                        windowsUIButtonPanel1.Buttons[2].Properties.Visible = true;
                        windowsUIButtonPanel1.Buttons[3].Properties.Visible = true;
                        //windowsUIButtonPanel1.Buttons[4].Properties.Visible = true;
                        //windowsUIButtonPanel1.Buttons[5].Properties.Visible = true;
                        //windowsUIButtonPanel1.Buttons[6].Properties.Visible = true;
                    }
                }
            }
            catch
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
        private void LoadGridDanhMuc(Int64 key)
        {
            try
            {
                grdDanhMuc.DataSource = null;
                grvDanhMuc.GroupSummary.Clear();
                grvDanhMuc.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, Commons.Modules.sPS, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                Commons.Modules.ObjSystems.MLoadXtraGrid(grdDanhMuc, grvDanhMuc, dt, false, true, false, false, true, this.Name);
                if (key != -1)
                {
                    int index = dt.Rows.IndexOf(dt.Rows.Find(key));
                    grvDanhMuc.FocusedRowHandle = grvDanhMuc.GetRowHandle(index);
                    grvDanhMuc.SelectRow(index);
                }
                else
                {
                    grvDanhMuc.FocusedRowHandle = 0;
                    grvDanhMuc.SelectRow(0);
                }
                //DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repoMemo = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
                //repoMemo.WordWrap = true;

                //foreach (DevExpress.XtraGrid.Columns.GridColumn column in grvDanhMuc.Columns)
                //{
                //    if (column.ColumnType.ToString() == "System.String")
                //        column.ColumnEdit = repoMemo;
                //}
                //grvDanhMuc.OptionsView.RowAutoHeight = true;
                grvDanhMuc.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, string.Empty);
                Commons.Modules.OXtraGrid.loadXmlgrd(grdDanhMuc);
            }
            catch (Exception EX)
            {
                XtraMessageBox.Show(EX.Message.ToString());
            }
        }

        private void ThemSua(Boolean AddEdit) //AddEdit = true --> them
        {
            try
            {
                if (Commons.Modules.iPermission != 1) return;
                if (grvDanhMuc.RowCount ==0 && AddEdit == false) return;
                XtraForm ctl;
                Type newType = Type.GetType("Vs.Category.frmEdit" + Commons.Modules.sPS.Replace("spGetList", "") + ", Vs.Category", true, true);
                object o1 = Activator.CreateInstance(newType, grvDanhMuc.GetFocusedRowCellValue(grvDanhMuc.Columns[0].FieldName), AddEdit);
                ctl = o1 as XtraForm;
                ctl.StartPosition = FormStartPosition.CenterParent;
                double iW, iH;
                iW = Screen.PrimaryScreen.WorkingArea.Width / 1.5;
                iH = Screen.PrimaryScreen.WorkingArea.Height / 1.5;
                if (iW < 800)
                {
                    iW = iW * 1.2;
                    iH = iH * 1.2;
                }
                ctl.Size = new Size((int)iW, (int)iH);
                if (ctl.ShowDialog() == DialogResult.OK)
                {
                    LoadGridDanhMuc(Convert.ToInt64(Commons.Modules.sId));
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());

            }
        }
        private void Xoa(string sCaption)
        {
            try
            {
                if (grvDanhMuc.RowCount == 0)
                {
                    XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgKhongCoDuLieuDeXoa"), sCaption);
                    return;
                }
                if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteDanhMuc"), sCaption, MessageBoxButtons.YesNo) == DialogResult.No) return;
                //xóa

                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE FROM [" + Commons.Modules.sPS.Replace("spGetList", "") + "] WHERE	" + grvDanhMuc.Columns[0].FieldName + " = " + grvDanhMuc.GetFocusedRowCellValue(grvDanhMuc.Columns[0].FieldName) + "");
                LoadGridDanhMuc(-1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString(), sCaption);

            }
        }

        private void Them()
        {
            try
            {
                XtraForm ctl;
                Type newType = Type.GetType("VietSoftHRM.frmEdit" + Commons.Modules.sPS.Replace("spGetList", ""), true, true);
                object o1 = Activator.CreateInstance(newType, grvDanhMuc.GetFocusedRowCellValue(grvDanhMuc.Columns[0].FieldName), true);
                ctl = o1 as XtraForm;
                ctl.StartPosition = FormStartPosition.CenterParent;
                //ctl.ShowDialog
                if (ctl.ShowDialog() == DialogResult.OK)
                {
                    LoadGridDanhMuc(Convert.ToInt64(Commons.Modules.sId));
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());

            }

        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        ThemSua(true);
                        break;
                    }
                case "xoa":
                    {
                        Xoa(btn.Caption);
                        break;
                    }
                case "sua":
                    {
                        ThemSua(false);
                        break;
                    }
                case "thoat":
                    {
                        Commons.Modules.ObjSystems.GotoHome(this); break;
                    }
                case "in":
                    {
                        
                        if (!grdDanhMuc.IsPrintingAvailable)
                        {
                            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                            return;
                        }
                        InDuLieu();
                        break;
                    }
                default:
                    break;
            }
        }

        private void grdDanhMuc_Validated(object sender, EventArgs e)
        {
            Commons.Modules.OXtraGrid.SaveRegisterGrid(grdDanhMuc);
        }
        
        private void grdDanhMuc_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                Xoa("");
                //view.DeleteSelectedRows();
            }
        }
        DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = null;
        private void grvDanhMuc_DoubleClick(object sender, EventArgs e)
        {
            if (hitInfo.HitTest != DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell) return;
            ThemSua(false);
        }
        private void grvDanhMuc_MouseDown(object sender, MouseEventArgs e)
        {
            //GridView view = sender as GridView;
            //Point p = view.GridControl.PointToClient(MousePosition);
            //DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info = view.CalcHitInfo(p);
            //if (info.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.Column)
            //{

            //}

            hitInfo = grvDanhMuc.CalcHitInfo(e.Location);
            //MessageBox.Show("Visual element under the mouse is: " + hitInfo.HitTest.ToString());
        }
        private void grvDanhMuc_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (" + sCount.Trim() + " = {2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void InDuLieu()
        {
            try
            {
                PrintingSystem printingSystem1 = new PrintingSystem();

                //Set default export option
                printingSystem1.ExportDefault = PrintingSystemCommand.ExportXls;
                printingSystem1.SetCommandVisibility(PrintingSystemCommand.ExportXls, CommandVisibility.All);

                printingSystem1.SendDefault = PrintingSystemCommand.SendXls;
                printingSystem1.SetCommandVisibility(PrintingSystemCommand.SendXls, CommandVisibility.All);

                //Create a link to print the Grid control. 
                PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();

                // Specify the link's printable component. 
                printableComponentLink1.Component = grdDanhMuc;

                // Assign the printing system to this link. 
                printableComponentLink1.PrintingSystem = printingSystem1;

                //add image
                Image a = (Image)(new Bitmap(Image.FromFile("d:\\2.jpg"), new Size(50, 50)));
                printableComponentLink1.Images.Add(a);
                printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;


                int icolVis = 0;
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in grvDanhMuc.Columns)
                {
                    if (column.Visible)
                        icolVis ++ ;
                }
                if (icolVis > 5) 
                    printableComponentLink1.Landscape = true;

                printableComponentLink1.Margins.Left = 10;
                printableComponentLink1.Margins.Right = 10;
                printableComponentLink1.Margins.Top = 90;
                printableComponentLink1.Margins.Bottom = 40;

                
                
                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;
                phf.Header.Content.Clear();

                // Add custom information to the link's header. 
                string[] sTitle = lab_Link.Text.Split(new Char[] { '/' });
                phf.Header.Content.AddRange(new string[] { "[Image 0]", sTitle[1].ToString().Trim(), "" });
                phf.Header.Font = new Font(phf.Header.Font.Name, 24, FontStyle.Bold);

                phf.Footer.Content.AddRange(new string[] { "Date: [Date Printed]", "", "Pages: [Page # of Pages #]" });

                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.LineAlignment = BrickAlignment.Far;
                printableComponentLink1.ShowPreview();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void ucListDMuc_Resize(object sender, EventArgs e) => grdDanhMuc.Refresh();
    }
}
