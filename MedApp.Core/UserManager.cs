using MedApp.DataLayer;
using MedApp.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.Core
{
    public class UserManager
    {
        private DataContext _dataContext;

        private static UserManager _instance;
        public static UserManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserManager();
                return _instance;
            }
        }

        protected UserManager()
        {
            _dataContext = new MedApp.DataLayer.DataContext();
        }

        public void CreateUser(string username)
        {
            _dataContext.Users.Add(new User() { Username = username });
            _dataContext.SaveChanges();
        }

    }
}
