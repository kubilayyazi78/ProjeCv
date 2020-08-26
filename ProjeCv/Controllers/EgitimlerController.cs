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
    }
}