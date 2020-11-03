using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
