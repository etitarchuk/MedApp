using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedApp.DataLayer.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MedApp.DataLayer
{
  public  class DataContext : DbContext
    {
      public DataContext()
          : base("name=DataContext")
                {
                    Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
                }
      public virtual DbSet<User> Users { get; set; }
      public virtual DbSet<Address> Addresses { get; set; }
      public virtual DbSet<BillingCode> BillingCodes { get; set; }
      public virtual DbSet<Email> Emails { get; set; }
      public virtual DbSet<Case> Cases { get; set; }
      public virtual DbSet<Employer> Employers { get; set; }
      public virtual DbSet<EmployerStatus> EmployerStatuses { get; set; }
      public virtual DbSet<EmploymentInformation> EmploymentInformation { get; set; }
      public virtual DbSet<EntityType> EntityTypes { get; set; }
      public virtual DbSet<Ethnicity> Ethnicities { get; set; }
      public virtual DbSet<Language> Languages { get; set; }
      public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }
      public virtual DbSet<Patient> Patients { get; set; }
      public virtual DbSet<PatientEmergencyContact> PatientEmergencyContact { get; set; }
      public virtual DbSet<PatientFlag> PatientFlags { get; set; }
      public virtual DbSet<PatientType> PatientTypes { get; set; }
      public virtual DbSet<PatientVisit> PatientVisits { get; set; }
      public virtual DbSet<PaymentPlan> PaymentPlans { get; set; }
      public virtual DbSet<Phone> Phones { get; set; }
      public virtual DbSet<PhoneType> PhoneType  { get; set; }
      public virtual DbSet<Practice> Practices { get; set; }
      public virtual DbSet<PracticeType> PracticeTypes { get; set; }
      public virtual DbSet<Provider> Providers { get; set; }
      public virtual DbSet<Race> Races { get; set; }
      public virtual DbSet<State> States { get; set; }
      public virtual DbSet<StudentStatus> StudentStatuses { get; set; }
      public virtual DbSet<Unit> Units { get; set; }
      public virtual DbSet<Role> Roles { get; set; }
      



      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
          modelBuilder.Entity<Patient>()
                    .HasOptional(m => m.Race)
                    .WithMany(t => t.RacePatients)
                    .HasForeignKey(m => m.RaceId)
                    .WillCascadeOnDelete(false);

          modelBuilder.Entity<Patient>()
                    .HasOptional(m => m.Race2)  
                    .WithMany(t => t.Race2Patients)
                    .HasForeignKey(m => m.Race2Id)
                    .WillCascadeOnDelete(false);

          modelBuilder.Entity<Case>()
                    .HasOptional(m => m.Patient)
                    .WithMany(t => t.PatientCases)
                    .HasForeignKey(m => m.PatientId)
                    .WillCascadeOnDelete(false);

          modelBuilder.Entity<Case>()
                    .HasOptional(m => m.Guarantor)
                    .WithMany(t => t.GuarantorCases)
                    .HasForeignKey(m => m.GuarantorId)
                    .WillCascadeOnDelete(false);

          modelBuilder.Entity<BillingCode>()
                    .HasOptional(m => m.ModifiedBy)
                    .WithMany(t => t.ModifiedByBillingCodes)
                    .HasForeignKey(m => m.ModifiedById)
                    .WillCascadeOnDelete(false);

          modelBuilder.Entity<BillingCode>()
                    .HasOptional(m => m.CreatedBy)
                    .WithMany(t => t.CreatedByBillingCodes)
                    .HasForeignKey(m => m.CreatedById)
                    .WillCascadeOnDelete(false);
      }
    }
}
