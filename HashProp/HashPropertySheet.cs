using SharpShell.Attributes;
using SharpShell.SharpPropertySheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HashProp
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class HashPropertySheet : SharpPropertySheet
    {
        protected override bool CanShowSheet()
        {
            return (SelectedItemPaths.Count() == 1);
        }

        protected override IEnumerable<SharpPropertyPage> CreatePages()
        {
            var page = new HashPropertyPage();
            return new[] { page };
        }
    }
}
