using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class NominatingBody : NHAMISBaseClass
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Ministry { get; set; }
    }
}