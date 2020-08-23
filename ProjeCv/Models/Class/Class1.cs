using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjeCv.Models.Entity;
namespace ProjeCv.Models.Class
{
    public class Class1
    {
        public IEnumerable<TblAbout> Deger1 { get; set; }
        public IEnumerable<TblExperience> Deger2 { get; set; }

        public IEnumerable<TblEducation> Deger3 { get; set; }

        public IEnumerable<TblSkills> Deger4 { get; set; }

        public IEnumerable<TblInterests> Deger5 { get; set; }

        public IEnumerable<TblAwards> Deger6 { get; set; }
    }
}