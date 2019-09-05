using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class County : NHAMISBaseClass
    {
        public int Id { get; set; }
        public string CountyName { get; set; }
        public string CountyCode { get; set; }
        public virtual ICollection<Subcounty> SubCounties { get; set; }
    }
}