using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.BookMyShow.Entity;
using Tavisca.BookMyShow.Manager;
using Tavisca.TheatreProviderContract;

namespace Tavisca.Manager
{
    public class Decorator : ITheatreProvider
    {
        private ITheatreProvider _theatrePro;
            private ITheatreProvider _price;

        
        public Decorator(ITheatreProvider theatreprovider)
        {
            this._theatrePro = theatreprovider;
            this._price = theatreprovider;
        }

        public List<Theatre> GetTheaters()
        {
            return this._theatrePro.GetTheaters();
        }

        public int TheatrePrice(Price price)
        {
            var s = Convert.ToInt32(ConfigurationManager.AppSettings["Discount"]);
            int value = (int)s;
            return value + this._price.TheatrePrice(price);
        }
    }
}
