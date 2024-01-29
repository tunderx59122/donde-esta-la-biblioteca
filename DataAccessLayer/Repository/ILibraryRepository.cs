using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface ILibraryRepository
    {
        public IEnumerable<Library> GetAll();
        public Library Get(int id);
    }
}
