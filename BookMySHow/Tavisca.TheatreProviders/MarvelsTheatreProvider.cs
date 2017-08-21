using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.BookMyShow.Entity;
using Tavisca.TheatreProviderContract;




namespace Tavisca.TheatreProviders
{

    public class MarvelsTheatreProvider : ITheatreProvider
    {
        List<Theatre> theatrelist1 { get;  set; }

        public List<Theatre> GetTheaters()
        {
            Theatre theatre = new Theatre();
            theatre.Name = "Cinepolis";
            Theatre theatre1 = new Theatre();
            theatre1.Name = "Cinepolis";
            theatrelist1.Add(theatre);
            theatrelist1.Add(theatre1);
            return theatrelist1;
        }

        public int TheatrePrice(Price price)
        {
           return price.TotalAmount = price.Amount + price.GSTPrice + price.Discount;
        }

        public MarvelsTheatreProvider()
        {
            theatrelist1 = new List<Theatre>();
        }
    }
}
