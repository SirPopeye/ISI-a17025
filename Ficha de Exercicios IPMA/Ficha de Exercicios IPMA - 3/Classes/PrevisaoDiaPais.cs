/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using ClassLibrary;
using System.Collections.Generic;

namespace Ficha_de_Exercicios_IPMA___3.Classes
{
    public class PrevisaoDiaPais
    {
        public List<PrevisaoDia> data { get; set; }

        public PrevisaoDiaPais()
        {
            this.data = new List<PrevisaoDia>();
        }
    }
}
