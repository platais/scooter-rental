using System;

namespace ScooterRental
{
    public class RentalCompanyNameNullException : Exception
    {
        public RentalCompanyNameNullException() : base("Company name can't be null or empty")
        {
        }
    }
}
