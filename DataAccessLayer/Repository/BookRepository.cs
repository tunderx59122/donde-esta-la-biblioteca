using BusinessObjects.Entity;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;

/// <summary>
/// Summary description for BookRepository
/// </summary>
public class BookRepository : IBookRepository
{
    public IEnumerable<Book> GetAll()
    {
        IEnumerable<Book> books = [];
        return books;
    }

    public Book Get(int id)
    {
        return new Book(1, "The Lord of the Rings", 1000, BookType.Fantasy, 5, 1);
    }   
}
