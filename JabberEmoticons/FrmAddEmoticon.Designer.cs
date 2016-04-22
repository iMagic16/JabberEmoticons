namespace JabberEmoticons
{
    partial class FrmAddEmoticon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmoticon));
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtFileLoc = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmoticonName = new System.Windows.Forms.TextBox();
            this.TxtEmoticonShortcut = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(12, 27);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(51, 23);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtFileLoc
            // 
            this.TxtFileLoc.Location = new System.Drawing.Point(69, 29);
            this.TxtFileLoc.Name = "TxtFileLoc";
            this.TxtFileLoc.ReadOnly = true;
            this.TxtFileLoc.Size = new System.Drawing.Size(191, 20);
            this.TxtFileLoc.TabIndex = 1;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Enabled = false;
            this.BtnSubmit.Location = new System.Drawing.Point(12, 138);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(248, 45);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Package && Close";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Place your emoji\'s into a zip && fill out the form below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emoticon Name e.g. \"An Egg\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emoticon Shortcut e.g. \"(egg)\"";
            // 
            // TxtEmoticonName
            // 
            this.TxtEmoticonName.Location = new System.Drawing.Point(12, 73);
            this.TxtEmoticonName.Name = "TxtEmoticonName";
            this.TxtEmoticonName.Size = new System.Drawing.Size(248, 20);
            this.TxtEmoticonName.TabIndex = 3;
            // 
            // TxtEmoticonShortcut
            // 
            this.TxtEmoticonShortcut.Location = new System.Drawing.Point(12, 112);
            this.TxtEmoticonShortcut.Name = "TxtEmoticonShortcut";
            this.TxtEmoticonShortcut.Size = new System.Drawing.Size(248, 20);
            this.TxtEmoticonShortcut.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Emoticon Zip|*.zip";
            // 
            // FrmAddEmoticon
            // 
            this.AcceptButton = this.BtnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 192);
            this.Controls.Add(this.TxtEmoticonShortcut);
            this.Controls.Add(this.TxtEmoticonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtFileLoc);
            this.Controls.Add(this.BtnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddEmoticon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jabber Emoticons | Add Emoticons";
            this.Load += new System.EventHandler(this.FrmAddEmoticon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtFileLoc;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmoticonName;
        private System.Windows.Forms.TextBox TxtEmoticonShortcut;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}