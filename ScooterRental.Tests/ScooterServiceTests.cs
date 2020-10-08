using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ScooterServiceTests
    {
        private IScooterService _scooterService;
        public ScooterServiceTests()
        {
            _scooterService = new ScooterService();
        }
        [TestMethod]
        public void AddScooterTest()
        {
            _scooterService.AddScooter("1", 0.2m);
        }
        [TestMethod]
        public void GetScooterByIdTest()
        { 
            _scooterService.AddScooter("1", 0.2m);
            var scooter = _scooterService.GetScooterById("1");
            Assert.AreEqual("1", scooter.Id);
            Assert.AreEqual(0.2m, scooter.PricePerMinute);
        }
        [TestMethod]
        public void AddScooterNegativePriceTest()
        {
            _scooterService.AddScooter("1", -0.2m);
            Assert.ThrowsException<NegativePriceException>(
                ()=> _scooterService.AddScooter("1", -0.2m)
                );
        }

        [TestMethod]
        public void AddScooterNullTest()
        {
            Assert.ThrowsException<ScooterIdNullException>(
                () => _scooterService.AddScooter(null, -0.2m)
                );
        }
        [TestMethod]
        public void AddScooterUniqueIdTest()
        {
            _scooterService.AddScooter("1", 0.2m);
            Assert.ThrowsException<ScooterIdExistsException>(
                () => _scooterService.AddScooter("1", 0.2m)
                );
        }
    }
}
