using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;

namespace BusinesssLayerTests
{
    [TestClass]
    public class CustomerBusinessTests
    {
        public void IsCustomerInserted()
        {
            //Arrange-dodeliti vrednosti
            var mockCustomerRepository = new Mock<ICustomerRepository>();
            Customer c = new Customer
            {

                CustomerID = 6,
                Username = "Milic",
                Name = "Ana",
                Email= "anamijailovic98@gmail.com",
                City="Cacak",
                Address="Trbusani bb",
                PhoneNumber= "060 555 555",
                Password="12345"
            };
            mockCustomerRepository.Setup(x => x.InsertCustomers(c)).Returns(1);

            CustomerBusiness customerBusiness = new CustomerBusiness(mockCustomerRepository.Object);

            //Act-izvrsiti operaciju
            var result = customerBusiness.InsertCustomers(c);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }
    }
}
