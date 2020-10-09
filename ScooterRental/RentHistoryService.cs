using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentHistoryService : IRentHistoryService
    {
        private IList<RentedScooter> _records;
        public RentHistoryService()
        {
            _records = new List<RentedScooter>();
        }
        public void AddRent(string id, decimal pricePerMinute, DateTime.Now)
        {
            _historyService.AddRent("1", 0.2m, DateTime.Now);
        }

        public void EndRent(string id, DateTime endTime)
        {
            _records.SingleOrDefault(r => r.ScooterId == id && r.EndRent == null);
            Rent.EndRent ... 
        }
    }
}
