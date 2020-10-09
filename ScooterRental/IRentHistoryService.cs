using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public interface IRentHistoryService
    {
        void AddRent(string id, decimal pricePerMinute, DateTime startTime );
        void EndRent(string id, DateTime endTime);
    }
}
