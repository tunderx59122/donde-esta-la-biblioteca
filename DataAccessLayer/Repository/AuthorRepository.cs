using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IAuthorRepository
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