using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedApp.Common.ViewModels.Lists
{
    public class PaymentPlanViewModels
    {
        public int Id { get; set; }

        [StringLength(4)]
        [Required]
        public string Code { get; set; }

        public bool Inactive { get; set; }

        [StringLength(20)]
        [Required]
        public string Description { get; set; }

        [DisplayName("First Payment Due")]
        public int FirstPaymentDue { get; set; }

        [DisplayName("Due Every")]
        public int DueEvery { get; set; }

        [DisplayName("Amount Due")]
        public decimal Amount { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateCreated { get; set; }


    }

    public class PaymentPlanListViewModel
    {

        public int Id { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }

        [DisplayName("1st Payment Due on")]
        public int FirstPaymentDue { get; set; }

        [DisplayName("Interval in Days")]
        public int DueEvery { get; set; }

        [DisplayName("Amount Due")]
        public decimal Amount { get; set; }


        [DisplayFormat(DataFormatString = "{0:d}")]
        [DisplayName("Date Modified")]
        private DateTime? dateModified { get; set; }

        [DisplayName("Date Modified")]
        public string DateModifiedString
        {
            get
            {
                return dateModified.Value.ToShortDateString();
            }
            set
            {
                dateModified = DateTime.Parse(value);
            }
        }

    }


}
