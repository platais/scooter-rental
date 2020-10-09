using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalCompanyTests
    {
        private IRentalCompany _company;
        private IScooterService _scooterService;
        private string _companyName = "Test company";
        public RentalCompanyTests()
        {
            _scooterService = new ScooterService();
            _company = new RentalCompany(_companyName, _scooterService);
        }
        [TestMethod]
        public void RentalCompanyNameTest()
        {
            Assert.AreEqual(_companyName, _company.Name);
        }
        [TestMethod]
        public void RentalCompanyNameNullTest()
        {
            Assert.ThrowsException<RentalCompanyNameNullException>(() => _company = new RentalCompany(null));
        }

        public void RentalCompanyStartRentTest()
        {
            _scooterService.AddScooter("1", 0.2m);
            _company.StartRent("1");
            Assert.AreEqual(true,
                _scooterService.GetScooterById("1").IsRented);
        }
        [TestMethod]
        public void RentalCompanyRentNotExistingScooterTest() 
        {
            Assert.ThrowsException<ScooterNotExistsException>(
                () => _company.StartRent("1")
                );

        }

        [TestMethod]
        public void RentScooterWithoutTestId()
        {
            Assert.ThrowsException<ScooterIdNullException>(
                ()=>
                );
        }

        [TestMethod]
        public void RentScooterTwiceTest()
        {
            _scooterService.AddScooter("1", 0.2m);
            _company.StartRent("1");
            Assert.ThrowsException<ScooterAlreadyRentedException>(
                () => _company.StartRent("1")
                );
        }

        public void EndScooterRentTest() 
        {
            _scooterService.AddScooter("1", 0.2m);
            _company.StartRent("1");
            _company.EndRent("1");
            Assert.AreEqual(false,
                _scooterService.GetScooterById("1").IsRented());
        }

        public void EndNotRentedScooterRentTest() 
        {
            _scooterService.AddScooter("1", 0.2m);
            Assert.ThrowsException<ScooterNoteRentedException>(
                ()=>...
                )
        }
    }
}
