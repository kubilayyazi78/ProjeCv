using ProjeCv.Models.Class;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class HobilerController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger5 = db.TblInterests.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult YeniHobi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniHobi(TblInterests p)
        {
            db.TblInterests.Add(p);
            db.SaveChanges();
            return View(p);
        }

        public ActionResult HobiSil(int id)
        {
            var hobi = db.TblInterests.Find(id);

            db.TblInterests.Remove(hobi);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult HobiGetir(int id)
        {
            var hobi = db.TblInterests.Find(id);

            return View("HobiGetir", hobi);
        }

        public ActionResult HobiGuncelle(TblInterests p)
        {
            var hobi = db.TblInterests.Find(p.Id);

            hobi.Interest = p.Interest;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}