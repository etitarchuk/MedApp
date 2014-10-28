using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedApp.Common.ViewModels.Lists;
using MedApp.DataLayer;
namespace MedApp.Core.Lists
{
  public   class PaymentPlanManager
    {
       private DataContext _dataContext;

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

        protected PaymentPlanManager()
        {
            _dataContext = new MedApp.DataLayer.DataContext();
        }

        public IEnumerable<PaymentPlanListViewModel> GetAllPaymentPlans()
        {
            return _dataContext.PaymentPlans.Select(m => new PaymentPlanListViewModel { 
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
