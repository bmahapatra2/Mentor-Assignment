using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.BookMyShow.Entity;
using Tavisca.TheatreProviders;
using Tavisca.BookMyShow.Manager;
using Tavisca.TheatreProviderContract;
using System.IO;
using Newtonsoft.Json;


namespace Tavisca.Manager
{
    public class TheatresManager
    {
        List<Theatre> CombinedTheatreList { get; set; }
        public TheatresManager()
        {
            CombinedTheatreList = new List<Theatre>();
        }
        public List<Theatre> GetTheatreList()
        {

            Theatre theatre = new Theatre();
            MarvelsTheatreProvider theatreprovider1 = new MarvelsTheatreProvider();
            DCTheatreProvider theatreprovider2 = new DCTheatreProvider();

            CombinedTheatreList.AddRange(theatreprovider1.GetTheaters());
            CombinedTheatreList.AddRange(theatreprovider2.GetTheaters());
            return CombinedTheatreList;
        }

        public int DistinctList()
        {

            int number;
            List<string> TheatreName = new List<string>();
            foreach (var s in GetTheatreList())
            {
                TheatreName.Add(s.Name);
            }
            number = TheatreName.Distinct().Count();
            return number;
        }



        public List<Theatre> CallproviderList(string type)
        {
            TheatresManager theatremanager = new TheatresManager();
            //TheatreProviderFactory movietheatre = new TheatreProviderFactory();
            ITheatreProvider theatreprovider = new TheatreProviderFactory().GetShow(type);

            return theatreprovider.GetTheaters();
        }

        
    }
}
