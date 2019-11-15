using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace VietSoftHRM
{
    public partial class ucSystems : DevExpress.XtraEditors.XtraUserControl
    {
        public Color color;
        public int iLoai;
        public int iIDOut;
        public string slinkcha;
        public ucSystems()
        {
            InitializeComponent();
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
                element.Click += Element_Click;
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
        private void Element_Click(object sender, EventArgs e)
        {
            var button = sender as AccordionControlElement;
            lab_Link.Text = slinkcha + "/" + button.Text;
            switch (button.Name)
            {
                case "mnuDoiMatKhau":
                    {
                        frmChangePass changepass = new frmChangePass("-1");
                        changepass.ShowDialog();
                        break;
                    }
                case "mnudangnhap":
                    {
                        this.ParentForm.Hide();
                        frmLogin login = new frmLogin();
                        login.ShowDialog();
                        this.ParentForm.Close();
                        break;
                    }
                case "mnuDSND":
                    {
                        ucListUsers user = new ucListUsers();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(user);
                        user.Dock = DockStyle.Fill;
                        break;
                    }
                default:
                    break;
            }
        }
        private void Elementchill_Click(object sender, EventArgs e)
        {
            var button = sender as AccordionControlElement;
            lab_Link.Text = slinkcha + "/" + button.Text + "/" + SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, CommandType.Text, "SELECT dbo.fuGetTeNhom(" + Convert.ToInt64(Commons.Modules.sId) + "," + Commons.Modules.TypeLanguage + ")");
            switch (button.Name)
            {
                case "mnuNHOM":
                    {
                        ucNHOM nhom = new ucNHOM();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(nhom);
                        nhom.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuMENU":
                    {
                        if (kiemtraNhomdaduocchon()) return;
                        ucMENU menu = new ucMENU();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(menu);
                        menu.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuNguoiDung":
                    {
                        if (kiemtraNhomdaduocchon()) return;
                        ucNGUOIDUNG menu = new ucNGUOIDUNG();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(menu);
                        menu.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuDuLieu":
                    {
                        if (kiemtraNhomdaduocchon()) return;
                        ucNHOMTO nhomto = new ucNHOMTO();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(nhomto);
                        nhomto.Dock = DockStyle.Fill;
                        break;
                    }
                default:
                    break;
            }
        }
        private bool kiemtraNhomdaduocchon()
        {
            bool resulst = false;
            if (Convert.ToInt64(Commons.Modules.sId) < 1)
            {
                XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanPhaiVaoNhomTruoc"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeChuY"), MessageBoxButtons.OK);
                resulst = true;
            }
            return resulst;
        }
        private void ucSystems_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;
            LoadDanhMuc();
            try
            {
                accorMenuleft.SelectElement(accorMenuleft.Elements["mnuNHOM"]);
            }
            catch 
            {
            }
        }

        private void ucSystems_Resize(object sender, EventArgs e) => panel2.Refresh();
    }
}
