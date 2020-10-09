using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class ScooterNotExistsException : Exception
    {

        public ScooterNotExistsException():base("scooter does not exist")
        {

        }
    }
}
