/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using System;

namespace ClassLibrary
{
    public class PrevisaoIpmaModel
    {   
        public string owner { get; set; }
        public string country { get; set; }
        public PrevisaoDiaModel[] data { get; set; }
        public int globalIdLocal { get; set; }
        public DateTime dataUpdate { get; set; }

        // Elemento adicional -> local
        public string local { get; set; }
    }
}
