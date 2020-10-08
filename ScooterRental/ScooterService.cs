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
