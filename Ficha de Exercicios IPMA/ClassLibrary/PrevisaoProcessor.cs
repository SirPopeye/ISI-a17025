using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PrevisaoProcessor
    {
        public static async Task<PrevisaoIpmaModel> LoadPrevisoes(int globalIdLocal)
        {
            ApiHelper apiHelper = new ApiHelper();
            apiHelper.InitializeClient();

            string url = $"https://api.ipma.pt/open-data/forecast/meteorology/cities/daily/{globalIdLocal}.json";

            using (HttpResponseMessage response = await apiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    PrevisaoIpmaModel result = await response.Content.ReadAsAsync<PrevisaoIpmaModel>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
