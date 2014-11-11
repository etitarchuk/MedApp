using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedApp.Core.Lists;
using MedApp.Web.Controls;

namespace MedApp.Web.Controllers
{
    public class ListsController : Controller
    {
        public BsGrid Grid;

        // GET: Lists
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PaymentPlanList()
        {
            return View(new MedApp.Common.ViewModels.Lists.PaymentPlanListViewModel());
        }
        [Bind(Exclude = "DateModified")]
        [HttpPost]
        public ActionResult GridInit( int page_num)
        {
            if (Grid == null)
            {
                Grid = new BsGrid();
                Grid.DataSource = PaymentPlanManager.Instance.GetAllPaymentPlans();
            }

            //Grid.Apply(HttpContext.Request.Params);

            return Json(Grid.GetData(), JsonRequestBehavior.AllowGet);

            //var pageNum = page_num;

            //var model = PaymentPlanManager.Instance.GetAllPaymentPlans();
            //List<Object> returnData = new List<Object>();
            //foreach(var item in model)
            //{
            //    returnData.Add(new { customer_id = item.Id,
            //                         date_updated  = item.DateModified,
            //                         email = "bla@bla.bla",
            //                         firstname = item.Description,
            //                         gender = "male",
            //                         lastname = item.Code});
            //}
            
            ////returnData.Add(new { id = 2, cell = new string[] { "Id2", "Votes2", "Title2" } });
            ////returnData.Add(new { id = 3, cell = new string[] { "Id3", "Votes3", "Title3" } });
            //var result = new Model { debug_message = new List<object>(), filter_error = new List<object>(), page_data = returnData, total_rows = returnData.Count };
            //return Json(result, JsonRequestBehavior.AllowGet);
        }
    }

    class Model
    {
        public object debug_message;

        public object error;

        public object filter_error;

        public object page_data;

        public object total_rows;
    }
}