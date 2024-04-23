using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyPoolStatsv2
{
    public partial class DisablePlayersForm : Form
    {
        public DisablePlayersForm()
        {
            InitializeComponent();
        }

        private void DisablePlayersForm_Load(object sender, EventArgs e)
        {

            // load players.
            if (System.IO.File.Exists(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath)))
            {


                string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                List<TeamRosters> rosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
                playersGrid.DataSource = rosters;


            }
            else
            {

            }


        }

        private void txt_PlayerName_TextChanged(object sender, EventArgs e)
        {
            // I need to filter the grid based on the player name.
            if (txt_PlayerName.Text.Length > 0)
            {
                List<TeamRosters> rosters = (List<TeamRosters>)playersGrid.DataSource;

                if (rosters.Count == 0)
                {
                    string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                    rosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
                    playersGrid.DataSource = rosters;

                }

                List<TeamRosters> filteredRosters = new List<TeamRosters>();
                foreach (TeamRosters roster in rosters)
                {
                    if (roster.FullName.ToLower().Contains(txt_PlayerName.Text.ToLower()))
                    {
                        filteredRosters.Add(roster);
                    }
                }
                playersGrid.DataSource = filteredRosters;
            }
            else
            {
                string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                List<TeamRosters> rosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
                playersGrid.DataSource = rosters;
            }


        }

        private void txt_teams_TextChanged(object sender, EventArgs e)
        {
            // I need to filter the grid based on the team name and the player name.
            if (txt_teams.Text.Length > 0)
            {
                List<TeamRosters> rosters = (List<TeamRosters>)playersGrid.DataSource;
                if (rosters.Count == 0)
                {
                    string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                    rosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
                    playersGrid.DataSource = rosters;

                }

                List<TeamRosters> filteredRosters = new List<TeamRosters>();
                foreach (TeamRosters roster in rosters)
                {

                    if (roster.TeamName.ToLower().Contains(txt_teams.Text.ToLower()))
                    {
                        filteredRosters.Add(roster);
                    }
                }
                playersGrid.DataSource = filteredRosters;
            }
            else
            {
                string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                List<TeamRosters> rosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
                playersGrid.DataSource = rosters;
            }
        }


        // I need an event when gridEnabled is checked off in the grid
        private void playersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                // I need to disable the player.
                bool Status = false;
                DataGridViewRow row = playersGrid.Rows[e.RowIndex];
                TeamRosters player = (TeamRosters)row.DataBoundItem;
                if (player.Enabled)
                {
                    player.Enabled = false;
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    player.Enabled = true;
                    Status = true;
                    row.DefaultCellStyle.BackColor = Color.Green;
                }


                string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                List<TeamRosters> rosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);

                foreach (TeamRosters roster in rosters)
                {
                    if (roster.PlayerID == player.PlayerID)
                    {
                        roster.Enabled = Status;
                        break;
                    }
                }

                // Now I need th save the list as json
                string newJson = JsonConvert.SerializeObject(rosters);
                System.IO.File.WriteAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath), newJson);

            }
        }



    }
}
