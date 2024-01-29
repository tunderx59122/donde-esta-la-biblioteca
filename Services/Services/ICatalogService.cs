using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface ICatalogService
    {
        public IEnumerable<Book> ShowCatalog();
        public IEnumerable<Book> ShowCatalog(string type);
        public Book FindBook(int id);
        public List<Book> GetFantasy();
        public Book GetBestBook();
    }
}
