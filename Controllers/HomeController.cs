using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeneralInsurancePrj.Models;

namespace GeneralInsurancePrj.Controllers
{
    public class HomeController : Controller
    {
        InsuranceDBEntities idb = new InsuranceDBEntities();
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
        public ActionResult RegistrationDetails(RegistrationInfo reginfo)
        {
            idb.RegistrationInfoes.Add(reginfo);
            idb.SaveChanges();
            return View(reginfo);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(RegistrationInfo regin)
        {
            if (ModelState.IsValid == true)
            {
                var credentials = idb.RegistrationInfoes.Where(model => model.Email == regin.Email && model.Paassword == regin.Paassword).First();
                if (credentials == null)
                {
                    ViewBag.ErrorMessage = "Login Failed";
                    return RedirectToAction("Login");
                }
                else
                {
                    Session["username"] = regin.CustomerName;
                    return RedirectToAction("BuyInsurance");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        public ActionResult BuyInsurance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuyInsurance(VehicleInsuranceInfo veinfo)
        {
            idb.VehicleInsuranceInfoes.Add(veinfo);
            idb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult InsuranceDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsuranceDetails(InsurancePlanInfo ipinfo)
        {
            idb.InsurancePlanInfoes.Add(ipinfo);
            idb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult PolicyDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PolicyDetails(PolicyInfoTB pinfo)
        {
            idb.PolicyInfoTBs.Add(pinfo);
            idb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ClaimDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClaimDetails(ClaimInfo cinfo)
        {
            idb.ClaimInfoes.Add(cinfo);
            idb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

    
