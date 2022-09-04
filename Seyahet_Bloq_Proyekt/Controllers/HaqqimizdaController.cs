using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahet_Bloq_Proyekt.Models.Sinifler;

namespace Seyahet_Bloq_Proyekt.Controllers
{
    public class HaqqimizdaController : Controller
    {
        // GET: Haqqimizda
        Context c = new Context();
        public ActionResult Index()
        {
            var melumatlar = c.Haqqimizdas.ToList();
            return View(melumatlar);
        }
    }
}