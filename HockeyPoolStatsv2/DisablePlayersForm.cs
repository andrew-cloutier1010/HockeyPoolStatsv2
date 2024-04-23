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
    }
}
