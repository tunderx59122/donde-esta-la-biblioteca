using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repository;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IGenericRepository<Author>
    {
        private LibraryContext _libraryContext = new LibraryContext();

        public List<Author> GetAll()
        {
            return _libraryContext._authors.ToList();
        }

        public Author Get(int id)
        {
            return _libraryContext._authors.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
    }
}