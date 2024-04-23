using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPoolStatsv2
{
    public class TeamRosters
    {

        public string TeamAbbrev { get; set; }
        public int PlayerID { get; set; }   
        public string TeamName { get; set; }
        public string FullName { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public int Shutouts { get; set; }
        public int Wins { get; set; }
        public string Position { get; set; }
        public bool Enabled { get; set; }

    }
}
