/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LocalProcessor
    {
        /// <summary>
        /// Loads Locais from api.ipma.pt
        /// </summary>
        /// <returns></returns>
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
