using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WordFindKeyAndReplace
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void bu_KeyReplacer_Click(object sender, RibbonControlEventArgs e)
        {
            WordFindKeyAndReplacePopForm Worder = new WordFindKeyAndReplacePopForm();
            Worder.ShowDialog();
        }
    }
}
