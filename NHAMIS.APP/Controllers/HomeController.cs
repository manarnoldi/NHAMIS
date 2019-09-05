using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHAMIS.APP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Citation()
        {
            return View();

        }

        public ActionResult NominatingBody()
        {
            return View();


        }
        

             public ActionResult Attachment()
            {
            return View();


        }
        public ActionResult OtherDetails()
        {
            return View();


        }
        
        public ActionResult Medals()
        {
            return View();


        }
        
        public ActionResult RoleOfHonor()
        {
            return View();


        }

        public ActionResult County()
        {
            return View();


        }

        public ActionResult SubCounty()
        {
            return View();


        }
        public ActionResult AcademicQual()
        {
            return View();


        }

        public ActionResult Ward()
        {
            return View();


        }
        

         public ActionResult NominatingBodies()
        {
            return View();


        }
        public ActionResult NominationPeriod()
        {
            return View();


        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}