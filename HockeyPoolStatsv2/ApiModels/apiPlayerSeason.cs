using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPoolStatsv2.ApiModels
{
    public class apiPlayerSeason
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
            public int points { get; set; }
            public int plusMinus { get; set; }
            public int powerPlayGoals { get; set; }
            public int powerPlayPoints { get; set; }
            public int gameWinningGoals { get; set; }
            public int otGoals { get; set; }
            public int shots { get; set; }
            public int shifts { get; set; }
            public int shorthandedGoals { get; set; }
            public int shorthandedPoints { get; set; }
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

        public class Root5
        {
            public int seasonId { get; set; }
            public int gameTypeId { get; set; }
            public List<PlayerStatsSeason> playerStatsSeasons { get; set; }
            public List<GameLog> gameLog { get; set; }
        }


    }
}
