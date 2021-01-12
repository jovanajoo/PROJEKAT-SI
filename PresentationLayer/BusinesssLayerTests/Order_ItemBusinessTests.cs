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
             
            OrderItemID=9,
            OrderID=8,
            ProductID=7,
            Quantity=2
        };
            mockOrder_ItemRepository.Setup(x => x.InsertOrderItems(oi)).Returns(1);

            Order_ItemBusiness order_ItemBusiness = new Order_ItemBusiness(mockOrder_ItemRepository.Object);

            //Act-izvrsiti operaciju
            var result = order_ItemBusiness.InsertOrderItems(oi);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }
    }
}
