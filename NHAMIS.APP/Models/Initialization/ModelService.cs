using NHAMIS.APP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models.Initialisation
{
    public static class ModelService
    {
        public static void InsertCounty()
        {
            using (NHAMISContext dbcontext = new NHAMISContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/Counties.txt");

                string[] Counties = File.ReadAllLines(path);

                foreach (string CountyLine in Counties)
                {
                    string countyName = CountyLine;

                    County County = new County() { CountyName = countyName };

                    dbcontext.Counties.Add(County);
                }
                dbcontext.SaveChanges();
            }
        }

        public static void InsertConstituency()
        {
            using (NHAMISContext dbcontext = new NHAMISContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/Constituencies.txt");

                string[] Constituencies = File.ReadAllLines(path);

                foreach (string ConstituencyLine in Constituencies)
                {
                    string subcountyName = ConstituencyLine.Split('=')[0];

                    string countyName = ConstituencyLine.Split('=')[1];

                    var CountyId = dbcontext.Counties.Where(n => n.CountyName == countyName).Select(f => f.Id ).FirstOrDefault();

                    County County = dbcontext.Counties.Find(CountyId) ;

                    Subcounty subcounty = new Subcounty() {  SubCountyName = subcountyName, County = County };

                    dbcontext.Subcounties.Add(subcounty);
                }
                dbcontext.SaveChanges();
            }
        }

        public static void InsertWard()
        {
            using (NHAMISContext dbcontext = new NHAMISContext())
            {
                string path = HttpContext.Current.Server.MapPath(@"~/Models/Initialisation/Wards.txt");

                string[] Wards = File.ReadAllLines(path);

                foreach (string WardLine in Wards)
                {
                    string wardName = WardLine.Split('=')[0];

                    string subcountyName = WardLine.Split('=')[1];

                    var subcountyId = dbcontext.Subcounties.Where(n => n.SubCountyName == subcountyName).Select(c => c.Id).FirstOrDefault();

                    Subcounty subcounty = dbcontext.Subcounties.Find(subcountyId);
                    
                    Ward Ward = new Ward() { WardName = wardName, Subcounty = subcounty };

                    dbcontext.Wards.Add(Ward);
                }
                dbcontext.SaveChanges();
            }
        }
    }
}