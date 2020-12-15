using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ficha_6_Covid_API.Models;     //Usar Model criado !!!

namespace Ficha_6_Covid_API.Controllers
{
    [ApiController]
    [Route("api/registo")]
    /// <summary>
    /// Controller para "Registo"
    /// </summary>
    public class RegistoController : ControllerBase
    {
        #region VAR
        static Registo r;
        #endregion

        public RegistoController()
        {
            if (r == null) r = new Registo();
        }

        [HttpPost("addInf")]
        public int Infected(int n)
        {
            return r.MoreInf(n);
        }

        [HttpGet("getInf")]
        public int GetInfected()
        {
            return r.Infetados;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
