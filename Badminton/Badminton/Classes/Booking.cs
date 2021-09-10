using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badminton.Classes
{
    public class Booking
    {
        public Customer Customer { get; set; }
        public Court Court { get; set; }

        public Booking( Customer customer,Court court)
        {
            Court = court;
            Customer = customer;
        }
    }
}
