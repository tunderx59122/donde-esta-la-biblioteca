namespace BusinessLayer.Test;
using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using DataAccessLayer.Repository;
using Moq;

[TestClass]
public class CatalogManagerTest
{
    private readonly Mock<BookRepository> _mockBookRepository;
    private readonly CatalogManager _catalogManager;


    [TestMethod]
    public void TestDisplayCatalog()
    {

        // Arrange
        _mockBookRepository.Setup(repo => repo.GetAll()).Returns(new List<Book>
                {
                    new Book { Id = 1, Name = "Book 1" },
                    new Book { Id = 2, Name = "Book 2" }
                });

        // Act & Assert
        Assert.ThrowsException<Exception>(() => _catalogManager.DisplayCatalog());
    }

    [TestMethod]
    public void DisplayCatalog(BookTypes type)
    {

        // Arrange
        _mockBookRepository.Setup(repo => repo.GetAll()).Returns(new List<Book>
                {
                    new Book { Id = 1, Name = "Book 1" },
                    new Book { Id = 2, Name = "Book 2" }
                });

        // Act & Assert
        Assert.ThrowsException<Exception>(() => _catalogManager.DisplayCatalog());
    }

    [TestMethod]
    public void TestFindBook()
    {
        // Arrange
        _mockBookRepository.Setup(repo => repo.GetAll()).Returns(new List<Book>
            {
                new Book { Id = 1, Name = "Book 1" },
                new Book { Id = 2, Name = "Book 2" }
            });
        // Act
        var result = _catalogManager.FindBook(1);

        // Assert
        Assert.IsNotNull(result);
        Assert.Equals("Book 1", result.Name);
    }

    [TestMethod]
    public void TestGetBooksFantasy()
    {
        // Arrange
        _mockBookRepository.Setup(repo => repo.GetAll()).Returns(new List<Book>
            {
                new Book { Id = 1, Name = "Book 1", Type = BookTypes.FANTASY },
                new Book { Id = 2, Name = "Book 2", Type = BookTypes.AVENTURE }
            });

        // Act
        var result = _catalogManager.GetBooksFantasy();

        // Assert
        Assert.IsNotNull(result);
        Assert.Equals(1, result.Count());
        Assert.Equals("Book 1", result.First().Name);
    }


    [TestMethod]
    public void TestGetBookBestRated()
    {
        // Arrange
        _mockBookRepository.Setup(repo => repo.GetAll()).Returns(new List<Book>
            {
                new Book { Id = 1, Name = "Book 1", Rate = 5 },
                new Book { Id = 2, Name = "Book 2", Rate = 4 }
            });

        // Act
        var result = _catalogManager.GetBookBestRated();

        // Assert
        Assert.IsNotNull(result);
        Assert.Equals("Book 1", result.Name);
        Assert.Equals(5, result.Rate);
    }
}