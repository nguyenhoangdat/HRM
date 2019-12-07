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
using DevExpress.Skins;
using DevExpress.XtraBars.Navigation;
using System.Threading;

namespace Vs.HRM
{
    public partial class ucCTQLNS : DevExpress.XtraEditors.XtraUserControl
    {
        List<LabelControl> List;
        static Int64 idcn = 0;
        public ucCTQLNS(Int64 iIdCN)
        {
            InitializeComponent();
            //Commons.Modules.ObjSystems.ThayDoiNN(this,Root,null);

            idcn = iIdCN;
        }
        private void ucCTQLNS_Load(object sender, EventArgs e)
        {
            XuLyTab();
            Lb_Click(labLyLich, null);

            //labLyLich.Appearance.ForeColor = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            //LoaduacCongNhan(labLyLich.Name);
        }
        private void XuLyTab()
        {
            List = new List<LabelControl>() { labLyLich, labCongTac, labHopDong, labTienLuong, labTienLuong, labKhanThuong, labTaiNan, labDanhGia, labBangCap };
            foreach (LabelControl lb in List)
            {
                lb.Click += Lb_Click;
            }
        }
        private void Lb_Click(object sender, EventArgs e)
        {
            try
            {
                var lable = sender as LabelControl;
                foreach (LabelControl lc in List)
                {
                    if (lable.Name == lc.Name)
                    {
                        lc.Appearance.ForeColor = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                        LoaduacCongNhan(lc.Name);
                    }
                    else
                    {
                        lc.Appearance.ForeColor = Color.Empty;
                        lc.Appearance.Font = this.Font;
                    }
                }
            }
            catch
            {
            }
        }
        private void LoaduacCongNhan(string tenlable)
        {
            switch (tenlable)
            {
                case "labLyLich":
                    {
                        //loaduac Chi tiết công nhân
                        //ucLyLichCN ll = new ucLyLichCN(idcn);
                        ucLyLich ll = new ucLyLich(idcn);
                        LoadUac(ll);
                        break;
                    }
                case "labCongTac":
                    {
                        ucQTCongTac ct = new ucQTCongTac(idcn);
                        LoadUac(ct);
                        break;
                    }
                case "labHopDong":
                    {
                        //ucLyLich ll = new ucLyLich(idcn);
                        //LoadUac(ll);
                        break;
                    }
                case "labTienLuong":
                    {
                        //ucLyLich ll = new ucLyLich(idcn);
                        //LoadUac(ll);
                        break;
                    }
                case "labKhanThuong":
                    {
                        //ucLyLich ll = new ucLyLich(idcn);
                        //LoadUac(ll);
                        break;
                    }
                case "labTaiNan":
                    {
                        ucTaiNanLD tn = new ucTaiNanLD(idcn);
                        LoadUac(tn);
                        break;
                    }
                case "labDanhGia":
                    {
                        ucDanhGia dg = new ucDanhGia(idcn);
                        LoadUac(dg);
                        break;
                    }
                case "labBangCap":
                    {
                        ucBangCap ll = new ucBangCap(idcn);
                        LoadUac(ll);
                        break;
                    }
                default:
                    break;
            }
        }
        private void LoadUac(XtraUserControl uac)
        {
            uac.Dock = DockStyle.Fill;
            NavigationPage page = new NavigationPage();
            page.Controls.Add(uac);
            navigationFrame1.Pages.Add(page);
            navigationFrame1.SelectedPage = page;
        }
    }
}
