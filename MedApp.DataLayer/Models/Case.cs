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
    public class Case
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [DisplayName("Case Number")]
        public int Id { get; private set; }

        [StringLength(30)]
        public string Description { get; set; }

        public bool IsCashCase { get; set; }

        public bool IsPrintPatientStatement { get; set; }

        public DateTime GlobagCoverage { get; set; }

        public Patient Guarantor { get; set; }

        public MaritalStatus MeritalStatus { get; set; }

        public StudentStatus StudentStatus { get; set; }

        public EmploymentInformation EmploymentInformation { get; set; }
        public Patient Patient { get; set; }
    }
}
