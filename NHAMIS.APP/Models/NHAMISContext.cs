using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class NHAMISContect: IdentityDbContext
    {
        public DbSet<Nomination> Nominations;
        public DbSet<AcademicQualification> AcademicQualifications;
        public DbSet<Citation> Citations;
        public DbSet<County> counties;
        public DbSet<HonorRole> HonorRoles;
        public DbSet<Medal> Medals;
        public DbSet<NominationBody> NominationBodies;
        public DbSet<NominatingBody> NominatingBodies;
        public DbSet<NominationAttachment> NominationAttachments;
        public DbSet<NominationPeriod> NominationPeriods;
        public DbSet<Salutation> Salutations;
        public DbSet<Subcounty> Subcounties;
        public DbSet<Ward> Wards;


    }
}