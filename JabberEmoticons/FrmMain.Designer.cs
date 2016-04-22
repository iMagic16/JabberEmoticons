namespace JabberEmoticons
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LblProgramPre = new System.Windows.Forms.Label();
            this.LblEmotionPre = new System.Windows.Forms.Label();
            this.LblNoOfEmoticonsPre = new System.Windows.Forms.Label();
            this.BtnUpdateEmoticons = new System.Windows.Forms.Button();
            this.LblNoOfEmoticons = new System.Windows.Forms.Label();
            this.LblProgVer = new System.Windows.Forms.Label();
            this.LblEmoVer = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdateProg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDebug = new System.Windows.Forms.TextBox();
            this.GrpEmoticons = new System.Windows.Forms.GroupBox();
            this.BtnAddEmoticons = new System.Windows.Forms.Button();
            this.GrpProgram = new System.Windows.Forms.GroupBox();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.GrpStatus = new System.Windows.Forms.GroupBox();
            this.GpSettings = new System.Windows.Forms.GroupBox();
            this.ChkAutoUpdateEmoticon = new System.Windows.Forms.CheckBox();
            this.TxtAutoUpdateEmoticonInterval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkAutoCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAutoCheckForUpdatesInterval = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GrpEmoticons.SuspendLayout();
            this.GrpProgram.SuspendLayout();
            this.GrpStatus.SuspendLayout();
            this.GpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayIcon
            // 
            this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TrayIcon.BalloonTipText = "Running in the background...";
            this.TrayIcon.BalloonTipTitle = "Jabber Emoticons";
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Jabber Emoticons";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // LblProgramPre
            // 
            this.LblProgramPre.AutoSize = true;
            this.LblProgramPre.Location = new System.Drawing.Point(4, 30);
            this.LblProgramPre.Name = "LblProgramPre";
            this.LblProgramPre.Size = new System.Drawing.Size(90, 13);
            this.LblProgramPre.TabIndex = 0;
            this.LblProgramPre.Text = "Program Version: ";
            // 
            // LblEmotionPre
            // 
            this.LblEmotionPre.AutoSize = true;
            this.LblEmotionPre.Location = new System.Drawing.Point(4, 43);
            this.LblEmotionPre.Name = "LblEmotionPre";
            this.LblEmotionPre.Size = new System.Drawing.Size(95, 13);
            this.LblEmotionPre.TabIndex = 1;
            this.LblEmotionPre.Text = "Emoticon Version: ";
            // 
            // LblNoOfEmoticonsPre
            // 
            this.LblNoOfEmoticonsPre.AutoSize = true;
            this.LblNoOfEmoticonsPre.Location = new System.Drawing.Point(4, 17);
            this.LblNoOfEmoticonsPre.Name = "LblNoOfEmoticonsPre";
            this.LblNoOfEmoticonsPre.Size = new System.Drawing.Size(114, 13);
            this.LblNoOfEmoticonsPre.TabIndex = 2;
            this.LblNoOfEmoticonsPre.Text = "Number of Emoticons: ";
            // 
            // BtnUpdateEmoticons
            // 
            this.BtnUpdateEmoticons.Location = new System.Drawing.Point(6, 19);
            this.BtnUpdateEmoticons.Name = "BtnUpdateEmoticons";
            this.BtnUpdateEmoticons.Size = new System.Drawing.Size(139, 23);
            this.BtnUpdateEmoticons.TabIndex = 1;
            this.BtnUpdateEmoticons.Text = "Update Emoticons";
            this.BtnUpdateEmoticons.UseVisualStyleBackColor = true;
            this.BtnUpdateEmoticons.Click += new System.EventHandler(this.BtnUpdateEmoticon);
            // 
            // LblNoOfEmoticons
            // 
            this.LblNoOfEmoticons.AutoSize = true;
            this.LblNoOfEmoticons.ForeColor = System.Drawing.Color.Green;
            this.LblNoOfEmoticons.Location = new System.Drawing.Point(110, 17);
            this.LblNoOfEmoticons.Name = "LblNoOfEmoticons";
            this.LblNoOfEmoticons.Size = new System.Drawing.Size(23, 13);
            this.LblNoOfEmoticons.TabIndex = 5;
            this.LblNoOfEmoticons.Text = "null";
            // 
            // LblProgVer
            // 
            this.LblProgVer.AutoSize = true;
            this.LblProgVer.ForeColor = System.Drawing.Color.Green;
            this.LblProgVer.Location = new System.Drawing.Point(87, 30);
            this.LblProgVer.Name = "LblProgVer";
            this.LblProgVer.Size = new System.Drawing.Size(23, 13);
            this.LblProgVer.TabIndex = 6;
            this.LblProgVer.Text = "null";
            // 
            // LblEmoVer
            // 
            this.LblEmoVer.AutoSize = true;
            this.LblEmoVer.ForeColor = System.Drawing.Color.Green;
            this.LblEmoVer.Location = new System.Drawing.Point(92, 43);
            this.LblEmoVer.Name = "LblEmoVer";
            this.LblEmoVer.Size = new System.Drawing.Size(23, 13);
            this.LblEmoVer.TabIndex = 7;
            this.LblEmoVer.Text = "null";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(6, 48);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(139, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Quit Program";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnExit);
            // 
            // BtnUpdateProg
            // 
            this.BtnUpdateProg.Location = new System.Drawing.Point(6, 19);
            this.BtnUpdateProg.Name = "BtnUpdateProg";
            this.BtnUpdateProg.Size = new System.Drawing.Size(93, 23);
            this.BtnUpdateProg.TabIndex = 3;
            this.BtnUpdateProg.Text = "Update Program";
            this.BtnUpdateProg.UseVisualStyleBackColor = true;
            this.BtnUpdateProg.Click += new System.EventHandler(this.BtnUpdateProg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDebug);
            this.groupBox1.Location = new System.Drawing.Point(390, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 247);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer Tools";
            // 
            // TxtDebug
            // 
            this.TxtDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDebug.Enabled = false;
            this.TxtDebug.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDebug.Location = new System.Drawing.Point(3, 16);
            this.TxtDebug.Multiline = true;
            this.TxtDebug.Name = "TxtDebug";
            this.TxtDebug.ReadOnly = true;
            this.TxtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDebug.Size = new System.Drawing.Size(561, 228);
            this.TxtDebug.TabIndex = 0;
            // 
            // GrpEmoticons
            // 
            this.GrpEmoticons.Controls.Add(this.BtnAddEmoticons);
            this.GrpEmoticons.Controls.Add(this.BtnUpdateEmoticons);
            this.GrpEmoticons.Location = new System.Drawing.Point(13, 89);
            this.GrpEmoticons.Name = "GrpEmoticons";
            this.GrpEmoticons.Size = new System.Drawing.Size(151, 82);
            this.GrpEmoticons.TabIndex = 11;
            this.GrpEmoticons.TabStop = false;
            this.GrpEmoticons.Text = "Emoticons";
            // 
            // BtnAddEmoticons
            // 
            this.BtnAddEmoticons.Enabled = false;
            this.BtnAddEmoticons.Location = new System.Drawing.Point(6, 48);
            this.BtnAddEmoticons.Name = "BtnAddEmoticons";
            this.BtnAddEmoticons.Size = new System.Drawing.Size(139, 23);
            this.BtnAddEmoticons.TabIndex = 2;
            this.BtnAddEmoticons.Text = "Add Emoticons";
            this.BtnAddEmoticons.UseVisualStyleBackColor = true;
            this.BtnAddEmoticons.Click += new System.EventHandler(this.BtnAddEmoticons_Click);
            // 
            // GrpProgram
            // 
            this.GrpProgram.Controls.Add(this.BtnSettings);
            this.GrpProgram.Controls.Add(this.BtnClose);
            this.GrpProgram.Controls.Add(this.BtnUpdateProg);
            this.GrpProgram.Location = new System.Drawing.Point(13, 177);
            this.GrpProgram.Name = "GrpProgram";
            this.GrpProgram.Size = new System.Drawing.Size(151, 82);
            this.GrpProgram.TabIndex = 12;
            this.GrpProgram.TabStop = false;
            this.GrpProgram.Text = "Program";
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::JabberEmoticons.Properties.Resources.settings;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Location = new System.Drawing.Point(105, 19);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(40, 23);
            this.BtnSettings.TabIndex = 5;
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // GrpStatus
            // 
            this.GrpStatus.Controls.Add(this.LblNoOfEmoticons);
            this.GrpStatus.Controls.Add(this.LblEmoVer);
            this.GrpStatus.Controls.Add(this.LblProgVer);
            this.GrpStatus.Controls.Add(this.LblProgramPre);
            this.GrpStatus.Controls.Add(this.LblEmotionPre);
            this.GrpStatus.Controls.Add(this.LblNoOfEmoticonsPre);
            this.GrpStatus.Location = new System.Drawing.Point(13, 13);
            this.GrpStatus.Name = "GrpStatus";
            this.GrpStatus.Size = new System.Drawing.Size(151, 70);
            this.GrpStatus.TabIndex = 13;
            this.GrpStatus.TabStop = false;
            this.GrpStatus.Text = "Statuses";
            // 
            // GpSettings
            // 
            this.GpSettings.Controls.Add(this.label3);
            this.GpSettings.Controls.Add(this.label4);
            this.GpSettings.Controls.Add(this.TxtAutoCheckForUpdatesInterval);
            this.GpSettings.Controls.Add(this.ChkAutoCheckForUpdates);
            this.GpSettings.Controls.Add(this.label2);
            this.GpSettings.Controls.Add(this.label1);
            this.GpSettings.Controls.Add(this.TxtAutoUpdateEmoticonInterval);
            this.GpSettings.Controls.Add(this.ChkAutoUpdateEmoticon);
            this.GpSettings.Enabled = false;
            this.GpSettings.Location = new System.Drawing.Point(184, 13);
            this.GpSettings.Name = "GpSettings";
            this.GpSettings.Size = new System.Drawing.Size(188, 246);
            this.GpSettings.TabIndex = 14;
            this.GpSettings.TabStop = false;
            this.GpSettings.Text = "Settings";
            // 
            // ChkAutoUpdateEmoticon
            // 
            this.ChkAutoUpdateEmoticon.AutoSize = true;
            this.ChkAutoUpdateEmoticon.Location = new System.Drawing.Point(7, 20);
            this.ChkAutoUpdateEmoticon.Name = "ChkAutoUpdateEmoticon";
            this.ChkAutoUpdateEmoticon.Size = new System.Drawing.Size(175, 17);
            this.ChkAutoUpdateEmoticon.TabIndex = 0;
            this.ChkAutoUpdateEmoticon.Text = "Automatically update emoticons";
            this.ChkAutoUpdateEmoticon.UseVisualStyleBackColor = true;
            this.ChkAutoUpdateEmoticon.CheckedChanged += new System.EventHandler(this.ChkAutoUpdateEmoticon_CheckedChanged);
            // 
            // TxtAutoUpdateEmoticonInterval
            // 
            this.TxtAutoUpdateEmoticonInterval.Location = new System.Drawing.Point(86, 43);
            this.TxtAutoUpdateEmoticonInterval.Name = "TxtAutoUpdateEmoticonInterval";
            this.TxtAutoUpdateEmoticonInterval.Size = new System.Drawing.Size(43, 20);
            this.TxtAutoUpdateEmoticonInterval.TabIndex = 1;
            this.TxtAutoUpdateEmoticonInterval.TextChanged += new System.EventHandler(this.TxtAutoUpdateEmoticonInterval_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update every ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seconds";
            // 
            // ChkAutoCheckForUpdates
            // 
            this.ChkAutoCheckForUpdates.AutoSize = true;
            this.ChkAutoCheckForUpdates.Location = new System.Drawing.Point(7, 71);
            this.ChkAutoCheckForUpdates.Name = "ChkAutoCheckForUpdates";
            this.ChkAutoCheckForUpdates.Size = new System.Drawing.Size(177, 17);
            this.ChkAutoCheckForUpdates.TabIndex = 4;
            this.ChkAutoCheckForUpdates.Text = "Automatically check for updates";
            this.ChkAutoCheckForUpdates.UseVisualStyleBackColor = true;
            this.ChkAutoCheckForUpdates.CheckedChanged += new System.EventHandler(this.ChkAutoCheckForUpdates_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update every ";
            // 
            // TxtAutoCheckForUpdatesInterval
            // 
            this.TxtAutoCheckForUpdatesInterval.Location = new System.Drawing.Point(86, 94);
            this.TxtAutoCheckForUpdatesInterval.Name = "TxtAutoCheckForUpdatesInterval";
            this.TxtAutoCheckForUpdatesInterval.Size = new System.Drawing.Size(43, 20);
            this.TxtAutoCheckForUpdatesInterval.TabIndex = 5;
            this.TxtAutoCheckForUpdatesInterval.TextChanged += new System.EventHandler(this.TxtAutoCheckForUpdatesInterval_TextChanged);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnUpdateEmoticons;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 268);
            this.Controls.Add(this.GpSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpEmoticons);
            this.Controls.Add(this.GrpProgram);
            this.Controls.Add(this.GrpStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jabber Emoticons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpEmoticons.ResumeLayout(false);
            this.GrpProgram.ResumeLayout(false);
            this.GrpStatus.ResumeLayout(false);
            this.GrpStatus.PerformLayout();
            this.GpSettings.ResumeLayout(false);
            this.GpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Label LblProgramPre;
        private System.Windows.Forms.Label LblEmotionPre;
        private System.Windows.Forms.Label LblNoOfEmoticonsPre;
        private System.Windows.Forms.Button BtnUpdateEmoticons;
        private System.Windows.Forms.Label LblNoOfEmoticons;
        private System.Windows.Forms.Label LblProgVer;
        private System.Windows.Forms.Label LblEmoVer;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdateProg;
        private System.Windows.Forms.GroupBox GrpEmoticons;
        private System.Windows.Forms.Button BtnAddEmoticons;
        private System.Windows.Forms.GroupBox GrpProgram;
        private System.Windows.Forms.GroupBox GrpStatus;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDebug;
        private System.Windows.Forms.GroupBox GpSettings;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAutoUpdateEmoticonInterval;
        private System.Windows.Forms.CheckBox ChkAutoUpdateEmoticon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAutoCheckForUpdatesInterval;
        private System.Windows.Forms.CheckBox ChkAutoCheckForUpdates;
    }
}