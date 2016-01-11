using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TNCVote.Migrations;
using TNCVote.Models;

namespace TNCVote
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
        
        void Application_Error(Object sender, EventArgs e) 
        { 
            var exception = Server.GetLastError();
            /*
            if (exception == null)
                return;
            var mail = new MailMessage { From = new MailAddress("automated@contoso.com") };
            mail.To.Add(new MailAddress("administrator@contoso.com"));
            mail.Subject = "Site Error at " + DateTime.Now;
            mail.Body = "Error Description: " + exception.Message;
            var server = new SmtpClient { Host = "your.smtp.server" };
            server.Send(mail);
        
            // Clear the error
            Server.ClearError();
        
            // Redirect to a landing page
            Response.Redirect("home/landing");
            */
      }
    }
}
