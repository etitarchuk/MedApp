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
    public class Practice
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(15)]
        public string FederalTaxId { get; set; }

        [StringLength(30)]
        public string Extra1 { get; set; }

        [StringLength(30)]
        public string Extra2 { get; set; }


        public PracticeType PracticeType { get; set; }
        public EntityType EntityType { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }
        public Email Email { get; set; }
        public User User { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }


        
    }
}
