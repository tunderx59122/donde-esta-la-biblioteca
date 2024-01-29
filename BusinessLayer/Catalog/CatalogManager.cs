using BusinessObjects.Entity;
using BusinessObjects.Enums;

namespace BusinessLayer.Catalog
{
    public class CatalogManager
    {
        public static IEnumerable<Book> GetAll()
        {
            return BookRepository.GetAll();
        }

        public static List<Book> GetAll(string type)
        {
            List<Book> books = [];

            foreach (Book book in CatalogManager.GetAll())
            {
                books.Add(book);
            }

            return books;
        }

        public static List<Book> GetFantasy()
        {
            List<Book> fantasyBooks = CatalogManager.GetAll().Where(book => BookType.Fantasy == book.Type).ToList();
            return fantasyBooks;
        }

        public static Book FindBook(int id)
        {
            return BookRepository.Get(id);
        }
    }
}
