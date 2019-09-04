using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Ward
    {
        public int ID { get; set; }
        public string WardName { get; set; }
        public string WardCode { get; set; }
        public int SubCountyID { get; set; }


        public virtual Subcounty Subcounty { get; set; }
    }
}