using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.DataLayer.Models
{
    public class PaymentPlan
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(3)]
        public string Code { get; set; }

        public bool Inactive { get; set; }

        [StringLength(20)]
        public string Description { get; set; }

        public int FirstPaymentDue { get; set; }

        public int DueEvery { get; set; }

        public decimal Amount { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateCreated { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
