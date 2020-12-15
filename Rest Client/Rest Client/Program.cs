using Nancy.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Rest_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VAR
            //Suportar Pedido e URI
            HttpWebRequest request;
            StringBuilder uri;
            string url;
            string apiKey = "b4e56d454f9ddc1a5b66102f99f28fa2";
            #endregion

            //Weather URL
            url = "http://api.openweathermap.org/data/2.5/weather?q=[City]&appid=[APIKEY]";

            #region ConstroiURI
            uri = new StringBuilder();
            uri.Append(url);
            uri.Replace("[City]", HttpUtility.UrlEncode("Barcelos"));
            uri.Replace("[APIKEY]", apiKey);
            #endregion
            request = WebRequest.Create(uri.ToString()) as HttpWebRequest;

            #region EnviaPedidoAnalisaResposta
            //analisa resposta
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }
                //Se for JSON

                Console.WriteLine("Recebido:");
                //Mostra JSON bruto
                string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Console.WriteLine(content);
                //ou 
                //Console.WriteLine(GetPageAsString(uri.ToString()));

                //Serializa de JSON para Objecto

                Root weather = JsonConvert.DeserializeObject<Root>(content);

                Console.WriteLine(weather.name);
            }
            #endregion

            Console.ReadKey();
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

}