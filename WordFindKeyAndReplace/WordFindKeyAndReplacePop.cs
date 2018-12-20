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
        Regex Finder = new Regex(@"((@\[([^\[,\],=,\n,@])*\])|(@\[([^\[,\],=,\n,@])*=([^\[,\],=,\n,@])*\]))", RegexOptions.Multiline);
        Dictionary<string, KeyValueControls> Dictionary;
        Microsoft.Office.Interop.Word.Document nativeDocument;
        Document vstoDocument;


        public WordFindKeyAndReplacePopForm()
        {
            InitializeComponent();

            if (Globals.ThisAddIn.Application.Documents.Count > 0)
            {
            
                nativeDocument = Globals.ThisAddIn.Application.ActiveDocument;
                vstoDocument = Globals.Factory.GetVstoObject(nativeDocument);

                BuildKeyList();
            }


        }

        void BuildKeyList()
        {
            //Clear globals
            Dictionary = new Dictionary<string, KeyValueControls>();
            GrBo_DictionaryInput.Controls.Clear();
            KeyValueControls.LineNumber = 0;

            string Values = vstoDocument.Content.Text;
            MatchCollection Matches = Finder.Matches(Values);

            foreach (Match Match in Matches)
            {
                if (!Dictionary.ContainsKey(Match.Value))
                {
                    Dictionary.Add(Match.Value, new KeyValueControls(Match.Value));
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

        private void Bu_Rescan_Click(object sender, EventArgs e)
        {
            BuildKeyList();
        }
    }
}
