using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;

namespace ProjeCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default


        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblAbout.ToList();
            return View(degerler);
        }
    }
}