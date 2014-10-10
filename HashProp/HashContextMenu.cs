using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashProp
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class HashContextMenu : SharpContextMenu
    {
        protected override bool CanShowMenu()
        {
            return (SelectedItemPaths.Count() == 1);
        }

        protected override ContextMenuStrip CreateMenu()
        {
            var menu = new ContextMenuStrip();
            var menuItem = new ToolStripMenuItem("Hash...");
            menuItem.Click += ShowHashWindow;
            menu.Items.Add(menuItem);
            return menu;
        }

        void ShowHashWindow(object sender, EventArgs e)
        {
            var win = new HashWindow(SelectedItemPaths.First());
            win.Show();
        }
    }
}
