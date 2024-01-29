using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : IGenericRepository<Library>
    {
        public IEnumerable<Library> GetAll()
        {
            return [];
        }

        public Library Get(int id)
        {
            return new Library(1, "Pablo", "12, rue");
        }
    }
}