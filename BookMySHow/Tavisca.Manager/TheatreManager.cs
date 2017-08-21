using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.BookMyShow.Entity;

namespace Tavisca.BookMyShow.Manager
{
    class TheatreManager
    {
        
        List<Theatre> Theatre { get; set; }

        public TheatreManager()
        {
            Theatre = new List<Theatre>();
        }

        public void RegisterTheatre(Theatre theatre)
        {
            Theatre.Add(theatre);
        }

        public List<Theatre> GetTheatre(Theatre theatre)
        {
            return Theatre;
        }

    }
}
