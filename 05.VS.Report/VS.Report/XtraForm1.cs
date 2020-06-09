using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;

namespace VS.Report
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmViewReport frm = new frmViewReport();
            frm.rpt = new rptTienThuongXepLoai();
            string sCo = @"Server=.;database=VS_HRM;uid=sa;pwd=123;Connect Timeout=9999;";
            //string sCo = @"Server=.;database=VS_HRM;uid=sa;pwd=123;Connect Timeout=9999;";
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(sCo, "spTienThuongXepLoai"));
            dt.TableName = "AAARE";
            frm.AddDataSource(dt);



            dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(sCo, CommandType.Text, @"SELECT 
                    'tdBaoCao' AS tdBaoCao,'CHXHCNVN' AS CHXHCNVN,'DLTDHP' AS DLTDHP,'STT' AS STT,'MS_CN' AS MS_CN,'HO_TEN' AS HO_TEN,'MucThuong' AS MucThuong,'XepLoaiThuong' AS 	XepLoaiThuong,
                    'HeSoThuong' AS 	HeSoThuong,'SoTienThuong' AS  SoTienThuong,'KyNhan' AS  KyNhan,'TongCong' AS  TongCong,'BangChu' AS  BangChu,'LapBang' AS  LapBang,
                    'TPTCHC' AS  TPTCHC,'KTTruong' AS  KTTruong,'GiamDoc' AS  GiamDoc,'NgayThangNam' NgayThangNam
            "));
            dt.TableName = "NNGU";
            frm.AddDataSource(dt);
            frm.rpt = new rptTienThuongXepLoai();
            frm.Show();


        }



        private void LoadNN()
        { }
    }

}





////////////////dt.Load(SqlHelper.ExecuteReader(sCo, CommandType.Text, " SELECT * FROM dbo.CAU_TRUC_THIET_BI"));
////////////////            dt.TableName = "CAU_TRUC_THIET_BI";
////////////////            frm.AddDataSource(dt);

////////////////            dt = new DataTable();
////////////////dt.Load(SqlHelper.ExecuteReader(sCo, CommandType.Text, "SELECT * FROM dbo.MAY"));
////////////////            dt.TableName = "MAY";
////////////////            frm.AddDataSource(dt);


//////////////////            frm.dsReport.Relations.Add("MAYCAU_TRUC_THIET_BI",
//////////////////frm.dsReport.Tables["MAY"].Columns["MS_MAY"],
//////////////////frm.dsReport.Tables["CAU_TRUC_THIET_BI"].Columns["MS_MAY"]);