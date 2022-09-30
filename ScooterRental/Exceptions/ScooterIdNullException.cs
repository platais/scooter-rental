using System;

namespace ScooterRental
{
    public class ScooterIdNullException : Exception
    {
        public ScooterIdNullException():base("scooter Id cant be null")
        {
        }
    }
}
