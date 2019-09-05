using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class NominationBody : NHAMISBaseClass
    {
        public int Id { get; set; }       
        public string Title { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public int NominationId { get; set; }
        public virtual Nomination Nomination { get; set; }
    }
       
}