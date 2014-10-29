using MedApp.DataLayer;
using MedApp.DataLayer.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.Core
{
    public class UserManager : Manager<User>
    {
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

        public void CreateUser(string username)
        {
            DataContext.Users.Add(new User() { Username = username });
            DataContext.SaveChanges();
        }

    }
}
