using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBear.Models;

namespace GummiBear.Tests
{
    [TestClass]
    public class ReviewTests
    {

        [TestMethod]
        public void Equals_ReviewsAreEqual_True()
        {
            Review review = new Review
            {
                ReviewId = 0,
                Title = "Yummy",
                Author = "Sam Johnson",
                Content = "These were very tasty",
                Rating = 5
            };

            Review reviewCopy = review;

            Assert.AreEqual(reviewCopy, review);
        }

        [TestMethod]
        public void GetRating_ReturnsRating_Int()
        {
            //Arrange
            Review review = new Review
            {
                Rating = 5
            };

            //Act
            var result = review.Rating;

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ContentBodyLength_ContentBodyLengthUnder255_True()
        {
            //Arrange
            var review = new Review
            {
                Content = "These are so yummy"
            };

            //Act
            bool result = review.ContentBodyLength();

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}       