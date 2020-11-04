/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
*/
using System;

namespace ClassLibrary
{
    public class PrevisaoIpma
    {   
        public string owner { get; set; }
        public string country { get; set; }
        public PrevisaoDia[] data { get; set; }
        public int globalIdLocal { get; set; }
        public DateTime dataUpdate { get; set; }

        // Elemento adicional -> local, amplitudeTermica
        public string local { get; set; }
        public float amplitudeTermica { get; set; }
        public float temperaturaMinimaSemanal { get; set; }
        public float temperaturaMaximaSemanal { get; set; }

    }
}
