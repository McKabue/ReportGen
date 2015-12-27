using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AutoDocx.Tools.Security
{
    public class Trial
    {
        private static HttpMessageHandler _httpClientHandler;

        public static DateTime Now { get { return DateTime.UtcNow; } }
        public static DateTime ExpirationDate { get { return DateTime.UtcNow.AddDays(7); } }


        public async static Task<bool> CheckTrial()
        {

            string apiBaseAddress = "http://localhost:57124/";

            CustomDelegatingHandler customDelegatingHandler = new CustomDelegatingHandler();

            HttpClient client = HttpClientFactory.Create(customDelegatingHandler);

            object pandlock = "pandlock";

            HttpResponseMessage response = await client.PostAsJsonAsync(apiBaseAddress + "api/AppRegistry/Register", pandlock);

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();

                return true;
            }
            else
            {
                string responseString = String.Format("Failed to call the API. HTTP Status: {0}, Reason {1}", response.StatusCode, response.ReasonPhrase);

                return false;
            }






            Licence _licence = new Licence();
            if (_licence.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                


                _licence.Dispose();
            }

            return true;
        }
    }
}
