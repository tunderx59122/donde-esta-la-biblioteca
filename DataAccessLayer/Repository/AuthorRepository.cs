using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    internal class AuthorRepository
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