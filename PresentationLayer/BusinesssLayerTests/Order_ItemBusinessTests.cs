using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;

namespace BusinesssLayerTests
{ 
    [TestClass]
    public class Order_ItemBusinessTests
    {
        [TestMethod]
        public void IsOrder_ItemInserted()
        {
            //Arrange-dodeliti vrednosti
            var mockOrder_ItemRepository = new Mock<IOrder_ItemRepository>();
            Order_Item oi = new Order_Item
            {
             
            OrderItemID=1,
            OrderID=1,
            ProductID=1,
            Quantity=4
        };
            mockOrder_ItemRepository.Setup(x => x.InsertOrderItems(oi)).Returns(1);

            Order_ItemBusiness order_ItemBusiness = new Order_ItemBusiness(mockOrder_ItemRepository.Object);

            //Act-izvrsiti operaciju
            var result = order_ItemBusiness.InsertOrderItems(oi);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOrder_ItemUpdated()
        {
            //Arrange-dodeliti vrednosti
            var mockOrder_ItemRepository = new Mock<IOrder_ItemRepository>();
            Order_Item oi = new Order_Item
            {

                OrderItemID = 1,
                OrderID = 1,
                ProductID = 1,
                Quantity = 4
            };
            mockOrder_ItemRepository.Setup(x => x.UpdateOrderItemsById(oi)).Returns(1);

            Order_ItemBusiness order_ItemBusiness = new Order_ItemBusiness(mockOrder_ItemRepository.Object);

            //Act-izvrsiti operaciju
            var result = order_ItemBusiness.UpdateOrderItemsById(oi);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOrder_ItemDeleted()
        {
            //Arrange-dodeliti vrednosti
            var mockOrder_ItemRepository = new Mock<IOrder_ItemRepository>();
            Order_Item OrderItemI = new Order_Item
            {

                OrderItemID = 1,
                OrderID = 1, 
                ProductID = 1,
                Quantity = 4
            };
            mockOrder_ItemRepository.Setup(x => x.DeleteOrderItemsById(It.IsAny<int>())).Returns(1);
            Order_ItemBusiness order_ItemBusiness = new Order_ItemBusiness (mockOrder_ItemRepository.Object);

            //Act
            var result = order_ItemBusiness.DeleteOrderItemsById(It.IsAny<int>());

            //Asert
            Assert.IsTrue(result);
        }

    }
}
