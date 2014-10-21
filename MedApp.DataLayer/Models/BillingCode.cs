﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.DataLayer.Models
{
    public class BillingCode
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(2)]
        public string Code { get; set; }

        public bool InactiveCode { get; set; }

        [StringLength(20)]
        public string Description { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
