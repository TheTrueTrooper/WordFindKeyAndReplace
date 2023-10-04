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
            this.La_Info = new System.Windows.Forms.Label();
            this.Ti_Listener = new System.Windows.Forms.Timer(this.components);
            this.Bu_AddVar = new System.Windows.Forms.Button();
            this.Bu_AddVarWithDefualt = new System.Windows.Forms.Button();
            this.TeBo_VarName = new System.Windows.Forms.TextBox();
            this.La_VarName = new System.Windows.Forms.Label();
            this.La_VarDefault = new System.Windows.Forms.Label();
            this.TeBo_VarDefault = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GrBo_DictionaryInput
            // 
            this.GrBo_DictionaryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrBo_DictionaryInput.Location = new System.Drawing.Point(12, 200);
            this.GrBo_DictionaryInput.Name = "GrBo_DictionaryInput";
            this.GrBo_DictionaryInput.Size = new System.Drawing.Size(776, 526);
            this.GrBo_DictionaryInput.TabIndex = 0;
            this.GrBo_DictionaryInput.TabStop = false;
            this.GrBo_DictionaryInput.Text = "Key values found to Replace";
            // 
            // Bu_FindAndReplace
            // 
            this.Bu_FindAndReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bu_FindAndReplace.Location = new System.Drawing.Point(15, 732);
            this.Bu_FindAndReplace.Name = "Bu_FindAndReplace";
            this.Bu_FindAndReplace.Size = new System.Drawing.Size(773, 23);
            this.Bu_FindAndReplace.TabIndex = 0;
            this.Bu_FindAndReplace.Text = "Find and Replace";
            this.Bu_FindAndReplace.UseVisualStyleBackColor = true;
            this.Bu_FindAndReplace.Click += new System.EventHandler(this.Bu_FindAndReplace_Click);
            // 
            // La_Info
            // 
            this.La_Info.AutoSize = true;
            this.La_Info.Location = new System.Drawing.Point(12, 132);
            this.La_Info.Name = "La_Info";
            this.La_Info.Size = new System.Drawing.Size(421, 65);
            this.La_Info.TabIndex = 2;
            this.La_Info.Text = resources.GetString("La_Info.Text");
            // 
            // Ti_Listener
            // 
            this.Ti_Listener.Interval = 1000;
            this.Ti_Listener.Tick += new System.EventHandler(this.Ti_Listener_Tick);
            // 
            // Bu_AddVar
            // 
            this.Bu_AddVar.Location = new System.Drawing.Point(15, 107);
            this.Bu_AddVar.Name = "Bu_AddVar";
            this.Bu_AddVar.Size = new System.Drawing.Size(378, 22);
            this.Bu_AddVar.TabIndex = 3;
            this.Bu_AddVar.Text = "Add Var";
            this.Bu_AddVar.UseVisualStyleBackColor = true;
            this.Bu_AddVar.Click += new System.EventHandler(this.Bu_AddVar_Click);
            // 
            // Bu_AddVarWithDefualt
            // 
            this.Bu_AddVarWithDefualt.Location = new System.Drawing.Point(399, 107);
            this.Bu_AddVarWithDefualt.Name = "Bu_AddVarWithDefualt";
            this.Bu_AddVarWithDefualt.Size = new System.Drawing.Size(381, 22);
            this.Bu_AddVarWithDefualt.TabIndex = 4;
            this.Bu_AddVarWithDefualt.Text = "Add Var With Default";
            this.Bu_AddVarWithDefualt.UseVisualStyleBackColor = true;
            this.Bu_AddVarWithDefualt.Click += new System.EventHandler(this.Bu_AddVarWithDefualt_Click);
            // 
            // TeBo_VarName
            // 
            this.TeBo_VarName.Location = new System.Drawing.Point(12, 29);
            this.TeBo_VarName.Name = "TeBo_VarName";
            this.TeBo_VarName.Size = new System.Drawing.Size(765, 20);
            this.TeBo_VarName.TabIndex = 5;
            // 
            // La_VarName
            // 
            this.La_VarName.AutoSize = true;
            this.La_VarName.Location = new System.Drawing.Point(12, 9);
            this.La_VarName.Name = "La_VarName";
            this.La_VarName.Size = new System.Drawing.Size(54, 13);
            this.La_VarName.TabIndex = 6;
            this.La_VarName.Text = "Var Name";
            // 
            // La_VarDefault
            // 
            this.La_VarDefault.AutoSize = true;
            this.La_VarDefault.Location = new System.Drawing.Point(12, 58);
            this.La_VarDefault.Name = "La_VarDefault";
            this.La_VarDefault.Size = new System.Drawing.Size(60, 13);
            this.La_VarDefault.TabIndex = 8;
            this.La_VarDefault.Text = "Var Default";
            // 
            // TeBo_VarDefault
            // 
            this.TeBo_VarDefault.Location = new System.Drawing.Point(12, 78);
            this.TeBo_VarDefault.Name = "TeBo_VarDefault";
            this.TeBo_VarDefault.Size = new System.Drawing.Size(765, 20);
            this.TeBo_VarDefault.TabIndex = 7;
            // 
            // WordFindKeyAndReplacePopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.La_VarDefault);
            this.Controls.Add(this.TeBo_VarDefault);
            this.Controls.Add(this.La_VarName);
            this.Controls.Add(this.TeBo_VarName);
            this.Controls.Add(this.Bu_AddVarWithDefualt);
            this.Controls.Add(this.Bu_AddVar);
            this.Controls.Add(this.La_Info);
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
        private System.Windows.Forms.Label La_Info;
        private System.Windows.Forms.Timer Ti_Listener;
        private System.Windows.Forms.Button Bu_AddVar;
        private System.Windows.Forms.Button Bu_AddVarWithDefualt;
        private System.Windows.Forms.TextBox TeBo_VarName;
        private System.Windows.Forms.Label La_VarName;
        private System.Windows.Forms.Label La_VarDefault;
        private System.Windows.Forms.TextBox TeBo_VarDefault;
    }
}