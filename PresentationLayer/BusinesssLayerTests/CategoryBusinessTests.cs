using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;

namespace BusinesssLayerTests
{
    [TestClass]
    public class CategoryBusinessTests
    {
        [TestMethod]
        public void IsCategoryInserted()
        {
            //Arrange-dodeliti vrednosti
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            Category c = new Category
            {
                CategoryID = 3,
                Name = "Muska garderoba",
                Description = "Pamuk"
            };
            mockCategoryRepository.Setup(x => x.InsertCategories(c)).Returns(1);

            CategoryBusiness categoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            //Act-izvrsiti operaciju
            var result = categoryBusiness.InsertCategories(c);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }
    }
}
