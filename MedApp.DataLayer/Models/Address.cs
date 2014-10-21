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
    public class Address
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Street2 { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        public State State { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        public virtual ICollection<Practice> Practices { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
