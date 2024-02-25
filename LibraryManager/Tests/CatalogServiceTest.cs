
using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using Moq;
using Services.Services;

namespace Services.Test { 
    [TestClass]
    public class CatalogServiceTest
    {
        private Mock<ICatalogManager> _mockCatalogManager;
        private CatalogService _catalogService;

        [TestInitialize]
        public void Initialize()
        {
            _mockCatalogManager = new Mock<ICatalogManager>();
            _catalogService = new CatalogService(_mockCatalogManager.Object);
        }

        [TestMethod]
        public void TestShowCatalog()
        {
            // Arrange
            _mockCatalogManager.Setup(manager => manager.DisplayCatalog()).Returns(new List<Book>
            {
                new Book { Id = 1, Name = "Book 1" },
                new Book { Id = 2, Name = "Book 2" }
            });

            // Act
            var result = _catalogService.ShowCatalog();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void TestShowCatalogWithType()
        {
            // Arrange
            _mockCatalogManager.Setup(manager => manager.DisplayCatalog()).Returns(new List<Book>
            {
                new Book { Id = 1, Name = "Book 1" },
                new Book { Id = 2, Name = "Book 2" }
            });

            // Act
            var result = _catalogService.ShowCatalog(typeof(Book));

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void TestFindBook()
        {
            // Arrange
            _mockCatalogManager.Setup(manager => manager.FindBook(1)).Returns(new Book { Id = 1, Name = "Book 1" });

            // Act
            var result = _catalogService.FindBook(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Book 1", result.Name);
        }

        [TestMethod]
        public void TestGetBooksFantasy()
        {
            // Arrange
            _mockCatalogManager.Setup(manager => manager.GetBooksFantasy()).Returns(new List<Book>
            {
                new Book { Id = 1, Name = "Book 1" },
                new Book { Id = 2, Name = "Book 2" }
            });

            // Act
            var result = _catalogService.GetBooksFantasy();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void TestGetBookBestRated()
        {
            // Arrange
            _mockCatalogManager.Setup(manager => manager.GetBookBestRated()).Returns(new Book { Id = 1, Name = "Book 1", Rate = 5 });

            // Act
            var result = _catalogService.GetBookBestRated();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Book 1", result.Name);
            Assert.AreEqual(5, result.Rate);
        }
    }
}
