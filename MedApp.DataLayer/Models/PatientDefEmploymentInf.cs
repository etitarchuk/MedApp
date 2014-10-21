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
    public class PatientDefEmploymentInf
    {
        [Key, ForeignKey("Patient")]        
        public int PatientId { get; set; }

        public Employer Employer { get; set; }

        public EmployerStatus Status { get; set; }

        public Phone WorkPhone { get; set; }

        [StringLength(6)]
        public string Location { get; set; }

        public DateTime RetirementDate { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
