/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PrevisaoProcessor
    {
        /// <summary>
        /// Loads weather forecast from api.ipma.pt
        /// </summary>
        /// <param name="globalIdLocal"></param>
        /// <returns></returns>
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
