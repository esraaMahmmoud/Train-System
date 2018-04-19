using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//ctrl+shift+R for refresh
namespace TrainMonitor_.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String username, String pass)
        {
            return RedirectToAction("admin");
        }
        //***********************Change language action**************************
        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);

            return Redirect(returnUrl);
        }
        //*****************************************************************



        public ActionResult TEST1()
        {
            return View();
        }
        public ActionResult admin()
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