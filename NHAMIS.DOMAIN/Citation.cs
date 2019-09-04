using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Citation
    {
        public int ID { get; set; }
        public int NominationID { get; set; }
        public int MedalID { get; set; }
        public string Achievement { get; set; }
        public string Engagements { get; set; }
        public string OtherContributions { get; set; }

        public virtual Nomination Nomination { get; set; }
        public virtual Medal Medal { get; set; }

    }
}