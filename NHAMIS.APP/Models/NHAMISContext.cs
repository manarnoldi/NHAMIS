using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NHAMIS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace NHAMIS.APP.Models
{
    public class NHAMISContext : IdentityDbContext
    {
        public NHAMISContext() : base("NHAMISConnection")
        {
            Database.SetInitializer<NHAMISContext>(null);
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Nomination> Nominations { get; set; }
        public DbSet<AcademicQualification> AcademicQualifications { get; set; }
        public DbSet<Citation> Citations { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<HonorRole> HonorRoles { get; set; }
        public DbSet<Medal> Medals { get; set; }
        public DbSet<NominationBody> NominationBodies { get; set; }
        public DbSet<NominatingBody> NominatingBodies { get; set; }
        public DbSet<NominationAttachment> NominationAttachments { get; set; }
        public DbSet<NominationPeriod> NominationPeriods { get; set; }
        public DbSet<Salutation> Salutations { get; set; }
        public DbSet<Subcounty> Subcounties { get; set; }
        public DbSet<Ward> Wards { get; set; }

        public static NHAMISContext Create()
        {
            return new NHAMISContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Configure Asp Net Identity Tables
            modelBuilder.Entity<IdentityUser>().ToTable("User");
            modelBuilder.Entity<IdentityUser>().Property(u => u.PasswordHash).HasMaxLength(500);
            modelBuilder.Entity<IdentityUser>().Property(u => u.SecurityStamp).HasMaxLength(500);
            modelBuilder.Entity<IdentityUser>().Property(u => u.PhoneNumber).HasMaxLength(50);

            modelBuilder.Entity<IdentityRole>().ToTable("Role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimType).HasMaxLength(150);
            modelBuilder.Entity<IdentityUserClaim>().Property(u => u.ClaimValue).HasMaxLength(500);
            base.OnModelCreating(modelBuilder);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is NHAMISBaseClass SMSModelBaseClass && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUserId = !string.IsNullOrEmpty(HttpContext.Current?.User?.Identity?.GetUserId())
            ? HttpContext.Current.User.Identity.GetUserId()
            : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((NHAMISBaseClass)entity.Entity).CreateDate = DateTime.Now;
                    ((NHAMISBaseClass)entity.Entity).CreateBy = currentUserId;
                }

                entity.Property("CreateBy").IsModified = false;
                entity.Property("CreateDate").IsModified = false;

                ((NHAMISBaseClass)entity.Entity).ModifyDate = DateTime.Now;
                ((NHAMISBaseClass)entity.Entity).ModifyBy = currentUserId;
            }
        }

        public override int SaveChanges()
        {
            try
            {
                AddTimestamps();
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join(" ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, "The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

    }
}