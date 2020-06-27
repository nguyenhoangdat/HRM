using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Navigation;
using Vs.HRM;
using VS.Report;

namespace VietSoftHRM
{

    public partial class ucListBaoCao : DevExpress.XtraEditors.XtraUserControl
    {
        public Color color;
        public int iLoai;
        public int iIDOut;
        public string slinkcha;
        public string sLoad="";
        public ucListBaoCao(TileBar tileBar)
        {
            InitializeComponent();
        }
        //load tất danh mục từ menu
        private void LoadDSBaoCao()
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
                //element.Click += Element_Click;
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
                        elementchill.Click += Elementchill_Click;
                        element.Elements.Add(elementchill);
                    }
                }
                else
                {
                    element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                }

            }
        }

        //sự kiện click cha
        //private void Element_Click(object sender, EventArgs e)
        //{

        //    var button = sender as AccordionControlElement;
        //    if (sLoad == button.Name) return;
        //    Commons.Modules.ObjSystems.ShowWaitForm(this);
        //    sLoad = button.Name;
        //    lab_Link.Text = slinkcha + "/" + button.Text;
        //    switch (button.Name)
        //    {
        //        case "mnuBCDonVi":
        //            {
        //                if (!panel2.Controls.Contains(ucKeHoachNghiPhep.Instance))
        //                {
        //                    panel2.Controls.Clear();
        //                    panel2.Controls.Add(ucKeHoachNghiPhep.Instance);
        //                    ucKeHoachNghiPhep.Instance.Dock = DockStyle.Fill;
        //                    ucKeHoachNghiPhep.Instance.BringToFront();
        //                }
        //                break;
        //            }
        //        case "mnuBCXiNghiep":
        //            {
        //                if (!panel2.Controls.Contains(ucDaoTao.Instance))
        //                {
        //                    panel2.Controls.Clear();
        //                    panel2.Controls.Add(ucDaoTao.Instance);
        //                    ucDaoTao.Instance.Dock = DockStyle.Fill;
        //                    ucDaoTao.Instance.BringToFront();
        //                }
        //                break;
        //            }
        //        case "mnuBCTo":
        //            {
        //                ucQuyetDinhThoiViec thoiviec = new ucQuyetDinhThoiViec();
        //                panel2.Controls.Clear();
        //                panel2.Controls.Add(thoiviec);
        //                thoiviec.Dock = DockStyle.Fill;
        //                break;
        //            }
        //        default:
        //            break;
        //    }
        //    Commons.Modules.ObjSystems.HideWaitForm();

        //}
        //sự kiện click con
        private void Elementchill_Click(object sender, EventArgs e)
        {
            var button = sender as AccordionControlElement;
            if (sLoad == button.Name) return;
            Commons.Modules.ObjSystems.ShowWaitForm(this);
            sLoad = button.Name;
            lab_Link.Text = slinkcha + "/" + button.Text;
            switch (button.Name)
            {
                case "mnuBCDonVi":
                    {
                        frmViewReport frm = new frmViewReport();
                        frm.rpt = new rptDSDonVi();
                        DataTable dt = new DataTable();
                        dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "rptDSDonVi", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
                        dt.TableName = "DATA";
                        frm.AddDataSource(dt);
                        //frm.AddDataSource(dt);

                        frm.ShowDialog();
                        break;
                    }
                case "mnuBCXiNghiep":
                    {
                        //if (!panel2.Controls.Contains(ucDaoTao.Instance))
                        //{
                        //    panel2.Controls.Clear();
                        //    panel2.Controls.Add(ucDaoTao.Instance);
                        //    ucDaoTao.Instance.Dock = DockStyle.Fill;
                        //    ucDaoTao.Instance.BringToFront();
                        //}
                        //break;
                        ucDaoTao daotao = new ucDaoTao();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(daotao);
                        daotao.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuBCTo":
                    {
                        ucQuyetDinhThoiViec thoiviec = new ucQuyetDinhThoiViec();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(thoiviec);
                        thoiviec.Dock = DockStyle.Fill;
                        break;
                    }
                default:
                    break;
            }
            Commons.Modules.ObjSystems.HideWaitForm();
        }
        private void ucListBaoCao_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;
            LoadDSBaoCao();
            try
            {
                accorMenuleft.SelectElement(accorMenuleft.Elements[0].Elements[0]);
                //Element_Click(accorMenuleft.Elements[0].Elements[0], null);
            }
            catch
            {
            }
        }
    }
}
