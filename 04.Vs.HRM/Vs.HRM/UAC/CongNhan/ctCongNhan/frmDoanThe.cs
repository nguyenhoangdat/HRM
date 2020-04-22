using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Docking2010;
namespace Vs.HRM
{
    public partial class frmDoanThe : DevExpress.XtraEditors.XtraForm
    {
        public frmDoanThe()
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, layoutControlGroup1, windowsUIButton);

        }

        private void frmDoanThe_Load(object sender, EventArgs e)
        {
            enableButon(true);
            Bindingdata(false);
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "sua":
                    {
                        Bindingdata(true);
                        enableButon(false);
                        break;
                    }
                case "xoa":
                    {
                        DeleteData();
                        break;
                    }
                case "luu":
                    {

                        SaveData();
                        enableButon(true);
                        Bindingdata(false);
                        break;
                    }
                case "khongluu":
                    {
                        enableButon(true);
                        Bindingdata(false);
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }
        #region hàm load form
        //hàm load gridview
        //hàm bingding dữ liệu
        private void Bindingdata(bool enable)
        {
            //lay datatable thheo ms công nhân
            try
            {

                DataTable dt = new DataTable();
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, "SELECT * FROM dbo.DOAN_THE WHERE ID_CN = " + Commons.Modules.iCongNhan + ""));
                THE_DANGTextEdit.EditValue = dt.Rows[0]["THE_DANG"];
                NGAY_KN_DANGDateEdit.EditValue = dt.Rows[0]["NGAY_KN_DANG"];
                NGAY_VAO_DANGDateEdit.EditValue = dt.Rows[0]["NGAY_VAO_DANG"];
                CHUC_VU_DANGTextEdit.EditValue = dt.Rows[0]["CHUC_VU_DANG"];
                THE_DOANTextEdit.EditValue = dt.Rows[0]["THE_DOAN"];
                NGAY_VAO_DOANDateEdit.EditValue = dt.Rows[0]["NGAY_VAO_DOAN"];
                CHUC_VU_DOANTextEdit.EditValue = dt.Rows[0]["CHUC_VU_DOAN"];
                THE_CONG_DOANTextEdit.EditValue = dt.Rows[0]["THE_CONG_DOAN"];
                NGAY_VAO_CONG_DOANDateEdit.EditValue = dt.Rows[0]["NGAY_VAO_CONG_DOAN"];
                CHUC_VU_CONG_DOANTextEdit.EditValue = dt.Rows[0]["CHUC_VU_CONG_DOAN"];
                gro_QuanNhanDuBi.Expanded = Convert.ToBoolean(dt.Rows[0]["QUAN_NHAN_DU_BI"]);//Da Nhap Ngu
                NGAY_NHAP_NGUDateEdit.EditValue = dt.Rows[0]["NGAY_NHAP_NGU"];
                CVU_QUAN_NGUTextEdit.EditValue = dt.Rows[0]["CVU_QUAN_NGU"];
                NGAY_XUAT_NGUDateEdit.EditValue = dt.Rows[0]["NGAY_XUAT_NGU"];
                gro_DaNhapNgu.Expanded = Convert.ToBoolean(dt.Rows[0]["DA_NHAP_NGU"]);//QUAN_NHAN_DU_BI= dt.Rows[0]["THE_DANG"];
                CHUC_VU_QNDBTextEdit.EditValue = dt.Rows[0]["CHUC_VU_QNDB"];
                DON_VITextEdit.EditValue = dt.Rows[0]["DON_VI"];
                THUONG_BINHCheckEdit.EditValue = dt.Rows[0]["THUONG_BINH"];
                HANG_THUONG_BINHTextEdit.EditValue = dt.Rows[0]["HANG_THUONG_BINH"];
                GIA_DINH_LIET_SICheckEdit.EditValue = dt.Rows[0]["GIA_DINH_LIET_SI"];
                GHI_CHUTextEdit.EditValue = dt.Rows[0]["GHI_CHU"];
                CAP_BACTextEdit.EditValue = dt.Rows[0]["CAP_BAC"];
                NGAY_RA_KHOI_DANGDateEdit.EditValue = dt.Rows[0]["NGAY_RA_KHOI_DANG"];
                NGAY_RA_KHOI_DOANDateEdit.EditValue = dt.Rows[0]["NGAY_RA_KHOI_DOAN"];
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        //hàm tắc mở control
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = !visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = visible;
            //ID_QHLookUpEdit.Properties.ReadOnly = visible;
            gro_DaNhapNgu.Enabled = !visible;
            gro_QuanNhanDuBi.Enabled = !visible;
            gro_GhiChu.Enabled = !visible;
            gro_TheCongDoan.Enabled = !visible;
            gro_TheDang.Enabled = !visible;
            gro_TheDoan.Enabled = !visible;

        }
        #endregion
        #region hàm sử lý data
        //hàm sử lý khi lưu dữ liệu(thêm/sữa)
        private void SaveData()
        {
            try
            {
                //XtraMessageBox.Show(NGAY_VAO_DOANDateEdit.EditValue.ToString());
                SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, "spUpdateDoanhThe",
                    Commons.Modules.iCongNhan,
          THE_DANGTextEdit.EditValue,
          NGAY_KN_DANGDateEdit.EditValue,
          NGAY_VAO_DANGDateEdit.EditValue,
          CHUC_VU_DANGTextEdit.EditValue,
          THE_DOANTextEdit.EditValue,
          NGAY_VAO_DOANDateEdit.EditValue,
          CHUC_VU_DOANTextEdit.EditValue,
          THE_CONG_DOANTextEdit.EditValue,
          NGAY_VAO_CONG_DOANDateEdit.EditValue,
          CHUC_VU_CONG_DOANTextEdit.EditValue,
          gro_DaNhapNgu.Expanded,//Da Nhap Ngu
          NGAY_NHAP_NGUDateEdit.EditValue,
          CVU_QUAN_NGUTextEdit.EditValue,
          NGAY_XUAT_NGUDateEdit.EditValue,
          gro_QuanNhanDuBi.Expanded,//QUAN_NHAN_DU_BI,
          CHUC_VU_QNDBTextEdit.EditValue,
          DON_VITextEdit.EditValue,
          Convert.ToBoolean(THUONG_BINHCheckEdit.EditValue),
          HANG_THUONG_BINHTextEdit.EditValue,
          Convert.ToBoolean(GIA_DINH_LIET_SICheckEdit.EditValue),
          GHI_CHUTextEdit.EditValue,
          CAP_BACTextEdit.EditValue,
          NGAY_RA_KHOI_DANGDateEdit.EditValue,
          NGAY_RA_KHOI_DOANDateEdit.EditValue
                    );
                XtraMessageBox.Show("Cập nhật đoàng thể thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        //hàm xử lý khi xóa dữ liệu
        private void DeleteData()
        {
            if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteGiaDinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
            //xóa
            try
            {
                //SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, "DELETE dbo.GIA_DINH WHERE ID_GD = " + grvGiaDinh.GetFocusedRowCellValue("ID_GD") + "");
                //grvGiaDinh.DeleteSelectedRows();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}