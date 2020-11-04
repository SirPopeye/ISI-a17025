/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClassLibrary
{
    public class ApiHelper
    {
        public HttpClient ApiClient { get; set; }

        public void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
