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
    public class Provider
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(5)]
        public string Code { get; set; }
                
        public bool Inactive { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string MiddleName { get; set; }
        
        [StringLength(10)]
        public string Credentials { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
