
namespace Fortnite_Resolution_Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verticalTb = new System.Windows.Forms.TextBox();
            this.horizontalTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.testResBtn = new System.Windows.Forms.Button();
            this.launchBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backupBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerValueTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noteLbl = new System.Windows.Forms.Label();
            this.importantNoteLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mouseAccelCb = new System.Windows.Forms.CheckBox();
            this.motionBlurCb = new System.Windows.Forms.CheckBox();
            this.showGrassCb = new System.Windows.Forms.CheckBox();
            this.vsyncCb = new System.Windows.Forms.CheckBox();
            this.fullscreenCb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.processPb = new System.Windows.Forms.PictureBox();
            this.versionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processPb)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Title.Location = new System.Drawing.Point(93, 47);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(193, 56);
            this.Title.TabIndex = 0;
            this.Title.Text = "Fortnite\r\n";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(202, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertical";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verticalTb
            // 
            this.verticalTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verticalTb.BackColor = System.Drawing.Color.White;
            this.verticalTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalTb.ForeColor = System.Drawing.Color.Black;
            this.verticalTb.Location = new System.Drawing.Point(203, 127);
            this.verticalTb.MaxLength = 4;
            this.verticalTb.Name = "verticalTb";
            this.verticalTb.Size = new System.Drawing.Size(91, 23);
            this.verticalTb.TabIndex = 3;
            this.verticalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verticalTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // horizontalTb
            // 
            this.horizontalTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.horizontalTb.BackColor = System.Drawing.Color.White;
            this.horizontalTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalTb.ForeColor = System.Drawing.Color.Black;
            this.horizontalTb.Location = new System.Drawing.Point(90, 127);
            this.horizontalTb.MaxLength = 4;
            this.horizontalTb.Name = "horizontalTb";
            this.horizontalTb.Size = new System.Drawing.Size(91, 23);
            this.horizontalTb.TabIndex = 2;
            this.horizontalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horizontalTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horizontal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            this.toolTip.InitialDelay = 350;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openFolderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.openFolderBtn.BackgroundImage = global::Fortnite_Resolution_Launcher.Properties.Resources.document;
            this.openFolderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openFolderBtn.FlatAppearance.BorderSize = 0;
            this.openFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderBtn.ForeColor = System.Drawing.Color.Transparent;
            this.openFolderBtn.Location = new System.Drawing.Point(125, 296);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(61, 58);
            this.openFolderBtn.TabIndex = 21;
            this.toolTip.SetToolTip(this.openFolderBtn, "Open config folder");
            this.openFolderBtn.UseVisualStyleBackColor = false;
            this.openFolderBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openFolderBtn_MouseClick);
            // 
            // testResBtn
            // 
            this.testResBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.testResBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testResBtn.BackColor = System.Drawing.Color.Transparent;
            this.testResBtn.BackgroundImage = global::Fortnite_Resolution_Launcher.Properties.Resources.desktop;
            this.testResBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testResBtn.FlatAppearance.BorderSize = 0;
            this.testResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testResBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testResBtn.ForeColor = System.Drawing.Color.Transparent;
            this.testResBtn.Location = new System.Drawing.Point(208, 296);
            this.testResBtn.Name = "testResBtn";
            this.testResBtn.Size = new System.Drawing.Size(61, 58);
            this.testResBtn.TabIndex = 14;
            this.toolTip.SetToolTip(this.testResBtn, "Test the selected resolution");
            this.testResBtn.UseVisualStyleBackColor = false;
            this.testResBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.testResBtn_MouseClick);
            // 
            // launchBtn
            // 
            this.launchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.launchBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.launchBtn.BackColor = System.Drawing.Color.Transparent;
            this.launchBtn.BackgroundImage = global::Fortnite_Resolution_Launcher.Properties.Resources.launch;
            this.launchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.launchBtn.FlatAppearance.BorderSize = 0;
            this.launchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.launchBtn.Location = new System.Drawing.Point(243, 358);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(61, 58);
            this.launchBtn.TabIndex = 7;
            this.toolTip.SetToolTip(this.launchBtn, "Launch the game");
            this.launchBtn.UseVisualStyleBackColor = false;
            this.launchBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.launchBtn_MouseClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImage = global::Fortnite_Resolution_Launcher.Properties.Resources.save;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Transparent;
            this.saveBtn.Location = new System.Drawing.Point(161, 358);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(61, 58);
            this.saveBtn.TabIndex = 6;
            this.toolTip.SetToolTip(this.saveBtn, "Save config file");
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveBtn_MouseClick);
            // 
            // backupBtn
            // 
            this.backupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backupBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backupBtn.BackColor = System.Drawing.Color.Transparent;
            this.backupBtn.BackgroundImage = global::Fortnite_Resolution_Launcher.Properties.Resources.backup;
            this.backupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backupBtn.FlatAppearance.BorderSize = 0;
            this.backupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backupBtn.Location = new System.Drawing.Point(84, 358);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(61, 58);
            this.backupBtn.TabIndex = 5;
            this.toolTip.SetToolTip(this.backupBtn, "Backup config file");
            this.backupBtn.UseVisualStyleBackColor = false;
            this.backupBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backupBtn_MouseClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Fortnite Resolution Launcher";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(182, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 6300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerValueTb
            // 
            this.timerValueTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timerValueTb.BackColor = System.Drawing.Color.White;
            this.timerValueTb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerValueTb.ForeColor = System.Drawing.Color.Black;
            this.timerValueTb.Location = new System.Drawing.Point(141, 206);
            this.timerValueTb.MaxLength = 5;
            this.timerValueTb.Name = "timerValueTb";
            this.timerValueTb.Size = new System.Drawing.Size(91, 23);
            this.timerValueTb.TabIndex = 4;
            this.timerValueTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerValueTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(137, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Timer value";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteLbl
            // 
            this.noteLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noteLbl.Location = new System.Drawing.Point(70, 232);
            this.noteLbl.Name = "noteLbl";
            this.noteLbl.Size = new System.Drawing.Size(234, 56);
            this.noteLbl.TabIndex = 10;
            this.noteLbl.Text = "Note: @ is the value recommended using. \r\nIf your PC is slower or your desktop re" +
    "solution\r\nis changing while the game is still opening\r\nconsider increasing this " +
    "value by hundreds.\r\n";
            this.noteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // importantNoteLbl
            // 
            this.importantNoteLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.importantNoteLbl.Location = new System.Drawing.Point(61, 153);
            this.importantNoteLbl.Name = "importantNoteLbl";
            this.importantNoteLbl.Size = new System.Drawing.Size(262, 35);
            this.importantNoteLbl.TabIndex = 11;
            this.importantNoteLbl.Text = "Note: If you\'re selecting a custom resolution you have\r\nto create it first in you" +
    "r graphics control panel!\r\n";
            this.importantNoteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fortnite process: ";
            // 
            // mouseAccelCb
            // 
            this.mouseAccelCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseAccelCb.AutoSize = true;
            this.mouseAccelCb.BackColor = System.Drawing.Color.Transparent;
            this.mouseAccelCb.Location = new System.Drawing.Point(253, 18);
            this.mouseAccelCb.Name = "mouseAccelCb";
            this.mouseAccelCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mouseAccelCb.Size = new System.Drawing.Size(119, 17);
            this.mouseAccelCb.TabIndex = 15;
            this.mouseAccelCb.Text = "Mouse acceleration";
            this.mouseAccelCb.UseVisualStyleBackColor = false;
            // 
            // motionBlurCb
            // 
            this.motionBlurCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.motionBlurCb.AutoSize = true;
            this.motionBlurCb.BackColor = System.Drawing.Color.Transparent;
            this.motionBlurCb.Location = new System.Drawing.Point(294, 33);
            this.motionBlurCb.Name = "motionBlurCb";
            this.motionBlurCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.motionBlurCb.Size = new System.Drawing.Size(78, 17);
            this.motionBlurCb.TabIndex = 16;
            this.motionBlurCb.Text = "Motion blur";
            this.motionBlurCb.UseVisualStyleBackColor = false;
            // 
            // showGrassCb
            // 
            this.showGrassCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGrassCb.AutoSize = true;
            this.showGrassCb.BackColor = System.Drawing.Color.Transparent;
            this.showGrassCb.Location = new System.Drawing.Point(291, 49);
            this.showGrassCb.Name = "showGrassCb";
            this.showGrassCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showGrassCb.Size = new System.Drawing.Size(81, 17);
            this.showGrassCb.TabIndex = 17;
            this.showGrassCb.Text = "Show grass";
            this.showGrassCb.UseVisualStyleBackColor = false;
            // 
            // vsyncCb
            // 
            this.vsyncCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vsyncCb.AutoSize = true;
            this.vsyncCb.BackColor = System.Drawing.Color.Transparent;
            this.vsyncCb.Location = new System.Drawing.Point(312, 64);
            this.vsyncCb.Name = "vsyncCb";
            this.vsyncCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vsyncCb.Size = new System.Drawing.Size(60, 17);
            this.vsyncCb.TabIndex = 18;
            this.vsyncCb.Text = "V-Sync";
            this.vsyncCb.UseVisualStyleBackColor = false;
            // 
            // fullscreenCb
            // 
            this.fullscreenCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreenCb.AutoSize = true;
            this.fullscreenCb.BackColor = System.Drawing.Color.Transparent;
            this.fullscreenCb.Location = new System.Drawing.Point(298, 2);
            this.fullscreenCb.Name = "fullscreenCb";
            this.fullscreenCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fullscreenCb.Size = new System.Drawing.Size(74, 17);
            this.fullscreenCb.TabIndex = 19;
            this.fullscreenCb.Text = "Fullscreen";
            this.fullscreenCb.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Made by: Gui1herme#8721 | @guihslk";
            // 
            // processPb
            // 
            this.processPb.Image = global::Fortnite_Resolution_Launcher.Properties.Resources.red_circle;
            this.processPb.Location = new System.Drawing.Point(86, 3);
            this.processPb.Name = "processPb";
            this.processPb.Size = new System.Drawing.Size(15, 15);
            this.processPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processPb.TabIndex = 13;
            this.processPb.TabStop = false;
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.BackColor = System.Drawing.Color.Transparent;
            this.versionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.Location = new System.Drawing.Point(3, 33);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(56, 13);
            this.versionLbl.TabIndex = 22;
            this.versionLbl.Text = "Version @";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 428);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fullscreenCb);
            this.Controls.Add(this.vsyncCb);
            this.Controls.Add(this.showGrassCb);
            this.Controls.Add(this.motionBlurCb);
            this.Controls.Add(this.mouseAccelCb);
            this.Controls.Add(this.testResBtn);
            this.Controls.Add(this.processPb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.importantNoteLbl);
            this.Controls.Add(this.noteLbl);
            this.Controls.Add(this.timerValueTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.launchBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.horizontalTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verticalTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortnite Resolution Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Launcher_FormClosed);
            this.Resize += new System.EventHandler(this.Launcher_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.processPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox verticalTb;
        private System.Windows.Forms.TextBox horizontalTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox timerValueTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label noteLbl;
        private System.Windows.Forms.Label importantNoteLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox processPb;
        private System.Windows.Forms.Button testResBtn;
        private System.Windows.Forms.CheckBox mouseAccelCb;
        private System.Windows.Forms.CheckBox motionBlurCb;
        private System.Windows.Forms.CheckBox showGrassCb;
        private System.Windows.Forms.CheckBox vsyncCb;
        private System.Windows.Forms.CheckBox fullscreenCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button openFolderBtn;
        private System.Windows.Forms.Label versionLbl;
    }
}

