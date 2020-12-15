using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ficha_6_Covid_API.Models
{
    public class Registo
    {
        private int mortes;
        private int recuperados;
        private int infetados;
        private DateTime dia;

        public int Mortes { get =>mortes; set => mortes = value; }
        public int Recuperados { get => recuperados; set => recuperados = value; }
        public int Infetados { get => infetados; set => infetados = value; }
        public DateTime Dia { get => dia; set => dia = value; }

        #region CONSTRUCTORS
        public Registo()
        {
            infetados = 0;
            recuperados = 0;
            mortes = 0;
            dia = DateTime.Today;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Regista mais infetados;
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int MoreInf(int n)
        {
            infetados += n;
            dia = DateTime.Now;
            return infetados;
        }

        /// <summary>
        /// Regista mais Mortes
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int MoreMortes(int n)
        {
            mortes += n;
            dia = DateTime.Now;
            return mortes;
        }

        /// <summary>
        /// Regista mais recuperados
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int MoreRecuperados(int n)
        {
            recuperados += n;
            dia = DateTime.Now;
            return recuperados;
        }

        #endregion
    }
}
