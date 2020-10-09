using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentedScooter
    {
        public DateTime StartRent { get; set; }
        public decimal Price { get; set; }
        
        public DateTime? EndRent { get; set; }
        public string ScooterId { get; set; }
    }
}
