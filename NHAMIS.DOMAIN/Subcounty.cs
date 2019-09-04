using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Subcounty
    {
        public int ID { get; set; }
        public string SubCountyName { get; set; }
        public string SubCountyCode { get; set; }
        public int CountyID { get; set; }

        public virtual ICollection<Ward> wards { get; set; }
        public virtual County County { get; set; }
    }
}