using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentalCompanyNameNullException : Exception
    {
        public RentalCompanyNameNullException() : base("Company name can't be null or empty")
        {
        }
    }
}
