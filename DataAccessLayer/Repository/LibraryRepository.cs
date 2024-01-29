using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : ILibraryRepository
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