using System;

namespace ScooterRental
{
    public class ScooterIdExistsException: Exception
    {
        public ScooterIdExistsException() :base("scooter Id should be unique")
        {
        }
    }
}
