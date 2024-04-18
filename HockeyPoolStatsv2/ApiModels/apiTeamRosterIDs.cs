using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPoolStatsv2
{
    public class apiTeamRosterIDs
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class BirthCity
        {
            public string @default { get; set; }
            public string cs { get; set; }
            public string de { get; set; }
            public string fi { get; set; }
            public string sk { get; set; }
            public string sv { get; set; }
        }

        public class BirthStateProvince
        {
            public string @default { get; set; }
            public string fr { get; set; }
            public string sk { get; set; }
        }

        public class Defenseman
        {
            public int id { get; set; }
            public string headshot { get; set; }
            public FirstName firstName { get; set; }
            public LastName lastName { get; set; }
            public int sweaterNumber { get; set; }
            public string positionCode { get; set; }
            public string shootsCatches { get; set; }
            public int heightInInches { get; set; }
            public int weightInPounds { get; set; }
            public int heightInCentimeters { get; set; }
            public int weightInKilograms { get; set; }
            public string birthDate { get; set; }
            public BirthCity birthCity { get; set; }
            public string birthCountry { get; set; }
            public BirthStateProvince birthStateProvince { get; set; }
        }

        public class FirstName
        {
            public string @default { get; set; }
        }

        public class Forward
        {
            public int id { get; set; }
            public string headshot { get; set; }
            public FirstName firstName { get; set; }
            public LastName lastName { get; set; }
            public int sweaterNumber { get; set; }
            public string positionCode { get; set; }
            public string shootsCatches { get; set; }
            public int heightInInches { get; set; }
            public int weightInPounds { get; set; }
            public int heightInCentimeters { get; set; }
            public int weightInKilograms { get; set; }
            public string birthDate { get; set; }
            public BirthCity birthCity { get; set; }
            public string birthCountry { get; set; }
            public BirthStateProvince birthStateProvince { get; set; }
        }

        public class Goaly
        {
            public int id { get; set; }
            public string headshot { get; set; }
            public FirstName firstName { get; set; }
            public LastName lastName { get; set; }
            public int sweaterNumber { get; set; }
            public string positionCode { get; set; }
            public string shootsCatches { get; set; }
            public int heightInInches { get; set; }
            public int weightInPounds { get; set; }
            public int heightInCentimeters { get; set; }
            public int weightInKilograms { get; set; }
            public string birthDate { get; set; }
            public BirthCity birthCity { get; set; }
            public string birthCountry { get; set; }
            public BirthStateProvince birthStateProvince { get; set; }
        }

        public class LastName
        {
            public string @default { get; set; }
            public string sv { get; set; }
        }

        public class Root2
        {
            public List<Forward> forwards { get; set; }
            public List<Defenseman> defensemen { get; set; }
            public List<Goaly> goalies { get; set; }
        }




    }
}
