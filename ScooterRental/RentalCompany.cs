using System;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _service;
        private readonly IRentHistoryService _historyService;
        

        //visitesti jaabuut tikai caur interfeisiem, nedodam iekšā klasi
        public RentalCompany(string name, IScooterService service, IRentHistoryService historyService)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new RentalCompanyNameNullException();//NOt?
            }
            Name = name; //
            _service = service;
            _historyService = historyService;
        }

        public string Name { get; }
        public void StartRent(string id)
        {
            var scooter = _service.GetScooterById(id);
            if (scooter.IsRented)
                throw new ScooterAlreadyRentedException();
            scooter.IsRented = true;
        }
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new NotImplementedException();
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
