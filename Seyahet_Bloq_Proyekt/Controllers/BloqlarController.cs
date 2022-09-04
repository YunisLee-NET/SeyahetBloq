using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahet_Bloq_Proyekt.Models.Sinifler;

namespace Seyahet_Bloq_Proyekt.Controllers
{
    public class BloqlarController : Controller
    {
        // GET: Bloqlar
        Context c = new Context();
        BloqYorum by = new BloqYorum();
        public ActionResult Index()
        {
            //var melumatlar = c.Bloqs.ToList();
            by.Melumat1 = c.Bloqs.ToList();
            by.Melumat3 = c.Bloqs.OrderByDescending(x => x.BloqID).Take(3).ToList();
            return View(by);
        }
        
        public ActionResult BloqGetir(int id)
        {
            //var bloqtap = c.Bloqs.Where(x => x.BloqID == id).ToList();
            by.Melumat1 = c.Bloqs.Where(x => x.BloqID == id).ToList();
            by.Melumat2 = c.Yorumlars.Where(y => y.BloqID == id).ToList();
            by.Melumat3 = c.Bloqs.OrderByDescending(x => x.BloqID).Take(3).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYaz(int id)
        {
            ViewBag.ID = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYaz(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}