using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;

namespace BusinesssLayerTests
{
    [TestClass]
    public class OrderBusinessTests
    {
        [TestMethod]
        public void IsOrderInserted()
        {
            //Arrange-dodeliti vrednosti
            var mockOrderRepository = new Mock<IOrderRepository>();
            Order o = new Order
            {

                OrderID = 5,
                CustomerID = 4,
                Order_Date = "12/1/2021",
                Delivery_Date ="14/1/2021"
            };
            mockOrderRepository.Setup(x => x.InsertOrders(o)).Returns(1);

            OrderBusiness orderBusiness = new OrderBusiness(mockOrderRepository.Object);

            //Act-izvrsiti operaciju
            var result = orderBusiness.InsertOrders(o);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }
    }
}
