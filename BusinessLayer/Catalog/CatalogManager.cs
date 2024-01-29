using BusinessObjects.Entity;

namespace BusinessLayer.Catalog
{
    public class CatalogManager
    {
        public static IEnumerable<Book> GetAll()
        {
            return BookRepository.GetAll();
        }

        public static IEnumerable<Book> GetAll(string type)
        {
            IEnumerable<Book> books = [];

            foreach (Book book in CatalogManager.GetAll())
            {
                books.Add(book);
            }

            return books;
        }

        public static Book FindBook(int id)
        {
            return BookRepository.Get(id);
        }
    }
}
