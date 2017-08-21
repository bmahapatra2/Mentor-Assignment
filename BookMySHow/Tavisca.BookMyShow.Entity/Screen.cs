using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.BookMyShow.Entity
{
    public class Screen
    {
        public int Id { get; set; }

        //public List<Movie> Movie { get; set; }

        public List<SeatDetail> SeatDetail { get; set; }

        public List<TimeSlot> DailyShowTiming { get; set; }

        public Screen()
        {
            SeatDetail = new List<SeatDetail>();
            DailyShowTiming = new List<TimeSlot>();
           
        }
       
    }
}
