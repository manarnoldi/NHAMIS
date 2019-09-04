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
       
    }
}