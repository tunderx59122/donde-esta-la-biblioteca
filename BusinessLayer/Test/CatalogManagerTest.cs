using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using Moq;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;

namespace BusinessLayer.Test
{
    [TestClass()]   
    public class CatalogManagerTest
    {
        private readonly Mock<IGenericRepository<Book>> _bookRepository;
        private readonly CatalogManager _catalogManager;

        public CatalogManagerTest()
        {
            _bookRepository = new Mock<IGenericRepository<Book>>();
            _catalogManager = new CatalogManager(_bookRepository.Object);
        }

        [TestMethod()]
        public void DisplayCatalogTest()
        {
            List<Book> mockBooks = [new Book(667, "Pablo", 12, BookType.Aventure, 2, 1)];
            _bookRepository.Setup(bkRep => bkRep.GetAll()).Returns(mockBooks);

            IEnumerable<Book> books = _catalogManager.DisplayCatalog();
            Assert.AreEqual(mockBooks, books);
        }

        [TestMethod()]
        public void DisplayCatalogTest1()
        {
            List<Book> mockBooks = [new Book(667, "Pablo", 12, BookType.Aventure, 2, 1), new Book(14, "Juan", 10, BookType.Fantasy, 3, 1)];
            _bookRepository.Setup(bkRep => bkRep.GetAll()).Returns(mockBooks);

            IEnumerable<Book> books = _catalogManager.DisplayCatalog();
            Assert.AreEqual([mockBooks[1]], books);
        }

        [TestMethod()]
        public void DisplayFantasyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisplayBestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindBookTest()
        {
            Assert.Fail();
        }
    }
}
