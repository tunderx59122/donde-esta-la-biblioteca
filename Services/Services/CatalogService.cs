using BusinessObjects.Entity;
using BusinessLayer.Catalog;
using BusinessObjects.Enums;

namespace Services.Services
{
    internal class CatalogService
    {
        public IEnumerable<Book> ShowCatalog()
        {
            return CatalogManager.GetAll();
        }

        public IEnumerable<Book> ShowCatalog(string type)
        {
            return CatalogManager.GetAll(type);
        }

        public Book FindBook(int id)
        {
            return CatalogManager.FindBook(id);
        }

        public List<Book> GetFantasy()
        {
            return CatalogManager.GetFantasy();
        }

        public Book GetBestBook()
        {
            return CatalogManager.GetBestBook();
        }
    }
}
