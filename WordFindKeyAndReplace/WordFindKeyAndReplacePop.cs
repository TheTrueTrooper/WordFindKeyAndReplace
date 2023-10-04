#region WritersSigniture
//Writer: Angelo Sanches (BitSan)(Git:TheTrueTrooper)
//Date Writen: Dec 20,2018
//Project Goal: Make a templater for basic text doc editing 
//File Goal: The bread and butter systems. 
//Most of the fuctionality is handled by the form that is prompted and that happens to happen here.
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;

namespace WordFindKeyAndReplace
{
    /// <summary>
    /// The bread and butter systems. 
    ///Most of the fuctionality is handled by the form that is prompted and that happens to happen here.
    /// </summary>
    public partial class WordFindKeyAndReplacePopForm : Form
    {
        /// <summary>
        /// The constant for the Regex Finder Expression
        /// </summary>
        const string FindersRegexExpression = @"((@\[([^\[\]=\n@])*\])|(@\[([^\[\]=\n@])*=([^\[\]=\n@])*\]))";
        /// <summary>
        /// The constant for the Regex Default Finder Expression
        /// </summary>
        const string DefaultFinderRegexExpression = @"(=([^=])*\])";

        /// <summary>
        /// the event for if someone types at all
        /// </summary>
        event EventHandler DocTextChanged;

        /// <summary>
        /// Our regular expression Pattern for finding the the varables in the text
        /// </summary>
        Regex Finder = new Regex(FindersRegexExpression, RegexOptions.Multiline);

        /// <summary>
        /// Our regular expression Pattern for finding the the default value in the varables
        /// </summary>
        Regex DefaultFinder = new Regex(DefaultFinderRegexExpression, RegexOptions.Singleline);

        /// <summary>
        /// A dictionary to hold the controls for the variable. uses the KeyValueControls custom class in the KeyValueControlsUtilities for the access and storage.
        /// </summary>
        Dictionary<string, KeyValueControls> Dictionary;

        /// <summary>
        /// The native document as per the microsoft guide not really used so far exept to build the viso
        /// </summary>
        Microsoft.Office.Interop.Word.Document NativeDocument;

        /// <summary>
        /// The VSTO Document object for the C# magic to edit with 
        /// Changes here are sent back to the document in real time
        /// </summary>
        Microsoft.Office.Tools.Word.Document VSTODocument;

        /// <summary>
        /// The Old text. For use with a timer on the generated form to trigger the event of text change for a rescan
        /// </summary>
        string Oldtext;


        /// <summary>
        /// The constructor
        /// </summary>
        public WordFindKeyAndReplacePopForm()
        {
            InitializeComponent();

            //if we have a document open begin to build the fuctionality or else close the window
            if (Globals.ThisAddIn.Application.Documents.Count > 0)
            {
                //Grab the word app as per the microsoft guide may be useful later
                NativeDocument = Globals.ThisAddIn.Application.ActiveDocument;
                //use that handle to to create the Document 
                VSTODocument = Globals.Factory.GetVstoObject(NativeDocument);
                //register a close event to close this code if the program is closed.
                VSTODocument.BeforeClose += CloseEvent;
                //register the event for text being changed
                DocTextChanged += OnDocTextChanged;
                //start the timer loop for text changes
                Ti_Listener.Enabled = true;
                //do a scan pass for the keys for varables
                BuildKeyList();
            }
            else
                Close();
        }

        /// <summary>
        /// This fuction scans for all of the key for varables marked by @[*=*] (losely see FindersRegexExpression) 
        /// and then them out with a defualt value to build the controls. After controls are built it regs them with the control group
        /// </summary>
        void BuildKeyList()
        {
            //clear all containers to empty states. states
            Dictionary = new Dictionary<string, KeyValueControls>(); //clear dictionary for GC
            GrBo_DictionaryInput.Controls.Clear(); //clear any controls for GC
            KeyValueControls.LineNumber = 0; //reset the line droper for the KeyValueControls use when self building controls

            //set the old text (not locked for quick pull) 
            lock (VSTODocument.Content.Text)
                Oldtext = VSTODocument.Content.Text;
            //find all the variables in the old text (not we do not use the new text as it could be still being writen to)
            MatchCollection Matches = Finder.Matches(Oldtext);

            //For each match we will pull the defualt value.
            foreach (Match Match in Matches)
            {
                //grab the value to be worked on and open a default value var
                string matchName = Match.Value;
                string defaultVal = null;

                //if ther is a = sign then there must be a defualt value by convent
                if (matchName.Contains("="))
                {
                    // first pull out the value of the value then clean the match
                    defaultVal = DefaultFinder.Match(matchName).Value;
                    defaultVal = defaultVal.Remove(defaultVal.Length - 1, 1).Remove(0, 1);
                    //clean the name
                    matchName = matchName.Remove(matchName.IndexOf('='), matchName.Length - matchName.IndexOf('=') - 1);
                }
                
                //if we not have the key add it and build the controls 
                if (!Dictionary.ContainsKey(matchName))
                {
                    //add it and build the controls(see the KeyValueControls to see how the controls are built and utilized)
                    Dictionary.Add(Match.Value, new KeyValueControls(matchName, defaultVal));
                    //register all of it's controls
                    Dictionary.Last().Value.RegisterTheControls(GrBo_DictionaryInput.Controls);
                }

            }
        }

        /// <summary>
        /// The find and replace button event
        /// On click will find all the Keys and replace them with their newly associated vars values as per the form
        /// </summary>
        /// <param name="sender">the sender(this form)</param>
        /// <param name="e">the args(the defualt)</param>
        private void Bu_FindAndReplace_Click(object sender, EventArgs e)
        {
            //grab the text to work on
            string values = VSTODocument.Content.FormattedText.Text;

            if (Dictionary != null)
            {
                foreach (KeyValuePair<string, KeyValueControls> KP in Dictionary)
                {
                    //for each key attempt a replace. and write it back to the text
                    values = values.Replace(KP.Key, KP.Value.ReplaceValue);
                }
            }
            lock (VSTODocument.Content.Text)
                VSTODocument.Content.FormattedText.Text = values;
            Close();
        }

        /// <summary>
        /// the close event is called if the application is closing simply closes the form
        /// </summary>
        /// <param name="sender">the sender (inherents from VSTODocument)</param>
        /// <param name="e">the event args (inherents from VSTODocument)</param>
        void CloseEvent(object sender, CancelEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// An event for if the text is changed. Rebuilds the Vars list and their controls
        /// </summary>
        /// <param name="sender">the sender (inherents from the Timer Event)</param>
        /// <param name="e">the event args (inherents from the Timer Event)</param>
        void OnDocTextChanged(object sender, EventArgs e)
        {
            if (VSTODocument.Content.Text != Oldtext)
                BuildKeyList();
        }

        /// <summary>
        /// An event for if the text is changed. invokes the DocTextChanged event
        /// </summary>
        /// <param name="sender">the sender (inherents from the Timer Event)</param>
        /// <param name="e">the event (inherents from the Timer Event)</param>
        private void Ti_Listener_Tick(object sender, EventArgs e)
        {
            if (VSTODocument.Content.Text != Oldtext)
                DocTextChanged.Invoke(sender, e);
        }

        /// <summary>
        /// An event for if the text the add var button is pressed
        /// </summary>
        /// <param name="sender">the sender</param>
        /// <param name="e">the event</param>
        private void Bu_AddVar_Click(object sender, EventArgs e)
        {
            string varName = TeBo_VarName.Text;

            InsertText($"@[{varName}]");
        }

        /// <summary>
        /// An event for if the text the add var default button is pressed
        /// </summary>
        /// <param name="sender">the sender</param>
        /// <param name="e">the event</param>
        private void Bu_AddVarWithDefualt_Click(object sender, EventArgs e)
        {
            string varName = TeBo_VarName.Text;
            string varDefault = TeBo_VarDefault.Text;

            InsertText($"@[{varName}={varDefault}]");
        }

        /// <summary>
        /// A simple function to insert text at the selected area
        /// </summary>
        /// <param name="Text">the text to insert</param>
        private void InsertText(string Text)
        { 
            if (!string.IsNullOrEmpty(Text))
            {
                //get the current selection
                Selection currentSelection = VSTODocument.ActiveWindow.Application.Selection;
                //replace with text
                currentSelection.TypeText(Text);
            }
        }
    }
}
