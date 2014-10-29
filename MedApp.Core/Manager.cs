using MedApp.DataLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.Core
{
    public class Manager
    {
        protected DataContext DataContext;              

        protected Manager()
        {
            DataContext = new DataContext();
        }
    }

    public class Manager<T> : Manager where T : class
    {
        public IQueryable<T> AllRecords
        {
            get
            {
                return DataContext.Set<T>();
            }
        }
    }
}
