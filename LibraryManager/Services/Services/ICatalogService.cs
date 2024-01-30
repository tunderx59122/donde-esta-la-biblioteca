using BusinessObjects.Entity;

namespace Services.Services
{
    public interface ICatalogService
    {
        public void ShowCatalog();
        public void ShowCatalog(Type type);
        public Book FindBook(int id);
        public IEnumerable<Book> GetBooksFantasy();
        public Book GetBookBestRated();
    }
}