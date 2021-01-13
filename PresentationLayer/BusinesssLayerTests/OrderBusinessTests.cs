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

                OrderID = 1,
                CustomerID = 2,
                Order_Date = DateTime.Now,
                Delivery_Date = DateTime.Now
            };
            mockOrderRepository.Setup(x => x.InsertOrders(o)).Returns(1);

            OrderBusiness orderBusiness = new OrderBusiness(mockOrderRepository.Object);

            //Act-izvrsiti operaciju
            var result = orderBusiness.InsertOrders(o);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOrderUpdated()
        {
            //Arrange-dodeliti vrednosti
            var mockOrderRepository = new Mock<IOrderRepository>();
            Order o = new Order
            {

                OrderID = 1,
                CustomerID = 2,
                Order_Date = DateTime.Now,
                Delivery_Date = DateTime.Now
            };
            mockOrderRepository.Setup(x => x.UpdateOrdersById(o)).Returns(1);

            OrderBusiness orderBusiness = new OrderBusiness(mockOrderRepository.Object);

            //Act-izvrsiti operaciju
            var result = orderBusiness.UpdateOrdersById(o);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsOrderDeleted()
        {
            //Arrange-dodeliti vrednosti 
            var mockOrderRepository = new Mock<IOrderRepository>();
            Order OrderID = new Order
            {

                OrderID = 1,
                CustomerID = 2,
                Order_Date = DateTime.Now,
                Delivery_Date = DateTime.Now
            };
            mockOrderRepository.Setup(x => x.DeleteOrdersById(It.IsAny<int>())).Returns(1);
            OrderBusiness orderBusiness = new OrderBusiness(mockOrderRepository.Object);

            //Act
            var result = orderBusiness.DeleteOrdersById(It.IsAny<int>());

            //Asert
            Assert.IsTrue(result);
        }
    }
}
