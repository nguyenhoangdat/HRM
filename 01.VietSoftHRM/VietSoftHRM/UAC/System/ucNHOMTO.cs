﻿using System;
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
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
namespace VietSoftHRM
{
    public partial class ucNHOMTO : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNHOMTO()
        {
            InitializeComponent();
        }
        private void ucNHOMTO_Load(object sender, EventArgs e)
        {
            LoadTreeMenu(false);
            enableButon(true);
            Commons.Modules.ObjSystems.ThayDoiNN(this, windowButton);
        }
        public void setcheck(TreeListNode node)
        {
            foreach (TreeListNode item in node.Nodes)
            {
                if (Convert.ToBoolean(item.GetValue("CHON")) == true)
                    treeListNhomTo.SetNodeCheckState(item, CheckState.Checked);
                setcheck(item); // recursive call
            }
        }

        private void EnableControl(bool enable)
        {
            treeListNhomTo.OptionsBehavior.Editable = enable;
            treeListNhomTo.OptionsView.ShowCheckBoxes = enable;
        }

        private void LoadTreeMenu(bool them)
        {
            try
            {
                DataTable dtTmp = new DataTable();
                dtTmp.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetDuLieuPQ", Commons.Modules.sId, them, Commons.Modules.TypeLanguage));
                dtTmp.Columns["TEN_TO"].ReadOnly = true;
                dtTmp.Columns["CHON"].ReadOnly = false;
                treeListNhomTo.DataSource = null;
                treeListNhomTo.BeginUpdate();
                treeListNhomTo.DataSource = dtTmp;
                treeListNhomTo.KeyFieldName = "ID_TO";
                treeListNhomTo.ParentFieldName = "MS_CHA";
                treeListNhomTo.CheckBoxFieldName = "CHON";
                treeListNhomTo.Columns["CHON"].Visible = false;
                EnableControl(false);
                treeListNhomTo.EndUpdate();
                treeListNhomTo.ExpandAll();
                treeListNhomTo.Columns["TEN_TO"].Caption = Commons.Modules.ObjLanguages.GetLanguage(this.Name, "TEN_TO");
                TreeListColumn colum = new TreeListColumn();
                colum = treeListNhomTo.Columns["CHON"];
                foreach (TreeListNode item in treeListNhomTo.Nodes)
                {
                    setcheck(item);
                }



            }
            catch
            {
            }
        }

        private void windowButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        LoadTreeMenu(true);
                        enableButon(false);
                        EnableControl(true);
                        break;
                    }
                case "luu":
                    {
                        enableButon(true);
                        //tạo bảng tạm từ lưới
                        try
                        {
                            treeListNhomTo.PostEditor();
                            treeListNhomTo.RefreshDataSource();
                            Commons.Modules.ObjSystems.MCreateTableToDatatable(Commons.IConnections.CNStr, "tabdata" + Commons.Modules.UserName, (DataTable)treeListNhomTo.DataSource, "");
                            string sSql = "DELETE FROM dbo.NHOM_TO WHERE ID_NHOM = "+Convert.ToInt32(Commons.Modules.sId) +" INSERT INTO dbo.NHOM_TO( ID_NHOM, ID_TO ) SELECT "+ Commons.Modules.sId + ", ID FROM tabdata"+Commons.Modules.UserName+" WHERE CHON = 1 AND ID_TO LIKE 'TO%'";
                            SqlHelper.ExecuteNonQuery(Commons.IConnections.CNStr, CommandType.Text, sSql);
                            Commons.Modules.ObjSystems.XoaTable("tabdata" + Commons.Modules.UserName);
                        }
                        catch
                        {
                            XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThemKhongThanhCong"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.YesNo);
                        }
                        EnableControl(false);
                        LoadTreeMenu(false);
                        break;
                    }
                case "khongluu":
                    {
                        LoadTreeMenu(false);
                        enableButon(true);
                        EnableControl(false);
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

        private void enableButon(bool visible)
        {
            windowButton.Buttons[0].Properties.Visible = visible;
            windowButton.Buttons[4].Properties.Visible = visible;
            windowButton.Buttons[1].Properties.Visible = visible;
            windowButton.Buttons[2].Properties.Visible = !visible;
            windowButton.Buttons[3].Properties.Visible = !visible;
        }

        //private void treeListNhomTo_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        //{
        //    if (e.Node != null && e.ToString.KeyFieldName=)
        //    {
        //        if (e.Node.GetValue("ID_TO").ToString() == "TO10")
        //        {
        //            e.Appearance.BackColor = Color.LightPink;
        //            e.Appearance.ForeColor = Color.DarkGreen;
        //        }
        //        else
        //        {
        //        }
        //    }

       
            
        //}
    }
}
