using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static HockeyPoolStatsv2.apiTeams;
using System.Windows.Forms;
using System.Net;

namespace HockeyPoolStatsv2.Helpers
{
    public class ApiCall
    {


        private Settings settings;
        private string ApiUri { get; set; }


        public ApiCall()
        {
            settings = new Settings();
            ApiUri = settings.ApiUrl;
        }

        /// <summary>
        /// Makes an API call and returns the json.
        /// </summary>
        /// <returns>Returns json string.</returns>
        public async Task<string> ReturnApiJsonAsync(string endpoint)
        {

            string responseBody = "";


            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string url = ApiUri + endpoint;
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        responseBody = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve data from the API.");
                    }

                    return responseBody;
                }
            }
            catch (HttpRequestException ex)
            {

                MessageBox.Show(ex.InnerException.Message + " Please check your ApiUri and your internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return responseBody;

            }

        }
    }
}
