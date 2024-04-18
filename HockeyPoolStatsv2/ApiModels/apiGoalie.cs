using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPoolStatsv2
{
    public class apiGoalie
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class BirthCity
        {
            public string @default { get; set; }
        }

        public class BirthStateProvince
        {
            public string @default { get; set; }
        }

        public class Career
        {
            public int gamesPlayed { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int otLosses { get; set; }
            public int shutouts { get; set; }
            public double goalsAgainstAvg { get; set; }
            public double savePctg { get; set; }
        }

        public class CareerTotals
        {
            public RegularSeason regularSeason { get; set; }
            public Playoffs playoffs { get; set; }
        }

        public class CurrentTeamRoster
        {
            public int playerId { get; set; }
            public LastName lastName { get; set; }
            public FirstName firstName { get; set; }
            public string playerSlug { get; set; }
        }

        public class DraftDetails
        {
            public int year { get; set; }
            public string teamAbbrev { get; set; }
            public int round { get; set; }
            public int pickInRound { get; set; }
            public int overallPick { get; set; }
        }

        public class FeaturedStats
        {
            public int season { get; set; }
            public RegularSeason regularSeason { get; set; }
        }

        public class FirstName
        {
            public string @default { get; set; }
        }

        public class FullTeamName
        {
            public string @default { get; set; }
            public string fr { get; set; }
        }

        public class Last5Game
        {
            public string decision { get; set; }
            public string gameDate { get; set; }
            public int gameId { get; set; }
            public int gameTypeId { get; set; }
            public int gamesStarted { get; set; }
            public int goalsAgainst { get; set; }
            public string homeRoadFlag { get; set; }
            public string opponentAbbrev { get; set; }
            public int penaltyMins { get; set; }
            public double savePctg { get; set; }
            public int shotsAgainst { get; set; }
            public string teamAbbrev { get; set; }
            public string toi { get; set; }
        }

        public class LastName
        {
            public string @default { get; set; }
            public string sv { get; set; }
        }

        public class Playoffs
        {
            public int gamesPlayed { get; set; }
            public int goals { get; set; }
            public int assists { get; set; }
            public int pim { get; set; }
            public int gamesStarted { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int otLosses { get; set; }
            public int shotsAgainst { get; set; }
            public int goalsAgainst { get; set; }
            public double goalsAgainstAvg { get; set; }
            public double savePctg { get; set; }
            public int shutouts { get; set; }
            public string timeOnIce { get; set; }
        }

        public class RegularSeason
        {
            public SubSeason subSeason { get; set; }
            public Career career { get; set; }
            public int gamesPlayed { get; set; }
            public int goals { get; set; }
            public int assists { get; set; }
            public int pim { get; set; }
            public int gamesStarted { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int otLosses { get; set; }
            public int shotsAgainst { get; set; }
            public int goalsAgainst { get; set; }
            public double goalsAgainstAvg { get; set; }
            public double savePctg { get; set; }
            public int shutouts { get; set; }
            public string timeOnIce { get; set; }
        }

        public class Root4
        {
            public int playerId { get; set; }
            public bool isActive { get; set; }
            public int currentTeamId { get; set; }
            public string currentTeamAbbrev { get; set; }
            public FullTeamName fullTeamName { get; set; }
            public FirstName firstName { get; set; }
            public LastName lastName { get; set; }
            public string teamLogo { get; set; }
            public int sweaterNumber { get; set; }
            public string position { get; set; }
            public string headshot { get; set; }
            public string heroImage { get; set; }
            public int heightInInches { get; set; }
            public int heightInCentimeters { get; set; }
            public int weightInPounds { get; set; }
            public int weightInKilograms { get; set; }
            public string birthDate { get; set; }
            public BirthCity birthCity { get; set; }
            public BirthStateProvince birthStateProvince { get; set; }
            public string birthCountry { get; set; }
            public string shootsCatches { get; set; }
            public DraftDetails draftDetails { get; set; }
            public string playerSlug { get; set; }
            public int inTop100AllTime { get; set; }
            public int inHHOF { get; set; }
            public FeaturedStats featuredStats { get; set; }
            public CareerTotals careerTotals { get; set; }
            public string shopLink { get; set; }
            public string twitterLink { get; set; }
            public string watchLink { get; set; }
            public List<Last5Game> last5Games { get; set; }
            public List<SeasonTotal> seasonTotals { get; set; }
            public List<CurrentTeamRoster> currentTeamRoster { get; set; }
        }

        public class SeasonTotal
        {
            public int gameTypeId { get; set; }
            public int gamesPlayed { get; set; }
            public double goalsAgainstAvg { get; set; }
            public string leagueAbbrev { get; set; }
            public double savePctg { get; set; }
            public int season { get; set; }
            public int sequence { get; set; }
            public TeamName teamName { get; set; }
            public int? goalsAgainst { get; set; }
            public int? shotsAgainst { get; set; }
            public int shutouts { get; set; }
            public string timeOnIce { get; set; }
            public int? losses { get; set; }
            public int? otLosses { get; set; }
            public int wins { get; set; }
            public int? assists { get; set; }
            public int? gamesStarted { get; set; }
            public int? goals { get; set; }
            public int? pim { get; set; }
            public int? ties { get; set; }
        }

        public class SubSeason
        {
            public int gamesPlayed { get; set; }
            public int wins { get; set; }
            public int losses { get; set; }
            public int ties { get; set; }
            public int otLosses { get; set; }
            public int shutouts { get; set; }
            public double goalsAgainstAvg { get; set; }
            public double savePctg { get; set; }
        }

        public class TeamName
        {
            public string @default { get; set; }
            public string fr { get; set; }
        }


    }
}
