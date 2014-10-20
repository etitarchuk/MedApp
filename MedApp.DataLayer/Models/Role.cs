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
    public class Role
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(50, MinimumLength = 3)]
        public string RoleName { get; set; }

        
        public bool? IsAdmin { get; set; }
       
        public bool? IsOwner { get; set; }

        public virtual ICollection<User> Users { get; set; }

        

    }
}
