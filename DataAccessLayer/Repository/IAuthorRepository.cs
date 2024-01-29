using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IAuthorRepository
    {
        public IEnumerable<Author> GetAll();
        public Author Get(int id);
    }
}
