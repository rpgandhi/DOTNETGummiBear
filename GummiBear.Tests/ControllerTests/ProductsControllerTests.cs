using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GummiBear.Models;
using GummiBear.Controllers;
using Moq;
using System.Linq;
using System.Diagnostics;
using System;

namespace GummiBear.Tests.ControllerTests
{

    [TestClass]
    public class ProductsControllerTests : IDisposable
    {
        Mock<IProductRepository> mock = new Mock<IProductRepository>();
       

        private void DbSetup()
        {
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductId = 1, Name = "Cinnamon Gummi Bears", Cost = 8,
                    Description = "Small bag of cinnamon gummi bears" },
                new Product {ProductId = 2, Name = "Strawberry Gummi Bears", Cost = 10,
                    Description = "Large bag of strawberry gummi bears"},
                new Product {ProductId = 3, Name ="Licorice Gummi Bears", Cost = 8,
                    Description = "Small bag of licorice gummi bears" }
            }.AsQueryable());
        }


        public void Dispose()
        {
            db.DeleteAll();
        }
    }
}
