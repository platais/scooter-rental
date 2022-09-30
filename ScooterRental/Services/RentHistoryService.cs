using System;
using System.Collections.Generic;
using System.Linq;

namespace ScooterRental
{
    public class RentHistoryService : IRentHistoryService
    {
        private IList<RentedScooter> _records;
        public RentHistoryService()
        {
            _records = new List<RentedScooter>();
        }
        public void AddRent(string id, decimal pricePerMinute, DateTime startTime)
        {
            _records.Add(
                new RentedScooter
                {
                    StartRent = startTime,
                    Price = pricePerMinute,
                    ScooterId = id
                });
        }

        public void EndRent(string id, DateTime endTime)
        {
            var rent = _records.SingleOrDefault(r => r.ScooterId == id && r.EndRent == null);
            rent.EndRent = endTime;
        }
    }
}
