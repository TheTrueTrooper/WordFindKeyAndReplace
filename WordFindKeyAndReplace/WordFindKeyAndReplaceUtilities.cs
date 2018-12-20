using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WordFindKeyAndReplace
{
    internal class KeyValueControls
    {
        const int startOffsetY = 16;
        const int startOffsetX = 10;
        const int LineOffsetY = 30;


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

        internal KeyValueControls(string Name)
        {
            string DefaultVal = null;
            if (Name.Contains("="))
            {
                DefaultVal = new Regex(@"(=([^=])*\])", RegexOptions.Singleline).Match(Name).Value;
                DefaultVal = DefaultVal.Remove(DefaultVal.Length - 1, 1).Remove(0, 1);
                Name = Name.Remove(Name.IndexOf('='), Name.Length - Name.IndexOf('=') - 1);
            }
            Label.Visible = true;
            Label.Name = "La_" + Name;
            Label.Text = Name;
            Label.Location = new Point(startOffsetX, startOffsetY + LineNumber * LineOffsetY);
            Label.Size = new Size(XNext, Label.Height);
            TextBox.Visible = true;
            TextBox.Name = "La_" + Name;
            TextBox.Text = DefaultVal != null ? DefaultVal : "";
            TextBox.Location = new Point(startOffsetX + XNext, startOffsetY + LineNumber * LineOffsetY);
            TextBox.MinimumSize = new Size(776 - TextBox.Location.X - 10, TextBox.Size.Height);
            TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LineNumber++;
        }
    }
}
