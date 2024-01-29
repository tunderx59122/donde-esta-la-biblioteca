using BusinessObjects.Entity;
using BusinessLayer.Catalog;
using BusinessObjects.Enums;

namespace Services.Services
{
    internal class CatalogService
    {
        CatalogManager _catalogManager = new CatalogManager();

        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.GetAll();
        }

        public IEnumerable<Book> ShowCatalog(string type)
        {
            return _catalogManager.GetAll(type);
        }

        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        public List<Book> GetFantasy()
        {
            return _catalogManager.GetFantasy();
        }

        public Book GetBestBook()
        {
            return _catalogManager.GetBestBook();
        }
    }
}
