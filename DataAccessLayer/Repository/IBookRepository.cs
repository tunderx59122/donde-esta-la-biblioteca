using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAll();
        public Book Get(int id);
    }
}
