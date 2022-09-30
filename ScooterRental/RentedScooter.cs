using System;

namespace ScooterRental
{
    public class RentedScooter
    {
        public DateTime StartRent { get; set; }
        public decimal Price { get; set; }
        
        public DateTime? EndRent { get; set; }
        public string ScooterId { get; set; }
    }
}
