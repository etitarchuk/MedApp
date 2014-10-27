using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedApp.Web.Controllers
{
    public class ListsController : Controller
    {
        // GET: Lists
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PaymentCodeList()
        {
            return View();
        }
    }
}