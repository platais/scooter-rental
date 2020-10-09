using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {


        //visitesti jaabuut tikai caur interfeisiem, nedodam iekšā klasi
        public RentalCompany(string name, IScooterService service)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new RentalCompanyNameNullException();//NOt?
            }
            Name = name; //
            _service = service;
        }
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
        public void StartRent(string id)
        {
            var scooter = _service.GetScooterById(id);
            if (scooter.IsRented)
                throw new ScooterAlreadyRentedException();
            scooter.IsRented = true;
        }

        public decimal EndRent(string id)
        {
            var scooter = _service.GetScooterById(id);
            if (!scooter.IsRented)
                throw new ScooterNotRentedException();
            scooter.IsRented = false;
            return 0.2m;
        }




    }
}
