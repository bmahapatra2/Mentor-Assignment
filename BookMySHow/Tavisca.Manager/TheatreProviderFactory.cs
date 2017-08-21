using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.TheatreProviders;
using Tavisca.TheatreProviderContract;
using Tavisca.BookMyShow.Entity;

namespace Tavisca.BookMyShow.Manager
{
    public class TheatreProviderFactory
    {
        public ITheatreProvider GetShow(string type)
        {

            
            if (type.Equals("Marvelstheatreprovider",StringComparison.CurrentCultureIgnoreCase))
            {
                MarvelsTheatreProvider theatreprovider1 = new MarvelsTheatreProvider();
                return theatreprovider1;
            }
    
            if (type.Equals("DCTheatreProvider",StringComparison.CurrentCultureIgnoreCase))
            {
                DCTheatreProvider theatreprovider2 = new DCTheatreProvider();
                return theatreprovider2;
            }
            return null;
        }

       
    }
}

