using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace MaxwelsToolbox
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void copyImg_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.Copy();
        }

        private void pasteImg_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.Paste(cbCrop.Checked, cbPosition.Checked, cbRotation.Checked, cbSize.Checked, cbHeight.Checked);
        }

        private void resetImg_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.Reset();
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ShowProps();
        }

    }
}
