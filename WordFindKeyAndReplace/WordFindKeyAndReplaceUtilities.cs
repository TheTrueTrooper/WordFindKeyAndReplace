#region WritersSigniture
//Writer: Angelo Sanches (BitSan)(Git:TheTrueTrooper)
//Date Writen: Dec 20,2018
//Project Goal: Make a templater for basic text doc editing 
//File Goal: To create an internal helper class for use with building controls and tracking them in the form's dictionary
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
using System.Drawing;
using System.Windows.Forms;


namespace WordFindKeyAndReplace
{
    internal class KeyValueControls
    {
        const int startOffsetY = 16;
        const int startOffsetX = 10;
        const int LineOffsetY = 30;
        const int ControlBoxStartAndMin = 776;


        internal static int LineNumber = 0;
        internal static int XNext = 250;

        public Label Label = new Label();
        public TextBox TextBox = new TextBox();

        public string ReplaceValue
        {
            get
            {
                return TextBox.Text;
            }
        }

        internal KeyValueControls(string Name, string DefaultVal)
        {
            Label.Visible = true;
            Label.Name = "La_" + Name;
            Label.Text = Name;
            Label.Location = new Point(startOffsetX, startOffsetY + LineNumber * LineOffsetY);
            Label.Size = new Size(XNext, Label.Height);
            TextBox.Visible = true;
            TextBox.Name = "La_" + Name;
            TextBox.Text = DefaultVal != null ? DefaultVal : "";
            TextBox.Location = new Point(startOffsetX + XNext, startOffsetY + LineNumber * LineOffsetY);
            TextBox.MinimumSize = new Size(ControlBoxStartAndMin - TextBox.Location.X - startOffsetX, TextBox.Size.Height);
            TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            LineNumber++;
        }
    }
}
