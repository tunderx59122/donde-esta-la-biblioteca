using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IGenericRepository<Author>
    {
        public IEnumerable<Author> GetAll()
        {
            return [];
        }

        public Author Get(int id)
        {
            return new Author(1, "Victor", "Hugo");
        }
    }
}