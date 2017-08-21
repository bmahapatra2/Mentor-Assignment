using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.BookMyShow.Entity;
using Tavisca.TheatreProviderContract;
using System.Configuration;

namespace Tavisca.TheatreProviders
{
    public class DCTheatreProvider : ITheatreProvider
    {
        List<Theatre> theatrelist1;
        public List<Theatre> GetTheaters()
        {
            Theatre theatre = new Theatre();
            theatre.Name = "PVR";
            Theatre theatre1 = new Theatre();
            theatre1.Name = "Inox";
            theatrelist1.Add(theatre);
            theatrelist1.Add(theatre1);
            return theatrelist1;
        }

        public int TheatrePrice(Price price)
        {
            return price.TotalAmount = price.Amount + price.GSTPrice + price.Discount;
        }

        public DCTheatreProvider()
        {
            theatrelist1 = new List<Theatre>();
        }

    }
}

