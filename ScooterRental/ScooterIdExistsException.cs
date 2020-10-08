using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class ScooterIdExistsException: Exception
    {
        public ScooterIdExistsException() :base("scooter Id should be unique")
        {

        }
    }
}
