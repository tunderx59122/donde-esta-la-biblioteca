using BusinessLayer.Catalog;
using BusinessObjects.Entity;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogManager _catalogManager;

        public CatalogService(ICatalogManager catalogManager)
        {
            _catalogManager = catalogManager;
        }

        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }

        public IEnumerable<Book> ShowCatalog(Type type)
        {
            return _catalogManager.DisplayCatalog();
        }

        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        public IEnumerable<Book> GetBooksFantasy()
        {
            return _catalogManager.GetBooksFantasy();
        }

        public Book GetBookBestRated()
        {
            return _catalogManager.GetBookBestRated();
        }
    }
}