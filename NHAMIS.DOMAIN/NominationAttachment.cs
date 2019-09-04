using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class NominationAttachment
    {
        public int ID { get; set; }
        public int NominationID { get; set; }
        public string AttachmentType { get; set; }
        public string AttachmentUrl { get; set; }


        public virtual Nomination Nomination { get; set; }
    }
}