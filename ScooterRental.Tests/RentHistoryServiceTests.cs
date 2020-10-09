using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentHistoryServiceTests
    {
        private IRentHistoryService _historyService;

        public RentHistoryServiceTests()
        {
            _historyService = new RentHistoryService();
        }

        [TestMethod]
        public void AddRecordTest()
        {
            _historyService.AddRent("1", 0.2m, DateTime.Now);
        }

        [TestMethod]
        public void EditRecordTest()
        {
            _historyService.AddRent("1", 0.2m, DateTime.Now);
            _historyService.EndRent("1", DateTime.Now);

        }

    }
}
