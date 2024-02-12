using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IGenericRepository<T> where T : AEntity
    {
        public IEnumerable<T> GetAll();

        public IEnumerable<T> Get(int id);

 //       T Add(int id);
//        T Update(int id); 
//        T Delete(int id);
    }
}