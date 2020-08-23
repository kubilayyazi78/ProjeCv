using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;
using ProjeCv.Models.Class;

namespace ProjeCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default


        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TblAbout.ToList();
            cs.Deger2 = db.TblExperience.ToList();
            cs.Deger3 = db.TblEducation.ToList();

            cs.Deger4 = db.TblSkills.ToList();
            cs.Deger5 = db.TblInterests.ToList();
            cs.Deger6 = db.TblAwards.ToList();


            return View(cs);

          //  var degerler = db.TblAbout.ToList();
            //return View(degerler);
        }
    }
}