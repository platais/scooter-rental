using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class NegativePriceException : Exception
        //jamantojas no exception klases
    {
        public NegativePriceException(): base("price per minute cant be negative")
        {

        }
    }
}
