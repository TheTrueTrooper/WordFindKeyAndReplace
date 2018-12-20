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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordFindKeyAndReplacePopForm));
            this.GrBo_DictionaryInput = new System.Windows.Forms.GroupBox();
            this.Bu_FindAndReplace = new System.Windows.Forms.Button();
            this.Bu_Rescan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GrBo_DictionaryInput
            // 
            this.GrBo_DictionaryInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrBo_DictionaryInput.Location = new System.Drawing.Point(12, 64);
            this.GrBo_DictionaryInput.Name = "GrBo_DictionaryInput";
            this.GrBo_DictionaryInput.Size = new System.Drawing.Size(776, 391);
            this.GrBo_DictionaryInput.TabIndex = 0;
            this.GrBo_DictionaryInput.TabStop = false;
            this.GrBo_DictionaryInput.Text = "Key values found to Replace";
            // 
            // Bu_FindAndReplace
            // 
            this.Bu_FindAndReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bu_FindAndReplace.Location = new System.Drawing.Point(408, 461);
            this.Bu_FindAndReplace.Name = "Bu_FindAndReplace";
            this.Bu_FindAndReplace.Size = new System.Drawing.Size(380, 23);
            this.Bu_FindAndReplace.TabIndex = 0;
            this.Bu_FindAndReplace.Text = "Find and Replace";
            this.Bu_FindAndReplace.UseVisualStyleBackColor = true;
            this.Bu_FindAndReplace.Click += new System.EventHandler(this.Bu_FindAndReplace_Click);
            // 
            // Bu_Rescan
            // 
            this.Bu_Rescan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bu_Rescan.Location = new System.Drawing.Point(12, 462);
            this.Bu_Rescan.Name = "Bu_Rescan";
            this.Bu_Rescan.Size = new System.Drawing.Size(390, 23);
            this.Bu_Rescan.TabIndex = 1;
            this.Bu_Rescan.Text = "Rescan";
            this.Bu_Rescan.UseVisualStyleBackColor = true;
            this.Bu_Rescan.Click += new System.EventHandler(this.Bu_Rescan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // WordFindKeyAndReplacePopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bu_Rescan);
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
        private System.Windows.Forms.Button Bu_Rescan;
        private System.Windows.Forms.Label label1;
    }
}