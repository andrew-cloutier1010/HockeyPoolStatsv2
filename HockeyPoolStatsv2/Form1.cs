using HockeyPoolStatsv2.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HockeyPoolStatsv2.apiGoalie;
using static HockeyPoolStatsv2.ApiModels.apiGoalieSeason;
using static HockeyPoolStatsv2.ApiModels.apiPlayerSeason;
using static HockeyPoolStatsv2.apiPlayers;
using static HockeyPoolStatsv2.apiTeamRosterIDs;
using static HockeyPoolStatsv2.apiTeams;

namespace HockeyPoolStatsv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Settings set;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialSetup();
            set = new Settings();
            lbl_status.Visible = false;
            LoadStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetPlayoffYear setPlayoffYear = new SetPlayoffYear();
            setPlayoffYear.ShowDialog();
            set = new Settings();
            LoadStatus();

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            set = new Settings();
            lbl_status.Visible = true;
            lbl_status.Text = "Generating Teams...Please wait.";


            if (System.IO.File.Exists(String.Format(@"{0}\Data\Teams.json", Application.StartupPath)))
            {
                // Need to ask the user if they want to continue
                DialogResult dialogResult = MessageBox.Show("This will delete the current list of teams and replace it with the current NHL teams. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    lbl_status.Text = "Generating Teams cancelled by user...";
                    return;
                }
            }

            // if Teams.json exists I need to delete it
            if (System.IO.File.Exists(String.Format(@"{0}\Data\Teams.json", Application.StartupPath)))
            {
                System.IO.File.Delete(String.Format(@"{0}\Data\Teams.json", Application.StartupPath));
            }

            ApiCall apiCall = new ApiCall();
            var responseBody = await apiCall.ReturnApiJsonAsync("v1/standings/now");

            // Process the response body here
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseBody);
            // loop through and populate my Teams.cs now....
            List<Teams> MyTeams = new List<Teams>();
            foreach (var item in myDeserializedClass.standings)
            {
                Teams team = new Teams();
                team.TeamName = item.teamName.@default;
                team.TeamAbbrev = item.teamAbbrev.@default;
                team.IsPlayoffTeam = false;
                MyTeams.Add(team);
            }
            // now we have the list of teams to work with. I need to save it as json
            string json = JsonConvert.SerializeObject(MyTeams);
            System.IO.File.WriteAllText(String.Format(@"{0}\Data\Teams.json", Application.StartupPath), json);


            lbl_status.Text = "Team generation complete. You will need to select playoff teams.";
            LoadStatus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            set = new Settings();
            SetupPlayOffTeams setupPlayOffTeams = new SetupPlayOffTeams();
            setupPlayOffTeams.ShowDialog();
            LoadStatus();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            set = new Settings();
            lbl_status.Visible = true;
            lbl_status.Text = "Generating Players...Please wait.";

            // if Teams.json exists I need to delete it
            if (System.IO.File.Exists(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath)))
            {
                System.IO.File.Delete(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
            }

            // Read the JSON file
            if (!System.IO.File.Exists(String.Format(@"{0}\Data\Teams.json", Application.StartupPath)))
            {
                MessageBox.Show("Teams have not been generated. Generate teams before trying to select playoff teams.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_status.Text = "Player generation complete with errors.";
                return;
            }
            string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\Teams.json", Application.StartupPath));

            // Deserialize the JSON into a list of Teams objects
            List<Teams> teamsList = JsonConvert.DeserializeObject<List<Teams>>(json);

            // Loop through the teams and perform logic on IsPlayoffTeam = true
            List<TeamRosters> teamRosters = new List<TeamRosters>();
            foreach (Teams team in teamsList)
            {
                if (team.IsPlayoffTeam)
                {
                    // Perform your logic here for playoff teams
                    ApiCall apiCall = new ApiCall();
                    var responseBody = await apiCall.ReturnApiJsonAsync("v1/roster/" + team.TeamAbbrev + "/current");

                    Root2 myDeserializedClass = JsonConvert.DeserializeObject<Root2>(responseBody);
                    foreach (var item in myDeserializedClass.forwards)
                    {
                        // getting forwards
                        TeamRosters roster = new TeamRosters();
                        roster.TeamAbbrev = team.TeamAbbrev;
                        roster.PlayerID = item.id;
                        roster.TeamName = team.TeamName;
                        roster.FullName = item.firstName.@default + " " + item.lastName.@default;
                        roster.Position = AssignPosition(item.positionCode);
                        roster.Goals = 0;
                        roster.Assists = 0;
                        roster.Shutouts = 0;
                        roster.Wins = 0;
                        roster.Points = 0;
                        roster.Enabled = true;
                        teamRosters.Add(roster);

                    }
                    foreach (var item in myDeserializedClass.defensemen)
                    {
                        // getting dfensemen
                        TeamRosters roster = new TeamRosters();
                        roster.TeamAbbrev = team.TeamAbbrev;
                        roster.PlayerID = item.id;
                        roster.TeamName = team.TeamName;
                        roster.FullName = item.firstName.@default + " " + item.lastName.@default;
                        roster.Position = AssignPosition(item.positionCode);
                        roster.Goals = 0;
                        roster.Assists = 0;
                        roster.Shutouts = 0;
                        roster.Wins = 0;
                        roster.Points = 0;
                        roster.Enabled = true;
                        teamRosters.Add(roster);
                    }
                    foreach (var item in myDeserializedClass.goalies)
                    {
                        // getting goalies
                        TeamRosters roster = new TeamRosters();
                        roster.TeamAbbrev = team.TeamAbbrev;
                        roster.PlayerID = item.id;
                        roster.TeamName = team.TeamName;
                        roster.FullName = item.firstName.@default + " " + item.lastName.@default;
                        roster.Position = AssignPosition(item.positionCode);
                        roster.Goals = 0;
                        roster.Assists = 0;
                        roster.Shutouts = 0;
                        roster.Wins = 0;
                        roster.Points = 0;
                        roster.Enabled = true;
                        teamRosters.Add(roster);
                    }

                }
            }

            // Serialize the list of TeamRosters objects to JSON
            string jsonTeamRosters = JsonConvert.SerializeObject(teamRosters);
            // save the file
            System.IO.File.WriteAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath), jsonTeamRosters);

            lbl_status.Text = "Player generation complete.";
            LoadStatus();
        }

        private async void button5_Click(object sender, EventArgs e)
        {

            set = new Settings();
            lbl_status.Visible = true;
            lbl_status.Text = "Gathering player stats...Please wait.";

            // read TeamRosters.json
            // Read the JSON file
            if (!System.IO.File.Exists(String.Format(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath))))
            {
                MessageBox.Show("Teams have not been generated. Generate teams before trying to select playoff teams.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_status.Text = "Gathering player stats complete with errors.";
                return;
            }
            string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
            // make a list of teamrosters
            List<TeamRosters> teamRosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
            int count = 0;
            Stopwatch watch = new Stopwatch();
            foreach (var item in teamRosters)
            {
                watch.Start();
                count++;
                lbl_status.Text = "Progress: " + count.ToString() + "/" + teamRosters.Count.ToString();


                // Player has been disabled. Skipping them.
                if (!item.Enabled) { continue;  }


                // I need to hit the player API to get the points for that player for this playoff season...
                // Perform your logic here for playoff teams
                ApiCall apiCall = new ApiCall();
                string responseBody = await apiCall.ReturnApiJsonAsync("v1/player/" + item.PlayerID + "/landing");

                // Process the response body here
                if (item.Position == "Goalie")
                {
                    Root4 myDeserializedClass = JsonConvert.DeserializeObject<Root4>(responseBody);
                    foreach (var season in myDeserializedClass.seasonTotals)
                    {

                        if (season.season == Convert.ToInt32(set.PlayoffYear))
                        {
                            // we found the season, checking the game type.
                            if (season.gameTypeId == 3)
                            {
                                // this is the playoff season.
                                // I need to find this player in teamRosters and update their points.
                                foreach (var player in teamRosters)
                                {
                                    if (player.PlayerID == item.PlayerID)
                                    {
                                        player.Wins = season.wins;
                                        player.Shutouts = season.shutouts;
                                    }
                                }
                            }

                        }

                    }
                }
                else
                {
                    Root3 myDeserializedClass = JsonConvert.DeserializeObject<Root3>(responseBody);
                    foreach (var season in myDeserializedClass.seasonTotals)
                    {

                        if (season.season == Convert.ToInt32(set.PlayoffYear))
                        {
                            // we found the season, checking the game type.
                            if (season.gameTypeId == 3)
                            {
                                // this is the playoff season.
                                // I need to find this player in teamRosters and update their points.
                                foreach (var player in teamRosters)
                                {
                                    if (player.PlayerID == item.PlayerID)
                                    {
                                        player.Goals = season.goals;
                                        player.Assists = season.assists;
                                        player.Points = season.points;
                                    }
                                }
                            }

                        }

                    }
                }
            }


            // Serialize the list of TeamRosters objects to JSON
            string jsonTeamRosters = JsonConvert.SerializeObject(teamRosters);
            // save the file
            System.IO.File.WriteAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath), jsonTeamRosters);

            // Save the list of TeamRosters objects to a CSV file
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("TeamAbbrev,PlayerID,TeamName,FullName,Goals,Assists,Points,Shutouts,Wins,Position");
            foreach (var item in teamRosters)
            {
                csv.AppendLine(item.TeamAbbrev + "," + item.PlayerID + "," + item.TeamName + "," + item.FullName + "," + item.Goals + "," + item.Assists + "," + item.Points + "," + item.Shutouts + "," + item.Wins + "," + item.Position);
            }

            // save the file
            if (System.IO.File.Exists(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath)))
            {
                System.IO.File.Delete(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath));
            }
            System.IO.File.WriteAllText(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath), csv.ToString());

            watch.Stop();
            double minutes = TimeSpan.FromMilliseconds(watch.ElapsedMilliseconds).TotalMinutes;
            minutes = Math.Round(minutes, 0, MidpointRounding.AwayFromZero);
            lbl_status.Text = "Gathering player stats complete. The process took: " + minutes.ToString() + " minutes.";

            LoadStatus();
        }


        // I need a function that accepts a position id and returns a string of for their position
        private string AssignPosition(string positionCode)
        {
            string position = "";
            switch (positionCode)
            {
                case "C":
                    position = "Center";
                    break;
                case "L":
                    position = "Left Wing";
                    break;
                case "R":
                    position = "Right Wing";
                    break;
                case "D":
                    position = "Defense";
                    break;
                case "G":
                    position = "Goalie";
                    break;
                default:
                    position = "Unknown";
                    break;
            }
            return position;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsUi set = new SettingsUi();
            set.ShowDialog();
        }


        private void LoadStatus()
        {

            var OldPlayoffYear = false;
            string year = set.PlayoffYear.Remove(0, 4);
            if (year != DateTime.Now.Year.ToString())
            {
                OldPlayoffYear = true;
            }

            if (set.PlayoffYear != "")
            {
                if (OldPlayoffYear)
                {
                    lbl_PlayoffYear.Text = set.PlayoffYear + " (Seems like last years Playoff year.)";
                    lbl_PlayoffYear.ForeColor = Color.DarkOrange;
                }
                else
                {
                    lbl_PlayoffYear.Text = set.PlayoffYear;
                    lbl_PlayoffYear.ForeColor = Color.Green;
                }
            }
            else
            {
                lbl_PlayoffYear.Text = "Not Set";
                lbl_PlayoffYear.ForeColor = Color.Red;
            }


            if (System.IO.File.Exists(String.Format(@"{0}\Data\Teams.json", Application.StartupPath)))
            {

                // Read the file and convert it to list of Teams
                string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\Teams.json", Application.StartupPath));
                List<Teams> teams = JsonConvert.DeserializeObject<List<Teams>>(json);
                if (teams.Count > 0)
                {
                    lbl_TeamsGeneratedStatus.Text = "Yes";
                    lbl_TeamsGeneratedStatus.ForeColor = Color.Green;
                }
                else
                {
                    lbl_TeamsGeneratedStatus.Text = "Yes (File exists but is empty. Re-generate teams.)";
                    lbl_TeamsGeneratedStatus.ForeColor = Color.DarkOrange;
                }


            }
            else
            {
                lbl_TeamsGeneratedStatus.Text = "No";
                lbl_TeamsGeneratedStatus.ForeColor = Color.Red;
            }

            if (System.IO.File.Exists(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath)))
            {
                string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                List<TeamRosters> teamRosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
                if (teamRosters.Count > 0)
                {
                    lbl_PlayersGeneratedStatus.Text = "Yes";
                    lbl_PlayersGeneratedStatus.ForeColor = Color.Green;
                }
                else
                {
                    lbl_PlayersGeneratedStatus.Text = "Yes (File exists but is empty. Make sure you have playoff teams selected.";
                    lbl_PlayersGeneratedStatus.ForeColor = Color.DarkOrange;
                }


            }
            else
            {
                lbl_PlayersGeneratedStatus.Text = "No";
                lbl_PlayersGeneratedStatus.ForeColor = Color.Red;
            }

        }

        private void InitialSetup()
        {
            if (!System.IO.Directory.Exists(String.Format(@"{0}\Data", Application.StartupPath)))
            {
                System.IO.Directory.CreateDirectory(String.Format(@"{0}\Data", Application.StartupPath));
            }
            if (!System.IO.Directory.Exists(String.Format(@"{0}\Stats", Application.StartupPath)))
            {
                System.IO.Directory.CreateDirectory(String.Format(@"{0}\Stats", Application.StartupPath));
            }
        }

        private void clearAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // I need to ask the user if they are sure they want to clear all data
            DialogResult dialogResult = MessageBox.Show("This will delete ALL data. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (System.IO.File.Exists(String.Format(@"{0}\Data\Teams.json", Application.StartupPath)))
                {
                    System.IO.File.Delete(String.Format(@"{0}\Data\Teams.json", Application.StartupPath));
                }
                if (System.IO.File.Exists(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath)))
                {
                    System.IO.File.Delete(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
                }
                if (System.IO.File.Exists(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath)))
                {
                    System.IO.File.Delete(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath));
                }

            }

            set = new Settings();
            LoadStatus();
        }

        private void openStatsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // I need to open the stats folder in explorer
            System.Diagnostics.Process.Start("explorer.exe", String.Format(@"{0}\Stats", Application.StartupPath));
        }

        private async void button6_Click(object sender, EventArgs e)
        {

            string json = System.IO.File.ReadAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath));
            // make a list of teamrosters

            List<TeamRosters> teamRosters = JsonConvert.DeserializeObject<List<TeamRosters>>(json);
            int count = 0;
            Stopwatch watch = new Stopwatch();

            lbl_status.Visible = true;
            foreach (var item in teamRosters)
            {

                count++;
                watch.Start();
                lbl_status.Text = count.ToString() + "/" + teamRosters.Count.ToString();

                ApiCall call = new ApiCall();
                string uri = string.Format("v1/player/{0}/game-log/{1}/3", item.PlayerID, set.PlayoffYear);
                var responseBody = await call.ReturnApiJsonAsync(uri);

                if (responseBody != null)
                {


                    if (item.Position == "Goalie")
                    {

                        int wins = 0;
                        int shutouts = 0;
                        if (!responseBody.Contains("GameLog")) { continue; }
                        Root6 myDeserializedClass = JsonConvert.DeserializeObject<Root6>(responseBody);
                        foreach (var game in myDeserializedClass.gameLog)
                        {
                            if (game.decision != "L")
                            {
                                wins++;
                            }
                            shutouts = game.shutouts;

                        }

                        item.Shutouts = shutouts;
                        item.Wins = wins;

                    }
                    else
                    {
                        int goals = 0;
                        int assits = 0;
                        int points = 0;

                        if (!responseBody.Contains("GameLog")) { continue; }
                        Root5 myDeserializedClass = JsonConvert.DeserializeObject<Root5>(responseBody);
                        foreach (var game in myDeserializedClass.gameLog)
                        {

                            goals += game.goals;
                            assits += game.assists;
                            points += game.points;
                        }

                        item.Goals = goals;
                        item.Assists = assits;
                        item.Points = points;

                    }

                }
            }


            // Serialize the list of TeamRosters objects to JSON
            string jsonTeamRosters = JsonConvert.SerializeObject(teamRosters);
            // save the file
            System.IO.File.WriteAllText(String.Format(@"{0}\Data\TeamRosters.json", Application.StartupPath), jsonTeamRosters);

            // Save the list of TeamRosters objects to a CSV file
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("TeamAbbrev,PlayerID,TeamName,FullName,Goals,Assists,Points,Shutouts,Wins,Position");
            foreach (var item in teamRosters)
            {
                csv.AppendLine(item.TeamAbbrev + "," + item.PlayerID + "," + item.TeamName + "," + item.FullName + "," + item.Goals + "," + item.Assists + "," + item.Points + "," + item.Shutouts + "," + item.Wins + "," + item.Position);
            }

            // save the file
            if (System.IO.File.Exists(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath)))
            {
                System.IO.File.Delete(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath));
            }
            System.IO.File.WriteAllText(String.Format(@"{0}\Stats\PlayerStats.csv", Application.StartupPath), csv.ToString());

            lbl_status.Text = "Gathering player stats complete.";
            LoadStatus();

            watch.Stop();
            lbl_status.Text = watch.ElapsedMilliseconds.ToString();


        }

        private void disablePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisablePlayersForm dplayers = new DisablePlayersForm();
            dplayers.ShowDialog();
        }
    }
}
