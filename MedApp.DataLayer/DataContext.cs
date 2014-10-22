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
      public virtual DbSet<Role> Roles { get; set; }
            
    }
}
