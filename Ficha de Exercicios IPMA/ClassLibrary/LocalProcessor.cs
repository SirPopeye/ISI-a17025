using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LocalProcessor
    {
        public static async Task<LocalModel[]> LoadLocais()
        {
            ApiHelper apiHelper = new ApiHelper();
            apiHelper.InitializeClient();

            string url = "https://api.ipma.pt/open-data/distrits-islands.json";

            using (HttpResponseMessage response = await apiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    LocalDataModel result = await response.Content.ReadAsAsync<LocalDataModel>();
                    return result.data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
