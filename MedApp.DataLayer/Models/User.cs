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
    public class User
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        
        public int Id { get; private set; }

        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Password { get; set; }

        public virtual Role  Role { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }

        public virtual ICollection<BillingCode> CreatedByBillingCodes { get; set; }
        public virtual ICollection<BillingCode> ModifiedByBillingCodes { get; set; }

    }
}
