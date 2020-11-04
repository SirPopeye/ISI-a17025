/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using Ficha_de_Exercicios_IPMA___3.Classes;

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

        // Informação Adicional
        public string local { get; set; }

        public PrevisaoDia()
        {
            this.temperatura = new Temperatura();
        }
    }
}
