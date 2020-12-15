/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
    <desc>Ficha 4 exercicio da calculadora - servico.</desc>
*/
using System;
using System.Web.Services;

namespace CalculadoraService.Services
{
    /// <summary>
    /// Summary description for Calculadora
    /// </summary>
    [WebService(Namespace = "http://ficha_4_calculadora.pt/", Description ="Serviço com funções de Calculadora.")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora : System.Web.Services.WebService
    {

        [WebMethod(Description = "Calcula a soma de dois numeros inteiros")]
        public int Adicao(int a, int b)
        {
            return a + b;
        }

        [WebMethod(Description = "Calcula a diferença entre dois numeros inteiros")]
        public int Subtracao(int a, int b)
        {
            return a - b;
        }

        [WebMethod(Description = "Calcula a multiplicaçao entre dois numeros inteiros.")]
        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        [WebMethod(Description = "Calcula a divisao entre dois numeros inteiros em que b diferente de 0.")]
        public float Divisao(int a, int b)
        {
            if (b != 0) return (float)a / b;
            else return 0;
        }

        [WebMethod(Description = "Calcula o factorial de um numero inteiro nao negativo.")]
        public int Factorial(int a)
        {
            int res;
            if (a == 0) return 1;
            else if (a < 0) return 0;
            else
            {
                res = a;
                while (a > 1)
                {
                    res *= (a - 1);
                    a--;
                }
            }
            return res;
        }

        [WebMethod(Description = "Calcula a potencia de 'num' elevado a 'exp'.")]
        public double Potencia(double num, double exp)
        {
            return Math.Pow(num, exp);
        }

        [WebMethod(Description = "Calcula o valor absoluto de um numero.")]
        public double ValorAbsoluto(int a)
        {
            if (a < 0) return -a;
            return a;
        }
    }
}
