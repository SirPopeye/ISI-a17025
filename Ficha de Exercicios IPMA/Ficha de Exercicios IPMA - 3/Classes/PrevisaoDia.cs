using Ficha_de_Exercicios_IPMA___3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PrevisaoDia
    {
        public string precipitaProb { get; set; }
        public Temperatura temperatura { get; set; }
        public string predWindDir { get; set; }
        public int idWeatherType { get; set; }
        public int classWindSpeed { get; set; }
        public string longitude { get; set; }
        public string forecastDate { get; set; }
        public int classPrecInt { get; set; }
        public string latitude { get; set; }

        public PrevisaoDia()
        {
            this.temperatura = new Temperatura();
        }
    }
}
