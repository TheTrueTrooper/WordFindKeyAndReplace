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
using static System.Windows.Forms.Control;

namespace WordFindKeyAndReplace
{
    /// <summary>
    /// To create an internal helper class for use with building controls and tracking them in the form's dictionary
    /// and build up the controls as it goes
    /// </summary>
    internal class KeyValueControls
    {
        /// <summary>
        /// the start from the top down
        /// </summary>
        const int startOffsetY = 16;
        /// <summary>
        /// the start from the left to right
        /// </summary>
        const int startOffsetX = 10;
        /// <summary>
        /// the offset to add on every line
        /// </summary>
        const int LineOffsetY = 30;
        /// <summary>
        /// the controlsboxes defualt size
        /// </summary>
        const int ControlBoxStartAndMin = 776;

        /// <summary>
        /// the label controls name Refex
        /// </summary>
        const string LaNamePrex = "La_";

        /// <summary>
        /// the label controls name Refex
        /// </summary>
        const string BuNamePrex = "Bu_";

        /// <summary>
        /// a shared line counter.
        /// </summary>
        internal static int LineNumber = 0;

        /// <summary>
        /// the place where the text boxes should start
        /// </summary>
        internal static int XNext = 250;

        /// <summary>
        /// the Label to identify the Key that you are entering a value for 
        /// </summary>
        public Label Label = new Label();
        /// <summary>
        /// the Text box to enter a value for the key
        /// </summary>
        public TextBox TextBox = new TextBox();

        /// <summary>
        /// A getter to use to get the textboxs value
        /// </summary>
        public string ReplaceValue
        {
            get
            {
                return TextBox.Text;
            }
        }

        /// <summary>
        /// The constructor that bullds the controls
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="DefaultVal"></param>
        internal KeyValueControls(string Name, string DefaultVal)
        {
            //Builds the keys idenification label
            Label.Visible = true;
            Label.Name = LaNamePrex + Name;
            Label.Text = Name;
            //sets where and size it will appear in the forms control group
            Label.Location = new Point(startOffsetX, startOffsetY + LineNumber * LineOffsetY);
            Label.Size = new Size(XNext, Label.Height);
            //Builds the replacement values input text box
            TextBox.Visible = true;
            TextBox.Name = BuNamePrex + Name;
            TextBox.Text = DefaultVal != null ? DefaultVal : string.Empty;
            //sets where and size it will appear in the forms control group
            TextBox.Location = new Point(startOffsetX + XNext, startOffsetY + LineNumber * LineOffsetY);
            TextBox.MinimumSize = new Size(ControlBoxStartAndMin - TextBox.Location.X - startOffsetX, TextBox.Size.Height);
            //sets the location
            TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            // moves up the line for the next rows build
            LineNumber++;
        }

        /// <summary>
        /// Registers the controls with the control group
        /// </summary>
        /// <param name="ControlOrFormReg">The control group to register to</param>
        internal void RegisterTheControls(ControlCollection ControlOrFormReg)
        {
            //reg all controls
            ControlOrFormReg.Add(Label);
            ControlOrFormReg.Add(TextBox);
        }
    }
}
