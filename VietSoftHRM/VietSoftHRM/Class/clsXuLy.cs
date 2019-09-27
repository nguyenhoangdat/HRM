using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VietSoftHRM.Class
{
    public class AddResetMenu
    {
        DevExpress.XtraGrid.GridControl grd_DonVi = new DevExpress.XtraGrid.GridControl();
        public void CreateMenuNewPBT(DevExpress.XtraGrid.GridControl grd)
        {
            grd_DonVi = grd;
            DevExpress.XtraGrid.Views.Grid.GridView grv = grd.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            grv.ShowGridMenu += grv_ShowGridMenu;

        }
        private void grv_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            if (e.MenuType != DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
                return;
            try
            {
                DevExpress.XtraGrid.Menu.GridViewMenu headerMenu = (DevExpress.XtraGrid.Menu.GridViewMenu)e.Menu;
                DevExpress.Utils.Menu.DXMenuItem menuItem = new DevExpress.Utils.Menu.DXMenuItem("Reset Grid", new EventHandler(MyMenuItem));
                menuItem.BeginGroup = true;
                menuItem.Tag = e.Menu;
                headerMenu.Items.Add(menuItem);
            }
            catch (Exception ex)
            {
            }
        }
        private void MyMenuItem(System.Object sender, System.EventArgs e)
        {
            grd_DonVi.MainView.RestoreLayoutFromXml(Application.StartupPath + "\\XML\\grd" + Commons.Modules.sPS.Replace("spGetList", "") + ".xml");
        }
    }
}
