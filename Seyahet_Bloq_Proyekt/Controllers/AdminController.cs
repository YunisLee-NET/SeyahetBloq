using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahet_Bloq_Proyekt.Models.Sinifler;

namespace Seyahet_Bloq_Proyekt.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminBloqlar()
        {
            var melumatlar = c.Bloqs.ToList();
            return View(melumatlar);
        }
        [HttpGet]
        public ActionResult YeniBloq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBloq(Bloq b)
        {
            
            if (Request.Files.Count > 0)
            {
                string senedadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Foto/" + senedadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                b.FotoBloq = senedadi + uzanti;
            }
            c.Bloqs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BloqSil(int id)
        {
            var b = c.Bloqs.Find(id);
            c.Bloqs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("AdminBloqlar");
        }

        public ActionResult BloqGetir (int id)
        {
            var bloq = c.Bloqs.Find(id);
            return View("BloqGetir", bloq);
        }

        public ActionResult BloqGuncelle(Bloq b)
        {
            var blq = c.Bloqs.Find(b.BloqID);
            blq.Aciqlama = b.Aciqlama;
            blq.Basliq = b.Basliq;
            blq.FotoBloq = b.FotoBloq;
            blq.Tarix = b.Tarix;
            c.SaveChanges();
            return RedirectToAction("AdminBloqlar");
        }

        public ActionResult AdminYorumSiyahi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("AdminYorumSiyahi");
        }
    }
}