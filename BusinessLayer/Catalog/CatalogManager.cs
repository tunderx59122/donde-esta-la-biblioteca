using BusinessObjects.Entity;

namespace BusinessLayer.Catalog
{
    internal class CatalogManager
    {
        public IEnumerable<Book> GetAll()
        {
            return BookRepository.GetAll();
        }

        public IEnumerable<Book> GetAll(string type)
        {
            IEnumerable<Book> books = [];

            foreach (Book book in this.GetAll())
            {
                books.Add(book);
            }

            return books;
        }

        public Book FindBook(int id)
        {
            return BookRepository.Get(id);
        }
    }
}
