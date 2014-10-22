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
    public class Phone
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        public PhoneType PhoneType { get; set; }

        public Patient Patient { get; set; }

        public PatientEmergencyContact PatientEmergencyContact { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }

        public virtual ICollection<EmploymentInformation> PatientDefEmploymentInf { get; set; }
    }
}
