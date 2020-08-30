using ProjeCv.Models.Class;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeCv.Controllers
{
    public class EgitimlerController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger3 = db.TblEducation.ToList();
            return View(cs);
        }

        [HttpGet]
        public ActionResult YeniEgitim()
        {
            return View();
        }

        public ActionResult YeniEgitim(TblEducation p)
        {
            db.TblEducation.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult EgitimSil(int id)
        {
            var egitim = db.TblEducation.Find(id);

            db.TblEducation.Remove(egitim);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult EgitimGetir(int id)
        {
            var egitim = db.TblEducation.Find(id);

            return View("EgitimGetir", egitim);
        }

        public ActionResult EgitimGuncelle(TblEducation p)
        {
            var egitim = db.TblEducation.Find(p.Id);

            egitim.Title = p.Title;
            egitim.SubTitle = p.SubTitle;
            egitim.Department = p.Department;
            egitim.Gpa = p.Gpa;


            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}