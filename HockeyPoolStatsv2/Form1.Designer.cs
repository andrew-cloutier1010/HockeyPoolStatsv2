namespace HockeyPoolStatsv2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_PlayoffYear = new System.Windows.Forms.Label();
            this.lbl_TeamsGeneratedStatus = new System.Windows.Forms.Label();
            this.lbl_PlayersGeneratedStatus = new System.Windows.Forms.Label();
            this.clearAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStatsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Playoff Year";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generate Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "Select Playoff Teams";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Setup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(133, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yearly Setup";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 75);
            this.button4.TabIndex = 3;
            this.button4.Text = "Generate Players";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(427, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daily Uses";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 75);
            this.button5.TabIndex = 6;
            this.button5.Text = "Generate Points CSV";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(14, 197);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(56, 20);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.clearAllDataToolStripMenuItem,
            this.openStatsFolderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_PlayersGeneratedStatus);
            this.groupBox4.Controls.Add(this.lbl_TeamsGeneratedStatus);
            this.groupBox4.Controls.Add(this.lbl_PlayoffYear);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(544, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(828, 139);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playoff Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teams Generated:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Players Generated:";
            // 
            // lbl_PlayoffYear
            // 
            this.lbl_PlayoffYear.AutoSize = true;
            this.lbl_PlayoffYear.Location = new System.Drawing.Point(219, 25);
            this.lbl_PlayoffYear.Name = "lbl_PlayoffYear";
            this.lbl_PlayoffYear.Size = new System.Drawing.Size(137, 30);
            this.lbl_PlayoffYear.TabIndex = 3;
            this.lbl_PlayoffYear.Text = "PlayoffYear";
            // 
            // lbl_TeamsGeneratedStatus
            // 
            this.lbl_TeamsGeneratedStatus.AutoSize = true;
            this.lbl_TeamsGeneratedStatus.Location = new System.Drawing.Point(219, 55);
            this.lbl_TeamsGeneratedStatus.Name = "lbl_TeamsGeneratedStatus";
            this.lbl_TeamsGeneratedStatus.Size = new System.Drawing.Size(51, 20);
            this.lbl_TeamsGeneratedStatus.TabIndex = 4;
            this.lbl_TeamsGeneratedStatus.Text = "label5";
            // 
            // lbl_PlayersGeneratedStatus
            // 
            this.lbl_PlayersGeneratedStatus.AutoSize = true;
            this.lbl_PlayersGeneratedStatus.Location = new System.Drawing.Point(219, 85);
            this.lbl_PlayersGeneratedStatus.Name = "lbl_PlayersGeneratedStatus";
            this.lbl_PlayersGeneratedStatus.Size = new System.Drawing.Size(51, 20);
            this.lbl_PlayersGeneratedStatus.TabIndex = 5;
            this.lbl_PlayersGeneratedStatus.Text = "label6";
            // 
            // clearAllDataToolStripMenuItem
            // 
            this.clearAllDataToolStripMenuItem.Name = "clearAllDataToolStripMenuItem";
            this.clearAllDataToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.clearAllDataToolStripMenuItem.Text = "Clear All Data";
            this.clearAllDataToolStripMenuItem.Click += new System.EventHandler(this.clearAllDataToolStripMenuItem_Click);
            // 
            // openStatsFolderToolStripMenuItem
            // 
            this.openStatsFolderToolStripMenuItem.Name = "openStatsFolderToolStripMenuItem";
            this.openStatsFolderToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.openStatsFolderToolStripMenuItem.Text = "Open Stats Folder";
            this.openStatsFolderToolStripMenuItem.Click += new System.EventHandler(this.openStatsFolderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 231);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hockey Pool Stats v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PlayersGeneratedStatus;
        private System.Windows.Forms.Label lbl_TeamsGeneratedStatus;
        private System.Windows.Forms.Label lbl_PlayoffYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clearAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStatsFolderToolStripMenuItem;
    }
}

