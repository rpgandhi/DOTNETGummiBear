using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GummiBear.Models;
using GummiBear.Controllers;
using Moq;
using System.Linq;

namespace ToDoList.Tests.ControllerTests
{

    [TestClass]
    public class ItemsControllerTests
    {
        Mock<IItemRepository> mock = new Mock<IItemRepository>();

        private void DbSetup()
        {
            mock.Setup(m => m.Items).Returns(new Item[]
            {
                new Item {ItemId = 1, Description = "Wash the dog" },
                new Item {ItemId = 2, Description = "Do the dishes" },
                new Item {ItemId = 3, Description = "Sweep the floor" }
            }.AsQueryable());
        }
