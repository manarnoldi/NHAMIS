using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Salutation
    {
        public int ID { get; set; }
        public int Order { get; set; }

        public virtual Nomination Nominations { get; set; }
        
    }
}