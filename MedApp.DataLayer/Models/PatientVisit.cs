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
    public class PatientVisit
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
               
        public DateTime VisitDate { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public Patient Patient { get; set; }

        
    }
}
