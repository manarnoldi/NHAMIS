using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class AcademicQualification
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual Nomination Nomination { get; set; } 
    }
}