using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.BookMyShow.Entity;

namespace Tavisca.BookMyShow.Manager
{
    public class UserManager
    {
        private List<User> Users { get; set; }

        public UserManager()
        {
            Users = new List<User>();
        }

        public void CreateUser(User user)
        {
            Users.Add(user);
        }

        public User GetUser(String fname)
        {
            foreach (User user in Users)
            {
                if (user.Name.FirstName.Equals(fname, StringComparison.CurrentCultureIgnoreCase))
                    return user;
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            return Users;

        }
    }
}
