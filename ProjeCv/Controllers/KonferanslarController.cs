using ProjeCv.Models.Class;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class KonferanslarController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index(string p)
        {

            var degerler = from d in db.TblAwards select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Award.Contains(p));
            }

            return View("Index", degerler.ToList());

           // Class1 cs = new Class1();
           // cs.Deger6 = db.TblAwards.ToList();
           // return View(cs);


        }

        [HttpGet]
        public ActionResult YeniKonferans()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKonferans(TblAwards p)
        {
            db.TblAwards.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult KonferansSil(int id)
        {

            var konferans = db.TblAwards.Find(id);

            db.TblAwards.Remove(konferans);

            db.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult KonferansGetir(int id)
        {
            var konferans = db.TblAwards.Find(id);

            return View("KonferansGetir", konferans);
        }

        public ActionResult KonferansGuncelle(TblAwards p)
        {
            var konferans = db.TblAwards.Find(p.Id);

            konferans.Award= p.Award;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}