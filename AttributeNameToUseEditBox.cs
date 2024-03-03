using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class AttributeNameToUseEditBox : ArcGIS.Desktop.Framework.Contracts.EditBox
    {
        public AttributeNameToUseEditBox()
        {
            Module1.Current.AttributeNameToUseEditBox1 = this;
            Text = "";
        }
    }
}
