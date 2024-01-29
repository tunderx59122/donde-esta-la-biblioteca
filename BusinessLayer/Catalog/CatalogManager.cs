using BusinessObjects.Entity;
using BusinessObjects.Enums;

namespace BusinessLayer.Catalog
{
    public class CatalogManager
    {
        BookRepository _bookRepository = new BookRepository();

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> GetAll(string type)
        {
            List<Book> books = [];

            foreach (Book book in this.GetAll())
            {
                books.Add(book);
            }

            return books;
        }

        public List<Book> GetFantasy()
        {
            List<Book> fantasyBooks = this.GetAll().Where(book => BookType.Fantasy == book.Type).ToList();
            return fantasyBooks;
        }
        public Book GetBestBook()
        {
            Book bestBook = this.GetAll().OrderByDescending(book => book.Rate).FirstOrDefault();
            return bestBook;
        }
        public Book FindBook(int id)
        {
            return _bookRepository.Get(id);
        }
    }
}
