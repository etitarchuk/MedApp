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
    public class EmploymentInformation
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        public Employer Employer { get; set; }

        public EmployerStatus Status { get; set; }

        public Phone WorkPhone { get; set; }

        [StringLength(6)]
        public string Location { get; set; }

        public DateTime RetirementDate { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
