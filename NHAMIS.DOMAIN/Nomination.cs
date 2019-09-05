using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Nomination : NHAMISBaseClass
    {
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string CountyOfBirth { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string Location { get; set; }
        public string SubLocation { get; set; }
        public string Village { get; set; }
        public string Occupation { get; set; }
        public string PublicServiceRecords { get; set; }
        public string Status { get; set; }
        public int WardId { get; set; }
        public virtual Ward Ward { get; set; }
        public int SalutationId { get; set; }
        public virtual Salutation Salutation { get; set; }
        public virtual ICollection<AcademicQualification> AcademicQualifications { get; set; }
        public virtual ICollection<NominationBody> NominationBodies { get; set; }
        public virtual ICollection<NominationPeriod> NominationPeriods { get; set; }
    }
}