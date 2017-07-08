using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consultants.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Register() // new!!!!!!!!!!!!!!!
        {
            return View("Register");
        }
        public ActionResult ChangePassword() // new!!!!!!!!!!!!!!!
        {
            return View("ChangePassword");
        }
        public ActionResult LoggedIn() // new!!!!!!!!!!!!!!!
        {
            return View("ChangePassword");
        }

    }
}