using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Modules
    {
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

    }
}
