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
                CategoryID = 1,
                Name = "Muska garderoba",
                Description = "Letnja kolekcija"
            };
            mockCategoryRepository.Setup(x => x.InsertCategories(c)).Returns(1);

            CategoryBusiness categoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            //Act-izvrsiti operaciju
            var result = categoryBusiness.InsertCategories(c);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCategoryUpdated()
        {
            //Arrange-dodeliti vrednosti
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            Category c = new Category
            {
                CategoryID = 1,
                Name = "Muska garderoba",
                Description = "Letnja kolekcija"
            };
            mockCategoryRepository.Setup(x => x.UpdateCategoriesById(c)).Returns(1);

            CategoryBusiness categoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            //Act-izvrsiti operaciju
            var result = categoryBusiness.UpdateCategoriesById(c);
            //Assert-proveriti rezultat
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCategoryDeleted()
        {
            //Arange
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            Category CategoriesID = new Category()
            {
                CategoryID = 1,
                Name = "Muska garderoba",
                Description = "Letnja kolekcija"
            };
            mockCategoryRepository.Setup(x => x.DeleteCategoriesById(It.IsAny<int>())).Returns(1);
            CategoryBusiness categoryBusiness = new CategoryBusiness(mockCategoryRepository.Object);

            //Act
            var result = categoryBusiness.DeleteCategoriesById(It.IsAny<int>());

            //Asert
            Assert.IsTrue(result);
        }
    }
}
