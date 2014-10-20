using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedApp.DataLayer;
namespace MedApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (DataContext context = new DataContext())
            {
                var d = context.Users.ToList();
                var ds = context.Roles.ToList();
            }
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