using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.BookMyShow.Entity
{
    public class Price
    {
        public int Amount { get; set; }

        public string Currency { get; set; }

        public int GSTPrice{ get; set; }

        public int TotalAmount { get; set; }

        public int Discount { get; set; }
    }
}
