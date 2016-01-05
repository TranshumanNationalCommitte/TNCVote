using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TNCVote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the TNC Membership Portal.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome to the TNC Membership Portal.  You can contact us the following ways:";

            return View();
        }

        public ActionResult Success()
        { 
            return View();
        }
    }
}