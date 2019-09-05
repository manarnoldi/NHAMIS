using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class AcademicQualification : NHAMISBaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NominationId { get; set; }
        public Nomination Nomination { get; set; }
    }
}