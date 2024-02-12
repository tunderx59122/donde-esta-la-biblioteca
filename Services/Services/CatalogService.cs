using BusinessObjects.Entity;
using BusinessLayer.Catalog;
using BusinessObjects.Enums;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        public readonly ICatalogManager _catalogManager;
        
        public CatalogService(ICatalogManager catalogManager)
        {
            _catalogManager = catalogManager;
        }

        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }

        public IEnumerable<Book> ShowCatalog(BookType type)
        {
            return _catalogManager.DisplayCatalog(type);
        }

        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        public List<Book> GetFantasy()
        {
            return _catalogManager.DisplayFantasy();
        }

        public Book GetBestBook()
        {
            return _catalogManager.DisplayBest();
        }
    }
}
