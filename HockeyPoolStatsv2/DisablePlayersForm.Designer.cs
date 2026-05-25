namespace HockeyPoolStatsv2
{
    partial class DisablePlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisablePlayersForm));
            this.playersGrid = new System.Windows.Forms.DataGridView();
            this.TeamAbbrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shutouts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_teams = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // playersGrid
            // 
            this.playersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamAbbrev,
            this.PlayerID,
            this.TeamName,
            this.FullName,
            this.Goals,
            this.Assists,
            this.Points,
            this.Shutouts,
            this.Wins,
            this.Position,
            this.gridEnabled});
            this.playersGrid.Location = new System.Drawing.Point(9, 56);
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.RowHeadersWidth = 62;
            this.playersGrid.Size = new System.Drawing.Size(902, 536);
            this.playersGrid.TabIndex = 0;
            this.playersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playersGrid_CellContentClick);
            // 
            // TeamAbbrev
            // 
            this.TeamAbbrev.DataPropertyName = "TeamAbbrev";
            this.TeamAbbrev.HeaderText = "TeamAbbrev";
            this.TeamAbbrev.MinimumWidth = 8;
            this.TeamAbbrev.Name = "TeamAbbrev";
            this.TeamAbbrev.ReadOnly = true;
            this.TeamAbbrev.Visible = false;
            // 
            // PlayerID
            // 
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.HeaderText = "PlayerID";
            this.PlayerID.MinimumWidth = 8;
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            this.PlayerID.Visible = false;
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.MinimumWidth = 8;
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Goals
            // 
            this.Goals.DataPropertyName = "Goals";
            this.Goals.HeaderText = "Goals";
            this.Goals.MinimumWidth = 8;
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            this.Goals.Visible = false;
            // 
            // Assists
            // 
            this.Assists.DataPropertyName = "Assists";
            this.Assists.HeaderText = "Assists";
            this.Assists.MinimumWidth = 8;
            this.Assists.Name = "Assists";
            this.Assists.ReadOnly = true;
            this.Assists.Visible = false;
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Points";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Visible = false;
            // 
            // Shutouts
            // 
            this.Shutouts.DataPropertyName = "Shutouts";
            this.Shutouts.HeaderText = "Shutouts";
            this.Shutouts.MinimumWidth = 8;
            this.Shutouts.Name = "Shutouts";
            this.Shutouts.ReadOnly = true;
            this.Shutouts.Visible = false;
            // 
            // Wins
            // 
            this.Wins.DataPropertyName = "Wins";
            this.Wins.HeaderText = "Wins";
            this.Wins.MinimumWidth = 8;
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            this.Wins.Visible = false;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 8;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // gridEnabled
            // 
            this.gridEnabled.DataPropertyName = "Enabled";
            this.gridEnabled.HeaderText = "Enabled";
            this.gridEnabled.MinimumWidth = 8;
            this.gridEnabled.Name = "gridEnabled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name:";
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(88, 6);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(181, 20);
            this.txt_PlayerName.TabIndex = 2;
            this.txt_PlayerName.TextChanged += new System.EventHandler(this.txt_PlayerName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team:";
            // 
            // txt_teams
            // 
            this.txt_teams.Location = new System.Drawing.Point(88, 31);
            this.txt_teams.Name = "txt_teams";
            this.txt_teams.Size = new System.Drawing.Size(181, 20);
            this.txt_teams.TabIndex = 4;
            this.txt_teams.TextChanged += new System.EventHandler(this.txt_teams_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enable All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Disable All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisablePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_teams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playersGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisablePlayersForm";
            this.Text = "DisablePlayersForm";
            this.Load += new System.EventHandler(this.DisablePlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playersGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teams;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAbbrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shutouts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridEnabled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}