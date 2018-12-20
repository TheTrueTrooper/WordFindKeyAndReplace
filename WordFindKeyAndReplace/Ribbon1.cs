#region WritersSigniture
//Writer: Angelo Sanches (BitSan)(Git:TheTrueTrooper)
//Date Writen: Dec 20,2018
//Project Goal: Make a templater for basic text doc editing 
//File Goal: To create a entry Point for the form and extend the fuc of Word in a neat way.
//Link: https://github.com/TheTrueTrooper/AngelASPExtentions
//Sources: 
//  {
//  Name: vsto & word
//  Writer/Publisher: Microsoft
//  Link: https://docs.microsoft.com/en-us/visualstudio/vsto/office-and-sharepoint-development-in-visual-studio?view=vs-2017,
//  Name: Windows Forms
//  Writer/Publisher: Microsoft
//  Link: https://docs.microsoft.com/en-us/visualstudio/ide/step-1-create-a-windows-forms-application-project?view=vs-2017
//  }
#endregion
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
            Worder.Show();
        }
    }
}
