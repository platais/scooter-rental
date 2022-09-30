using System;

namespace ScooterRental
{
    public class ScooterNotExistsException : Exception
    {

        public ScooterNotExistsException():base("scooter does not exist")
        {
        }
    }
}
