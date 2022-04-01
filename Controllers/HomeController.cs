using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeneralInsuranceProject.Models;

namespace GeneralInsuranceProject.Controllers
{
    public class HomeController : Controller
    {
        RegistrationInfoContext rc = new RegistrationInfoContext();
        public ActionResult Index()
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

        [HttpGet]
        public ActionResult RegistrationDetails()
        {
            return View();
        }

        [HttpPost]
        
        [ValidateAntiForgeryToken]
        public ActionResult RegistrationDetails(RegistrationInfo reginfo)
        {
                rc.customers.Add(reginfo);
                rc.SaveChanges();
                return View(reginfo);
            
        }

    }
}