using BusinessObjects.Entity;
using BusinessObjects.Enums;

namespace BusinessLayer.Catalog
{
    public class CatalogManager
    {
        BookRepository _bookRepository = new BookRepository();

        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> DisplayCatalog(string type)
        {
            List<Book> books = [];

            foreach (Book book in this.DisplayCatalog())
            {
                books.Add(book);
            }

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
