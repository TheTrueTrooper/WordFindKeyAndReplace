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


namespace WordFindKeyAndReplace
{
    public partial class WordFindKeyAndReplacePopForm : Form
    {
        event EventHandler DocTextChanged;

        Regex Finder = new Regex(@"((@\[([^\[,\],=,\n,@])*\])|(@\[([^\[,\],=,\n,@])*=([^\[,\],=,\n,@])*\]))", RegexOptions.Multiline);
        Regex DefaultFinder = new Regex(@"(=([^=])*\])", RegexOptions.Singleline);
        Dictionary<string, KeyValueControls> Dictionary;
        Microsoft.Office.Interop.Word.Document nativeDocument;
        Document vstoDocument;
        string Oldtext;



        public WordFindKeyAndReplacePopForm()
        {
            InitializeComponent();

            if (Globals.ThisAddIn.Application.Documents.Count > 0)
            {
                nativeDocument = Globals.ThisAddIn.Application.ActiveDocument;
                vstoDocument = Globals.Factory.GetVstoObject(nativeDocument);
                vstoDocument.BeforeClose += CloseEvent;
                DocTextChanged += OnDocTextChanged;
                Ti_Listener.Enabled = true;
                BuildKeyList();
            }
        }

        void BuildKeyList()
        {
            //Clear globals
            Dictionary = new Dictionary<string, KeyValueControls>();
            GrBo_DictionaryInput.Controls.Clear();
            KeyValueControls.LineNumber = 0;

            Oldtext = vstoDocument.Content.Text;
            MatchCollection Matches = Finder.Matches(Oldtext);

            foreach (Match Match in Matches)
            {
                string MatchName = Match.Value;
                string DefaultVal = null;
                if (MatchName.Contains("="))
                {
                    DefaultVal = DefaultFinder.Match(MatchName).Value;
                    DefaultVal = DefaultVal.Remove(DefaultVal.Length - 1, 1).Remove(0, 1);
                    MatchName = MatchName.Remove(MatchName.IndexOf('='), MatchName.Length - MatchName.IndexOf('=') - 1);
                }

                if (!Dictionary.ContainsKey(MatchName))
                {
                    Dictionary.Add(MatchName, new KeyValueControls(MatchName, DefaultVal));
                    GrBo_DictionaryInput.Controls.Add(Dictionary.Last().Value.Label);
                    GrBo_DictionaryInput.Controls.Add(Dictionary.Last().Value.TextBox);
                }

            }
        }

        private void Bu_FindAndReplace_Click(object sender, EventArgs e)
        {

            string Values = vstoDocument.Content.Text;

            if (Dictionary != null)
            {
                foreach (KeyValuePair<string, KeyValueControls> KP in Dictionary)
                {
                    vstoDocument.Content.Text = vstoDocument.Content.Text.Replace(KP.Key, KP.Value.ReplaceValue);
                }
            }
            Close();
        }

        //private void Bu_Rescan_Click(object sender, EventArgs e)
        //{
        //    BuildKeyList();
        //}

        void CloseEvent(object sender, CancelEventArgs e)
        {
            Close();
        }

        void OnDocTextChanged(object sender, EventArgs e)
        {
            if (vstoDocument.Content.Text != Oldtext)
                BuildKeyList();
        }

        private void Ti_Listener_Tick(object sender, EventArgs e)
        {
            if (vstoDocument.Content.Text != Oldtext)
                DocTextChanged.Invoke(this, e);
        }
    }
}
