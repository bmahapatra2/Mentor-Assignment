using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.BookMyShow.Entity
{
    public class Theatre
    {
        public string Name { get; set; }

        public Address Location { get; set; }

        public List<Screen> Screens { get; set; }

       

        

    }
}
