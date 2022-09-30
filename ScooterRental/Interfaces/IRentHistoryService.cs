using System;

namespace ScooterRental
{
    public interface IRentHistoryService
    {
        void AddRent(string id, decimal pricePerMinute, DateTime startTime );
        void EndRent(string id, DateTime endTime);
    }
}
