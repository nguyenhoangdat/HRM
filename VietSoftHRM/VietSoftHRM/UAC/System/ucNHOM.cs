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
using VietSoftHRM.Class;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;

namespace VietSoftHRM
{
    public partial class ucNHOM : DevExpress.XtraEditors.XtraUserControl
    {
        private int grid = 1;

        public ucNHOM()
        {
            InitializeComponent();
        }
        private void ucNHOM_Load(object sender, EventArgs e)
        {
            LoadgrdNhom();
            //Commons.Modules.ObjSystems.ThayDoiNN(this);
        }
        //load nhom
        private void LoadgrdNhom()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetAllNhom", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.Columns["TEN_NHOM"].ReadOnly = false;
            dt.Columns["GHI_CHU"].ReadOnly = false;
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdNhom, grvNhom, dt,false, false,true, true, true, this.Name);
            grdNhom.DataSource = dt;
        }
        //load user
        private void LoadUser()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetUserbyGroup",Convert.ToInt64(grvNhom.GetFocusedRowCellValue("ID_NHOM")), Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.Columns["TO"].ReadOnly = false;
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdUser, grvUser, dt, true, true, true, true, true, this.Name);
        }

        private void grvNhom_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadUser();
            //XtraMessageBox.Show("sda");
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "them":
                    {
                        if (grid == 1)
                        {
                            //grvNhom.OptionsBehavior.Editable = true;
                            AddnewRow(grvNhom, true);
                        }
                        else
                        {
                            AddnewRow(grvUser, true);
                        }
                        //LockGrid(grvNhom,false);
                        break;
                    }
                case "xoa":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDeleteDanhMuc"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeXoa"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        //xóa
                        try
                        {

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgDelDangSuDung") + "\n" + ex.Message.ToString());

                        }
                        break;
                    }
                case "sua":
                    {
                        if (grid == 1)
                        {
                            //grvNhom.OptionsBehavior.Editable = true;
                            AddnewRow(grvNhom, false);
                        }
                        else
                        {
                            AddnewRow(grvUser, false);
                        }
                        //LockGrid(grvNhom,false);
                        break;
                    }
                case "luu":
                    {
                        DeleteAddRow(grvNhom);
                        DeleteAddRow(grvUser);
                        break;
                    }
                case "khongluu":
                    {
                        DeleteAddRow(grvNhom);
                        DeleteAddRow(grvUser);
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


        private void AddnewRow(GridView view, bool add)
        {

            view.OptionsBehavior.Editable = true;
            if (add == true)
            {
                view.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            }
        }

        private void DeleteAddRow(GridView view)
        {
            view.OptionsBehavior.Editable = false;
            view.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        }
        private void LockGrid(GridView grid, bool TT)
        {
            for (int i = 0; i <= grid.Columns.Count - 1; i++)
            {
                grid.Columns[i].OptionsColumn.AllowEdit = !TT;
                grid.Columns[i].OptionsColumn.ReadOnly = TT;
            }
        }

        private void grvUser_Click(object sender, EventArgs e)
        {
            grid = 2;
        }

        private void grvNhom_Click(object sender, EventArgs e)
        {
            grid = 1;
        }
    }
}