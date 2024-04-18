using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPoolStatsv2
{
    public class Settings
    {

        public string PlayoffYear { get; set; }
        public string ApiUrl { get; set; }

        public Settings()
        {

            PlayoffYear = ConfigurationManager.AppSettings["PlayoffYear"];
            ApiUrl = ConfigurationManager.AppSettings["ApiUri"];
            if (ApiUrl == null)
            {
                ApiUrl = "https://api-web.nhle.com";
            }
            if (!ApiUrl.EndsWith("/"))
            {
                ApiUrl += "/";
            }

        }

        public static void SaveSetting(string Name, string Value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[Name].Value = Value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
