using BusinessObjects.Entity;
using BusinessLayer.Catalog;

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
    }
}
