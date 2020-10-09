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
            if (ValidateId(id))
                _scooters.Add(id, new Scooter(id, pricePerMinute));
        }

        public IList<Scooter> GetScooters()
        {
            return _scooters.Select(s => s.Value).ToList();
        }

        public Scooter GetScooterById(string id)
        {
            if (ValidateId(id))//
             return  _scooters[id];
            return null;
        }

        public void RemoveScooter(string id)
        {
          if(ValidateId(id))
            _scooters.Remove(id);
        }
        private bool ValidateId(string id)
        {
            if (String.IsNullOrEmpty(id))
                throw new ScooterIdNullException();
            if (_scooters.ContainsKey(id))
                throw new ScooterNotExistsException();//te kkko
        }
        public void GetScootersTest()
        {
            _scooterService.AddScooter("1", 0.2m);
            Assert.AreEqual(1, _scooterService.GetScooters().Count);
        }
    }
}
