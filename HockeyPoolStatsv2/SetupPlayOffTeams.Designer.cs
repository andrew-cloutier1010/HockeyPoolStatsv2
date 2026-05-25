namespace HockeyPoolStatsv2
{
    partial class SetupPlayOffTeams
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamAbbrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPlayoffTeam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName,
            this.TeamAbbrev,
            this.IsPlayoffTeam,
            this.Eliminated});
            this.dataGridView2.Location = new System.Drawing.Point(8, 11);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(675, 504);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 526);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.MinimumWidth = 8;
            this.TeamName.Name = "TeamName";
            // 
            // TeamAbbrev
            // 
            this.TeamAbbrev.DataPropertyName = "TeamAbbrev";
            this.TeamAbbrev.HeaderText = "Team Abbrev";
            this.TeamAbbrev.MinimumWidth = 8;
            this.TeamAbbrev.Name = "TeamAbbrev";
            // 
            // IsPlayoffTeam
            // 
            this.IsPlayoffTeam.DataPropertyName = "IsPlayoffTeam";
            this.IsPlayoffTeam.HeaderText = "Playoff Team";
            this.IsPlayoffTeam.MinimumWidth = 8;
            this.IsPlayoffTeam.Name = "IsPlayoffTeam";
            this.IsPlayoffTeam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPlayoffTeam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminated
            // 
            this.Eliminated.DataPropertyName = "Eliminated";
            this.Eliminated.HeaderText = "Eliminated";
            this.Eliminated.Name = "Eliminated";
            // 
            // SetupPlayOffTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SetupPlayOffTeams";
            this.Text = "SetupPlayOffTeams";
            this.Load += new System.EventHandler(this.SetupPlayOffTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAbbrev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPlayoffTeam;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminated;
    }
}