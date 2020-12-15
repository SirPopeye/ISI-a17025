using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ficha_6_Covid_API.Models;

namespace Ficha_6_Covid_API.Controllers
{
    public class HistoricoController : ControllerBase
    {
        #region VAR
        static Historico h;
        #endregion

        public HistoricoController()
        {
            if (h == null) h = new Historico();
        }

        #region METHODS
        /// <summary>
        /// Insere novo Registo.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [HttpPost("insereNovoRegisto")]
        public bool NewRegist(Registo n)
        {
            return h.InsertRegisto(n);
        }

        /// <summary>
        /// Devolve todos os Registos.
        /// </summary>
        /// <returns></returns>
        [HttpGet("hist")]
        public List<Registo> GetRegist()
        {
            return h.GetHistorico();
        }

        [HttpGet("getRegisto/{d}")]
        public Registo GetRegist(DateTime d)
        {
            return h.GetRegistDay(d);
        }
        #endregion

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
