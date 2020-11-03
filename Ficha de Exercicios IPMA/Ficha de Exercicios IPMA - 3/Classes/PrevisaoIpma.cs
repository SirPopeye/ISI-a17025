using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public float temperaturaMinima { get; set; }
        public float temperaturaMaxima { get; set; }

    }
}
