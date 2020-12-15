using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ficha_6_Covid_API.Models
{
    public class Historico
    {
        List<Registo> historico;

        public Historico()
        {
            if (historico == null) historico = new List<Registo>();
        }

        /// <summary>
        /// Insere registo no Historico.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool InsertRegisto(Registo r)
        {
            if ((historico != null) && !historico.Contains(r))
            {
                // Rever !!!!
                historico.Add(r);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Devolve Registos.
        /// </summary>
        /// <returns></returns>
        public List<Registo> GetHistorico()
        {
            return historico;
        }

        public Registo GetRegistDay(DateTime d)
        {
            //LINQ
            //Contains
            foreach(Registo r in historico)
            {
                if (r.Dia == d) return r;
            }
            return null;
        }
    }
}
