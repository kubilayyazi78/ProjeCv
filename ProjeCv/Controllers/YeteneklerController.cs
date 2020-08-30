using Microsoft.Ajax.Utilities;
using ProjeCv.Models.Class;
using ProjeCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace ProjeCv.Controllers
{
    public class YeteneklerController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index(int sayfa=1)
        {
            //Class1 cs = new Class1();
            var degerler = db.TblSkills.ToList().ToPagedList(sayfa,3);
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(TblSkills p)
        {
            db.TblSkills.Add(p);
            db.SaveChanges();
            return View(p);
        }

        public ActionResult YetenekSil(int id)
        {
            var yetenek = db.TblSkills.Find(id);

            db.TblSkills.Remove(yetenek);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult YetenekGetir(int id)
        {
            var yetenek = db.TblSkills.Find(id);

            return View("YetenekGetir", yetenek);
        }

        public ActionResult YetenekGuncelle(TblSkills p)
        {
            var yetenek = db.TblSkills.Find(p.Id);

            yetenek.Skill = p.Skill;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}