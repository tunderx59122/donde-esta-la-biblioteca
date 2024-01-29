using BusinessObjects.Entity;
using BusinessObjects.Enums;

namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        BookRepository _bookRepository = new BookRepository();

        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> DisplayCatalog(BookType type)
        {
            List<Book> books = this.DisplayCatalog().Where(book => type == book.Type).ToList();
            return books;
        }

        public List<Book> DisplayFantasy()
        {
            List<Book> fantasyBooks = this.DisplayCatalog().Where(book => BookType.Fantasy == book.Type).ToList();
            return fantasyBooks;
        }
        public Book DisplayBest()
        {
            Book bestBook = this.DisplayCatalog().OrderByDescending(book => book.Rate).FirstOrDefault();
            return bestBook;
        }
        public Book FindBook(int id)
        {
            return _bookRepository.Get(id);
        }
    }
}
