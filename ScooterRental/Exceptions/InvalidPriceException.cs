using System;

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
