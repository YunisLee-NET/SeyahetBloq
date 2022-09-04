using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahet_Bloq_Proyekt.Models.Sinifler;

namespace Seyahet_Bloq_Proyekt.Controllers
{
    public class AnaSehifeController : Controller
    {
        // GET: AnaSehife
        Context c = new Context();
        public ActionResult Index()
        {
            var melumatlar = c.Bloqs.Take(4).ToList();
            return View(melumatlar);
        }

        public PartialViewResult Partial1()
        {
            var melumatlar = c.Bloqs.OrderByDescending(x => x.BloqID).Take(3).ToList();
            return PartialView(melumatlar);
        }

        public PartialViewResult Partial3()
        {
            var melumatlar = c.Bloqs.OrderBy(x => x.BloqID).Take(10).ToList();
            return PartialView(melumatlar);
        }

        public PartialViewResult Partial4()
        {
            var melumatlar = c.Bloqs.OrderBy(x => x.BloqID).Take(3).ToList();
            return PartialView(melumatlar);
        }

        public PartialViewResult Partial5()
        {
            var melumatlar = c.Bloqs.OrderByDescending(x => x.BloqID).Take(3).ToList();
            return PartialView(melumatlar);
        }
    }
}