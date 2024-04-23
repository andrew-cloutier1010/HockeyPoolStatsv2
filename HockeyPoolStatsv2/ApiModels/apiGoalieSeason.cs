using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPoolStatsv2.ApiModels
{
    public class apiGoalieSeason
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CommonName
        {
            public string @default { get; set; }
        }

        public class GameLog
        {
            public int gameId { get; set; }
            public string teamAbbrev { get; set; }
            public string homeRoadFlag { get; set; }
            public string gameDate { get; set; }
            public int goals { get; set; }
            public int assists { get; set; }
            public CommonName commonName { get; set; }
            public OpponentCommonName opponentCommonName { get; set; }
            public int gamesStarted { get; set; }
            public string decision { get; set; }
            public int shotsAgainst { get; set; }
            public int goalsAgainst { get; set; }
            public double savePctg { get; set; }
            public int shutouts { get; set; }
            public string opponentAbbrev { get; set; }
            public int pim { get; set; }
            public string toi { get; set; }
        }

        public class OpponentCommonName
        {
            public string @default { get; set; }
        }

        public class PlayerStatsSeason
        {
            public int season { get; set; }
            public List<int> gameTypes { get; set; }
        }

        public class Root6
        {
            public int seasonId { get; set; }
            public int gameTypeId { get; set; }
            public List<PlayerStatsSeason> playerStatsSeasons { get; set; }
            public List<GameLog> gameLog { get; set; }
        }


    }
}
