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
        public Mock<IGenericRepository<Book>> _bookRepository;
        public CatalogManager _catalogManager;

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
            Book awaitedResult = new Book(667, "Pablo", 12, BookType.Aventure, 2, 1);
            List<Book> mockBooks = [new Book(14, "Juan", 10, BookType.Fantasy, 3, 1), awaitedResult];
            _bookRepository.Setup(bkRep => bkRep.GetAll()).Returns(mockBooks);
            List<Book> books = _catalogManager.DisplayCatalog(BookType.Aventure);
            Assert.AreEqual(awaitedResult, books[0]);
            Assert.AreEqual(books.Count, 1);
        }

        [TestMethod()]
        public void DisplayFantasyTest()
        {
            Book awaitedResult = new Book(14, "Juan", 10, BookType.Fantasy, 3, 1);
            List<Book> mockBooks = [new Book(667, "Pablo", 12, BookType.Aventure, 2, 1), awaitedResult];
            _bookRepository.Setup(bkRep => bkRep.GetAll()).Returns(mockBooks);
            List<Book> books = _catalogManager.DisplayCatalog(BookType.Fantasy);
            Assert.AreEqual(awaitedResult, books[0]);
            Assert.AreEqual(books.Count, 1);
        }

        [TestMethod()]
        public void DisplayBestTest()
        {
            Book awaitedResult = new Book(14, "Juan", 10, BookType.Fantasy, 5, 1);
            List<Book> mockBooks = [new Book(667, "Pablo", 12, BookType.Aventure, 4, 1), awaitedResult];

            _bookRepository.Setup(bkRep => bkRep.GetAll()).Returns(mockBooks);

            Book bestBook = _catalogManager.DisplayBest();
            Assert.AreEqual(bestBook, awaitedResult);
        }

        [TestMethod()]
        public void FindBookTest()
        {
            Book awaitedResult = new Book(14, "Juan", 10, BookType.Fantasy, 3, 1);
            List<Book> mockBooks = [new Book(667, "Pablo", 12, BookType.Aventure, 2, 1), awaitedResult];

            //_bookRepository.Setup(bkRep => bkRep.Get(id)).Returns(mockBooks);

            Book foundBook = _catalogManager.FindBook(14);
            Assert.AreEqual(awaitedResult, foundBook);
        }
    }
}
