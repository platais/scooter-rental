using System;

namespace ScooterRental
{
    public class ScooterAlreadyRentedException: Exception 
    {
        public ScooterAlreadyRentedException() : base("scooter alread rented, cant....")
        {
        }  
    }

    
}
