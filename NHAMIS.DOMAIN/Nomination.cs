using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class Nomination
    {
        public int ID { get; set; }
        public string IdNumber { get; set; }
        public int SalutationID { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string CountyOfBirth { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public int ward { get; set; }
        public string Location { get; set; }
        public string SubLocation { get; set; }
        public string Village { get; set; }
        public int AcademicQualificationID { get; set; }
        public string Occupation { get; set; }
        public string PublicServiceRecords { get; set; }
        public string Status { get; set; }
        public int NominationPeriodID { get; set; }



        public virtual ICollection<Salutation> Salutations { get; set; }
        public virtual ICollection<NominationPeriod> NominationPeriods{ get; set; }
        public virtual ICollection<AcademicQualification> AcademicQualifications { get; set; }
        public virtual ICollection<Ward> Wards { get; set; }
    }
}