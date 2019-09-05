using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Citation:NHAMISBaseClass
    {
        public int Id { get; set; }        
        public string Achievement { get; set; }
        public string Engagements { get; set; }
        public string OtherContributions { get; set; }
        public int NominationId { get; set; }
        public int MedalId { get; set; }
        public virtual Nomination Nomination { get; set; }
        public virtual Medal Medal { get; set; }

    }
}