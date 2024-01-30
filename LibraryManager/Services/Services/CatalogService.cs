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

        public void ShowCatalog()
        {
            _catalogManager.DisplayCatalog();
        }

        public void ShowCatalog(Type type)
        {
            _catalogManager.DisplayCatalog();
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