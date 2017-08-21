using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.BookMyShow.Entity
{
    public class TimeSlot
    {
        //TimeSlot time = new TimeSlot();

        public int StartTimeHours { get; set; }

        public int EndTimeHours { get; set; }

        public Movie Movie { get; set; }

        public Price Price { get; set; }

        public TimeSlot()
        {
            Price = new Price();
        }


    }
}
