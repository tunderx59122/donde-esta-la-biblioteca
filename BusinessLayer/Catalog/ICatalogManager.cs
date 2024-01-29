using BusinessObjects.Entity;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Catalog
{
    public interface ICatalogManager
    {
        public IEnumerable<Book> DisplayCatalog();
        public List<Book> DisplayCatalog(string type);
        public List<Book> DisplayFantasy();
        public Book DisplayBest():
        public Book FindBook(int id):
    }
}
