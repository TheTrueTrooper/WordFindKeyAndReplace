#region WritersSigniture
//Writer: Angelo Sanches (BitSan)(Git:TheTrueTrooper)
//Date Writen: Dec 20,2018
//Project Goal: Make a templater for basic text doc editing 
//File Goal: Generated designer mostly
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
namespace WordFindKeyAndReplace
{
    partial class WordFindKeyAndReplacePopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordFindKeyAndReplacePopForm));
            this.GrBo_DictionaryInput = new System.Windows.Forms.GroupBox();
            this.Bu_FindAndReplace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ti_Listener = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GrBo_DictionaryInput
            // 
            this.GrBo_DictionaryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrBo_DictionaryInput.Location = new System.Drawing.Point(12, 77);
            this.GrBo_DictionaryInput.Name = "GrBo_DictionaryInput";
            this.GrBo_DictionaryInput.Size = new System.Drawing.Size(776, 378);
            this.GrBo_DictionaryInput.TabIndex = 0;
            this.GrBo_DictionaryInput.TabStop = false;
            this.GrBo_DictionaryInput.Text = "Key values found to Replace";
            // 
            // Bu_FindAndReplace
            // 
            this.Bu_FindAndReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bu_FindAndReplace.Location = new System.Drawing.Point(15, 461);
            this.Bu_FindAndReplace.Name = "Bu_FindAndReplace";
            this.Bu_FindAndReplace.Size = new System.Drawing.Size(773, 23);
            this.Bu_FindAndReplace.TabIndex = 0;
            this.Bu_FindAndReplace.Text = "Find and Replace";
            this.Bu_FindAndReplace.UseVisualStyleBackColor = true;
            this.Bu_FindAndReplace.Click += new System.EventHandler(this.Bu_FindAndReplace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Ti_Listener
            // 
            this.Ti_Listener.Interval = 1000;
            this.Ti_Listener.Tick += new System.EventHandler(this.Ti_Listener_Tick);
            // 
            // WordFindKeyAndReplacePopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bu_FindAndReplace);
            this.Controls.Add(this.GrBo_DictionaryInput);
            this.MinimumSize = new System.Drawing.Size(816, 536);
            this.Name = "WordFindKeyAndReplacePopForm";
            this.Text = "WordFindKeyAndReplacePop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBo_DictionaryInput;
        private System.Windows.Forms.Button Bu_FindAndReplace;
        //private System.Windows.Forms.Button Bu_Rescan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Ti_Listener;
    }
}