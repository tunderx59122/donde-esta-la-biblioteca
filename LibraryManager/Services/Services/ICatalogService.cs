using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        public IEnumerable<Book> ShowCatalog();
        public IEnumerable<Book> ShowCatalog(Type type);
        public Book FindBook(int id);
        public IEnumerable<Book> GetBooksFantasy();
        public Book GetBookBestRated();
    }
}