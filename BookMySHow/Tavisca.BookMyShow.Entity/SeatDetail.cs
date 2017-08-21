using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.BookMyShow.Entity
{
   public class SeatDetail
    {
        public string SeatType { get; set; }

        public int SeatAvailability { get; set; }
        
        public SeatRange SeatRange { get; set; }
    }
}
