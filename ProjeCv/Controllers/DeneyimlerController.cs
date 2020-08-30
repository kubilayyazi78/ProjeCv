using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;
using ProjeCv.Models.Class;
namespace ProjeCv.Controllers
{
    public class DeneyimlerController : Controller
    {
        // GET: Deneyimler

        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.TblExperience.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniDeneyim()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniDeneyim(TblExperience p)
        {
            db.TblExperience.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult DeneyimSil (int id)
        {
            var deneyim = db.TblExperience.Find(id);

            db.TblExperience.Remove(deneyim);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult DeneyimGetir(int id)
        {
            var deneyim = db.TblExperience.Find(id);

            return View("DeneyimGetir", deneyim);
        }

        public ActionResult DeneyimGuncelle(TblExperience p)
        {
            var deneyim = db.TblExperience.Find(p.Id);

            deneyim.Title = p.Title;
            deneyim.SubTitle = p.SubTitle;
            deneyim.Date = p.Date;
            deneyim.Details = p.Details;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}