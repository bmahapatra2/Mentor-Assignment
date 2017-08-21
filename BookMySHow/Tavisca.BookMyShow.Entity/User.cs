using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.BookMyShow.Entity
{
    public class User
    {
       
        public string Password { get; set; }

        public Address Address { get; set; }

        public Name Name { get; set; }     
        
        public string Username { get; set; }

        public Gender Gender { get; set; }


    }
}
