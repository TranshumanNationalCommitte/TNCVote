using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public ActionResult Convention()
        {
            return View();
        }

        public ActionResult Legal()
        {
            return View();
        }

        public ActionResult SendGridTest()
        {
            try
            {
                // using send grid offline... 
                //var username = "your_sendgrid_username";
                //var pswd = "your_sendgrid_password"; 
                //var credentials = new NetworkCredential(username, pswd);
                //var transportWeb = new Web(credentials);

                var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");

                var transportWeb = new Web(apiKey);

                SendGridMessage myMessage = new SendGridMessage();
                myMessage.From = new MailAddress("donotreply@transhumanpolitics.com");
                //myMessage.AddTo(NewMemberEmailAccount);
                myMessage.AddTo("pieseczek@hotmail.com");
                myMessage.Subject = "Welcome New Registered TNC Member";
                myMessage.Html = "test";

                transportWeb.DeliverAsync(myMessage);
            }
            catch (Exception e)
            {
                throw e;
                //throw (E); 
            }

            return View();
        }
    }
}