using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyPoolStatsv2
{
    public partial class SetupPlayOffTeams : Form
    {
        public SetupPlayOffTeams()
        {
            InitializeComponent();
        }

        private void SetupPlayOffTeams_Load(object sender, EventArgs e)
        {
            if (!File.Exists(String.Format(@"{0}\Data\Teams.json", Application.StartupPath)))
            {
                MessageBox.Show("Teams have not been generated. Generate teams before trying to select playoff teams.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            string json = File.ReadAllText(String.Format(@"{0}\Data\Teams.json", Application.StartupPath));
            List<Teams> teams = JsonConvert.DeserializeObject<List<Teams>>(json);
            // Use the 'teams' list as needed
            dataGridView2.DataSource = teams;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Teams> newTeamsList = new List<Teams>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                Teams team = new Teams();
                team.TeamName = row.Cells["TeamName"].Value.ToString();
                team.TeamAbbrev = row.Cells["TeamAbbrev"].Value.ToString();
                team.IsPlayoffTeam = Convert.ToBoolean(row.Cells["IsPlayoffTeam"].Value);
                // Set other properties of the 'team' object as needed
                newTeamsList.Add(team);
            }
            // Use the 'newTeamsList' as needed
            string json = JsonConvert.SerializeObject(newTeamsList, Formatting.Indented);
            File.WriteAllText(String.Format(@"{0}\Data\Teams.json", Application.StartupPath), json);
            this.Close();

        }
    }
}
