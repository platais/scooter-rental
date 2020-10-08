using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private Dictionary<string, Scooter> _scooters;
        public ScooterService()
        {
            _scooters = new Dictionary<string, Scooter>();
        }
        public void AddScooter(string id, decimal pricePerMinute) 
        {
            if (pricePerMinute < 0)
                throw new NegativePriceException();
            if (String.IsNullOrEmpty(id)) //parbaudit vai te bij pareizi
                throw new ScooterIdNullException();
            if (_scooters.ContainsKey(id))
                throw new ScooterIdExistsException();

            _scooters.Add(id, new Scooter(id, pricePerMinute));
        }
        public IList<Scooter> GetScooters()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveScooter(string id)
        {
            throw new NotImplementedException();
        }

        public Scooter GetScooterById(string scooterId)
        {
            return _scooters[scooterId];
        }
    }
}
