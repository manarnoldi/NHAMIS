using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class HonorRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MedalID { get; set; }
        public string SerialNo { get; set; }
        public DateTime ConfirementDate { get; set; }
        public string Nationality { get; set; }
        public int SalutationID { get; set; }

        public virtual Salutation Salutation { get; set; }
        public virtual Medal Medal { get; set; }

    }
}