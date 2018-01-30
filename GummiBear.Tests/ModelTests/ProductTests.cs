using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBear.Models;

namespace GummiBear.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void GetDescription_ReturnsProductDescription_String()
        {
            //Arrange
            var product = new Product
            {
                Description = "Small bag of gummy bears"
            };

            //Act
            var result = product.Description;

            //Assert
            Assert.AreEqual("Small bag of gummy bears", result);
        }

        [TestMethod]
        public void GetAverageRating_ReturnsAverageRating_Double()
        {
            //Arrange
            var product = new Product
            {
                AverageRating = 15
            };

            //Act
            var result = product.AverageRating;

            //Assert
            Assert.AreEqual(15, result);
        }


        [TestMethod]
        public void Equals_ProductsAreEqual_True()
        {
            Product product = new Product
            {
                ProductId = 0,
                Name = "Cinnamon",
                Cost = 8,
                Description = "Small bag of cinnamon gummi bears"
            };

            Product productCopy = product;

            Assert.AreEqual(productCopy, product);
        }
    }
}

