using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCv.Models.Entity;
using ProjeCv.Models.Class;

namespace ProjeCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda

        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TblAbout.ToList();
            return View(cs);
        }

        public ActionResult HakkimdaGetir(int id)
        {
            var hakkimda = db.TblAbout.Find(id);

            return View("HakkimdaGetir", hakkimda);
        }


        public ActionResult HakkimdaGuncelle(TblAbout p)
        {
            var hakkimda = db.TblAbout.Find(p.Id);

           // hakkimda.Id = p.Id;
            hakkimda.Name = p.Name;
            hakkimda.Surname = p.Surname;
            hakkimda.Phone = p.Phone;
            hakkimda.Address = p.Address;
            hakkimda.Mail = p.Mail;
            hakkimda.About = p.About;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}