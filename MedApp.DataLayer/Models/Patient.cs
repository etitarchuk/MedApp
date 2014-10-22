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
    public class Patient
    {
        [Key]
        [DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        [StringLength(8)]
        public string ChartNumber { get; set; }       
        public bool Inactive { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(10)]
        public string Suffix { get; set; }

        [StringLength(25)]
        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal BirthWeight { get; set; }

        public decimal SocialSecurity { get; set; }

        public DateTime DeathDate { get; set; }

        [StringLength(15)]
        public string PatientID2 { get; set; }

        [StringLength(10)]
        public string PatientIndicator { get; set; }

        [StringLength(10)]
        public string HealthcareId { get; set; }

        public bool SignatureOnFile { get; set; }

        public DateTime SignatureDate { get; set; }

        public bool IsSmoker { get; set; }

        public Sex Sex { get; set; }

        public Unit Unit { get; set; }        

        public EntityType EntityType { get; set; }

        public Address Address { get; set; }

        public Email Email { get; set; }

        public Practice Practice {get;set;}

        public Race Race { get; set; }

        public Race Race2 { get; set; }

        public Ethnicity Ethnicity { get; set; }

        public Language Language { get; set; }

        public PatientType PatientType { get; set; }

        public Provider AssignedProvider { get; set; }

        public BillingCode PatientBillingCode { get; set; }

        public PatientFlag PatientFlag { get; set; }

        public PatientEmergencyContact PatientEmergencyContact { get; set; }

        public PaymentPlan PaymentPlan { get; set; }

        public EmploymentInformation PatientDefaultEmploymentInformation { get; set; }
 
        public virtual ICollection<Phone> Phones { get; set; }

        public virtual ICollection<PatientVisit> PatientVisits { get; set; }

        //public virtual ICollection<Case> Cases { get; set; }
        
    }
}
