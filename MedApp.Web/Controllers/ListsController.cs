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

        [HttpPost]
        public ActionResult GridInit()
        {
            List<Object> returnData = new List<Object>();
            returnData.Add(new { id = 1, cell = new string[] { "Id1", "Votes1", "Title1" } });
            returnData.Add(new { id = 2, cell = new string[] { "Id2", "Votes2", "Title2" } });
            returnData.Add(new { id = 3, cell = new string[] { "Id3", "Votes3", "Title3" } });
            var result = new { total = 1, page = 1, records = 3, rows = returnData };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}