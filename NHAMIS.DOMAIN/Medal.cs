using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Medal : NHAMISBaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Quantity { get; set; }


    }
}