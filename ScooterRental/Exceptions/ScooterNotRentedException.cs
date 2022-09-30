using System;

namespace ScooterRental
{
    public class ScooterNotRentedException: Exception
    {
        public ScooterNotRentedException():base("...")
        {
        }
    }
}
