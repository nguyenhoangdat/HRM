using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commons
{
    public class Modules
    {
        // DevExpress.LookAndFeel.UserLookAndFeel defaultLF = new DevExpress.LookAndFeel.UserLookAndFeel(this);
        private static DevExpress.LookAndFeel.UserLookAndFeel _defaultLF;
        public static DevExpress.LookAndFeel.UserLookAndFeel defaultLF
        {
            get
            {
                return _defaultLF;
            }
            set
            {
                _defaultLF = value;
            }
        }

        private static string _ModuleName;
        private static string myHost = System.Net.Dns.GetHostName();

        public static List<string> lstControlName
        {
            get
            {
                return _lstControlName;
            }
            set
            {
                _lstControlName = value;
            }
        }

        // Private Shared _lstControlName As New List(Of String)(New String() {"LookUpEdit", "Label", "RadioButton", "CheckBox", "GroupBox", "TabPage", "LabelControl", "CheckButton", "CheckEdit", "XtraTabPage", "GroupControl", "Button", "SimpleButton", "RadioGroup", "CheckedListBoxControl", "XtraTabControl", "GridControl", "DataGridView", "DataGridViewNew", "DataGridViewEditor", "NavBarControl", "navBarControl", "TextEdit", "TextBox", "ComboBox", "ButtonEdit", "MemoEdit"}) '"DateEdit",

        private static List<string> _lstControlName = new List<string>(new string[] { "LookUpEdit", "Label", "RadioButton", "CheckBox", "GroupBox", "TabPage", "LabelControl", "CheckButton", "CheckEdit", "XtraTabPage", "GroupControl", "Button", "SimpleButton", "RadioGroup", "CheckedListBoxControl", "XtraTabControl", "GridControl", "DataGridView", "DataGridViewNew", "DataGridViewEditor", "NavBarControl", "navBarControl", "BarManager", "TextEdit" });
        private static string _sPS;
        public static string sPS
        {
            get
            {
                return _sPS;
            }
            set
            {
                _sPS = value;
            }
        }

        public static string ModuleName
        {
            get
            {
                return _ModuleName;
            }
            set
            {
                _ModuleName = value;
            }
        }

        private static int _Licences;
        public static int Licences
        {
            get
            {
                return _Licences;
            }
            set
            {
                _Licences = value;
            }
        }
        // Private Shared _Licences As Integer = 5
        public static int _LicensePro;
        public static int _LicenseProduction;
        public static int _LicenseWarehouse;

        public static bool _LicDemo;
        public static bool LicDemo
        {
            get
            {
                return _LicDemo;
            }
            set
            {
                _LicDemo = value;
            }
        }

        public static int LicenseProduction
        {
            get
            {
                return _LicenseProduction;
            }
            set
            {
                _LicenseProduction = value;
            }
        }
        public static int LicenseWarehouse
        {
            get
            {
                return _LicenseWarehouse;
            }
            set
            {
                _LicenseWarehouse = value;
            }
        }
        public static int LicensePro
        {
            get
            {
                return _LicensePro;
            }
            set
            {
                _LicensePro = value;
            }
        }


        public static int _LicID;
        public static int LicID
        {
            get
            {
                return _LicID;
            }
            set
            {
                _LicID = value;
            }
        }


        public static DateTime _DemoDate = Convert.ToDateTime("12/12/2015");
        public static DateTime DemoDate
        {
            get
            {
                return _DemoDate;
            }
            set
            {
                _DemoDate = value;
            }
        }
        private static string _UserName = string.Empty;
        public static string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        private static int _TypeLanguage;
        public static int TypeLanguage
        {
            get
            {
                return _TypeLanguage;
            }
            set
            {
                _TypeLanguage = value;
            }
        }

        //private static MExcel _MExcel = new MExcel();
        //public static MExcel MExcel
        //{
        //    get
        //    {
        //        return _MExcel;
        //    }
        //    set
        //    {
        //        _MExcel = value;
        //    }
        //}

        //private static MMail _MMail = new MMail();
        //public static MMail MMail
        //{
        //    get
        //    {
        //        return _MMail;
        //    }
        //    set
        //    {
        //        _MMail = value;
        //    }
        //}

        private static OSystems _OSystems = new OSystems();
        public static OSystems ObjSystems
        {
            get
            {
                return _OSystems;
            }
            set
            {
                _OSystems = value;
            }
        }

        private static OLanguages _OLanguages = new OLanguages();
        public static OLanguages ObjLanguages
        {
            get
            {
                return _OLanguages;
            }
            set
            {
                _OLanguages = value;
            }
        }

        //private static OGroups _OGroups = new OGroups();
        //public static OGroups ObjGroups
        //{
        //    get
        //    {
        //        return _OGroups;
        //    }
        //    set
        //    {
        //        _OGroups = value;
        //    }
        //}

        private static string _PermisString;
        public static string PermisString
        {
            get
            {
                return _PermisString;
            }
            set
            {
                _PermisString = value;
            }
        }

        private static DataGridViewCellStyle _DataGridViewCellStyle1 = new DataGridViewCellStyle();
        public static DataGridViewCellStyle DataGridViewCellStyle1
        {
            get
            {
                return _DataGridViewCellStyle1;
            }
            set
            {
                _DataGridViewCellStyle1 = value;
            }
        }

        private static DataGridViewCellStyle _DataGridViewCellStyle2 = new DataGridViewCellStyle();
        public static DataGridViewCellStyle DataGridViewCellStyle2
        {
            get
            {
                return _DataGridViewCellStyle2;
            }
            set
            {
                _DataGridViewCellStyle2 = value;
            }
        }

        private static string _SqlString;
        public static string SQLString
        {
            get
            {
                return _SqlString;
            }
            set
            {
                _SqlString = value;
            }
        }

        private static Hashtable _HasTableVT = new Hashtable();
        public static Hashtable HasTableVT
        {
            get
            {
                return _HasTableVT;
            }
            set
            {
                _HasTableVT = value;
            }
        }

        private static string _sMailFrom;
        public static string sMailFrom
        {
            get
            {
                return _sMailFrom;
            }
            set
            {
                _sMailFrom = value;
            }
        }

        private static string _sMailFromPass;
        public static string sMailFromPass
        {
            get
            {
                return _sMailFromPass;
            }
            set
            {
                _sMailFromPass = value;
            }
        }

        private static string _sMailFromSmtp;
        public static string sMailFromSmtp
        {
            get
            {
                return _sMailFromSmtp;
            }
            set
            {
                _sMailFromSmtp = value;
            }
        }

        private static string _sMailFromPort;
        public static string sMailFromPort
        {
            get
            {
                return _sMailFromPort;
            }
            set
            {
                _sMailFromPort = value;
            }
        }

        private static bool _GoiMail = false;
        public static bool GoiMail
        {
            get
            {
                return _GoiMail;
            }
            set
            {
                _GoiMail = value;
            }
        }

        private static int _iLoaiGoiMail;
        public static int iLoaiGoiMail
        {
            get
            {
                return _iLoaiGoiMail;
            }
            set
            {
                _iLoaiGoiMail = value;
            }
        }

        private static string _sDDanMail;
        public static string sDDanMail
        {
            get
            {
                return _sDDanMail;
            }
            set
            {
                _sDDanMail = value;
            }
        }

        // Xac dinh thong tin cong ty
        private static string _sPrivate;
        public static string sPrivate
        {
            get
            {
                return _sPrivate.ToUpper();
            }
            set
            {
                _sPrivate = value.ToUpper();
            }
        }

        // Dung de xac dinh in report cung = 1 hay excel = 0 = 0
        private static int _iReport;
        public static int iReport
        {
            get
            {
                return _iReport;
            }
            set
            {
                _iReport = value;
            }
        }

        // Dung de dinh nghia set so phieu = ma so.     = 0 Binh Thuong, = 1 so phieu = ma so, = 2 so phieu = ma so lock luon so phieu  = 0
        private static int _iDefault;
        public static int iDefault
        {
            get
            {
                return _iDefault;
            }
            set
            {
                _iDefault = value;
            }
        }


        private static int _iSoLeSL;
        public static int iSoLeSL
        {
            get
            {
                return _iSoLeSL;
            }
            set
            {
                _iSoLeSL = value;
            }
        }

        private static int _iSoLeDG;
        public static int iSoLeDG
        {
            get
            {
                return _iSoLeDG;
            }
            set
            {
                _iSoLeDG = value;
            }
        }


        private static int _iSoLeTT;
        public static int iSoLeTT
        {
            get
            {
                return _iSoLeTT;
            }
            set
            {
                _iSoLeTT = value;
            }
        }

        private static string _sSoLeSL;
        public static string sSoLeSL
        {
            get
            {
                return _sSoLeSL;
            }
            set
            {
                _sSoLeSL = value;
            }
        }

        private static string _sSoLeDG;
        public static string sSoLeDG
        {
            get
            {
                return _sSoLeDG;
            }
            set
            {
                _sSoLeDG = value;
            }
        }

        private static string _sSoLeTT;
        public static string sSoLeTT
        {
            get
            {
                return _sSoLeTT;
            }
            set
            {
                _sSoLeTT = value;
            }
        }

        private static int _iTRFData;
        public static int iTRFData
        {
            get
            {
                return _iTRFData;
            }
            set
            {
                _iTRFData = value;
            }
        }

        // 0 Nhu hien tai, Nhap tu gio va den gio
        // 1 Nhap So Gio trong phieu bao tri
        private static int _iPBTTheoGio;
        public static int iPBTTheoGio
        {
            get
            {
                return _iPBTTheoGio;
            }
            set
            {
                _iPBTTheoGio = value;
            }
        }

        private static string _sDonViMacDinh;
        public static string sDonViMacDinh
        {
            get
            {
                return _sDonViMacDinh;
            }
            set
            {
                _sDonViMacDinh = value;
            }
        }

        // 0 Nhu hien tai mac dinh la WO trong ma so phieu bao tri
        // 1 Theo dinh nghia trong Don vi
        private static int _iMaPBT;
        public static int iMaPBT
        {
            get
            {
                return _iMaPBT;
            }
            set
            {
                _iMaPBT = value;
            }
        }


        private static int _iMaKhoMD;
        public static int iMaKhoMD
        {
            get
            {
                return _iMaKhoMD;
            }
            set
            {
                _iMaKhoMD = value;
            }
        }

        private static string _sTenKhoMD;
        public static string sTenKhoMD
        {
            get
            {
                return _sTenKhoMD;
            }
            set
            {
                _sTenKhoMD = value;
            }
        }


        private static string _sTienTeMD;
        public static string sTienTeMD
        {
            get
            {
                return _sTienTeMD;
            }
            set
            {
                _sTienTeMD = value;
            }
        }

        private static string _sTenNhanVienMD;
        public static string sTenNhanVienMD
        {
            get
            {
                return _sTenNhanVienMD;
            }
            set
            {
                _sTenNhanVienMD = value;
            }
        }

        private static string _sMaNhanVienMD;
        public static string sMaNhanVienMD
        {
            get
            {
                return _sMaNhanVienMD;
            }
            set
            {
                _sMaNhanVienMD = value;
            }
        }

        private static string _sInfoClient;
        public static string sInfoClient
        {
            get
            {
                return _sInfoClient;
            }
            set
            {
                _sInfoClient = value;
            }
        }

        private static string _sInfoSer;
        public static string sInfoSer
        {
            get
            {
                return _sInfoSer;
            }
            set
            {
                _sInfoSer = value;
            }
        }

        private static bool _bSSL = false;
        public static bool bSSL
        {
            get
            {
                return _bSSL;
            }
            set
            {
                _bSSL = value;
            }
        }


        private static string _sMailUser;
        public static string sMailUser
        {
            get
            {
                return _sMailUser;
            }
            set
            {
                _sMailUser = value;
            }
        }

        private static bool _bCNDXDuyet;
        public static bool bCNDXDuyet
        {
            get
            {
                return _bCNDXDuyet;
            }
            set
            {
                _bCNDXDuyet = value;
            }
        }

        private static bool _bDoiFontReport;
        public static bool bDoiFontReport
        {
            get
            {
                return _bDoiFontReport;
            }
            set
            {
                _bDoiFontReport = value;
            }
        }

        private static string _sFontReport;
        public static string sFontReport
        {
            get
            {
                return _sFontReport;
            }
            set
            {
                _sFontReport = value;
            }
        }

        private static string _sFontForm;
        public static string sFontForm
        {
            get
            {
                return _sFontForm;
            }
            set
            {
                _sFontForm = value;
            }
        }
        private static int _iFontsize;
        public static int iFontsize
        {
            get
            {
                return _iFontsize;
            }
            set
            {
                _iFontsize = value;
            }
        }

        private static int _iBBCPMail;
        public static int iBBCPMail
        {
            get
            {
                return _iBBCPMail;
            }
            set
            {
                _iBBCPMail = value;
            }
        }

        private static int _iMacDinhCVPT;
        public static int iMacDinhCVPT
        {
            get
            {
                return _iMacDinhCVPT;
            }
            set
            {
                _iMacDinhCVPT = value;
            }
        }

        // 0 Trong PBT cong viec nhan su nhap theo gio
        // 1 Trong PBT cong viec nhan su nhap theo Phut
        private static int _iPhutGioPBT;
        public static int iPhutGioPBT
        {
            get
            {
                return _iPhutGioPBT;
            }
            set
            {
                _iPhutGioPBT = value;
            }
        }

        public static string GetNNgu(string sForm, string sKeyWord)
        {
            SqlDataReader dtReader;
            string tam;
            dtReader = SqlHelper.ExecuteReader(IConnections.CNStr, "GetLanguage", Modules.ModuleName, sForm, sKeyWord);
            if (dtReader.HasRows)
            {
                while (dtReader.Read())
                {
                    if (Modules.TypeLanguage == 0)
                        tam = dtReader["VIETNAM"].ToString();
                    else if (Modules.TypeLanguage == 1)
                        tam = dtReader["ENGLISH"].ToString();
                    else
                        tam = dtReader["CHINESE"].ToString();
                    dtReader.Close();
                    return tam;
                }
            }
            else
            {
                dtReader.Close();
                string sTV = "@" + sKeyWord + "@";
                string sTA = "@" + sKeyWord + "@";
                string sTH = "@" + sKeyWord + "@";
                string sSql = " SELECT TOP 1 ISNULL(VIETNAM,'') AS VIETNAM, ISNULL(ENGLISH,'') AS ENGLISH,ISNULL(CHINESE,'') AS CHINESE " + " FROM [LANGUAGES] WHERE KEYWORD = N'" + sKeyWord + "'   AND SUBSTRING(VIETNAM,1,1) <> '@' " + " GROUP BY VIETNAM , ENGLISH, CHINESE ORDER BY COUNT(KEYWORD) DESC ";
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                if (dtTmp.Rows.Count > 0)
                {
                    try
                    {
                        if (dtTmp.Rows[0]["VIETNAM"].ToString() != "")
                            sTV = dtTmp.Rows[0]["VIETNAM"].ToString();
                    }
                    catch (Exception ex)
                    {
                        sTV = "@" + sKeyWord + "@";
                    }
                    try
                    {
                        if (dtTmp.Rows[0]["ENGLISH"].ToString() != "")
                            sTA = dtTmp.Rows[0]["ENGLISH"].ToString();
                    }
                    catch (Exception ex)
                    {
                        sTA = "@" + sKeyWord + "@";
                    }
                    try
                    {
                        if (dtTmp.Rows[0]["CHINESE"].ToString() != "")
                            sTH = dtTmp.Rows[0]["CHINESE"].ToString();
                    }
                    catch (Exception ex)
                    {
                        sTH = "@" + sKeyWord + "@";
                    }
                }
                int result = SqlHelper.ExecuteNonQuery(IConnections.CNStr, CommandType.Text, " INSERT INTO [LANGUAGES]([MS_MODULE],[FORM],[KEYWORD],[VIETNAM],[ENGLISH],[CHINESE]," + " [FORM_HAY_REPORT],[VIETNAM_OR],[ENGLISH_OR],[CHINESE_OR]) " + " VALUES(N'" + Modules.ModuleName + "',N'" + sForm + "',N'" + sKeyWord + "',N'" + sTV + "',N'" + sTA + "',N'" + sTH + "'," + " 0,N'" + sTV + "',N'" + sTA + "',N'" + sTH + "')");
                if (Commons.Modules.TypeLanguage == 0)
                    tam = sTV;
                else if (Commons.Modules.TypeLanguage == 1)
                    tam = sTA;
                else
                    tam = sTH;
                dtReader.Close();
                return tam;
            }
            if (dtReader.IsClosed)
                dtReader.Close();
            return "?" + sKeyWord + "?";
        }
    }
}
