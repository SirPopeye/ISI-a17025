/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
namespace Ficha_de_Exercicios_IPMA___3.Classes
{
    public class WeatherImages
    {
        /// <summary>
        /// Gets Weather ID correspondece.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetCode(int id)
        {
            if (id == 1) return "01";
            if (id == 2 || id == 3) return "02";
            if (id == 4) return "03";
            if (id == 5 || id == 24 || id == 25 || id == 27) return "04";
            if (id == 6 || id == 8 || id == 9 || id == 11 || id == 14) return "09";
            if (id == 7 || id == 10 || id == 12 || id == 13 || id == 15) return "10";
            if (id == 19 || id == 20 || id == 23) return "11";
            if (id == 18 || id == 21 || id == 22) return "13";
            if (id == 16 || id == 17 || id == 26) return "50";
            return "-1";
        }
    }
}
