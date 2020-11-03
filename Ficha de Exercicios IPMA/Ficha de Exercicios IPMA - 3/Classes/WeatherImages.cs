using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

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
            if (id == 3) return "03";
            if (new[] { 5, 24, 25, 27 }.All(x => x == id)) return "04";
            if (new[] { 6, 8, 9, 11, 14 }.All(x => x == id)) return "09";
            if (new[] { 7, 10, 12, 13, 15 }.All(x => x == id)) return "10";
            if (new[] { 19, 20, 23 }.All(x => x == id)) return "11";
            if (new[] { 28, 21, 22 }.All(x => x == id)) return "13";
            if (new[] { 16, 17, 26 }.All(x => x == id)) return "50";
            return "-1";
        }
    }
}
