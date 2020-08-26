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
    }
}