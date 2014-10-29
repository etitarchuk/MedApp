using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedApp.Common.ViewModels.Lists;
using MedApp.DataLayer;
using MedApp.DataLayer.Models;

namespace MedApp.Core.Lists
{
    public class PaymentPlanManager : Manager<PaymentPlan>
    {
        private static PaymentPlanManager _instance;
        public static PaymentPlanManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaymentPlanManager();
                return _instance;
            }
        }

        public IEnumerable<PaymentPlanListViewModel> GetAllPaymentPlans()
        {
            return DataContext.PaymentPlans.Select(m => new PaymentPlanListViewModel
            {
                Id = m.Id,
                Code = m.Code,
                Description = m.Description,
                FirstPaymentDue = m.FirstPaymentDue,
                DueEvery = m.DueEvery,
                Amount = m.Amount,
                DateModified = m.DateModified
            });
        }
    }
}
