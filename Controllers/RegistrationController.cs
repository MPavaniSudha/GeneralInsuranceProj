using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeneralInsurancePrj.Models;

namespace GeneralInsurancePrj.Controllers
{
    public class RegistrationController : Controller
    {
        InsuranceDBEntities idb = new InsuranceDBEntities();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegistrationDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrationDetails(RegistrationInfo reginfo)
        {
            idb.RegistrationInfoes.Add(reginfo);
            idb.SaveChanges();
            return View(reginfo);
        }
    }
}