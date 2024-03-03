using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class ModValueToSetEditBox : ArcGIS.Desktop.Framework.Contracts.EditBox
    {
        public ModValueToSetEditBox()
        {
            Module1.Current.ModValueToSetEditBox1 = this;
            Text = "";
        }
    }
}

